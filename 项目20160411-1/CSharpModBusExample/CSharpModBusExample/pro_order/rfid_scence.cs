using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Threading;
using System.Windows.Forms;

namespace CSharpModBusExample.pro_order
{
    public partial class rfid_scence : UserControl, ILog, IDisposable
    {
        
       PLCDAHelper plchelper = new PLCDAHelper();//plc操作类
        MyClass mycalss = new MyClass();
        DB db = new DB();
        private ModBusWrapper Wrapper = null;
        int Anum = 0;
        int Bnum = 0;
        int Aliao = 0;
        int Bliao = 0;

        static Thread Testthread;

        public rfid_scence()
        {
            InitializeComponent();
            this.Wrapper = ModBusWrapper.CreateInstance(Protocol.TCPIP);
            this.Wrapper.Logger = this;
        }

        #region ILog 成员
        public void Write(string log)
        {
            this.tbxHistory.AppendText(log + Environment.NewLine);
            this.tbxHistory.Select(this.tbxHistory.TextLength, 0);
            this.tbxHistory.ScrollToCaret();
        }
        #endregion

        private void TestModBus_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Wrapper.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void rfid_scence_Load(object sender, EventArgs e)
        {
             

            string cmdstr1 = "delete from ordercases ";
            db.sqlEx(cmdstr1);
            string cmdstr = "insert into ordercases  select  * from ordernew_info where 产品种类1数量!='0' and  产品种类2数量!='0' and 是否发布='是' ";
            db.sqlEx(cmdstr);

            string cmdstr2= "delete from tb_case ";
            db.sqlEx(cmdstr2);
            string cmdstr3 = "delete from tb_生产执行步骤 ";
            db.sqlEx(cmdstr3);
            string cmdstr4 = "delete from tb_caseinfo ";
            db.sqlEx(cmdstr4);


            DataSet myDs = new DataSet();
            dataGridView1.DataSource = db.GetDataSetStr(" select  * from ordercases ", "ordercases");
        }

        private void bt_ReadID_Click(object sender, EventArgs e)
        {
            lb_ReadTagID.Text = "";
            byte[] b2 = { 0, 0, 0, 6, 255, 3, 160, 0, 0, 4 };
            byte[] bb = this.Wrapper.Send(b2, 17);

            string Function_Code = getFunctionCode(bb);
            this.tb_ReadTagIDFunctionCode.Text = Function_Code;
            if (Function_Code == "83")
            {
                lb_ReadTagID.Text = "读取标签有误，请检查！";
            }
            this.tbxReceiveText.Text = getTagID(bb);
        }

        private void bt_WriteDateTime_Click(object sender, EventArgs e)
        {
            byte[] b1 = getDateTime();
            byte[] b2 = { 0, 0, 0, 13, 255, 16, 0, 0, 0, 3, 6 };
            byte[] b = new byte[b2.Length + b1.Length];
            b2.CopyTo(b, 0);
            b1.CopyTo(b, b2.Length);
            this.Wrapper.Send(b, 12);
        }

        private void bt_ReadDateTime_Click(object sender, EventArgs e)
        {
            byte[] b1 = { 0, 0, 0, 6, 255, 3, 0, 0, 0, 3 };
            byte[] bb = this.Wrapper.Send(b1, 15);
            byte[] b = new byte[6];
            Array.Copy(bb, 9, b, 0, 6);
            string s = Byte2StringDecimal(b);
            tx_TagValue.Text = s;

        }
        private string Byte2String(byte[] data)
        {
            StringBuilder logText = new StringBuilder();
            foreach (byte item in data)
            {
                logText.Append(item.ToString("x2") + " ");
            }

            return logText.ToString();
        }

