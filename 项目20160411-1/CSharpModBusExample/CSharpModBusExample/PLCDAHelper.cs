using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using OPCAutomation;
using System.Threading;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;

namespace CSharpModBusExample
{
    public class PLCDAHelper
    {
       public PLCDAHelper(){}

        #region
        private  OPCServer MyServer = new OPCServer();       
       
      
       // private OPCGroup group1;
        
        
        int Material_Item_Count;
        string strHostIP = "";
        string strHostName = "";
        bool opc_connected = false;
       

        #endregion

        public OPCServer getServer()
        {
            return MyServer;
        }

        public   Array getLocalServers()
        {
            strHostName = Dns.GetHostName();  
            object serverList = MyServer.GetOPCServers(strHostName);
            return (Array)serverList;            
                      
        }

        public bool ConnectRemoteServer(string remoteServerIP, string remoteServerName)
        {           
            MyServer.Connect(remoteServerName, remoteServerIP);
            if (MyServer.ServerState != (int)OPCServerState.OPCRunning)
            {
                return false;
            }
            return true;
        }

        public OPCGroup CreateGroup(string GroupName,int updataRate)
        {
            OPCGroup group1 = MyServer.OPCGroups.Add(GroupName); //第1组，原料仓组
           // Material_Cylinder_Group = MyGroups.Add("Material_Cylinder_Group"); //第2组，料仓气缸状态组
            {
                MyServer.OPCGroups.DefaultGroupIsActive = true;
                MyServer.OPCGroups.DefaultGroupDeadband = 0;       //死区值，设为0时，服务器端组内任何数据变化都通知组
                MyServer.OPCGroups.DefaultGroupUpdateRate = updataRate; //250
                group1.IsSubscribed = true;
               // Material_Cylinder_Group.IsSubscribed = true;

            }
            return group1;

        }

        public OPCItem[] AddGroupItems(OPCGroup group, string filename)
        {            
            OPCItems Items = group.OPCItems;          
            IEnumerable<string> lines = File.ReadAllLines(filename);
            int itemsCount = lines.Count();
            int linenum = 0;
            OPCItem[] item = new OPCItem[itemsCount];             
            foreach (string line in lines)
            {
                string[] segs = line.Split('-');
                string strName = segs[0].ToString();
                string strHandle = segs[1].ToString();               
                item[linenum] = Items.AddItem(strName, Int32.Parse(strHandle));  
                linenum++;
            }                 
            return item;         //返回的第一个值为OPCITEM数组
        }

        public void StoreToDatabase(object[] itemValue)
        {
           // string sql = "insert into T_material values(@A1FULL,@A2FULL,@B2FULL,@B1FULL,@A1EMPTY,@A2EMPTY,@B2EMPTY,@B1EMPTY,@A1COUNT,@A2COUNT,@B2COUNT,@B1COUNT) ";
            string sql = @"update  T_material set A1FULL=@A1FULL,A2FULL=@A2FULL,B2FULL=@B2FULL,B1FULL=@B1FULL,
                          A1EMPTY=@A1EMPTY,A2EMPTY=@A2EMPTY,B2EMPTY=@B2EMPTY,B1EMPTY=@B1EMPTY,
                            A1COUNT=@A1COUNT,A2COUNT=@A2COUNT,B2COUNT=@B2COUNT,B1COUNT=@B1COUNT";
            SqlParameter[] p = new SqlParameter[12];
            p[0] = new SqlParameter("@A1FULL",(bool)itemValue[0]);
            p[1] = new SqlParameter("@A2FULL", (bool)itemValue[1]);
            p[2] = new SqlParameter("@B2FULL", (bool)itemValue[2]);
            p[3] = new SqlParameter("@B1FULL", (bool)itemValue[3]);
            p[4] = new SqlParameter("@A1EMPTY", (bool)itemValue[4]);
            p[5] = new SqlParameter("@A2EMPTY", (bool)itemValue[5]);
            p[6] = new SqlParameter("@B2EMPTY", (bool)itemValue[6]);
            p[7] = new SqlParameter("@B1EMPTY", (bool)itemValue[7]);
            p[8] = new SqlParameter("@A1COUNT", (Int16)itemValue[8]);
            p[9] = new SqlParameter("@A2COUNT", (Int16)itemValue[9]);
            p[10] = new SqlParameter("@B2COUNT", (Int16)itemValue[10]);
            p[11] = new SqlParameter("@B1COUNT", (Int16)itemValue[11]);
            SQLHelper.ExecuteNonQuery(sql,p);
        }

        public void StoreToMaterialCylinderDatabase(object[] itemValue)
        {
            // string sql = "insert into T_material values(@A1FULL,@A2FULL,@B2FULL,@B1FULL,@A1EMPTY,@A2EMPTY,@B2EMPTY,@B1EMPTY,@A1COUNT,@A2COUNT,@B2COUNT,@B1COUNT) ";
            string sql = @"update  T_material_cylinder set A1MCIN=@A1MCIN,A2MCIN=@A2MCIN,B2MCIN=@B2MCIN,B1MCIN=@B1MCIN,
                          A1MCOUT=@A1MCOUT,A2MCOUT=@A2MCOUT,B2MCOUT=@B2MCOUT,B1MCOUT=@B1MCOUT";
                           // A1MC=@A1MC,A2MC=@A2MC,B2MC=@B2MC,B1MC=@B1MC";
            SqlParameter[] p = new SqlParameter[itemValue.Length];
            p[0] = new SqlParameter("@A1MCIN", (bool)itemValue[0]);
            p[1] = new SqlParameter("@A2MCIN", (bool)itemValue[1]);
            p[2] = new SqlParameter("@B2MCIN", (bool)itemValue[2]);
            p[3] = new SqlParameter("@B1MCIN", (bool)itemValue[3]);
            p[4] = new SqlParameter("@A1MCOUT", (bool)itemValue[4]);
            p[5] = new SqlParameter("@A2MCOUT", (bool)itemValue[5]);
            p[6] = new SqlParameter("@B2MCOUT", (bool)itemValue[6]);
            p[7] = new SqlParameter("@B1MCOUT", (bool)itemValue[7]);
            //p[8] = new SqlParameter("@A1MC", (bool)itemValue[8]);
            //p[9] = new SqlParameter("@A2MC", (bool)itemValue[9]);
            //p[10] = new SqlParameter("@B2MC", (bool)itemValue[10]);
            //p[11] = new SqlParameter("@B1MC", (bool)itemValue[11]);
            SQLHelper.ExecuteNonQuery(sql, p);
        }

        public DataRow getDataRow(string tableName)
        {
            string sql = "select * from " +tableName;
            return SQLHelper.ExecuteDataRow(sql);
        }

        public int getTableCount(string tableName)
        {
            string sql = "select * from " + tableName;
            return SQLHelper.ExecuteDataTable(sql).Rows.Count;
        }

        public object itemREAD(OPCItem item)
        {
            object ItemValues; object Qualities; object TimeStamps;
            item.Read(1, out ItemValues, out Qualities, out TimeStamps);
            return ItemValues;
        }
        public object[] itemREAD(OPCItem[] item)
        {
            object ItemValues; object Qualities; object TimeStamps;
            int count = item.Length;
            object[] values = new object[count];
            for (int i = 0; i < count; i++)
            {
                item[i].Read(1, out ItemValues, out Qualities, out TimeStamps);                
                values[i] = ItemValues;
            }
            return values;
        }

        public void itemWrite(OPCItem item,object value)
        {
            item.Write(value);
        }

    }
}
