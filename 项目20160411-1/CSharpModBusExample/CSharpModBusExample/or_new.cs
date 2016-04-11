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
    public partial class or_new : Form
    {
        DB db = new DB();
        string ordernum;
        int sumo;
        string fabu;
        public or_new()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string str_a = tb_a.Text.ToString();
            string str_b = tb_b.Text.ToString();
            DataTable datatable = db.GetDataSetStr("select * from ordernew_info", "ordernew_info");
            int ss = datatable.Rows.Count;
            ordernum = "test_0" + ss.ToString();
            if (yes.Checked == true)
            {
                fabu = "是";
            }
            else if (no.Checked == true)
            {
                fabu ="否";
            }
            else
            {
                MessageBox.Show("请选择是否发布？", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (sum.Text == "")
            {
                sumo = int.Parse("1");

            }
            else
            {
                sumo = int.Parse(sum.Text);
            }
            if (str_a != "" && str_b !="")
            {
                
                int a = int.Parse(str_a);
                int b = int.Parse(str_b);

                string cmdstr = "insert into order_new(序号,订单号,产品种类1,产品种类1数量,产品种类2,产品种类2数量,计划产出数量,创建时间,是否发布,是否完成)values('" + ss + "','" + ordernum + "','A','" + a + "','B','" + b + "','" + sumo + "','" + DateTime.Now + "','" + fabu + "','没完成')";
                db.sqlEx(cmdstr);
                string cmdstr1 = "insert into ordernew_info(序号,订单号,产品种类1,产品种类1数量,产品种类2,产品种类2数量,计划产出数量,创建时间,是否发布,是否完成)values('" + ss + "','" + ordernum + "','A','" + a + "','B','" + b + "','" + sumo + "','" + DateTime.Now + "','" + fabu + "','没完成')";
                db.sqlEx(cmdstr1);

                for (int i = 1; i < a; i++)
                {
                    string ordernum_a = "A" + i.ToString();
                    string cmdstr_a = "insert into order_write(订单号,订单详情)values('" + ordernum + "','" + ordernum_a + "')";
                    db.sqlEx(cmdstr_a);
                }
                for (int i = 1; i < b; i++)
                {
                    string ordernum_b = "B" + i.ToString();
                    string cmdstr_b = "insert into order_write(订单号,订单详情)values('" + ordernum + "','" + ordernum_b + "')";
                    db.sqlEx(cmdstr_b);
                }

                this.Close();

            }
            if (str_a ==""&&str_b!="")
            {
                int a = 0;
                int b = int.Parse(str_b);

                string cmdstr = "insert into order_new(序号,订单号,产品种类2,产品种类2数量,计划产出数量,创建时间,是否发布,是否完成)values('" + ss + "','" + ordernum + "','B','" + b + "','" + sumo + "','" + DateTime.Now + "','" + fabu + "','没完成')";
                db.sqlEx(cmdstr);
                string cmdstr1 = "insert into ordernew_info(序号,订单号,产品种类2,产品种类2数量,计划产出数量,创建时间,是否发布，是否完成)values('" + ss + "','" + ordernum + "''B','" + b + "','" + sumo + "','" + DateTime.Now + "','" + fabu + "','没完成')";
                db.sqlEx(cmdstr1);

                for (int i = 1; i < a; i++)
                {
                    string ordernum_a = "A" + i.ToString();
                    string cmdstr_a = "insert into order_write(订单号,订单详情)values('" + ordernum + "','" + ordernum_a + "')";
                    db.sqlEx(cmdstr_a);
                }
                for (int i = 1; i < b; i++)
                {
                    string ordernum_b = "B" + i.ToString();
                    string cmdstr_b = "insert into order_write(订单号,订单详情)values('" + ordernum + "','" + ordernum_b + "')";
                    db.sqlEx(cmdstr_b);
                }

                this.Close();
            }
            if ( str_b == "" &&str_a!="")
            {
                int a = int.Parse(str_a);
                int b = 0;

                string cmdstr = "insert into order_new(序号,订单号,产品种类1,产品种类1数量,计划产出数量,创建时间,是否发布,是否完成)values('" + ss + "','" + ordernum + "','A','" + a + "','" + sumo + "','" + DateTime.Now + "','" + fabu + "','没完成')";
                db.sqlEx(cmdstr);
                string cmdstr1 = "insert into ordernew_info(序号,订单号,产品种类1,产品种类1数量,计划产出数量,创建时间,是否发布,是否完成)values('" + ss + "','" + ordernum + "','A','" + a + "','" + sumo + "','" + DateTime.Now + "','" + fabu + "','没完成')";
                db.sqlEx(cmdstr1);

                for (int i = 1; i < a; i++)
                {
                    string ordernum_a = "A" + i.ToString();
                    string cmdstr_a = "insert into order_write(订单号,订单详情)values('" + ordernum + "','" + ordernum_a + "')";
                    db.sqlEx(cmdstr_a);
                }
                for (int i = 1; i < b; i++)
                {
                    string ordernum_b = "B" + i.ToString();
                    string cmdstr_b = "insert into order_write(订单号,订单详情)values('" + ordernum + "','" + ordernum_b + "')";
                    db.sqlEx(cmdstr_b);
                }

                this.Close();
            }
          if(str_a==""&&str_b=="") 
            {
                if (MessageBox.Show("当前还没新建订单，确认退出吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    this.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void or_new_Load(object sender, EventArgs e)
        {

        }

      
    }
}
