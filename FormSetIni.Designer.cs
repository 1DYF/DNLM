namespace 运动控制项目
{
    partial class FormSetIni
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
            this.numEquiv = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numZAxisNo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numYAxisNo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numXAxisNo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnApplyAll = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnReloadConfig = new System.Windows.Forms.Button();
            this.btnWriteToController = new System.Windows.Forms.Button();
            this.btnReadFromController = new System.Windows.Forms.Button();
            this.cbbAxisName = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numHomeOffset = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.numHomeDecTime = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numHomeAccTime = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numHomeHighVel = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numHomeLowVel = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numHomeMode = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numDecTime = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numAccTime = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numStopVel = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numStartVel = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkSoftLimit = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numNegLimit = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numPosLimit = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.numMaxVel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numEquiv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZAxisNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYAxisNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXAxisNo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeDecTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeAccTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeHighVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeLowVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeMode)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartVel)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNegLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVel)).BeginInit();
            this.SuspendLayout();
            // 
            // numEquiv
            // 
            this.numEquiv.Location = new System.Drawing.Point(79, 35);
            this.numEquiv.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numEquiv.Name = "numEquiv";
            this.numEquiv.Size = new System.Drawing.Size(120, 25);
            this.numEquiv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "轴名称";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制器配置";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(68, 24);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(146, 25);
            this.txtIp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP地址";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numZAxisNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numYAxisNo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numXAxisNo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 201);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "轴号配置";
            // 
            // numZAxisNo
            // 
            this.numZAxisNo.Location = new System.Drawing.Point(68, 135);
            this.numZAxisNo.Name = "numZAxisNo";
            this.numZAxisNo.Size = new System.Drawing.Size(120, 25);
            this.numZAxisNo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Z轴号";
            // 
            // numYAxisNo
            // 
            this.numYAxisNo.Location = new System.Drawing.Point(68, 84);
            this.numYAxisNo.Name = "numYAxisNo";
            this.numYAxisNo.Size = new System.Drawing.Size(120, 25);
            this.numYAxisNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y轴号";
            // 
            // numXAxisNo
            // 
            this.numXAxisNo.Location = new System.Drawing.Point(68, 35);
            this.numXAxisNo.Name = "numXAxisNo";
            this.numXAxisNo.Size = new System.Drawing.Size(120, 25);
            this.numXAxisNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "X轴号";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnApplyAll);
            this.groupBox3.Controls.Add(this.btnSaveConfig);
            this.groupBox3.Controls.Add(this.btnReloadConfig);
            this.groupBox3.Controls.Add(this.btnWriteToController);
            this.groupBox3.Controls.Add(this.btnReadFromController);
            this.groupBox3.Controls.Add(this.cbbAxisName);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(245, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 404);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "轴参数配置";
            // 
            // btnApplyAll
            // 
            this.btnApplyAll.Location = new System.Drawing.Point(418, 51);
            this.btnApplyAll.Name = "btnApplyAll";
            this.btnApplyAll.Size = new System.Drawing.Size(146, 23);
            this.btnApplyAll.TabIndex = 13;
            this.btnApplyAll.Text = "应用到所有轴";
            this.btnApplyAll.UseVisualStyleBackColor = true;
            this.btnApplyAll.Click += new System.EventHandler(this.btnApplyAll_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(266, 51);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(146, 23);
            this.btnSaveConfig.TabIndex = 12;
            this.btnSaveConfig.Text = "写入配置文件";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnReloadConfig
            // 
            this.btnReloadConfig.Location = new System.Drawing.Point(570, 22);
            this.btnReloadConfig.Name = "btnReloadConfig";
            this.btnReloadConfig.Size = new System.Drawing.Size(146, 23);
            this.btnReloadConfig.TabIndex = 11;
            this.btnReloadConfig.Text = "重载配置文件";
            this.btnReloadConfig.UseVisualStyleBackColor = true;
            this.btnReloadConfig.Click += new System.EventHandler(this.btnReloadConfig_Click);
            // 
            // btnWriteToController
            // 
            this.btnWriteToController.Location = new System.Drawing.Point(418, 22);
            this.btnWriteToController.Name = "btnWriteToController";
            this.btnWriteToController.Size = new System.Drawing.Size(146, 23);
            this.btnWriteToController.TabIndex = 10;
            this.btnWriteToController.Text = "写入控制器配置";
            this.btnWriteToController.UseVisualStyleBackColor = true;
            this.btnWriteToController.Click += new System.EventHandler(this.btnWriteToController_Click);
            // 
            // btnReadFromController
            // 
            this.btnReadFromController.Location = new System.Drawing.Point(266, 22);
            this.btnReadFromController.Name = "btnReadFromController";
            this.btnReadFromController.Size = new System.Drawing.Size(146, 23);
            this.btnReadFromController.TabIndex = 9;
            this.btnReadFromController.Text = "读取控制器配置";
            this.btnReadFromController.UseVisualStyleBackColor = true;
            this.btnReadFromController.Click += new System.EventHandler(this.btnReadFromController_Click);
            // 
            // cbbAxisName
            // 
            this.cbbAxisName.FormattingEnabled = true;
            this.cbbAxisName.Location = new System.Drawing.Point(70, 23);
            this.cbbAxisName.Name = "cbbAxisName";
            this.cbbAxisName.Size = new System.Drawing.Size(172, 23);
            this.cbbAxisName.TabIndex = 8;
            this.cbbAxisName.SelectedIndexChanged += new System.EventHandler(this.cbbAxisName_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.numHomeOffset);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.numHomeDecTime);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.numHomeAccTime);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.numHomeHighVel);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.numHomeLowVel);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.numHomeMode);
            this.groupBox6.Location = new System.Drawing.Point(510, 94);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(224, 298);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "回零配置";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 25;
            this.label17.Text = "回零偏移";
            // 
            // numHomeOffset
            // 
            this.numHomeOffset.Location = new System.Drawing.Point(87, 259);
            this.numHomeOffset.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numHomeOffset.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numHomeOffset.Name = "numHomeOffset";
            this.numHomeOffset.Size = new System.Drawing.Size(120, 25);
            this.numHomeOffset.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 23;
            this.label18.Text = "减速时间";
            // 
            // numHomeDecTime
            // 
            this.numHomeDecTime.DecimalPlaces = 3;
            this.numHomeDecTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numHomeDecTime.Location = new System.Drawing.Point(87, 215);
            this.numHomeDecTime.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numHomeDecTime.Name = "numHomeDecTime";
            this.numHomeDecTime.Size = new System.Drawing.Size(120, 25);
            this.numHomeDecTime.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "加速时间";
            // 
            // numHomeAccTime
            // 
            this.numHomeAccTime.DecimalPlaces = 3;
            this.numHomeAccTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numHomeAccTime.Location = new System.Drawing.Point(87, 171);
            this.numHomeAccTime.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numHomeAccTime.Name = "numHomeAccTime";
            this.numHomeAccTime.Size = new System.Drawing.Size(120, 25);
            this.numHomeAccTime.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "回零高速";
            // 
            // numHomeHighVel
            // 
            this.numHomeHighVel.Location = new System.Drawing.Point(87, 127);
            this.numHomeHighVel.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numHomeHighVel.Name = "numHomeHighVel";
            this.numHomeHighVel.Size = new System.Drawing.Size(120, 25);
            this.numHomeHighVel.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "回零低速";
            // 
            // numHomeLowVel
            // 
            this.numHomeLowVel.Location = new System.Drawing.Point(87, 79);
            this.numHomeLowVel.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numHomeLowVel.Name = "numHomeLowVel";
            this.numHomeLowVel.Size = new System.Drawing.Size(120, 25);
            this.numHomeLowVel.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 15;
            this.label16.Text = "回零模式";
            // 
            // numHomeMode
            // 
            this.numHomeMode.Location = new System.Drawing.Point(87, 35);
            this.numHomeMode.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numHomeMode.Name = "numHomeMode";
            this.numHomeMode.Size = new System.Drawing.Size(120, 25);
            this.numHomeMode.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.numMaxVel);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.numDecTime);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.numAccTime);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.numStopVel);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.numStartVel);
            this.groupBox5.Location = new System.Drawing.Point(264, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 298);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "运动速度曲线";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "减速时间";
            // 
            // numDecTime
            // 
            this.numDecTime.DecimalPlaces = 3;
            this.numDecTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numDecTime.Location = new System.Drawing.Point(91, 219);
            this.numDecTime.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDecTime.Name = "numDecTime";
            this.numDecTime.Size = new System.Drawing.Size(120, 25);
            this.numDecTime.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "加速时间";
            // 
            // numAccTime
            // 
            this.numAccTime.DecimalPlaces = 3;
            this.numAccTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numAccTime.Location = new System.Drawing.Point(91, 175);
            this.numAccTime.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAccTime.Name = "numAccTime";
            this.numAccTime.Size = new System.Drawing.Size(120, 25);
            this.numAccTime.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "停止速度";
            // 
            // numStopVel
            // 
            this.numStopVel.DecimalPlaces = 2;
            this.numStopVel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numStopVel.Location = new System.Drawing.Point(91, 127);
            this.numStopVel.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numStopVel.Name = "numStopVel";
            this.numStopVel.Size = new System.Drawing.Size(120, 25);
            this.numStopVel.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "起始速度";
            // 
            // numStartVel
            // 
            this.numStartVel.DecimalPlaces = 2;
            this.numStartVel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numStartVel.Location = new System.Drawing.Point(91, 35);
            this.numStartVel.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numStartVel.Name = "numStartVel";
            this.numStartVel.Size = new System.Drawing.Size(120, 25);
            this.numStartVel.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkSoftLimit);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numNegLimit);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numPosLimit);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.numEquiv);
            this.groupBox4.Location = new System.Drawing.Point(15, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 201);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "轴配置";
            // 
            // chkSoftLimit
            // 
            this.chkSoftLimit.AutoSize = true;
            this.chkSoftLimit.Location = new System.Drawing.Point(79, 79);
            this.chkSoftLimit.Name = "chkSoftLimit";
            this.chkSoftLimit.Size = new System.Drawing.Size(18, 17);
            this.chkSoftLimit.TabIndex = 7;
            this.chkSoftLimit.UseVisualStyleBackColor = true;
            this.chkSoftLimit.CheckedChanged += new System.EventHandler(this.chkSoftLimit_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 15);
            this.label19.TabIndex = 6;
            this.label19.Text = "软限位";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "负限位";
            // 
            // numNegLimit
            // 
            this.numNegLimit.Location = new System.Drawing.Point(79, 152);
            this.numNegLimit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numNegLimit.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numNegLimit.Name = "numNegLimit";
            this.numNegLimit.Size = new System.Drawing.Size(120, 25);
            this.numNegLimit.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "正限位";
            // 
            // numPosLimit
            // 
            this.numPosLimit.Location = new System.Drawing.Point(79, 108);
            this.numPosLimit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPosLimit.Name = "numPosLimit";
            this.numPosLimit.Size = new System.Drawing.Size(120, 25);
            this.numPosLimit.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "脉冲当量";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 15;
            this.label20.Text = "最大速度";
            // 
            // numMaxVel
            // 
            this.numMaxVel.DecimalPlaces = 2;
            this.numMaxVel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numMaxVel.Location = new System.Drawing.Point(91, 84);
            this.numMaxVel.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numMaxVel.Name = "numMaxVel";
            this.numMaxVel.Size = new System.Drawing.Size(120, 25);
            this.numMaxVel.TabIndex = 14;
            // 
            // FormSetIni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 424);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSetIni";
            this.Text = "参数设置";
            this.Load += new System.EventHandler(this.FormSetIni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEquiv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZAxisNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYAxisNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXAxisNo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeDecTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeAccTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeHighVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeLowVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeMode)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartVel)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNegLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numEquiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numZAxisNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numYAxisNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numXAxisNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbbAxisName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numHomeOffset;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numHomeDecTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numHomeAccTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numHomeHighVel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numHomeLowVel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numHomeMode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numDecTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numAccTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numStopVel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numStartVel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numNegLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numPosLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApplyAll;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnReloadConfig;
        private System.Windows.Forms.Button btnWriteToController;
        private System.Windows.Forms.Button btnReadFromController;
        private System.Windows.Forms.CheckBox chkSoftLimit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numMaxVel;
    }
}