using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using OPCAutomation;
using System.Timers;

namespace CSharpModBusExample
{
    public partial class DAModule : Form
    {
        PLCDAHelper PLCHelper = new PLCDAHelper();
        //public static OPCItem[] Material_Item, Material_Cylinder_Item, Order_Item; //物料组，物料气缸组，订单组
        //public static OPCGroup Material_Group, Material_Cylinder_Group, Order_Group;
        //public static int Material_Cylinder_Item_Count;

        //public static OPCGroup Sorting_Group, Assemble_Group, Robot_Group;
        //public static OPCItem[] Sorting_Item, Assemble_Item, Robot_Item; //分栋组，装配组，机器人组

        //public static OPCGroup Vision_Group, Storage_Status_Group, Storage_Group;
        //public static OPCItem[] Vision_Item, Storage_Status_Item, Storage_Item; //视觉组，仓库状态组，仓库组

        //public static OPCGroup Split_Group, RFID_Group, Other_Group;
        //public static OPCItem[] Split_Item, RFID_Item, Other_Item; //拆装组，读写平台组，其它部分       

        public static OPCEntity Material = new OPCEntity();
        public static OPCEntity Material_Cylinder = new OPCEntity();
        public static OPCEntity Order = new OPCEntity();

        public static OPCEntity Sorting = new OPCEntity();
        public static OPCEntity Assemble = new OPCEntity();
        public static OPCEntity Robot = new OPCEntity();

        public static OPCEntity Vision = new OPCEntity();
        public static OPCEntity Storage_Status = new OPCEntity();
        public static OPCEntity Storage = new OPCEntity();

        public static OPCEntity Split = new OPCEntity();
        public static OPCEntity RFID = new OPCEntity();
        public static OPCEntity Other = new OPCEntity();
        
        public DAModule()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void DAModule_Load(object sender, EventArgs e)
        {
            GetLocalServer();
        }

        private void btnConnServer_Click(object sender, EventArgs e)
        {
            if (PLCHelper.ConnectRemoteServer(txtRemoteServerIP.Text, cmbServerName.Text))
            {
                MessageBox.Show("连接成功！");
                LoadOPCData();
                Thread.Sleep(200);
               
            }
            else
            {
                MessageBox.Show("conn error");
            }
        }

