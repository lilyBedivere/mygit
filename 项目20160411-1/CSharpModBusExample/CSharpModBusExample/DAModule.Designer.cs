namespace CSharpModBusExample
{
    partial class DAModule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbConnState = new System.Windows.Forms.Label();
            this.btnConnServer = new System.Windows.Forms.Button();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemoteServerIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_LoadInfo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbConnState);
            this.groupBox1.Controls.Add(this.btnConnServer);
            this.groupBox1.Controls.Add(this.cmbServerName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRemoteServerIP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(31, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接OPC服务器";
            // 
            // lbConnState
            // 
            this.lbConnState.AutoSize = true;
            this.lbConnState.Location = new System.Drawing.Point(6, 92);
            this.lbConnState.Name = "lbConnState";
            this.lbConnState.Size = new System.Drawing.Size(35, 12);
            this.lbConnState.TabIndex = 10;
            this.lbConnState.Text = "lable";
            // 
            // btnConnServer
            // 
            this.btnConnServer.Enabled = false;
            this.btnConnServer.Location = new System.Drawing.Point(129, 87);
            this.btnConnServer.Name = "btnConnServer";
            this.btnConnServer.Size = new System.Drawing.Size(75, 23);
            this.btnConnServer.TabIndex = 8;
            this.btnConnServer.Text = "连接";
            this.btnConnServer.UseVisualStyleBackColor = true;
            this.btnConnServer.Click += new System.EventHandler(this.btnConnServer_Click);
            // 
            // cmbServerName
            // 
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(74, 54);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(130, 20);
            this.cmbServerName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "服务器：";
            // 
            // txtRemoteServerIP
            // 
            this.txtRemoteServerIP.Location = new System.Drawing.Point(74, 23);
            this.txtRemoteServerIP.Name = "txtRemoteServerIP";
            this.txtRemoteServerIP.Size = new System.Drawing.Size(130, 21);
            this.txtRemoteServerIP.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "IP:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "跳到FORM3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_LoadInfo
            // 
            this.tb_LoadInfo.Location = new System.Drawing.Point(267, 12);
            this.tb_LoadInfo.Multiline = true;
            this.tb_LoadInfo.Name = "tb_LoadInfo";
            this.tb_LoadInfo.Size = new System.Drawing.Size(191, 272);
            this.tb_LoadInfo.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(513, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 272);
            this.textBox1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "跳到FORM3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "lable";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "跳到FORM3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(624, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "跳到FORM4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DAModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 403);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_LoadInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DAModule";
            this.Text = "DAModule";
            this.Load += new System.EventHandler(this.DAModule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbConnState;
        private System.Windows.Forms.Button btnConnServer;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemoteServerIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_LoadInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}