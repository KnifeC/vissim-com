namespace vissim二次开发测试
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SimulationPeriod = new System.Windows.Forms.TextBox();
            this.SimulationSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.times = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.peizhi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开路网";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "开始仿真";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "仿真周期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "仿真速度";
            // 
            // SimulationPeriod
            // 
            this.SimulationPeriod.Location = new System.Drawing.Point(62, 3);
            this.SimulationPeriod.Name = "SimulationPeriod";
            this.SimulationPeriod.Size = new System.Drawing.Size(100, 21);
            this.SimulationPeriod.TabIndex = 4;
            // 
            // SimulationSpeed
            // 
            this.SimulationSpeed.Location = new System.Drawing.Point(62, 36);
            this.SimulationSpeed.Name = "SimulationSpeed";
            this.SimulationSpeed.Size = new System.Drawing.Size(100, 21);
            this.SimulationSpeed.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "仿真次数";
            this.label3.Visible = false;
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(62, 68);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(100, 21);
            this.times.TabIndex = 7;
            this.times.Text = "1";
            this.times.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.times);
            this.panel1.Controls.Add(this.SimulationPeriod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SimulationSpeed);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 97);
            this.panel1.TabIndex = 8;
            // 
            // peizhi
            // 
            this.peizhi.Location = new System.Drawing.Point(12, 41);
            this.peizhi.Name = "peizhi";
            this.peizhi.Size = new System.Drawing.Size(88, 23);
            this.peizhi.TabIndex = 9;
            this.peizhi.Text = "选择配置文件";
            this.peizhi.UseVisualStyleBackColor = true;
            this.peizhi.Click += new System.EventHandler(this.peizhi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 378);
            this.Controls.Add(this.peizhi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "vissim二次开发测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SimulationPeriod;
        private System.Windows.Forms.TextBox SimulationSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox times;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button peizhi;
    }
}

