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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
             b1.SendToBack();
            b1.Dock = DockStyle.Top;
            b2.SendToBack();
            b2.Dock = DockStyle.Bottom;
            b3.SendToBack();
            b3.Dock = DockStyle.Bottom;
            b4.SendToBack();
            b4.Dock = DockStyle.Bottom;

            p4.SendToBack();
            p3.SendToBack();
            p2.SendToBack();
            p1.BringToFront();
            p1.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            int buttonleft = (panel3.Width - button7.Width) / 2;
            button5.Left = buttonleft;
            button6.Left = buttonleft;
            button7.Left = buttonleft;
            button8.Left = buttonleft;
            button9.Left = buttonleft;
            button10.Left = buttonleft;
            b1_Click(sender, e);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.SendToBack();
            b2.Dock = DockStyle.Top;
            b1.SendToBack();
            b1.Dock = DockStyle.Top;
            b3.SendToBack();
            b3.Dock = DockStyle.Bottom;
            b4.SendToBack();
            b4.Dock = DockStyle.Bottom;

            p1.SendToBack();
            p3.SendToBack();
            p4.SendToBack();

            p2.BringToFront();
            p2.Dock = DockStyle.Fill;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.SendToBack();
            b3.Dock = DockStyle.Top;
            b2.SendToBack();
            b2.Dock = DockStyle.Top;
            b1.SendToBack();
            b1.Dock = DockStyle.Top; ;
            b4.SendToBack();
            b4.Dock = DockStyle.Bottom;

            p1.SendToBack();
            p2.SendToBack();
            p4.SendToBack();
            p3.BringToFront();

            p3.Dock = DockStyle.Fill;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.SendToBack();
            b4.Dock = DockStyle.Top;
            b3.SendToBack();
            b3.Dock = DockStyle.Top;
            b2.SendToBack();
            b2.Dock = DockStyle.Top;
            b1.SendToBack();
            b1.Dock = DockStyle.Top;

            p1.SendToBack();
            p2.SendToBack();
            p3.SendToBack();
            p4.BringToFront();

            p4.Dock = DockStyle.Fill;
        }
    }
}
