namespace CSharpModBusExample
{
    partial class TestModBus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxSendText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.tbxReceiveText = new System.Windows.Forms.TextBox();
            this.tbxHistory = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbxSendText
            // 
            this.tbxSendText.Location = new System.Drawing.Point(12, 20);
            this.tbxSendText.Name = "tbxSendText";
            this.tbxSendText.Size = new System.Drawing.Size(615, 21);
            this.tbxSendText.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(646, 20);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送(S)";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(646, 69);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 1;
            this.btnReceive.Text = "接收(R)";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // tbxReceiveText
            // 
            this.tbxReceiveText.Location = new System.Drawing.Point(12, 69);
            this.tbxReceiveText.Name = "tbxReceiveText";
            this.tbxReceiveText.Size = new System.Drawing.Size(615, 21);
            this.tbxReceiveText.TabIndex = 0;
            // 
            // tbxHistory
            // 
            this.tbxHistory.Location = new System.Drawing.Point(12, 112);
            this.tbxHistory.Name = "tbxHistory";
            this.tbxHistory.Size = new System.Drawing.Size(740, 450);
            this.tbxHistory.TabIndex = 2;
            this.tbxHistory.Text = "";
            // 
            // TestModBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 567);
            this.Controls.Add(this.tbxHistory);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxReceiveText);
            this.Controls.Add(this.tbxSendText);
            this.MaximizeBox = false;
            this.Name = "TestModBus";
            this.Text = "TestModBus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestModBus_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSendText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox tbxReceiveText;
        private System.Windows.Forms.RichTextBox tbxHistory;
    }
}