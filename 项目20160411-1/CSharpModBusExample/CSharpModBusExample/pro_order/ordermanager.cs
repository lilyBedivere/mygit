using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpModBusExample.pro_order
{
    public partial class ordermanager : UserControl
    {
        Boolean blnModify = false;
        DB db = new DB();
        //CurrencyManager cmOrders;
        public ordermanager()
        {
            InitializeComponent();

        }

        private void ordermanager_Load(object sender, EventArgs e)
        {



            DataSet myDs1 = new DataSet();
            dataGridView1.DataSource = db.GetDataSetStr("select * from ordernew_info order by 是否发布 desc,创建时间 asc", "ordernew_info");

            DataTable datatable = db.GetDataSetStr("select * from ordernew_info", "ordernew_info");
            int ss = datatable.Rows.Count;

            textBox1.Text = ss.ToString();


        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.ToolTipText == "首记录")
            {


            }
            if (e.Button.ToolTipText == "上一记录")
            {

            }
            if (e.Button.ToolTipText == "下一记录")
            {

            }
            if (e.Button.ToolTipText == "尾记录")
            {

            }
            if (e.Button.ToolTipText == "新增")
            {


                or_new ordernew = new or_new();
                ordernew.Show();
            }
            if (e.Button.ToolTipText == "修改")
            {
                blnModify = !blnModify;
                SetModifyMode(blnModify);
            }
            if (e.Button.ToolTipText == "删除")
            {
                string id = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                DialogResult result = MessageBox.Show("确认删除订单号为：" + id + "的订单吗？！", "删除数据", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    //string id = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string delete_num = "delete from ordernew_info where  订单号='" + id + "'";
                    db.sqlEx(delete_num);
                    dataGridView1.DataSource = db.GetDataSetStr("select * from ordernew_info order by 是否发布 desc,创建时间 asc", "ordernew_info");

                }

            }
            if (e.Button.ToolTipText == "刷新")
            {


                DataSet myDs1 = new DataSet();
                dataGridView1.DataSource = db.GetDataSetStr("select * from ordernew_info order by 是否发布 desc,创建时间 asc", "ordernew_info");
            }

            if (e.Button.ToolTipText == "发布")
            {
                string id = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string fabu = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                if (fabu == "是")
                {
                    MessageBox.Show("当前订单为发布状态，无需重新发布！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("确认要发布订单号为:" + id + "的订单吗？！", "发布订单", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {


                        string update_fabu = "update ordernew_info set 是否发布='是' where 订单号='" + id + "' ";


                        db.sqlEx(update_fabu);
                        dataGridView1.DataSource = db.GetDataSetStr("select * from ordernew_info order by 是否发布 desc,创建时间 asc", "ordernew_info");

                    }
                }
            }
            if (e.Button.ToolTipText == "取消发布")
            {
                string id = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string fabu = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                if (fabu == "否")
                {
                    MessageBox.Show("当前订单为没有发布，无需取消发布！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("确认要取消发布订单号为:" + id + "的订单吗？！", "发布订单", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {


                        string update_fabu = "update ordernew_info set 是否发布='否' where 订单号='" + id + "' ";


                        db.sqlEx(update_fabu);
                        dataGridView1.DataSource = db.GetDataSetStr("select * from ordernew_info order by 是否发布 desc,创建时间 asc", "ordernew_info");

                    }
                }
            }
            if (e.Button.ToolTipText == "退出")
            {
                //if (dataSet11.HasChanges())
                //{
                //    DialogResult result = MessageBox.Show("数据集有被修改但尚未提交的数据，是否提交？", "确认", MessageBoxButtons.OKCancel);
                //    if (result == DialogResult.OK)
                //        da1.Update(dataSet11);
                //}
                //this.Close();
            }

        }
        private void SetModifyMode(bool blnModify)
        {
            //设置文本框
            //txt7.ReadOnly = !blnModify;
            //txt12.ReadOnly = !blnModify;
            //txt13.ReadOnly = !blnModify;
            //txt14.ReadOnly = !blnModify;
            //txt11.ReadOnly = !blnModify;

            //txtMemo.ReadOnly = !blnModify;
            ////设置表格的只读模式
            //dataGrid1.ReadOnly = !blnModify;

            ////编辑时不允许搜索数据
            //btnSearch.Enabled = !blnModify;
            ////允许使用选择按钮
            //selBtn1.Enabled = blnModify;
            //selBtn2.Enabled = blnModify;

            //one.Enabled = blnModify;
            onenum.Enabled = blnModify;
            //two.Enabled = blnModify;
            twonum.Enabled = blnModify;
            make_time.Enabled = blnModify;
            plan_num.Enabled = blnModify;
            issue.Enabled = blnModify;
            overtime.Enabled = blnModify;
            pro_batch.Enabled = blnModify;
            user.Enabled = blnModify;

        }

        private void selBtn2_Click(object sender, EventArgs e)
        {

        }

        private void selBtn2_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void selBtn1_Click(object sender, EventArgs e)
        {

        }

        private void selBtn1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1["select", i].Value = true;
            }
            //all.Checked = true;
            //cancel.Checked = false;
            //all.Visible = false;
            checkBox2.Visible = true;
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                this.dataGridView1["select", i].Value = false;
            }
            //all.Checked = false;
            // cancel.Checked = true;
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            one.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            onenum.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            two.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            twonum.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            make_time.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            plan_num.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[9].Value.ToString() == "是")
            {
                issue.Checked = true;
                issue.Text = "已发布";
            }
            else
            {
                issue.Checked = false;
                issue.Text = "没发布";
            }
            //  issue.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            plan_time.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            overtime.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            pro_batch.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            user.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            id.Enabled = false;
            one.Enabled = false;
            two.Enabled = false;
            onenum.Enabled = false;
            twonum.Enabled = false;
            make_time.Enabled = false;
            plan_num.Enabled = false;
            issue.Enabled = false;
            overtime.Enabled = false;
            pro_batch.Enabled = false;
            user.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void found_ensure_Click(object sender, EventArgs e)
        {

        }


        //确认修改
        private void button2_Click_1(object sender, EventArgs e)
        {
            string id_ = id.Text.ToString();
            string onenum_ = onenum.Text.ToString();
            string twonum_ = twonum.Text.ToString();
            string plan_num_ = plan_num.Text.ToString();


            string update_all = "update ordernew_info set 产品种类1数量='" + onenum_ + "',产品种类2数量='" + twonum_ + "',计划产出数量='" + plan_num_ + "' where 订单号='" + id_ + "'";

            //string update_all = "delete from ordernew_info where  订单号='" + id_ + "'";

            db.sqlEx(update_all);
            dataGridView1.DataSource = db.GetDataSetStr("select * from ordernew_info order by 是否发布 desc,创建时间 asc", "ordernew_info");

            //  string update_all = "update ordernew_info set 产品种类1数量='1000' where id ='test_01'";
            SetModifyMode(false);

        }

        private void found_ensure_Click_1(object sender, EventArgs e)
        {
            if (Fid.Text != String.Empty)
            {
                String Fid_ = Fid.Text.ToString();
                string select_str = "SELECT * FROM ordernew_info WHERE 订单号='" + Fid_ + "'";

                dataGridView2.DataSource = db.GetDataSetStr(select_str, "ordernew_info");
            }
            else
            {
                //if (Foneortwo.Text!=null)
                //{
                //    String Foneortwo_ = Foneortwo.SelectedItem.ToString();
                //    string select_str = "SELECT * FROM ordernew_info WHERE 产品种类1='" + Foneortwo_ + "'or 产品种类2='" + Foneortwo_ + "'";
                //    dataGridView2.DataSource = db.GetDataSetStr(select_str, "ordernew_info");

                //}
                if (Fplannum.Text != String.Empty && Fispublish.Checked)
                {
                    String Fplannum_ = Fplannum.Text.ToString();
                    string select_str = "SELECT * FROM ordernew_info WHERE 计划产出数量='" + Fplannum_ + "'and 是否发布='是'";
                    dataGridView2.DataSource = db.GetDataSetStr(select_str, "ordernew_info");
                }
                else
                {
                    if (Fplannum.Text != String.Empty)
                    {
                        String Fplannum_ = Fplannum.Text.ToString();
                        string select_str = "SELECT * FROM ordernew_info WHERE 计划产出数量='" + Fplannum_ + "'";
                        dataGridView2.DataSource = db.GetDataSetStr(select_str, "ordernew_info");


                    }
                    else
                    {
                        string select_str = "SELECT * FROM ordernew_info WHERE 是否发布='是'";
                        dataGridView2.DataSource = db.GetDataSetStr(select_str, "ordernew_info");
                    }
                }

            }
        }

 
    }
}
