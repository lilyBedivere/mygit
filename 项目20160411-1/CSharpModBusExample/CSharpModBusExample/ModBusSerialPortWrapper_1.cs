using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpModBusExample
{
    internal class ModBusSerialPortWrapper : ModBusWrapper, IDisposable
    {
        public override void Connect()
        {
            throw new NotImplementedException();
        }

        public override byte[] Receive()
        {
            throw new NotImplementedException();
        }

        public override void Send(byte[] data)
        {
            throw new NotImplementedException();
        }

        #region IDisposable 成员
        public override void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
