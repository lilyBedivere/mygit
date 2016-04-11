using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpModBusExample
{
    public partial class TestModBus : Form, ILog, IDisposable
    {
        private ModBusWrapper Wrapper = null;
        public TestModBus()
        {
            InitializeComponent();
            this.Wrapper = ModBusWrapper.CreateInstance(Protocol.TCPIP);
            this.Wrapper.Logger = this;
        }

        #region ILog 成员
        public void Write(string log)
        {
            this.tbxHistory.AppendText(log + Environment.NewLine);
            this.tbxHistory.Select(this.tbxHistory.TextLength, 0);
            this.tbxHistory.ScrollToCaret();
        }
        #endregion

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Wrapper.Send(Encoding.ASCII.GetBytes(this.tbxSendText.Text.Trim()));
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            this.tbxReceiveText.Text = Encoding.ASCII.GetString(this.Wrapper.Receive());
        }

        private void TestModBus_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Wrapper.Dispose();
        }
    }
}
