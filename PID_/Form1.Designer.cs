namespace PID_
{
    partial class PID_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PID_form));
            this.comPortControlPanel = new System.Windows.Forms.Panel();
            this.baudrateSelect = new System.Windows.Forms.Label();
            this.comSelectLabbel = new System.Windows.Forms.Label();
            this.bauratCbBox = new System.Windows.Forms.ComboBox();
            this.cbComSelect = new System.Windows.Forms.ComboBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.connectStateLabel = new System.Windows.Forms.Label();
            this.motorSetupLabel = new System.Windows.Forms.Panel();
            this.sendController = new System.Windows.Forms.Button();
            this.motorPannel = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maxSpeedLb = new System.Windows.Forms.Label();
            this.encoderLb = new System.Windows.Forms.Label();
            this.motorSp = new System.Windows.Forms.Label();
            this.controllerPannel = new System.Windows.Forms.Panel();
            this.kdTb = new System.Windows.Forms.TextBox();
            this.kiTb = new System.Windows.Forms.TextBox();
            this.kpTb = new System.Windows.Forms.TextBox();
            this.kdLb = new System.Windows.Forms.Label();
            this.kiLb = new System.Windows.Forms.Label();
            this.controllerLabel = new System.Windows.Forms.Label();
            this.kpLb = new System.Windows.Forms.Label();
            this.motorAppear = new System.Windows.Forms.Label();
            this.livePannel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.comPortControlPanel.SuspendLayout();
            this.motorSetupLabel.SuspendLayout();
            this.motorPannel.SuspendLayout();
            this.controllerPannel.SuspendLayout();
            this.livePannel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comPortControlPanel
            // 
            this.comPortControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comPortControlPanel.Controls.Add(this.baudrateSelect);
            this.comPortControlPanel.Controls.Add(this.comSelectLabbel);
            this.comPortControlPanel.Controls.Add(this.bauratCbBox);
            this.comPortControlPanel.Controls.Add(this.cbComSelect);
            this.comPortControlPanel.Controls.Add(this.disconnectButton);
            this.comPortControlPanel.Controls.Add(this.connectButton);
            this.comPortControlPanel.Controls.Add(this.connectStateLabel);
            this.comPortControlPanel.Location = new System.Drawing.Point(1049, 29);
            this.comPortControlPanel.Name = "comPortControlPanel";
            this.comPortControlPanel.Size = new System.Drawing.Size(247, 238);
            this.comPortControlPanel.TabIndex = 2;
            // 
            // baudrateSelect
            // 
            this.baudrateSelect.AutoSize = true;
            this.baudrateSelect.BackColor = System.Drawing.Color.White;
            this.baudrateSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baudrateSelect.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudrateSelect.Location = new System.Drawing.Point(23, 183);
            this.baudrateSelect.Name = "baudrateSelect";
            this.baudrateSelect.Size = new System.Drawing.Size(71, 21);
            this.baudrateSelect.TabIndex = 11;
            this.baudrateSelect.Text = "Baudrate";
            // 
            // comSelectLabbel
            // 
            this.comSelectLabbel.AutoSize = true;
            this.comSelectLabbel.BackColor = System.Drawing.Color.White;
            this.comSelectLabbel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comSelectLabbel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comSelectLabbel.Location = new System.Drawing.Point(23, 152);
            this.comSelectLabbel.Name = "comSelectLabbel";
            this.comSelectLabbel.Size = new System.Drawing.Size(87, 21);
            this.comSelectLabbel.TabIndex = 10;
            this.comSelectLabbel.Text = "Chọn Cổng";
            // 
            // bauratCbBox
            // 
            this.bauratCbBox.FormattingEnabled = true;
            this.bauratCbBox.Location = new System.Drawing.Point(126, 182);
            this.bauratCbBox.Name = "bauratCbBox";
            this.bauratCbBox.Size = new System.Drawing.Size(93, 24);
            this.bauratCbBox.TabIndex = 9;
            // 
            // cbComSelect
            // 
            this.cbComSelect.DisplayMember = "(none)";
            this.cbComSelect.FormattingEnabled = true;
            this.cbComSelect.Location = new System.Drawing.Point(126, 152);
            this.cbComSelect.Name = "cbComSelect";
            this.cbComSelect.Size = new System.Drawing.Size(93, 24);
            this.cbComSelect.TabIndex = 8;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(126, 74);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(106, 52);
            this.disconnectButton.TabIndex = 7;
            this.disconnectButton.Text = "Ngắt kết nối";
            this.disconnectButton.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(14, 74);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(96, 52);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Kết nối";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectStateLabel
            // 
            this.connectStateLabel.AutoSize = true;
            this.connectStateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectStateLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectStateLabel.ForeColor = System.Drawing.Color.Red;
            this.connectStateLabel.Location = new System.Drawing.Point(37, 13);
            this.connectStateLabel.Name = "connectStateLabel";
            this.connectStateLabel.Size = new System.Drawing.Size(163, 27);
            this.connectStateLabel.TabIndex = 0;
            this.connectStateLabel.Text = "Không có kết nối";
            // 
            // motorSetupLabel
            // 
            this.motorSetupLabel.Controls.Add(this.sendController);
            this.motorSetupLabel.Controls.Add(this.motorPannel);
            this.motorSetupLabel.Controls.Add(this.controllerPannel);
            this.motorSetupLabel.Controls.Add(this.motorAppear);
            this.motorSetupLabel.Location = new System.Drawing.Point(91, 29);
            this.motorSetupLabel.Name = "motorSetupLabel";
            this.motorSetupLabel.Size = new System.Drawing.Size(499, 435);
            this.motorSetupLabel.TabIndex = 3;
            // 
            // sendController
            // 
            this.sendController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(176)))), ((int)(((byte)(155)))));
            this.sendController.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendController.Location = new System.Drawing.Point(140, 336);
            this.sendController.Name = "sendController";
            this.sendController.Size = new System.Drawing.Size(213, 96);
            this.sendController.TabIndex = 6;
            this.sendController.Text = "Gửi thông số đi";
            this.sendController.UseVisualStyleBackColor = false;
            this.sendController.Click += new System.EventHandler(this.sendController_Click);
            // 
            // motorPannel
            // 
            this.motorPannel.Controls.Add(this.textBox5);
            this.motorPannel.Controls.Add(this.textBox4);
            this.motorPannel.Controls.Add(this.maxSpeedLb);
            this.motorPannel.Controls.Add(this.encoderLb);
            this.motorPannel.Controls.Add(this.motorSp);
            this.motorPannel.Location = new System.Drawing.Point(277, 91);
            this.motorPannel.Name = "motorPannel";
            this.motorPannel.Size = new System.Drawing.Size(200, 231);
            this.motorPannel.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(22, 178);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 30);
            this.textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(22, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 30);
            this.textBox4.TabIndex = 7;
            // 
            // maxSpeedLb
            // 
            this.maxSpeedLb.AutoSize = true;
            this.maxSpeedLb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxSpeedLb.Location = new System.Drawing.Point(3, 153);
            this.maxSpeedLb.Name = "maxSpeedLb";
            this.maxSpeedLb.Size = new System.Drawing.Size(122, 22);
            this.maxSpeedLb.TabIndex = 6;
            this.maxSpeedLb.Text = "Tốc độ tối đa:";
            // 
            // encoderLb
            // 
            this.encoderLb.AutoSize = true;
            this.encoderLb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encoderLb.Location = new System.Drawing.Point(3, 81);
            this.encoderLb.Name = "encoderLb";
            this.encoderLb.Size = new System.Drawing.Size(145, 22);
            this.encoderLb.TabIndex = 5;
            this.encoderLb.Text = "xung/vòng(PPR):";
            // 
            // motorSp
            // 
            this.motorSp.AutoSize = true;
            this.motorSp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(212)))), ((int)(((byte)(184)))));
            this.motorSp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorSp.Location = new System.Drawing.Point(64, 31);
            this.motorSp.Name = "motorSp";
            this.motorSp.Size = new System.Drawing.Size(77, 22);
            this.motorSp.TabIndex = 4;
            this.motorSp.Text = "Động cơ";
            // 
            // controllerPannel
            // 
            this.controllerPannel.Controls.Add(this.kdTb);
            this.controllerPannel.Controls.Add(this.kiTb);
            this.controllerPannel.Controls.Add(this.kpTb);
            this.controllerPannel.Controls.Add(this.kdLb);
            this.controllerPannel.Controls.Add(this.kiLb);
            this.controllerPannel.Controls.Add(this.controllerLabel);
            this.controllerPannel.Controls.Add(this.kpLb);
            this.controllerPannel.Location = new System.Drawing.Point(32, 91);
            this.controllerPannel.Name = "controllerPannel";
            this.controllerPannel.Size = new System.Drawing.Size(200, 231);
            this.controllerPannel.TabIndex = 1;
            // 
            // kdTb
            // 
            this.kdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kdTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kdTb.Location = new System.Drawing.Point(57, 167);
            this.kdTb.Name = "kdTb";
            this.kdTb.Size = new System.Drawing.Size(103, 30);
            this.kdTb.TabIndex = 6;
            // 
            // kiTb
            // 
            this.kiTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kiTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiTb.Location = new System.Drawing.Point(57, 123);
            this.kiTb.Name = "kiTb";
            this.kiTb.Size = new System.Drawing.Size(103, 30);
            this.kiTb.TabIndex = 5;
            // 
            // kpTb
            // 
            this.kpTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kpTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kpTb.Location = new System.Drawing.Point(57, 78);
            this.kpTb.Name = "kpTb";
            this.kpTb.Size = new System.Drawing.Size(103, 30);
            this.kpTb.TabIndex = 4;
            // 
            // kdLb
            // 
            this.kdLb.AutoSize = true;
            this.kdLb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kdLb.Location = new System.Drawing.Point(17, 167);
            this.kdLb.Name = "kdLb";
            this.kdLb.Size = new System.Drawing.Size(34, 22);
            this.kdLb.TabIndex = 3;
            this.kdLb.Text = "Kd";
            // 
            // kiLb
            // 
            this.kiLb.AutoSize = true;
            this.kiLb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiLb.Location = new System.Drawing.Point(17, 123);
            this.kiLb.Name = "kiLb";
            this.kiLb.Size = new System.Drawing.Size(30, 22);
            this.kiLb.TabIndex = 2;
            this.kiLb.Text = "Ki";
            // 
            // controllerLabel
            // 
            this.controllerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(212)))), ((int)(((byte)(184)))));
            this.controllerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controllerLabel.Location = new System.Drawing.Point(34, 9);
            this.controllerLabel.Name = "controllerLabel";
            this.controllerLabel.Size = new System.Drawing.Size(148, 44);
            this.controllerLabel.TabIndex = 0;
            this.controllerLabel.Text = "Lựa chọn thông số bộ điều khiển";
            this.controllerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.controllerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // kpLb
            // 
            this.kpLb.AutoSize = true;
            this.kpLb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kpLb.Location = new System.Drawing.Point(17, 79);
            this.kpLb.Name = "kpLb";
            this.kpLb.Size = new System.Drawing.Size(34, 22);
            this.kpLb.TabIndex = 1;
            this.kpLb.Text = "Kp";
            // 
            // motorAppear
            // 
            this.motorAppear.AutoSize = true;
            this.motorAppear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            this.motorAppear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motorAppear.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorAppear.Location = new System.Drawing.Point(106, 28);
            this.motorAppear.Name = "motorAppear";
            this.motorAppear.Size = new System.Drawing.Size(284, 31);
            this.motorAppear.TabIndex = 0;
            this.motorAppear.Text = "Chỉnh sửa thông số cơ bản";
            // 
            // livePannel
            // 
            this.livePannel.Controls.Add(this.panel2);
            this.livePannel.Controls.Add(this.label8);
            this.livePannel.Location = new System.Drawing.Point(694, 29);
            this.livePannel.Name = "livePannel";
            this.livePannel.Size = new System.Drawing.Size(264, 435);
            this.livePannel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(26, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 316);
            this.panel2.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(22, 194);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(138, 30);
            this.textBox8.TabIndex = 10;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tốc độ đặt (sp):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(25, 273);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(138, 30);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(22, 115);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(138, 30);
            this.textBox7.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tốc độ hiện tại (pv):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xung/chu kỳ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(212)))), ((int)(((byte)(184)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Động cơ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(211)))), ((int)(((byte)(218)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Các giá trị hiện tại";
            // 
            // serialPort
            // 
            this.serialPort.WriteBufferSize = 2096;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(176)))), ((int)(((byte)(155)))));
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1064, 340);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(213, 96);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PID_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 613);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.livePannel);
            this.Controls.Add(this.motorSetupLabel);
            this.Controls.Add(this.comPortControlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PID_form";
            this.Text = "PID_";
            this.Load += new System.EventHandler(this.PID_form_Load);
            this.comPortControlPanel.ResumeLayout(false);
            this.comPortControlPanel.PerformLayout();
            this.motorSetupLabel.ResumeLayout(false);
            this.motorSetupLabel.PerformLayout();
            this.motorPannel.ResumeLayout(false);
            this.motorPannel.PerformLayout();
            this.controllerPannel.ResumeLayout(false);
            this.controllerPannel.PerformLayout();
            this.livePannel.ResumeLayout(false);
            this.livePannel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel comPortControlPanel;
        private System.Windows.Forms.Label baudrateSelect;
        private System.Windows.Forms.Label comSelectLabbel;
        private System.Windows.Forms.ComboBox bauratCbBox;
        private System.Windows.Forms.ComboBox cbComSelect;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label connectStateLabel;
        private System.Windows.Forms.Panel motorSetupLabel;
        private System.Windows.Forms.Panel motorPannel;
        private System.Windows.Forms.Panel controllerPannel;
        private System.Windows.Forms.Label kpLb;
        private System.Windows.Forms.Label controllerLabel;
        private System.Windows.Forms.Label motorAppear;
        private System.Windows.Forms.Label maxSpeedLb;
        private System.Windows.Forms.Label encoderLb;
        private System.Windows.Forms.Label motorSp;
        private System.Windows.Forms.Label kdLb;
        private System.Windows.Forms.Label kiLb;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox kdTb;
        private System.Windows.Forms.TextBox kiTb;
        private System.Windows.Forms.TextBox kpTb;
        private System.Windows.Forms.Panel livePannel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button sendController;
    }
}

