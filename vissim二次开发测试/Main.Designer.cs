namespace vissim二次开发测试
{
    partial class Main
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
            this.OpenInp = new System.Windows.Forms.Button();
            this.OpenIni = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SimulationPeriod = new System.Windows.Forms.TextBox();
            this.SimulationSpeed = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.evaP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pjtab = new System.Windows.Forms.TabControl();
            this.roadnum = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dtLinkEvaluation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxLinkEvaluation = new System.Windows.Forms.ComboBox();
            this.msnum = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBoxDatacollection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pjtab.SuspendLayout();
            this.roadnum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLinkEvaluation)).BeginInit();
            this.msnum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenInp
            // 
            this.OpenInp.Location = new System.Drawing.Point(12, 12);
            this.OpenInp.Name = "OpenInp";
            this.OpenInp.Size = new System.Drawing.Size(90, 23);
            this.OpenInp.TabIndex = 0;
            this.OpenInp.Text = "打开路网";
            this.OpenInp.UseVisualStyleBackColor = true;
            this.OpenInp.Click += new System.EventHandler(this.OpenInp_Click);
            // 
            // OpenIni
            // 
            this.OpenIni.Location = new System.Drawing.Point(108, 12);
            this.OpenIni.Name = "OpenIni";
            this.OpenIni.Size = new System.Drawing.Size(90, 23);
            this.OpenIni.TabIndex = 1;
            this.OpenIni.Text = "打开配置文件";
            this.OpenIni.UseVisualStyleBackColor = true;
            this.OpenIni.Click += new System.EventHandler(this.OpenIni_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(425, 414);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(45, 42);
            this.Start.TabIndex = 2;
            this.Start.Text = "开始仿真";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "仿真周期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "仿真速度";
            // 
            // SimulationPeriod
            // 
            this.SimulationPeriod.Location = new System.Drawing.Point(75, 11);
            this.SimulationPeriod.Name = "SimulationPeriod";
            this.SimulationPeriod.Size = new System.Drawing.Size(100, 21);
            this.SimulationPeriod.TabIndex = 5;
            this.SimulationPeriod.Text = "1";
            // 
            // SimulationSpeed
            // 
            this.SimulationSpeed.Location = new System.Drawing.Point(75, 42);
            this.SimulationSpeed.Name = "SimulationSpeed";
            this.SimulationSpeed.Size = new System.Drawing.Size(100, 21);
            this.SimulationSpeed.TabIndex = 6;
            this.SimulationSpeed.Text = "1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 349);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.evaP);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.SimulationPeriod);
            this.tabPage1.Controls.Add(this.SimulationSpeed);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "仿真参数设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // evaP
            // 
            this.evaP.Location = new System.Drawing.Point(75, 79);
            this.evaP.Name = "evaP";
            this.evaP.Size = new System.Drawing.Size(100, 21);
            this.evaP.TabIndex = 9;
            this.evaP.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "评价周期";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pjtab);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(495, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "评价";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pjtab
            // 
            this.pjtab.Controls.Add(this.roadnum);
            this.pjtab.Controls.Add(this.msnum);
            this.pjtab.Location = new System.Drawing.Point(6, 6);
            this.pjtab.Name = "pjtab";
            this.pjtab.SelectedIndex = 0;
            this.pjtab.Size = new System.Drawing.Size(482, 314);
            this.pjtab.TabIndex = 0;
            // 
            // roadnum
            // 
            this.roadnum.Controls.Add(this.label3);
            this.roadnum.Controls.Add(this.dtLinkEvaluation);
            this.roadnum.Controls.Add(this.comboBoxLinkEvaluation);
            this.roadnum.Location = new System.Drawing.Point(4, 22);
            this.roadnum.Name = "roadnum";
            this.roadnum.Padding = new System.Windows.Forms.Padding(3);
            this.roadnum.Size = new System.Drawing.Size(474, 288);
            this.roadnum.TabIndex = 0;
            this.roadnum.Text = "路段参数";
            this.roadnum.UseVisualStyleBackColor = true;
            this.roadnum.Enter += new System.EventHandler(this.roadnum_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "编号";
            // 
            // dtLinkEvaluation
            // 
            this.dtLinkEvaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLinkEvaluation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtLinkEvaluation.Location = new System.Drawing.Point(7, 34);
            this.dtLinkEvaluation.Name = "dtLinkEvaluation";
            this.dtLinkEvaluation.RowTemplate.Height = 23;
            this.dtLinkEvaluation.Size = new System.Drawing.Size(593, 248);
            this.dtLinkEvaluation.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "检测周期";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "平均速度";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "平均密度";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "平均流量";
            this.Column4.Name = "Column4";
            // 
            // comboBoxLinkEvaluation
            // 
            this.comboBoxLinkEvaluation.FormattingEnabled = true;
            this.comboBoxLinkEvaluation.Location = new System.Drawing.Point(53, 6);
            this.comboBoxLinkEvaluation.Name = "comboBoxLinkEvaluation";
            this.comboBoxLinkEvaluation.Size = new System.Drawing.Size(121, 20);
            this.comboBoxLinkEvaluation.TabIndex = 0;
            this.comboBoxLinkEvaluation.SelectedIndexChanged += new System.EventHandler(this.comboBoxLinkEvaluation_SelectedIndexChanged);
            // 
            // msnum
            // 
            this.msnum.Controls.Add(this.label7);
            this.msnum.Controls.Add(this.dataGridView2);
            this.msnum.Controls.Add(this.comboBoxDatacollection);
            this.msnum.Location = new System.Drawing.Point(4, 22);
            this.msnum.Name = "msnum";
            this.msnum.Padding = new System.Windows.Forms.Padding(3);
            this.msnum.Size = new System.Drawing.Size(474, 288);
            this.msnum.TabIndex = 1;
            this.msnum.Text = "检测器参数";
            this.msnum.UseVisualStyleBackColor = true;
            this.msnum.Enter += new System.EventHandler(this.msnum_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "编号";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView2.Location = new System.Drawing.Point(6, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(464, 252);
            this.dataGridView2.TabIndex = 3;
            // 
            // comboBoxDatacollection
            // 
            this.comboBoxDatacollection.FormattingEnabled = true;
            this.comboBoxDatacollection.Location = new System.Drawing.Point(56, 7);
            this.comboBoxDatacollection.Name = "comboBoxDatacollection";
            this.comboBoxDatacollection.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDatacollection.TabIndex = 2;
            this.comboBoxDatacollection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDatacollection_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 7;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(374, 414);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(45, 42);
            this.Stop.TabIndex = 8;
            this.Stop.Text = "停止仿真";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "没卵用——>";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "检测周期";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "检测器平均速度";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "检测器车数量";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "检测器车占有率";
            this.Column8.Name = "Column8";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.OpenIni);
            this.Controls.Add(this.OpenInp);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.pjtab.ResumeLayout(false);
            this.roadnum.ResumeLayout(false);
            this.roadnum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLinkEvaluation)).EndInit();
            this.msnum.ResumeLayout(false);
            this.msnum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenInp;
        private System.Windows.Forms.Button OpenIni;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SimulationPeriod;
        private System.Windows.Forms.TextBox SimulationSpeed;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl pjtab;
        private System.Windows.Forms.TabPage roadnum;
        private System.Windows.Forms.TabPage msnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtLinkEvaluation;
        private System.Windows.Forms.ComboBox comboBoxLinkEvaluation;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBoxDatacollection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox evaP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}