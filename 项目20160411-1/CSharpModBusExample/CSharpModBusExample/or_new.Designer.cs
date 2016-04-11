namespace CSharpModBusExample
{
    partial class or_new
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.RadioButton();
            this.yes = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品B个数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "产品A个数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "计划产出数量：";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(223, 28);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(270, 21);
            this.tb_a.TabIndex = 5;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(223, 98);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(270, 21);
            this.tb_b.TabIndex = 6;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(223, 166);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(270, 21);
            this.sum.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "是否发布：";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(343, 236);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(35, 16);
            this.no.TabIndex = 58;
            this.no.TabStop = true;
            this.no.Text = "否";
            this.no.UseVisualStyleBackColor = true;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(233, 234);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(35, 16);
            this.yes.TabIndex = 59;
            this.yes.TabStop = true;
            this.yes.Text = "是";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // or_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 358);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "or_new";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增";
            this.Load += new System.EventHandler(this.or_new_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton yes;
    }
}