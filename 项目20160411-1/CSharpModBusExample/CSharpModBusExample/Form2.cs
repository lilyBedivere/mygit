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
    public partial class Form2 : Form
    {
        System.Timers.Timer myTimer; 

        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 user = new UserControl1();
          //  pro_order.ordermanager order = new pro_order.ordermanager();
            panel1.Controls.Add(user);
            user.Dock = DockStyle.Fill;
            //string A = textBox1.Text.ToString();
            //byte[] data = strToToHexByte(A);
            //string B = byteToHexStr(data);
            //textBox2.Text = B;
        }
        public static byte[] strToToHexByte(string hexString)//字符串转换为十六进制
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 10);
            return returnBytes;
        }
        public static string byteToHexStr(byte[] bytes)//字符数组转换为16进制字符串
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

        private void Form2_Load(object sender, EventArgs e)
        {
            myTimer = new System.Timers.Timer(2000);//定时周期2秒
            myTimer.Elapsed += myTimer_Elapsed;//到2秒了做的事件
            myTimer.AutoReset = true; //是否不断重复定时器操作


        }

        void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "\n" + "aaa";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myTimer.Enabled = true; //定时器开始用
            //如果不写下面这句会有一个异常。
            //异常：线程间操作无效: 从不是创建控件"richtextbox"的线程访问它
            //但这不是最好的方法。如果只有一个进程调用richtextbox而已。就可以用下面这句
            //如果有多个线程调用richtextbox等控件。就要用委托。具体百度
            //一篇参考博客http://www.cnblogs.com/zyh-nhy/archive/2008/01/28/1056194.html
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (myTimer.Enabled)
            {
                myTimer.Enabled = false; //定时器停止
                button2.Text = "continue";
            }
            else
            {
                myTimer.Enabled = true;
                button2.Text = "pause";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            myTimer.Close(); //释放Timer占用的资源
            myTimer.Dispose();
            textBox1.Text = textBox1.Text + "\n" + "over";

        }

        
    }
}
