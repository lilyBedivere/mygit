using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace CSharpModBusExample
{
    public enum FunctionCode : byte
    {
        /// <summary>
        /// Read Multiple Registers
        /// </summary>
        Read = 3,

        /// <summary>
        /// Write Multiple Registers
        /// </summary>
        Write = 16
    }

    internal class ModBusTCPIPWrapper : ModBusWrapper, IDisposable
    {
        private static short StartingAddress = short.Parse(ConfigurationManager.AppSettings["StartingAddress"]);
        public static ModBusTCPIPWrapper Instance = new ModBusTCPIPWrapper();
        private SocketWrapper socketWrapper = new SocketWrapper();
        bool connected = false;

        public override void Connect()
        {
            if (!connected)
            {
                this.socketWrapper.Logger = this.Logger;
                this.socketWrapper.Connect();
                this.connected = true;
            }
        }

        public override byte[] Receive()
        {
            this.Connect();
            List<byte> sendData = new List<byte>(255);

            //[1].Send
            sendData.AddRange(ValueHelper.Instance.GetBytes(this.NextDataIndex()));//1~2.(Transaction Identifier)
            sendData.AddRange(new Byte[] { 0, 0 });//3~4:Protocol Identifier,0 = MODBUS protocol
            sendData.AddRange(ValueHelper.Instance.GetBytes((short)6));//5~6:后续的Byte数量（针对读请求，后续为6个byte）
            sendData.Add(0);//7:Unit Identifier:This field is used for intra-system routing purpose.
            sendData.Add((byte)FunctionCode.Read);//8.Function Code : 3 (Read Multiple Register)
            sendData.AddRange(ValueHelper.Instance.GetBytes(StartingAddress));//9~10.起始地址
            sendData.AddRange(ValueHelper.Instance.GetBytes((short)30));//11~12.需要读取的寄存器数量
            this.socketWrapper.Write(sendData.ToArray()); //发送读请求

            //[2].防止连续读写引起前台UI线程阻塞
            Application.DoEvents();

            //[3].读取Response Header : 完后会返回8个byte的Response Header
            byte[] receiveData = this.socketWrapper.Read(256);//缓冲区中的数据总量不超过256byte，一次读256byte，防止残余数据影响下次读取
            short identifier = (short)((((short)receiveData[0]) << 8) + receiveData[1]);

            //[4].读取返回数据：根据ResponseHeader，读取后续的数据
            if (identifier != this.CurrentDataIndex) //请求的数据标识与返回的标识不一致，则丢掉数据包
            {
                return new Byte[0];
            }
            byte length = receiveData[8];//最后一个字节，记录寄存器中数据的Byte数
            byte[] result = new byte[length];
            Array.Copy(receiveData, 9, result, 0, length);
            return result;
        }

        public override void Send(byte[] data)
        {
            //[0]:填充0，清掉剩余的寄存器
            if (data.Length < 60)
            {
                var input = data;
                data = new Byte[60];
                Array.Copy(input, data, input.Length);
            }
            this.Connect();
            List<byte> values = new List<byte>(255);

            //[1].Write Header：MODBUS Application Protocol header
            values.AddRange(ValueHelper.Instance.GetBytes(this.NextDataIndex()));//1~2.(Transaction Identifier)
            values.AddRange(new Byte[] { 0, 0 });//3~4:Protocol Identifier,0 = MODBUS protocol
            values.AddRange(ValueHelper.Instance.GetBytes((byte)(data.Length + 7)));//5~6:后续的Byte数量
            values.Add(0);//7:Unit Identifier:This field is used for intra-system routing purpose.
            values.Add((byte)FunctionCode.Write);//8.Function Code : 16 (Write Multiple Register)
            values.AddRange(ValueHelper.Instance.GetBytes(StartingAddress));//9~10.起始地址
            values.AddRange(ValueHelper.Instance.GetBytes((short)(data.Length / 2)));//11~12.寄存器数量
            values.Add((byte)data.Length);//13.数据的Byte数量

            //[2].增加数据
            values.AddRange(data);//14~End:需要发送的数据

            //[3].写数据
            this.socketWrapper.Write(values.ToArray());

            //[4].防止连续读写引起前台UI线程阻塞
            Application.DoEvents();

            //[5].读取Response: 写完后会返回12个byte的结果
            byte[] responseHeader = this.socketWrapper.Read(12);
        }

        #region IDisposable 成员
        public override void Dispose()
        {
            socketWrapper.Dispose();
        }
        #endregion
    }
}
