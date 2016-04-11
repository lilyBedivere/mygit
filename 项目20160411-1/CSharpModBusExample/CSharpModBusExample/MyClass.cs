using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CSharpModBusExample
{
    class MyClass
    {
        DB dbObj = new DB();
        //CommonClassID cObj = new CommonClassID();
        public byte[] byteNum;//编号
        public byte[] byteCorrect;//正确
        public string stringCaseN;//案例名
        public string stringCaseG;//案例组
        int portReceive = 3003;//接收端口3003
        static byte[] data = new byte[100];
        //static string strReturn;//返回
        public string strJudge = "";//判断是否成功
        public string Get_data;
        public int sendwaittime = 8008;//每次发送等待时间
        public string shortaddress;
        public string CaseName;//案例名称
        public string CaseStep;//测试步
        public string CaseStepData;//测试步发送数据
        public string StepReJudge;//测试步判断
        public string ReJudge;//测试结果判断

        public void databaseoperation(string sms_sqlstr)//操作数据库，传递参数为SQL语句
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            SqlCommand myCommand;//声明SqlCommand对象实例
            SqlDataReader myRead;//声明SqlDataReader对象实例
            try
            {
                mySqlConnection.Open();//打开数据库的连接               
                myCommand = new SqlCommand(sms_sqlstr, mySqlConnection);//将SqlCommand对象实例化
                myRead = myCommand.ExecuteReader();//执行SQL语句生成一个sqlDataReader对象
            }
            catch (SqlException)
            {
                //读取数据库出错输出错误信息
                //System.Web.HttpContext.Current.Response.Write(ex.Message.ToString());
            }
            finally
            {
                mySqlConnection.Close();//关闭与数据库的连接
                //System.Web.HttpContext.Current.Response.Write("关闭数据库成功！");
            }
        }
        public byte[] ConvertData(int recv, byte[] data) //因为接收到的data是1024位，而需要返回一个接收到的recv位
        {
            byte[] newbyte = new byte[recv];
            for (int i = 0; i < recv; i++)
            {
                newbyte[i] = data[i];
            }
            return newbyte;
        }
        public static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2") + " ";
                }
            }
            return returnStr;
        }

        public DataTable GetCaseInfo(string CaseName)
        {
            string myStr = ConfigurationManager.AppSettings["ConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(myStr);
            conn.Open();
            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = conn;
            myCmd.CommandText = "select * FROM ordercases where 订单号=@CaseName";
            //SqlCommand myCmd = dbObj.GetCommandProc("proc_GetCaseID");
            //添加参数
            SqlParameter CaseN = new SqlParameter("@CaseName", SqlDbType.NVarChar, 50);
            CaseN.Value = CaseName;
            myCmd.Parameters.Add(CaseN);
            dbObj.ExecNonQuery(myCmd);
            DataTable dsTable = dbObj.GetDataSet(myCmd, "ordercases");
            return dsTable;
        }

    }
}
