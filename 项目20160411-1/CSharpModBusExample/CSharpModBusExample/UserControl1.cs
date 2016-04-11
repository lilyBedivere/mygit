using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpModBusExample
{
    public partial class UserControl1 : UserControl
    {
        int pos = -1;
        int i = 0;
        int temp = 0;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(textBox1.Text);
            i = 0;
            pos = 1;
            output.Text = "kaishi jis";
            //optput("开始计时");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos = 0;
            //output("停止计时");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pos == 1)
            {
                i++;
                if (i == temp)
                {
                    i = 0;
                    //output("定时器归0");
                    //output(" ");
                }
                else
                { }
                    //output("临时变量累加："+i.ToString());
            }
        }
    }
}
