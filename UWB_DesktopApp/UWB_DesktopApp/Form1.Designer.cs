namespace UWB_DesktopApp
{
    partial class Form1
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
            this.picBoxMain = new System.Windows.Forms.PictureBox();
            this.bt_loadBG = new System.Windows.Forms.Button();
            this.gbMap = new System.Windows.Forms.GroupBox();
            this.labScale = new System.Windows.Forms.Label();
            this.tbYScale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btScale = new System.Windows.Forms.Button();
            this.tbXScale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBaseSet = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbY3 = new System.Windows.Forms.TextBox();
            this.tbX3 = new System.Windows.Forms.TextBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btBaseSet = new System.Windows.Forms.Button();
            this._serialPort = new System.IO.Ports.SerialPort(this.components);
            this.gbSerial = new System.Windows.Forms.GroupBox();
            this.comboSerialPorts = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btOpenSerial = new System.Windows.Forms.Button();
            this.comboStopBits = new System.Windows.Forms.ComboBox();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.comboDataBits = new System.Windows.Forms.ComboBox();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).BeginInit();
            this.gbMap.SuspendLayout();
            this.gbBaseSet.SuspendLayout();
            this.gbSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxMain
            // 
            this.picBoxMain.Location = new System.Drawing.Point(12, 15);
            this.picBoxMain.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxMain.Name = "picBoxMain";
            this.picBoxMain.Size = new System.Drawing.Size(718, 676);
            this.picBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMain.TabIndex = 0;
            this.picBoxMain.TabStop = false;
            // 
            // bt_loadBG
            // 
            this.bt_loadBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_loadBG.Location = new System.Drawing.Point(112, 12);
            this.bt_loadBG.Margin = new System.Windows.Forms.Padding(2);
            this.bt_loadBG.Name = "bt_loadBG";
            this.bt_loadBG.Size = new System.Drawing.Size(74, 28);
            this.bt_loadBG.TabIndex = 1;
            this.bt_loadBG.Text = "原点";
            this.bt_loadBG.UseVisualStyleBackColor = true;
            this.bt_loadBG.Click += new System.EventHandler(this.bt_loadBG_Click);
            // 
            // gbMap
            // 
            this.gbMap.Controls.Add(this.labScale);
            this.gbMap.Controls.Add(this.tbYScale);
            this.gbMap.Controls.Add(this.label2);
            this.gbMap.Controls.Add(this.btScale);
            this.gbMap.Controls.Add(this.tbXScale);
            this.gbMap.Controls.Add(this.label1);
            this.gbMap.Controls.Add(this.bt_loadBG);
            this.gbMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMap.Location = new System.Drawing.Point(774, 37);
            this.gbMap.Margin = new System.Windows.Forms.Padding(2);
            this.gbMap.Name = "gbMap";
            this.gbMap.Padding = new System.Windows.Forms.Padding(2);
            this.gbMap.Size = new System.Drawing.Size(198, 94);
            this.gbMap.TabIndex = 3;
            this.gbMap.TabStop = false;
            this.gbMap.Text = "地图标定";
            this.gbMap.Enter += new System.EventHandler(this.gbMap_Enter);
            // 
            // labScale
            // 
            this.labScale.AutoSize = true;
            this.labScale.Location = new System.Drawing.Point(16, 22);
            this.labScale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labScale.Name = "labScale";
            this.labScale.Size = new System.Drawing.Size(56, 16);
            this.labScale.TabIndex = 7;
            this.labScale.Text = "XXXXXX";
            // 
            // tbYScale
            // 
            this.tbYScale.Location = new System.Drawing.Point(66, 51);
            this.tbYScale.Margin = new System.Windows.Forms.Padding(2);
            this.tbYScale.Name = "tbYScale";
            this.tbYScale.Size = new System.Drawing.Size(22, 22);
            this.tbYScale.TabIndex = 6;
            this.tbYScale.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // btScale
            // 
            this.btScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btScale.Location = new System.Drawing.Point(112, 46);
            this.btScale.Margin = new System.Windows.Forms.Padding(2);
            this.btScale.Name = "btScale";
            this.btScale.Size = new System.Drawing.Size(74, 28);
            this.btScale.TabIndex = 4;
            this.btScale.Text = "参考点";
            this.btScale.UseVisualStyleBackColor = true;
            this.btScale.Click += new System.EventHandler(this.btScale_Click);
            // 
            // tbXScale
            // 
            this.tbXScale.Location = new System.Drawing.Point(24, 51);
            this.tbXScale.Margin = new System.Windows.Forms.Padding(2);
            this.tbXScale.Name = "tbXScale";
            this.tbXScale.Size = new System.Drawing.Size(22, 22);
            this.tbXScale.TabIndex = 3;
            this.tbXScale.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // gbBaseSet
            // 
            this.gbBaseSet.Controls.Add(this.label7);
            this.gbBaseSet.Controls.Add(this.label6);
            this.gbBaseSet.Controls.Add(this.label3);
            this.gbBaseSet.Controls.Add(this.tbY3);
            this.gbBaseSet.Controls.Add(this.tbX3);
            this.gbBaseSet.Controls.Add(this.tbY2);
            this.gbBaseSet.Controls.Add(this.tbX2);
            this.gbBaseSet.Controls.Add(this.tbY1);
            this.gbBaseSet.Controls.Add(this.label4);
            this.gbBaseSet.Controls.Add(this.tbX1);
            this.gbBaseSet.Controls.Add(this.label5);
            this.gbBaseSet.Controls.Add(this.btBaseSet);
            this.gbBaseSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBaseSet.Location = new System.Drawing.Point(774, 143);
            this.gbBaseSet.Margin = new System.Windows.Forms.Padding(2);
            this.gbBaseSet.Name = "gbBaseSet";
            this.gbBaseSet.Padding = new System.Windows.Forms.Padding(2);
            this.gbBaseSet.Size = new System.Drawing.Size(212, 140);
            this.gbBaseSet.TabIndex = 8;
            this.gbBaseSet.TabStop = false;
            this.gbBaseSet.Text = " 基站设置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "基站3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "基站2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "基站1:";
            // 
            // tbY3
            // 
            this.tbY3.Location = new System.Drawing.Point(106, 92);
            this.tbY3.Margin = new System.Windows.Forms.Padding(2);
            this.tbY3.Name = "tbY3";
            this.tbY3.Size = new System.Drawing.Size(28, 22);
            this.tbY3.TabIndex = 11;
            this.tbY3.Text = "13";
            // 
            // tbX3
            // 
            this.tbX3.Location = new System.Drawing.Point(61, 92);
            this.tbX3.Margin = new System.Windows.Forms.Padding(2);
            this.tbX3.Name = "tbX3";
            this.tbX3.Size = new System.Drawing.Size(27, 22);
            this.tbX3.TabIndex = 10;
            this.tbX3.Text = "10";
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(106, 63);
            this.tbY2.Margin = new System.Windows.Forms.Padding(2);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(28, 22);
            this.tbY2.TabIndex = 9;
            this.tbY2.Text = "0";
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(61, 64);
            this.tbX2.Margin = new System.Windows.Forms.Padding(2);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(27, 22);
            this.tbX2.TabIndex = 8;
            this.tbX2.Text = "10";
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(106, 34);
            this.tbY1.Margin = new System.Windows.Forms.Padding(2);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(28, 22);
            this.tbY1.TabIndex = 6;
            this.tbY1.Text = "13";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y(m)";
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(61, 34);
            this.tbX1.Margin = new System.Windows.Forms.Padding(2);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(27, 22);
            this.tbX1.TabIndex = 3;
            this.tbX1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "X(m)";
            // 
            // btBaseSet
            // 
            this.btBaseSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaseSet.Location = new System.Drawing.Point(146, 34);
            this.btBaseSet.Margin = new System.Windows.Forms.Padding(2);
            this.btBaseSet.Name = "btBaseSet";
            this.btBaseSet.Size = new System.Drawing.Size(56, 80);
            this.btBaseSet.TabIndex = 1;
            this.btBaseSet.Text = "应用";
            this.btBaseSet.UseVisualStyleBackColor = true;
            this.btBaseSet.Click += new System.EventHandler(this.btBaseSet_Click);
            // 
            // _serialPort
            // 
            this._serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this._serialPort_DataReceived);
            // 
            // gbSerial
            // 
            this.gbSerial.Controls.Add(this.comboSerialPorts);
            this.gbSerial.Controls.Add(this.label12);
            this.gbSerial.Controls.Add(this.btOpenSerial);
            this.gbSerial.Controls.Add(this.comboStopBits);
            this.gbSerial.Controls.Add(this.comboParity);
            this.gbSerial.Controls.Add(this.comboDataBits);
            this.gbSerial.Controls.Add(this.comboBaudRate);
            this.gbSerial.Controls.Add(this.label11);
            this.gbSerial.Controls.Add(this.label10);
            this.gbSerial.Controls.Add(this.label9);
            this.gbSerial.Controls.Add(this.label8);
            this.gbSerial.Location = new System.Drawing.Point(778, 300);
            this.gbSerial.Name = "gbSerial";
            this.gbSerial.Size = new System.Drawing.Size(198, 175);
            this.gbSerial.TabIndex = 9;
            this.gbSerial.TabStop = false;
            this.gbSerial.Text = "串口设置";
            // 
            // comboSerialPorts
            // 
            this.comboSerialPorts.FormattingEnabled = true;
            this.comboSerialPorts.Location = new System.Drawing.Point(59, 22);
            this.comboSerialPorts.Name = "comboSerialPorts";
            this.comboSerialPorts.Size = new System.Drawing.Size(67, 21);
            this.comboSerialPorts.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "串口号:";
            // 
            // btOpenSerial
            // 
            this.btOpenSerial.BackColor = System.Drawing.Color.Red;
            this.btOpenSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenSerial.ForeColor = System.Drawing.Color.White;
            this.btOpenSerial.Location = new System.Drawing.Point(135, 19);
            this.btOpenSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btOpenSerial.Name = "btOpenSerial";
            this.btOpenSerial.Size = new System.Drawing.Size(56, 131);
            this.btOpenSerial.TabIndex = 10;
            this.btOpenSerial.Text = "打开";
            this.btOpenSerial.UseVisualStyleBackColor = false;
            this.btOpenSerial.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboStopBits
            // 
            this.comboStopBits.FormattingEnabled = true;
            this.comboStopBits.Location = new System.Drawing.Point(57, 129);
            this.comboStopBits.Name = "comboStopBits";
            this.comboStopBits.Size = new System.Drawing.Size(67, 21);
            this.comboStopBits.TabIndex = 20;
            this.comboStopBits.Text = "1";
            // 
            // comboParity
            // 
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Location = new System.Drawing.Point(57, 102);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(67, 21);
            this.comboParity.TabIndex = 19;
            this.comboParity.Text = "None";
            // 
            // comboDataBits
            // 
            this.comboDataBits.FormattingEnabled = true;
            this.comboDataBits.Location = new System.Drawing.Point(57, 75);
            this.comboDataBits.Name = "comboDataBits";
            this.comboDataBits.Size = new System.Drawing.Size(67, 21);
            this.comboDataBits.TabIndex = 18;
            this.comboDataBits.Text = "8";
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Location = new System.Drawing.Point(57, 48);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(67, 21);
            this.comboBaudRate.TabIndex = 17;
            this.comboBaudRate.Text = "9600";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "停止位:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "校验位:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "数据位:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "波特率:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1362, 851);
            this.Controls.Add(this.gbSerial);
            this.Controls.Add(this.gbBaseSet);
            this.Controls.Add(this.gbMap);
            this.Controls.Add(this.picBoxMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UWB_DesktopApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).EndInit();
            this.gbMap.ResumeLayout(false);
            this.gbMap.PerformLayout();
            this.gbBaseSet.ResumeLayout(false);
            this.gbBaseSet.PerformLayout();
            this.gbSerial.ResumeLayout(false);
            this.gbSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxMain;
        private System.Windows.Forms.Button bt_loadBG;
        private System.Windows.Forms.GroupBox gbMap;
        private System.Windows.Forms.TextBox tbYScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btScale;
        private System.Windows.Forms.TextBox tbXScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labScale;
        private System.Windows.Forms.GroupBox gbBaseSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbY3;
        private System.Windows.Forms.TextBox tbX3;
        private System.Windows.Forms.TextBox tbY2;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbY1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btBaseSet;
        private System.IO.Ports.SerialPort _serialPort;
        private System.Windows.Forms.GroupBox gbSerial;
        private System.Windows.Forms.Button btOpenSerial;
        private System.Windows.Forms.ComboBox comboStopBits;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.ComboBox comboDataBits;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboSerialPorts;
        private System.Windows.Forms.Label label12;
    }
}

