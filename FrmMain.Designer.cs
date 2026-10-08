namespace 运动控制项目
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteJob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPoints = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWaitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMoveZ = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.numPosZ = new System.Windows.Forms.NumericUpDown();
            this.btnMoveY = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numPosY = new System.Windows.Forms.NumericUpDown();
            this.btnMoveX = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numPosX = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnZMinus = new System.Windows.Forms.Button();
            this.btnZPlus = new System.Windows.Forms.Button();
            this.btnYMinus = new System.Windows.Forms.Button();
            this.btnYPlus = new System.Windows.Forms.Button();
            this.btnXMinus = new System.Windows.Forms.Button();
            this.btnXPlus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numManualSpeed = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStopJob = new System.Windows.Forms.Button();
            this.btnStartJob = new System.Windows.Forms.Button();
            this.btnClearError = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelZAlarm = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelYAlarm = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelXAlarm = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelZMove = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelYMove = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelXMove = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoints)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numManualSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 33);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfig,
            this.menuJob});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuConfig
            // 
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(104, 29);
            this.menuConfig.Text = "控制器配置";
            this.menuConfig.Click += new System.EventHandler(this.menuConfig_Click);
            // 
            // menuJob
            // 
            this.menuJob.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveJobs,
            this.menuLoadJobs,
            this.menuDeleteJob,
            this.menuClearJobs,
            this.menuAddJob});
            this.menuJob.Name = "menuJob";
            this.menuJob.Size = new System.Drawing.Size(88, 29);
            this.menuJob.Text = "点位控制";
            // 
            // menuSaveJobs
            // 
            this.menuSaveJobs.Name = "menuSaveJobs";
            this.menuSaveJobs.Size = new System.Drawing.Size(224, 26);
            this.menuSaveJobs.Text = "保存点位";
            this.menuSaveJobs.Click += new System.EventHandler(this.menuSaveJobs_Click);
            // 
            // menuLoadJobs
            // 
            this.menuLoadJobs.Name = "menuLoadJobs";
            this.menuLoadJobs.Size = new System.Drawing.Size(224, 26);
            this.menuLoadJobs.Text = "加载点位";
            this.menuLoadJobs.Click += new System.EventHandler(this.menuLoadJobs_Click);
            // 
            // menuDeleteJob
            // 
            this.menuDeleteJob.Name = "menuDeleteJob";
            this.menuDeleteJob.Size = new System.Drawing.Size(224, 26);
            this.menuDeleteJob.Text = "删除点位";
            this.menuDeleteJob.Click += new System.EventHandler(this.menuDeleteJob_Click);
            // 
            // menuClearJobs
            // 
            this.menuClearJobs.Name = "menuClearJobs";
            this.menuClearJobs.Size = new System.Drawing.Size(224, 26);
            this.menuClearJobs.Text = "清空点位";
            this.menuClearJobs.Click += new System.EventHandler(this.menuClearJobs_Click);
            // 
            // menuAddJob
            // 
            this.menuAddJob.Name = "menuAddJob";
            this.menuAddJob.Size = new System.Drawing.Size(224, 26);
            this.menuAddJob.Text = "添加点位";
            this.menuAddJob.Click += new System.EventHandler(this.menuAddJob_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 34);
            this.panel2.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPoints);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1138, 539);
            this.splitContainer1.SplitterDistance = 793;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvPoints
            // 
            this.dgvPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colX,
            this.colY,
            this.colZ,
            this.colWaitTime,
            this.colEnable});
            this.dgvPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPoints.Location = new System.Drawing.Point(0, 0);
            this.dgvPoints.Name = "dgvPoints";
            this.dgvPoints.RowHeadersWidth = 51;
            this.dgvPoints.RowTemplate.Height = 27;
            this.dgvPoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoints.Size = new System.Drawing.Size(793, 539);
            this.dgvPoints.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "点位名称";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 120;
            // 
            // colX
            // 
            this.colX.DataPropertyName = "X";
            this.colX.HeaderText = "X";
            this.colX.MinimumWidth = 6;
            this.colX.Name = "colX";
            this.colX.Width = 90;
            // 
            // colY
            // 
            this.colY.DataPropertyName = "Y";
            this.colY.HeaderText = "Y";
            this.colY.MinimumWidth = 6;
            this.colY.Name = "colY";
            this.colY.Width = 90;
            // 
            // colZ
            // 
            this.colZ.DataPropertyName = "Z";
            this.colZ.HeaderText = "Z";
            this.colZ.MinimumWidth = 6;
            this.colZ.Name = "colZ";
            this.colZ.Width = 90;
            // 
            // colWaitTime
            // 
            this.colWaitTime.DataPropertyName = "WaitTime";
            this.colWaitTime.HeaderText = "停留时间";
            this.colWaitTime.MinimumWidth = 6;
            this.colWaitTime.Name = "colWaitTime";
            this.colWaitTime.Width = 90;
            // 
            // colEnable
            // 
            this.colEnable.DataPropertyName = "Enable";
            this.colEnable.HeaderText = "启用";
            this.colEnable.MinimumWidth = 6;
            this.colEnable.Name = "colEnable";
            this.colEnable.Width = 60;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnMoveZ);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.numPosZ);
            this.groupBox5.Controls.Add(this.btnMoveY);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.numPosY);
            this.groupBox5.Controls.Add(this.btnMoveX);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.numPosX);
            this.groupBox5.Location = new System.Drawing.Point(3, 361);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(303, 172);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "定位移动";
            // 
            // btnMoveZ
            // 
            this.btnMoveZ.Location = new System.Drawing.Point(198, 86);
            this.btnMoveZ.Name = "btnMoveZ";
            this.btnMoveZ.Size = new System.Drawing.Size(50, 25);
            this.btnMoveZ.TabIndex = 13;
            this.btnMoveZ.Text = "移动";
            this.btnMoveZ.UseVisualStyleBackColor = true;
            this.btnMoveZ.Click += new System.EventHandler(this.btnMoveZ_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Z:";
            // 
            // numPosZ
            // 
            this.numPosZ.Location = new System.Drawing.Point(72, 86);
            this.numPosZ.Name = "numPosZ";
            this.numPosZ.Size = new System.Drawing.Size(120, 25);
            this.numPosZ.TabIndex = 11;
            // 
            // btnMoveY
            // 
            this.btnMoveY.Location = new System.Drawing.Point(198, 55);
            this.btnMoveY.Name = "btnMoveY";
            this.btnMoveY.Size = new System.Drawing.Size(50, 25);
            this.btnMoveY.TabIndex = 10;
            this.btnMoveY.Text = "移动";
            this.btnMoveY.UseVisualStyleBackColor = true;
            this.btnMoveY.Click += new System.EventHandler(this.btnMoveY_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Y:";
            // 
            // numPosY
            // 
            this.numPosY.Location = new System.Drawing.Point(72, 55);
            this.numPosY.Name = "numPosY";
            this.numPosY.Size = new System.Drawing.Size(120, 25);
            this.numPosY.TabIndex = 8;
            // 
            // btnMoveX
            // 
            this.btnMoveX.Location = new System.Drawing.Point(198, 24);
            this.btnMoveX.Name = "btnMoveX";
            this.btnMoveX.Size = new System.Drawing.Size(50, 25);
            this.btnMoveX.TabIndex = 7;
            this.btnMoveX.Text = "移动";
            this.btnMoveX.UseVisualStyleBackColor = true;
            this.btnMoveX.Click += new System.EventHandler(this.btnMoveX_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "X:";
            // 
            // numPosX
            // 
            this.numPosX.Location = new System.Drawing.Point(72, 24);
            this.numPosX.Name = "numPosX";
            this.numPosX.Size = new System.Drawing.Size(120, 25);
            this.numPosX.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnZMinus);
            this.groupBox4.Controls.Add(this.btnZPlus);
            this.groupBox4.Controls.Add(this.btnYMinus);
            this.groupBox4.Controls.Add(this.btnYPlus);
            this.groupBox4.Controls.Add(this.btnXMinus);
            this.groupBox4.Controls.Add(this.btnXPlus);
            this.groupBox4.Location = new System.Drawing.Point(3, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 92);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "点动控制";
            // 
            // btnZMinus
            // 
            this.btnZMinus.Location = new System.Drawing.Point(118, 55);
            this.btnZMinus.Name = "btnZMinus";
            this.btnZMinus.Size = new System.Drawing.Size(50, 25);
            this.btnZMinus.TabIndex = 6;
            this.btnZMinus.Text = "Z-";
            this.btnZMinus.UseVisualStyleBackColor = true;
            this.btnZMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZMinus_MouseDown);
            this.btnZMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZMinus_MouseUp);
            // 
            // btnZPlus
            // 
            this.btnZPlus.Location = new System.Drawing.Point(62, 55);
            this.btnZPlus.Name = "btnZPlus";
            this.btnZPlus.Size = new System.Drawing.Size(50, 25);
            this.btnZPlus.TabIndex = 5;
            this.btnZPlus.Text = "Z+";
            this.btnZPlus.UseVisualStyleBackColor = true;
            this.btnZPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZPlus_MouseDown);
            this.btnZPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZPlus_MouseUp);
            // 
            // btnYMinus
            // 
            this.btnYMinus.Location = new System.Drawing.Point(6, 55);
            this.btnYMinus.Name = "btnYMinus";
            this.btnYMinus.Size = new System.Drawing.Size(50, 25);
            this.btnYMinus.TabIndex = 4;
            this.btnYMinus.Text = "Y-";
            this.btnYMinus.UseVisualStyleBackColor = true;
            this.btnYMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnYMinus_MouseDown);
            this.btnYMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnYMinus_MouseUp);
            // 
            // btnYPlus
            // 
            this.btnYPlus.Location = new System.Drawing.Point(118, 24);
            this.btnYPlus.Name = "btnYPlus";
            this.btnYPlus.Size = new System.Drawing.Size(50, 25);
            this.btnYPlus.TabIndex = 3;
            this.btnYPlus.Text = "Y+";
            this.btnYPlus.UseVisualStyleBackColor = true;
            this.btnYPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnYPlus_MouseDown);
            this.btnYPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnYPlus_MouseUp);
            // 
            // btnXMinus
            // 
            this.btnXMinus.Location = new System.Drawing.Point(62, 24);
            this.btnXMinus.Name = "btnXMinus";
            this.btnXMinus.Size = new System.Drawing.Size(50, 25);
            this.btnXMinus.TabIndex = 2;
            this.btnXMinus.Text = "X-";
            this.btnXMinus.UseVisualStyleBackColor = true;
            this.btnXMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnXMinus_MouseDown);
            this.btnXMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnXMinus_MouseUp);
            // 
            // btnXPlus
            // 
            this.btnXPlus.Location = new System.Drawing.Point(6, 24);
            this.btnXPlus.Name = "btnXPlus";
            this.btnXPlus.Size = new System.Drawing.Size(50, 25);
            this.btnXPlus.TabIndex = 1;
            this.btnXPlus.Text = "X+";
            this.btnXPlus.UseVisualStyleBackColor = true;
            this.btnXPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnXPlus_MouseDown);
            this.btnXPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnXPlus_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.numManualSpeed);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(141, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "手动控制";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "MM/S";
            // 
            // numManualSpeed
            // 
            this.numManualSpeed.DecimalPlaces = 2;
            this.numManualSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numManualSpeed.Location = new System.Drawing.Point(10, 39);
            this.numManualSpeed.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numManualSpeed.Name = "numManualSpeed";
            this.numManualSpeed.Size = new System.Drawing.Size(120, 25);
            this.numManualSpeed.TabIndex = 1;
            this.numManualSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "速度";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStopJob);
            this.groupBox2.Controls.Add(this.btnStartJob);
            this.groupBox2.Controls.Add(this.btnClearError);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Location = new System.Drawing.Point(141, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "控制器操作";
            // 
            // btnStopJob
            // 
            this.btnStopJob.Location = new System.Drawing.Point(6, 132);
            this.btnStopJob.Name = "btnStopJob";
            this.btnStopJob.Size = new System.Drawing.Size(153, 30);
            this.btnStopJob.TabIndex = 3;
            this.btnStopJob.Text = "停止作业";
            this.btnStopJob.UseVisualStyleBackColor = true;
            this.btnStopJob.Click += new System.EventHandler(this.btnStopJob_Click);
            // 
            // btnStartJob
            // 
            this.btnStartJob.Location = new System.Drawing.Point(6, 96);
            this.btnStartJob.Name = "btnStartJob";
            this.btnStartJob.Size = new System.Drawing.Size(153, 30);
            this.btnStartJob.TabIndex = 2;
            this.btnStartJob.Text = "开始作业";
            this.btnStartJob.UseVisualStyleBackColor = true;
            this.btnStartJob.Click += new System.EventHandler(this.btnStartJob_Click);
            // 
            // btnClearError
            // 
            this.btnClearError.Location = new System.Drawing.Point(6, 60);
            this.btnClearError.Name = "btnClearError";
            this.btnClearError.Size = new System.Drawing.Size(153, 30);
            this.btnClearError.TabIndex = 1;
            this.btnClearError.Text = "清除错误";
            this.btnClearError.UseVisualStyleBackColor = true;
            this.btnClearError.Click += new System.EventHandler(this.btnClearError_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(153, 30);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "复位(回零)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelZAlarm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panelYAlarm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panelXAlarm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panelZMove);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panelYMove);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panelXMove);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制器状态";
            // 
            // panelZAlarm
            // 
            this.panelZAlarm.Location = new System.Drawing.Point(79, 204);
            this.panelZAlarm.Name = "panelZAlarm";
            this.panelZAlarm.Size = new System.Drawing.Size(30, 30);
            this.panelZAlarm.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Z轴报警";
            // 
            // panelYAlarm
            // 
            this.panelYAlarm.Location = new System.Drawing.Point(79, 168);
            this.panelYAlarm.Name = "panelYAlarm";
            this.panelYAlarm.Size = new System.Drawing.Size(30, 30);
            this.panelYAlarm.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y轴报警";
            // 
            // panelXAlarm
            // 
            this.panelXAlarm.Location = new System.Drawing.Point(79, 132);
            this.panelXAlarm.Name = "panelXAlarm";
            this.panelXAlarm.Size = new System.Drawing.Size(30, 30);
            this.panelXAlarm.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "X轴报警";
            // 
            // panelZMove
            // 
            this.panelZMove.Location = new System.Drawing.Point(79, 96);
            this.panelZMove.Name = "panelZMove";
            this.panelZMove.Size = new System.Drawing.Size(30, 30);
            this.panelZMove.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Z轴运动";
            // 
            // panelYMove
            // 
            this.panelYMove.Location = new System.Drawing.Point(79, 60);
            this.panelYMove.Name = "panelYMove";
            this.panelYMove.Size = new System.Drawing.Size(30, 30);
            this.panelYMove.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y轴运动";
            // 
            // panelXMove
            // 
            this.panelXMove.Location = new System.Drawing.Point(79, 24);
            this.panelXMove.Name = "panelXMove";
            this.panelXMove.Size = new System.Drawing.Size(30, 30);
            this.panelXMove.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X轴运动";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 606);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "雷赛控制卡";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoints)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numManualSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuJob;
        private System.Windows.Forms.DataGridView dgvPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelZMove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelYMove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelXMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelZAlarm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelYAlarm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelXAlarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStopJob;
        private System.Windows.Forms.Button btnStartJob;
        private System.Windows.Forms.Button btnClearError;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numManualSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnZMinus;
        private System.Windows.Forms.Button btnZPlus;
        private System.Windows.Forms.Button btnYMinus;
        private System.Windows.Forms.Button btnYPlus;
        private System.Windows.Forms.Button btnXMinus;
        private System.Windows.Forms.Button btnXPlus;
        private System.Windows.Forms.Button btnMoveX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPosX;
        private System.Windows.Forms.Button btnMoveZ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numPosZ;
        private System.Windows.Forms.Button btnMoveY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPosY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem menuSaveJobs;
        private System.Windows.Forms.ToolStripMenuItem menuLoadJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaitTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEnable;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteJob;
        private System.Windows.Forms.ToolStripMenuItem menuClearJobs;
        private System.Windows.Forms.ToolStripMenuItem menuAddJob;
    }
}