        private void GetLocalServer()
        {

            try
            {
                foreach (string turn in PLCHelper.getLocalServers())
                {
                    cmbServerName.Items.Add(turn);
                }

                cmbServerName.SelectedIndex = 0;
                btnConnServer.Enabled = true;
            }

            catch (Exception err)
            {
                MessageBox.Show("枚举本地OPC服务器出错：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadOPCData()
        {

            Material.Group= PLCHelper.CreateGroup("Material_Group", 50);
            Material.Item = PLCHelper.AddGroupItems(Material.Group, "../../dataItems/Material.txt");//添加项，获取项和值
            tb_LoadInfo.AppendText("加载物料组数据成功！" + "\n");


            Material_Cylinder.Group = PLCHelper.CreateGroup("Material_Cylinder_Group", 50);
            Material_Cylinder.Item = PLCHelper.AddGroupItems(Material_Cylinder.Group, "../../dataItems/Material_Cylinder.txt");
            Material_Cylinder.Count = Material_Cylinder.Item.Count();
            tb_LoadInfo.AppendText("加载物料气缸组数据成功！" + "\n");

            Order.Group = PLCHelper.CreateGroup("Order_Group", 50);
            Order.Item = PLCHelper.AddGroupItems(Order.Group, "../../dataItems/Order.txt");
            tb_LoadInfo.AppendText("加载订单组数据成功！" + "\n");


            //Material_Group = PLCHelper.CreateGroup("Material_Group", 50);
            //Material_Item = PLCHelper.AddGroupItems(Material_Group, "../../dataItems/Material.txt");//添加项，获取项和值
            //tb_LoadInfo.AppendText("加载物料组数据成功！"+"\n");


            //Material_Cylinder_Group = PLCHelper.CreateGroup("Material_Cylinder_Group", 50);
            //Material_Cylinder_Item = PLCHelper.AddGroupItems(Material_Cylinder_Group, "../../dataItems/Material_Cylinder.txt");
            //Material_Cylinder_Item_Count = Material_Cylinder_Item.Count();
            //tb_LoadInfo.AppendText("加载物料气缸组数据成功！" + "\n");

            //Order_Group = PLCHelper.CreateGroup("Order_Group", 50);
            //Order_Item = PLCHelper.AddGroupItems(Order_Group, "../../dataItems/Order.txt");
            //tb_LoadInfo.AppendText("加载订单组数据成功！" + "\n");

            Sorting.Group = PLCHelper.CreateGroup("Sorting_Group", 50);
            Sorting.Item = PLCHelper.AddGroupItems(Sorting.Group, "../../dataItems/Sorting.txt");
            tb_LoadInfo.AppendText("加载分栋组数据成功！" + "\n");

            Assemble.Group = PLCHelper.CreateGroup("Assemble_Group", 50);
            Assemble.Item = PLCHelper.AddGroupItems(Assemble.Group, "../../dataItems/Assemble.txt");
            tb_LoadInfo.AppendText("加载装配组数据成功！" + "\n");

            Robot.Group = PLCHelper.CreateGroup("Robot_Group", 50);
            Robot.Item = PLCHelper.AddGroupItems(Robot.Group, "../../dataItems/Robot.txt");
            tb_LoadInfo.AppendText("加载机器人组数据成功！" + "\n");


            ////Sorting_Group = PLCHelper.CreateGroup("Sorting_Group", 50);
            //Sorting_Item = PLCHelper.AddGroupItems(Sorting_Group, "../../dataItems/Sorting.txt");
            //tb_LoadInfo.AppendText("加载分栋组数据成功！" + "\n");

            //Assemble_Group = PLCHelper.CreateGroup("Assemble_Group", 50);
            //Assemble_Item = PLCHelper.AddGroupItems(Assemble_Group, "../../dataItems/Assemble.txt");
            //tb_LoadInfo.AppendText("加载装配组数据成功！" + "\n");

            //Robot_Group = PLCHelper.CreateGroup("Robot_Group", 50);
            //Robot_Item = PLCHelper.AddGroupItems(Robot_Group, "../../dataItems/Robot.txt");
            //tb_LoadInfo.AppendText("加载机器人组数据成功！" + "\n");

            Vision.Group = PLCHelper.CreateGroup("Vision_Group", 50);
            Vision.Item = PLCHelper.AddGroupItems(Vision.Group, "../../dataItems/Vision.txt");
            tb_LoadInfo.AppendText("加载视觉组数据成功！" + "\n");

            Storage_Status.Group = PLCHelper.CreateGroup("Storage_Status_Group", 50);
            Storage_Status.Item = PLCHelper.AddGroupItems(Storage_Status.Group, "../../dataItems/Storage_Status.txt");
            tb_LoadInfo.AppendText("加载仓库状态组数据成功！" + "\n");

            Storage.Group = PLCHelper.CreateGroup("Storage_Group", 50);
            Storage.Item = PLCHelper.AddGroupItems(Storage.Group, "../../dataItems/Storage.txt");
            tb_LoadInfo.AppendText("加载仓库组数据成功！" + "\n");

            //Vision_Group = PLCHelper.CreateGroup("Vision_Group", 50);
            //Vision_Item = PLCHelper.AddGroupItems(Vision_Group, "../../dataItems/Vision.txt");
            //tb_LoadInfo.AppendText("加载视觉组数据成功！" + "\n");

            //Storage_Status_Group = PLCHelper.CreateGroup("Storage_Status_Group", 50);
            //Storage_Status_Item = PLCHelper.AddGroupItems(Storage_Status_Group, "../../dataItems/Storage_Status.txt");
            //tb_LoadInfo.AppendText("加载仓库状态组数据成功！" + "\n");

            //Storage_Group = PLCHelper.CreateGroup("Storage_Group", 50);
            //Storage_Item = PLCHelper.AddGroupItems(Storage_Group, "../../dataItems/Storage.txt");
            //tb_LoadInfo.AppendText("加载仓库组数据成功！" + "\n");

            Split.Group = PLCHelper.CreateGroup("Split_Group", 50);
            Split.Item = PLCHelper.AddGroupItems(Split.Group, "../../dataItems/Split.txt");
            tb_LoadInfo.AppendText("加载拆装组数据成功！" + "\n");

            RFID.Group = PLCHelper.CreateGroup("RFID_Group", 50);
            RFID.Item = PLCHelper.AddGroupItems(RFID.Group, "../../dataItems/RFID.txt");
            tb_LoadInfo.AppendText("加载RFID读写平台部分数据成功！" + "\n");

            Other.Group = PLCHelper.CreateGroup("Other_Group", 50);
            Other.Item = PLCHelper.AddGroupItems(Other.Group, "../../dataItems/Other.txt");
            tb_LoadInfo.AppendText("加载其它部分数据成功！" + "\n");



            //Split_Group = PLCHelper.CreateGroup("Split_Group", 50);
            //Split_Item = PLCHelper.AddGroupItems(Split_Group, "../../dataItems/Split.txt");
            //tb_LoadInfo.AppendText("加载拆装组数据成功！" + "\n");

            //RFID_Group = PLCHelper.CreateGroup("RFID_Group", 50);
            //RFID_Item = PLCHelper.AddGroupItems(RFID_Group, "../../dataItems/RFID.txt");
            //tb_LoadInfo.AppendText("加载RFID读写平台部分数据成功！" + "\n");

            //Other_Group = PLCHelper.CreateGroup("Other_Group", 50);
            //Other_Item = PLCHelper.AddGroupItems(Other_Group, "../../dataItems/Other.txt");
            //tb_LoadInfo.AppendText("加载其它部分数据成功！" + "\n");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3();
            //form3.Activate();
            //form3.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.AppendText(Material_Cylinder_Item_Count.ToString()+"\n");
            //textBox1.AppendText(Material_Cylinder_Item[0].Value.ToString());
            //System.Timers.Timer t = new System.Timers.Timer(100);
            //t.Elapsed +=new System.Timers.ElapsedEventHandler(timeEvent);
            //t.AutoReset = true;
            //t.Enabled = true;
        }

        private void timeEvent(object source,System.Timers.ElapsedEventArgs e)
        {
            //if (Material_Cylinder_Item[0].Value == false)
            //{
            //    label1.BackColor = Color.Gray;
            //}
            //if (Material_Cylinder_Item[0].Value == true)
            //{
            //    label1.BackColor = Color.Green;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //bool[] b = (bool[])Test_Item[0].Value;
            ////MessageBox.Show(b[1].ToString());

            //if (b[1] == false)
            //{
            //    label1.BackColor = Color.Yellow;
            //}
            //if (b[1] == true)
            //{
            //    label1.BackColor = Color.Red;
            //}          
            //for (int i = 0; i < b.Length; i++)
            //{
            //    textBox1.AppendText(b[i].ToString() + "\n");
            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form4 form4 = new Form4();
            //form4.Activate();
            //form4.Show();
            //this.Hide();
        }


        
    }
}
