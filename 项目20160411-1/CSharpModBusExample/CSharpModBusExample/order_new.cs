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
    public partial class order_new : Form
    {
        DB db = new DB();
        string ordernum;
        public order_new()
        {
            InitializeComponent();
        }

        private void sumbit_Click(object sender, EventArgs e)
        {
            string str_a = text_A.Text.ToString();
            string str_b = text_B.Text.ToString();
            DataTable datatable = db.GetDataSetStr("select * from ordernew_info", "ordernew_info");
            int ss = datatable.Rows.Count;
            ordernum = "test_0" + ss.ToString();
            if (str_a != "" && str_b != " ")
            {
                int a = int.Parse(str_a);
                int b = int.Parse(str_b);

                string cmdstr = "insert into order_new(订单号,产品种类1,产品种类1数量,产品种类2,产品种类2数量,创建时间)values('" + ordernum + "','A','" + a + "','B','" + b + "','" + DateTime.Now + "')";
                db.sqlEx(cmdstr);
                string cmdstr1 = "insert into ordernew_info(订单号,产品种类1,产品种类1数量,产品种类2,产品种类2数量,创建时间)values('" + ordernum + "','A','" + a + "','B','" + b + "','" + DateTime.Now + "')";
                db.sqlEx(cmdstr1);
                
                for (int i = 1; i < a; i++)
                {
                    string ordernum_a = "A" + i.ToString();
                    string cmdstr_a = "insert into order_write(订单号,订单详情)values('" + ordernum + "','" + ordernum_a + "')";
                    db.sqlEx(cmdstr_a);
                }
                for (int i = 1; i <b; i++)
                {
                    string ordernum_b = "B" + i.ToString();
                    string cmdstr_b = "insert into order_write(订单号,订单详情)values('" + ordernum + "','" + ordernum_b + "')";
                    db.sqlEx(cmdstr_b);
                }

                this.Close();

            }
            else 
            {
                if (MessageBox.Show("当前还没新建订单，确认退出吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    this.Close();

            }
        }
    }
}