        private string Byte2StringDecimal(byte[] data)
        {
            StringBuilder logText = new StringBuilder();
            foreach (byte item in data)
            {
                logText.Append(item.ToString("d2") + " ");
            }

            return logText.ToString();
        }
        private string getFunctionCode(byte[] data)
        {
            return data[7].ToString("x2");
        }
        private string getDataAddress(byte[] data)
        {
            //return string.Join(data[8].ToString(),data[9].ToString());
            return data[8].ToString("x2");
        }
        private string getDataValue(byte[] data)
        {
            string s1 = data[9].ToString("x2");
            string s2 = data[10].ToString("x2");
            string s = s1 + "" + s2;
            return s;
        }
        private string getTagID(byte[] data)
        {
            byte[] b = new byte[8];
            Array.Copy(data, 9, b, 0, 8);
            return Byte2String(b);
        }
        private byte[] getDateTime()
        {
            int year = DateTime.Now.Year % 100;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            byte[] dt = { (byte)year, (byte)month, (byte)day, (byte)hour, (byte)minute, (byte)second };
            return dt;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            //读取plc数据方法
            //plchelper.itemWrite(DAModule.Order.Item[0], 1);
            //plchelper.itemWrite(DAModule.Order.Item[1], 1);

            DataTable datatable = db.GetDataSetStr("select * from ordercases", "ordercases");
            int ss = datatable.Rows.Count;
            for (int i = 0; i < ss; i++)
            {
                Anum = Anum +Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);//当前生产A的个数

                Bnum = Bnum + Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);//当前生产B的个数

            }
            //获取料仓A和B的个数
            //判断料仓是否足够
            //if (Anum > Aliao && Bnum > Bliao)
            //{
            //    timer1.Enabled = true;
            //    ImageProging.Image = CSharpModBusExample.Properties.Resources.T运行中;
            //    start.Enabled = false;
            //    pause.Enabled = true;
            //    stop.Enabled = true;
            //    LabStart.Text = myclass.gettime();
            //    Testthread = new Thread(new ThreadStart(Testing));
            //    Testthread.Start();
            //}
            //else
            //{
            //    MessageBox.Show("当前料仓缺，请修改订单或者增加加料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}




            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////执行订单操作/////////////////////////////////////////////////////
             Anum = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value);
             Bnum = Convert.ToInt32(dataGridView1.Rows[0].Cells[4].Value);
             plchelper.itemWrite(DAModule.Order.Item[0], Anum);
             plchelper.itemWrite(DAModule.Order.Item[1], Bnum);

             DAModule.Order.Group.DataChange += new OPCAutomation.DIOPCGroupEvent_DataChangeEventHandler(Order_Group_DataChange);
            







          
        }



        void Order_Group_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            if (DAModule.Order.Item[0].Value == 0 && DAModule.Order.Item[1].Value == 0)
            {
                 MessageBox.Show("完成！等待执行下一条订单","报告");
                 string id = dataGridView1.Rows[0].Cells[2].Value.ToString();
                 string cmdstr5 = "delete from ordernew_info where 订单号='" + id + "'";
                 db.sqlEx(cmdstr5);

 
            }
            
           
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
          




        void Testing()//测试
        {
            DataTable datatable = db.GetDataSetStr("select * from ordercases", "ordercases");
            int ss = datatable.Rows.Count;
          int num=0;
          string order_id;
            string order_str;
          for (num=0; num < ss; num++)
          {
             string starttime = DateTime.Now.ToString(); ;
              string pro_num= dataGridView1.Rows[num].Cells[6].Value.ToString();//计划查出数量
              string TIME = dataGridView1.Rows[num].Cells[5].Value.ToString();
              order_id = dataGridView1.Rows[num].Cells[0].Value.ToString();//订单号
              int A_pro = Convert.ToInt32(dataGridView1.Rows[num].Cells[2].Value);//执行生产
              int B_pro = Convert.ToInt32(dataGridView1.Rows[num].Cells[4].Value);//执行生产
              string oper_num="";//定义生产执行步骤
              string oper_result = "";//定义生产执行步骤结果
              order_str = A_pro + "个A，" + B_pro+"个B";
              mycalss.CaseName =order_id;
              string str_lingjian;//当前的零件
              //DataTable dsTable = mycalss.GetCaseInfo(order_id);
              string CaseDes_sqlstr = "insert into tb_caseinfo(订单号,订单信息,计划产出数量,生产状态,创建时间,计划开始时间,计划结束时间,生产结果) values ('" + order_id + "','" + order_str + "','" + pro_num + "','测试运行中...','" + TIME + "','" + starttime + "',' ',' ')";
              mycalss.databaseoperation(CaseDes_sqlstr);

              //执行生产A
              if (A_pro != 0)
              {
                  int num_srta =2;
                  for (int ia = 0; ia < A_pro; ia++)
                  {

                      for(int numk=1;numk<=num_srta;numk++)
                      {
                          if (numk == 1)
                          {
                              str_lingjian = "A1";

                          }
                          else
                          {
                              str_lingjian = "A2";
                          }
                      string CaseDes_sqlstr1 = "insert into tb_生产执行步骤(订单号,订单信息,计划产出数量,当前生产产品类型,当前零件,生产执行步骤,生产执行步骤结果,生产结果) values ('" + order_id + "','" + order_str + "','" + pro_num + "','A','"+str_lingjian+"','"+oper_num+"','" +oper_result + "',' ')";
                      mycalss.databaseoperation(CaseDes_sqlstr1);
                          //在轨道上执行生产B，需要获得读RFID的指令装配指令
                     
                      }
                      if (ia == A_pro)
                      {
                          break;

                      }
                  }
              }
              //执行生产B

              if (B_pro != 0)
              {
                  int num_srtb = 2;
                  for (int ib = 0; ib < B_pro; ib++)
                  {
                      for (int numb = 1; numb <= num_srtb; numb++)
                      {
                          if (numb == 1)
                          {
                              str_lingjian = "B1";

                          }
                          else
                          {
                              str_lingjian = "B2";
                          }

                          string CaseDes_sqlstr1 = "insert into tb_生产执行步骤(订单号,订单信息,计划产出数量,当前生产产品类型,当前零件,生产执行步骤,生产执行步骤结果,生产结果) values ('" + order_id + "','" + order_str + "','" + pro_num + "','A','" + str_lingjian + "','" + oper_num + "','" + oper_result + "',' ')";
                          mycalss.databaseoperation(CaseDes_sqlstr1);
                          //在轨道上执行生产B
                      }
                      if (ib == B_pro)
                      {
                          break;
                      }

                  }
                  
              }
           
              

          }

        }
        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ImageProging.Image = CSharpModBusExample.Properties.Resources.T等待;
            start.Enabled = false;
            pause.Enabled = false;
            stop.Enabled = true;
            redo.Enabled = true;
        }

        private void redo_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ImageProging.Image = CSharpModBusExample.Properties.Resources.T运行中;
            start.Enabled = false;
            pause.Enabled = true;
            stop.Enabled = true;
            redo.Enabled = false;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ImageProging.Image =CSharpModBusExample.Properties.Resources.T等待;
            if (Testthread.IsAlive)
            {
                Testthread.Abort();
            }
            start.Enabled = true;
            pause.Enabled = false;
            stop.Enabled = false;
            redo.Enabled = false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  dataGridView2.DataSource = db.GetDataSetStr("select 订单号,订单信息,计划产出数量,当前生产产品类型,当前零件,生产状态,创建时间,计划开始时间,计划结束时间,生产结果 from tb_case ", "tb_case");
            dataGridView2.DataSource = db.GetDataSetStr("select * from tb_caseinfo ", "tb_caseinfo");
            dataGridView3.DataSource = db.GetDataSetStr("select * from tb_生产执行步骤 order by 序号 desc", "tb_生产执行步骤");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //如何判断有多少个
            string id_rfid;//定义plc返回的信息
            string ordernum_id=null;
            string rfid_write=null;
            string sql_str = "insert into write_rfid(零件类型,写入RFID码,写入状态) values('"+ordernum_id+"','"+rfid_write+"','写入成功')";
            mycalss.databaseoperation(sql_str);
            dataGridView5.DataSource = db.GetDataSetStr("select *from write_rfid", "write_rfid");
        

        }

       

    }
}
