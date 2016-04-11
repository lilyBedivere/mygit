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
    public partial class resource : UserControl
    {
        public resource()
        {
            InitializeComponent();
            a1zhuangtai.Enabled = true;
            a2zhuangtai.Enabled = true;
            b1zhuangtai.Enabled = true;
            b2zhuangtai.Enabled = true;

            //监听OPC数据变化
            DAModule.Material.Group.DataChange += new OPCAutomation.DIOPCGroupEvent_DataChangeEventHandler(Material_Group_DataChange);
        }

        void Material_Group_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            //-------------------------A1----------------------------------------//
            //-------------------------------------------------------------------//
            if (DAModule.Material.Item[0].Value == true)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._8格;
            }

            if (DAModule.Material.Item[4].Value == true) 
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources.空;
            }

            if (DAModule.Material.Item[8].Value == 7)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._7格;
            }
            if (DAModule.Material.Item[8].Value == 6)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._6格;
            }
            if (DAModule.Material.Item[8].Value == 5)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._5格;
            }
            if (DAModule.Material.Item[8].Value == 4)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._4格;
            }
            if (DAModule.Material.Item[8].Value == 3)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._3格;
            }
            if (DAModule.Material.Item[8].Value == 2)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._2格;
            }
            if (DAModule.Material.Item[8].Value == 1)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._1格;
            }
            if (DAModule.Material_Cylinder.Item[0].Value == true)
            {
                a1zhuangtai.Text = "收回";
            }
            if (DAModule.Material_Cylinder.Item[4].Value == true)
            {
                a1zhuangtai.Text = "推出";
            }



            //-------------------------A2----------------------------------------//
            //-------------------------------------------------------------------//
            if (DAModule.Material.Item[1].Value == true)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._8格;
            }

            if (DAModule.Material.Item[5].Value == true)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources.空;
            }

            if (DAModule.Material.Item[9].Value == 7)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._7格;
            }
            if (DAModule.Material.Item[9].Value == 6)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._6格;
            }
            if (DAModule.Material.Item[9].Value == 5)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._5格;
            }
            if (DAModule.Material.Item[9].Value == 4)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._4格;
            }
            if (DAModule.Material.Item[9].Value == 3)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._3格;
            }
            if (DAModule.Material.Item[9].Value == 2)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._2格;
            }
            if (DAModule.Material.Item[9].Value == 1)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._1格;
            }
            if (DAModule.Material_Cylinder.Item[1].Value == true)
            {
                a1zhuangtai.Text = "收回";
            }
            if (DAModule.Material_Cylinder.Item[5].Value == true)
            {
                a1zhuangtai.Text = "推出";
            }


            //-------------------------B1----------------------------------------//
            //-------------------------------------------------------------------//
            if (DAModule.Material.Item[3].Value == true)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._8格;
            }

            if (DAModule.Material.Item[7].Value == true)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources.空;
            }

            if (DAModule.Material.Item[11].Value == 7)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._7格;
            }
            if (DAModule.Material.Item[11].Value == 6)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._6格;
            }
            if (DAModule.Material.Item[11].Value == 5)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._5格;
            }
            if (DAModule.Material.Item[11].Value == 4)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._4格;
            }
            if (DAModule.Material.Item[11].Value == 3)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._3格;
            }
            if (DAModule.Material.Item[11].Value == 2)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._2格;
            }
            if (DAModule.Material.Item[11].Value == 1)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._1格;
            }
            if (DAModule.Material_Cylinder.Item[3].Value == true)
            {
                a1zhuangtai.Text = "收回";
            }
            if (DAModule.Material_Cylinder.Item[7].Value == true)
            {
                a1zhuangtai.Text = "推出";
            }


            //-------------------------B2----------------------------------------//
            //-------------------------------------------------------------------//
            if (DAModule.Material.Item[2].Value == true)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._8格;
            }

            if (DAModule.Material.Item[6].Value == true)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources.空;
            }

            if (DAModule.Material.Item[10].Value == 7)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._7格;
            }
            if (DAModule.Material.Item[10].Value == 6)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._6格;
            }
            if (DAModule.Material.Item[10].Value == 5)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._5格;
            }
            if (DAModule.Material.Item[10].Value == 4)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._4格;
            }
            if (DAModule.Material.Item[10].Value == 3)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._3格;
            }
            if (DAModule.Material.Item[10].Value == 2)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._2格;
            }
            if (DAModule.Material.Item[10].Value == 1)
            {
                liaocang1.Image = CSharpModBusExample.Properties.Resources._1格;
            }
            if (DAModule.Material_Cylinder.Item[2].Value == true)
            {
                a1zhuangtai.Text = "收回";
            }
            if (DAModule.Material_Cylinder.Item[6].Value == true)
            {
                a1zhuangtai.Text = "推出";
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CSharpModBusExample.Properties.Resources.正常1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void qigang2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void b2zhuangtai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
