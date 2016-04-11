using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSharpModBusExample.user
{
    public partial class Login : Form
    {
        DB db = new DB();
        CPublic cppublic = new CPublic();
        public static string userName;
        public static string passWord;
        public static string type;
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            userName = txtUsername.Text.Trim();
            passWord =txtUserpassword.Text.Trim();
        
            try
            {
                if (txtUsername.Text.Trim() == "")
                {
                    MessageBox.Show("用户名不能为空!", "错误");
                    txtUsername.Focus();
                    return;
                }
                else if (txtUserpassword.Text.Trim() == "")
                {
                    MessageBox.Show("密码不能为空!", "错误");
                    txtUserpassword.Focus();
                    return;
                }
                else if (comboxType.Text=="")
                {
                    MessageBox.Show("请选择用户登录权限!", "错误");
                    comboxType.Focus();
                    return;
                }
                this.Text = "正在验证......";
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;  //让光标变成沙漏状

                string sqlStr = "select u_Name ,u_Pass,u_Type from tb_user where u_Name ='" + userName + "'and u_Pass ='" + passWord.Trim() + "'and u_Type='" + comboxType.Text+ "'";
                DataSet ds = new DataSet();
                SqlConnection con =db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlStr,con);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (!sdr.Read())
                {
                    MessageBox.Show("用户名或密码错误！请重新输入", "错误");
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "用户登录";
                    txtUsername.Text = "";
                    txtUserpassword.Text = "";
                    txtUsername.Focus();
                }

           

                else
                {
                    main ob_FrmMain = new main();
                    CPublic.userInfo[0] = txtUsername.Text.Trim();
                    CPublic.userInfo[1] = txtUserpassword.Text.Trim();

                    //CPublic.userInfo[2] = ds.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
                    //CPublic.userInfo[3] = ds.Tables[0].Rows[0].ItemArray[2].ToString().Trim();
                    //数据集登录方法

                    CPublic.userInfo[2] = sdr["u_Type"].ToString().Trim();
                 
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "用户登录";
                    ob_FrmMain.Show();
                    this.Hide();
                }
                con.Close();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "登录异常");
                this.Cursor = System.Windows.Forms.Cursors.Arrow;
                this.Text = "用户登录";
                txtUsername.Text = "";
                txtUserpassword.Text = "";
                txtUsername.Focus();
            }
            finally
            {
              
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
