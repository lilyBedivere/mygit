using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpModBusExample
{
    public partial class main : Form
    {
        DB db = new DB();
        public main()
        {
            InitializeComponent();
        }

        private static Panel Var_Panel = new Panel();
        private static PictureBox Var_Pict = new PictureBox();
        private static int Var_i = 0;
        private Font Var_Font = new Font("宋体", 9);

   

        private void main_Load(object sender, EventArgs e)
        {
            int buttonleft = (panel22.Width - button7.Width-3) / 2;
            button5.Left = buttonleft;
            button6.Left = buttonleft;
            button7.Left = buttonleft;
            button8.Left = buttonleft;
            button9.Left = buttonleft;
           button10.Left = buttonleft;
           button11.Left = buttonleft;
            b1_Click(sender, e);
          
            db.Cmdsorted();
        }

        private void label_1_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Gray;
            ((Label)sender).Font = new Font(Var_Font, Var_Font.Style | FontStyle.Underline);
        }

        private void label_1_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
            ((Label)sender).Font = new Font(Var_Font, Var_Font.Style);
        }

     
      

      

        public void frm_show(string FName)
        {
            if (FName == "订单信息管理")
            {
                order_new fp = new order_new();//实例化一个窗体
                fp.Text = FName;//设置窗体的名称
                fp.ShowDialog();//用模试对话框打开窗体
                fp.Dispose();//释放窗体的所有资原
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order_new fp = new order_new();//实例化一个窗体
            fp.Text = "新建订单";//设置窗体的名称
            fp.ShowDialog();//用模试对话框打开窗体
            fp.Dispose();//释放窗体的所有资原

        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable datatable = db.GetDataSetStr("select * from order_new", "order_new");
            int ss = datatable.Rows.Count;
            if (ss == 0)
            {
                message fp = new message();//实例化一个窗体
              //  fp.Text = "你还没新建订单，请点击新建按钮后，再刷新！";//设置窗体的名称
                fp.ShowDialog();//用模试对话框打开窗体
                fp.Dispose();//释放窗体的所有资原

            }
            if(ss==1)
            {
                dataGridView1.Visible = true;
                 DataSet myDs = new DataSet();
                 dataGridView1.DataSource = db.GetDataSetStr("select * from order_new", "order_new");


              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            history lishi = new history();
            lishi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //TestModBus test = new TestModBus();
            //test.Show();
          
                //TestModBus test = new TestModBus();
                //test.TopLevel = false;
            //this.panel3.Controls.Add(test);
            // test.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable datatable = db.GetDataSetStr("select * from order_new", "order_new");
            int ss = datatable.Rows.Count;
            if (ss == 0)
            {
                message fp = new message();//实例化一个窗体
                //  fp.Text = "你还没新建订单，请点击新建按钮后，再刷新！";//设置窗体的名称
                fp.ShowDialog();//用模试对话框打开窗体
                fp.Dispose();//释放窗体的所有资原

            }
            else
            {
                process pro = new process();
                pro.Show();
            }
        }

 

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  

        private void b1_Click(object sender, EventArgs e)
        {
            b1.SendToBack();
            b1.Dock = DockStyle.Top;
            b2.SendToBack();
            b2.Dock = DockStyle.Bottom;
            b4.SendToBack();
            b4.Dock = DockStyle.Bottom;
            b3.SendToBack();
            b3.Dock = DockStyle.Bottom;
         

            b5.SendToBack();
            b5.Dock = DockStyle.Bottom;
         
            b7.SendToBack();
            b7.Dock = DockStyle.Bottom;
            b6.SendToBack();
            b6.Dock = DockStyle.Bottom;
            b8.SendToBack();
            b8.Dock = DockStyle.Bottom;
            b9.SendToBack();
            b9.Dock = DockStyle.Bottom;

            p4.SendToBack();
            p3.SendToBack();
            p2.SendToBack();
            p1.BringToFront();
            p1.Dock = DockStyle.Fill;

            panel20.Controls.Clear();
            pro_order.ordermanager order = new pro_order.ordermanager();
            panel20.Controls.Add(order);
            order.Dock = DockStyle.Fill;
      

        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.SendToBack();
            b2.Dock = DockStyle.Top;
            b1.SendToBack();
            b1.Dock = DockStyle.Top;
            b4.SendToBack();
            b4.Dock = DockStyle.Bottom;
            b3.SendToBack();
            b3.Dock = DockStyle.Bottom;
          
            b7.SendToBack();
            b7.Dock = DockStyle.Bottom;
            b6.SendToBack();
            b6.Dock = DockStyle.Bottom;
            b8.SendToBack();
            b8.Dock = DockStyle.Bottom;


            p1.SendToBack();
            p3.SendToBack();
            p4.SendToBack();

            p2.BringToFront();
            p2.Dock = DockStyle.Fill;


            panel20.Controls.Clear();
            pro_order.resource  resource= new pro_order.resource();

            panel20.Controls.Add(resource);
            resource.Dock = DockStyle.Fill;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.SendToBack();
            b3.Dock = DockStyle.Top;
            b4.SendToBack();
            b4.Dock = DockStyle.Top;
            b2.SendToBack();
            b2.Dock = DockStyle.Top;
            b1.SendToBack();
            b1.Dock = DockStyle.Top; ;
        

          
            b7.SendToBack();
            b7.Dock = DockStyle.Bottom;
            b6.SendToBack();
            b6.Dock = DockStyle.Bottom;
            b8.SendToBack();
            b8.Dock = DockStyle.Bottom;

            p1.SendToBack();
            p2.SendToBack();
            p4.SendToBack();
            p3.BringToFront();

            p3.Dock = DockStyle.Fill;

            panel20.Controls.Clear();
            pro_order.rfid_scence scene = new pro_order.rfid_scence();
            //pro_order.scene_mang scene = new pro_order.scene_mang();
         //   pro_order.scene_manager scene = new pro_order.scene_manager();

            panel20.Controls.Add(scene);
            scene.Dock = DockStyle.Fill;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.SendToBack();
            b4.Dock = DockStyle.Top;
            b3.SendToBack();
            b3.Dock = DockStyle.Bottom;
            b2.SendToBack();
            b2.Dock = DockStyle.Top;
            b1.SendToBack();
            b1.Dock = DockStyle.Top;

       
            b7.SendToBack();
            b7.Dock = DockStyle.Bottom;
            b6.SendToBack();
            b6.Dock = DockStyle.Bottom;
            b8.SendToBack();
            b8.Dock = DockStyle.Bottom;

            p1.SendToBack();
            p2.SendToBack();
            p3.SendToBack();
            p4.BringToFront();

            p4.Dock = DockStyle.Fill;
            panel20.Controls.Clear();
            pro_order.warehose_mang warehouse = new pro_order.warehose_mang();
            panel20.Controls.Add(warehouse);
            warehouse.Dock = DockStyle.Fill;
        }

       

      

        private void b9_Click(object sender, EventArgs e)
        {

        }

        private void b5_Click(object sender, EventArgs e)
        {

        }

     

      
     

        private void button11_Click(object sender, EventArgs e)
        {
          
           
        }

        private void b8_Click_1(object sender, EventArgs e)
        {
            b8.SendToBack();
            b8.Dock = DockStyle.Top;
            b6.SendToBack();
            b6.Dock = DockStyle.Top;
            b7.SendToBack();
            b7.Dock = DockStyle.Top;
       
        
          
            b3.SendToBack();
            b3.Dock = DockStyle.Top;
            b4.SendToBack();
            b4.Dock = DockStyle.Top;
            b2.SendToBack();
            b2.Dock = DockStyle.Top;
            b1.SendToBack();
            b1.Dock = DockStyle.Top;
            p1.SendToBack();
            p2.SendToBack();
            p3.SendToBack();
            p4.SendToBack();
          

          

        }

        private void b6_Click_1(object sender, EventArgs e)
        {
            b6.SendToBack();
            b6.Dock = DockStyle.Top;
             b7.SendToBack();
            b7.Dock = DockStyle.Top;
            b8.SendToBack();
            b8.Dock = DockStyle.Bottom;
           

            b3.SendToBack();
            b3.Dock = DockStyle.Top;
            b4.SendToBack();
            b4.Dock = DockStyle.Top;
            b2.SendToBack();
            b2.Dock = DockStyle.Top;
            b1.SendToBack();
            b1.Dock = DockStyle.Top;
         
         
         
        
            p1.SendToBack();
            p2.SendToBack();
            p3.BringToFront();
            p4.SendToBack();

            p3.Dock = DockStyle.Fill;

        }

        private void b7_Click_1(object sender, EventArgs e)
        {
            b7.SendToBack();
            b7.Dock = DockStyle.Top;
          
            b6.SendToBack();
            b6.Dock = DockStyle.Bottom;
            b8.SendToBack();
            b8.Dock = DockStyle.Bottom;
   
           
            b3.SendToBack();
            b3.Dock = DockStyle.Top;
            b4.SendToBack();
            b4.Dock = DockStyle.Top;
            b2.SendToBack();
            b2.Dock = DockStyle.Top;
            b1.SendToBack();
            b1.Dock = DockStyle.Top;
            p1.SendToBack();
            p2.SendToBack();
            p3.BringToFront();
            p4.SendToBack();

            p3.Dock = DockStyle.Fill;

        }

        private void 华数工业管理系统_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            DAModule da = new DAModule();
            da.Activate();
            da.Show();
        }

    

   

    

     
    }
    

}
