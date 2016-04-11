namespace CSharpModBusExample.pro_order
{
    partial class rfid_scence
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_ReadDateTime = new System.Windows.Forms.Label();
            this.lb_ReadTagID = new System.Windows.Forms.Label();
            this.bt_ReadDateTime = new System.Windows.Forms.Button();
            this.tx_TagValue = new System.Windows.Forms.TextBox();
            this.bt_WriteDateTime = new System.Windows.Forms.Button();
            this.tb_ReadTagIDFunctionCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_ReadID = new System.Windows.Forms.Button();
            this.tbxHistory = new System.Windows.Forms.RichTextBox();
            this.tbxReceiveText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageProging = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.Button();
            this.redo = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1520, 815);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.dataGridView5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lb_ReadDateTime);
            this.tabPage1.Controls.Add(this.lb_ReadTagID);
            this.tabPage1.Controls.Add(this.bt_ReadDateTime);
            this.tabPage1.Controls.Add(this.tx_TagValue);
            this.tabPage1.Controls.Add(this.bt_WriteDateTime);
            this.tabPage1.Controls.Add(this.tb_ReadTagIDFunctionCode);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.bt_ReadID);
            this.tabPage1.Controls.Add(this.tbxHistory);
            this.tabPage1.Controls.Add(this.tbxReceiveText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1512, 789);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RFID写";
            // 
            // lb_ReadDateTime
            // 
            this.lb_ReadDateTime.AutoSize = true;
            this.lb_ReadDateTime.Location = new System.Drawing.Point(489, 177);
            this.lb_ReadDateTime.Name = "lb_ReadDateTime";
            this.lb_ReadDateTime.Size = new System.Drawing.Size(29, 12);
            this.lb_ReadDateTime.TabIndex = 57;
            this.lb_ReadDateTime.Text = "tips";
            // 
            // lb_ReadTagID
            // 
            this.lb_ReadTagID.AutoSize = true;
            this.lb_ReadTagID.Location = new System.Drawing.Point(354, 93);
            this.lb_ReadTagID.Name = "lb_ReadTagID";
            this.lb_ReadTagID.Size = new System.Drawing.Size(29, 12);
            this.lb_ReadTagID.TabIndex = 56;
            this.lb_ReadTagID.Text = "tips";
            // 
            // bt_ReadDateTime
            // 
            this.bt_ReadDateTime.Location = new System.Drawing.Point(126, 172);
            this.bt_ReadDateTime.Name = "bt_ReadDateTime";
            this.bt_ReadDateTime.Size = new System.Drawing.Size(75, 23);
            this.bt_ReadDateTime.TabIndex = 55;
            this.bt_ReadDateTime.Text = "读取时间";
            this.bt_ReadDateTime.UseVisualStyleBackColor = true;
            this.bt_ReadDateTime.Click += new System.EventHandler(this.bt_ReadDateTime_Click);
            // 
            // tx_TagValue
            // 
            this.tx_TagValue.Location = new System.Drawing.Point(237, 174);
            this.tx_TagValue.Name = "tx_TagValue";
            this.tx_TagValue.Size = new System.Drawing.Size(230, 21);
            this.tx_TagValue.TabIndex = 54;
            // 
            // bt_WriteDateTime
            // 
            this.bt_WriteDateTime.Location = new System.Drawing.Point(126, 128);
            this.bt_WriteDateTime.Name = "bt_WriteDateTime";
            this.bt_WriteDateTime.Size = new System.Drawing.Size(75, 23);
            this.bt_WriteDateTime.TabIndex = 53;
            this.bt_WriteDateTime.Text = "写入时间";
            this.bt_WriteDateTime.UseVisualStyleBackColor = true;
            this.bt_WriteDateTime.Click += new System.EventHandler(this.bt_WriteDateTime_Click);
            // 
            // tb_ReadTagIDFunctionCode
            // 
            this.tb_ReadTagIDFunctionCode.Location = new System.Drawing.Point(237, 90);
            this.tb_ReadTagIDFunctionCode.Name = "tb_ReadTagIDFunctionCode";
            this.tb_ReadTagIDFunctionCode.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadTagIDFunctionCode.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 51;
            this.label4.Text = "功能代码：";
            // 
            // bt_ReadID
            // 
            this.bt_ReadID.Location = new System.Drawing.Point(126, 52);
            this.bt_ReadID.Name = "bt_ReadID";
            this.bt_ReadID.Size = new System.Drawing.Size(75, 23);
            this.bt_ReadID.TabIndex = 50;
            this.bt_ReadID.Text = "读取ID";
            this.bt_ReadID.UseVisualStyleBackColor = true;
            this.bt_ReadID.Click += new System.EventHandler(this.bt_ReadID_Click);
            // 
            // tbxHistory
            // 
            this.tbxHistory.Location = new System.Drawing.Point(126, 201);
            this.tbxHistory.Name = "tbxHistory";
            this.tbxHistory.Size = new System.Drawing.Size(457, 248);
            this.tbxHistory.TabIndex = 49;
            this.tbxHistory.Text = "";
            // 
            // tbxReceiveText
            // 
            this.tbxReceiveText.Location = new System.Drawing.Point(237, 54);
            this.tbxReceiveText.Name = "tbxReceiveText";
            this.tbxReceiveText.Size = new System.Drawing.Size(230, 21);
            this.tbxReceiveText.TabIndex = 48;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ImageProging);
            this.tabPage2.Controls.Add(this.tabControl3);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1512, 789);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "订单执行";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Location = new System.Drawing.Point(37, 413);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1465, 361);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1457, 335);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "生产跟踪";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1431, 323);
            this.panel2.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1457, 335);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "设备信息";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1420, 323);
            this.panel3.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.panel5);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1457, 335);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "标签读写";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView4);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1420, 315);
            this.panel5.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label1);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1457, 335);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "生产报告";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(482, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查看/打印";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(33, 85);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1473, 322);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1465, 296);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "当前生产";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Location = new System.Drawing.Point(3, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1438, 276);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1397, 229);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1465, 296);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "订单信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1453, 266);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.redo);
            this.panel1.Controls.Add(this.pause);
            this.panel1.Controls.Add(this.start);
            this.panel1.Location = new System.Drawing.Point(37, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 64);
            this.panel1.TabIndex = 0;
            // 
            // ImageProging
            // 
            this.ImageProging.Image = global::CSharpModBusExample.Properties.Resources.T等待;
            this.ImageProging.Location = new System.Drawing.Point(1152, 35);
            this.ImageProging.Name = "ImageProging";
            this.ImageProging.Size = new System.Drawing.Size(100, 23);
            this.ImageProging.TabIndex = 6;
            this.ImageProging.TabStop = false;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(451, 21);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(65, 23);
            this.stop.TabIndex = 5;
            this.stop.Text = "■停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // redo
            // 
            this.redo.Location = new System.Drawing.Point(369, 21);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(65, 23);
            this.redo.TabIndex = 4;
            this.redo.Text = "恢复";
            this.redo.UseVisualStyleBackColor = true;
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(289, 21);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(65, 23);
            this.pause.TabIndex = 3;
            this.pause.Text = "|| 暂停";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.Location = new System.Drawing.Point(209, 20);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(65, 23);
            this.start.TabIndex = 2;
            this.start.Text = "▶ 开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(1406, 304);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(9, 13);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(1372, 279);
            this.dataGridView4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1162, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "写标签";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(740, 113);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.Size = new System.Drawing.Size(729, 354);
            this.dataGridView5.TabIndex = 59;
            // 
            // rfid_scence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "rfid_scence";
            this.Size = new System.Drawing.Size(1571, 831);
            this.Load += new System.EventHandler(this.rfid_scence_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageProging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImageProging;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button redo;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ReadDateTime;
        private System.Windows.Forms.Label lb_ReadTagID;
        private System.Windows.Forms.Button bt_ReadDateTime;
        private System.Windows.Forms.TextBox tx_TagValue;
        private System.Windows.Forms.Button bt_WriteDateTime;
        private System.Windows.Forms.TextBox tb_ReadTagIDFunctionCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_ReadID;
        private System.Windows.Forms.RichTextBox tbxHistory;
        private System.Windows.Forms.TextBox tbxReceiveText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button1;
    }
}
