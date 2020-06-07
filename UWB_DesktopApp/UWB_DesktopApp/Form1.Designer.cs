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
            this.picBoxMain = new System.Windows.Forms.PictureBox();
            this.bt_loadBG = new System.Windows.Forms.Button();
            this.gbMap = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbXScale = new System.Windows.Forms.TextBox();
            this.btScale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYScale = new System.Windows.Forms.TextBox();
            this.labScale = new System.Windows.Forms.Label();
            this.gbBaseSet = new System.Windows.Forms.GroupBox();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btBaseSet = new System.Windows.Forms.Button();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY3 = new System.Windows.Forms.TextBox();
            this.tbX3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).BeginInit();
            this.gbMap.SuspendLayout();
            this.gbBaseSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxMain
            // 
            this.picBoxMain.Location = new System.Drawing.Point(25, 29);
            this.picBoxMain.Name = "picBoxMain";
            this.picBoxMain.Size = new System.Drawing.Size(408, 349);
            this.picBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMain.TabIndex = 0;
            this.picBoxMain.TabStop = false;
            // 
            // bt_loadBG
            // 
            this.bt_loadBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_loadBG.Location = new System.Drawing.Point(225, 21);
            this.bt_loadBG.Name = "bt_loadBG";
            this.bt_loadBG.Size = new System.Drawing.Size(149, 54);
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
            this.gbMap.Location = new System.Drawing.Point(468, 71);
            this.gbMap.Name = "gbMap";
            this.gbMap.Size = new System.Drawing.Size(396, 180);
            this.gbMap.TabIndex = 3;
            this.gbMap.TabStop = false;
            this.gbMap.Text = "地图标定";
            this.gbMap.Enter += new System.EventHandler(this.gbMap_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // tbXScale
            // 
            this.tbXScale.Location = new System.Drawing.Point(48, 98);
            this.tbXScale.Name = "tbXScale";
            this.tbXScale.Size = new System.Drawing.Size(40, 22);
            this.tbXScale.TabIndex = 3;
            this.tbXScale.Text = "10";
            // 
            // btScale
            // 
            this.btScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btScale.Location = new System.Drawing.Point(225, 83);
            this.btScale.Name = "btScale";
            this.btScale.Size = new System.Drawing.Size(149, 54);
            this.btScale.TabIndex = 4;
            this.btScale.Text = "参考点";
            this.btScale.UseVisualStyleBackColor = true;
            this.btScale.Click += new System.EventHandler(this.btScale_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // tbYScale
            // 
            this.tbYScale.Location = new System.Drawing.Point(132, 98);
            this.tbYScale.Name = "tbYScale";
            this.tbYScale.Size = new System.Drawing.Size(40, 22);
            this.tbYScale.TabIndex = 6;
            this.tbYScale.Text = "0";
            // 
            // labScale
            // 
            this.labScale.AutoSize = true;
            this.labScale.Location = new System.Drawing.Point(32, 42);
            this.labScale.Name = "labScale";
            this.labScale.Size = new System.Drawing.Size(56, 16);
            this.labScale.TabIndex = 7;
            this.labScale.Text = "XXXXXX";
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
            this.gbBaseSet.Location = new System.Drawing.Point(468, 275);
            this.gbBaseSet.Name = "gbBaseSet";
            this.gbBaseSet.Size = new System.Drawing.Size(396, 215);
            this.gbBaseSet.TabIndex = 8;
            this.gbBaseSet.TabStop = false;
            this.gbBaseSet.Text = " 基站设置";
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(211, 66);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(51, 22);
            this.tbY1.TabIndex = 6;
            this.tbY1.Text = "13";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y(m)";
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(122, 66);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(50, 22);
            this.tbX1.TabIndex = 3;
            this.tbX1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "X(m)";
            // 
            // btBaseSet
            // 
            this.btBaseSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaseSet.Location = new System.Drawing.Point(278, 117);
            this.btBaseSet.Name = "btBaseSet";
            this.btBaseSet.Size = new System.Drawing.Size(112, 54);
            this.btBaseSet.TabIndex = 1;
            this.btBaseSet.Text = "应用";
            this.btBaseSet.UseVisualStyleBackColor = true;
            this.btBaseSet.Click += new System.EventHandler(this.btBaseSet_Click);
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(211, 106);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(51, 22);
            this.tbY2.TabIndex = 9;
            this.tbY2.Text = "0";
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(122, 106);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(50, 22);
            this.tbX2.TabIndex = 8;
            this.tbX2.Text = "10";
            // 
            // tbY3
            // 
            this.tbY3.Location = new System.Drawing.Point(211, 149);
            this.tbY3.Name = "tbY3";
            this.tbY3.Size = new System.Drawing.Size(51, 22);
            this.tbY3.TabIndex = 11;
            this.tbY3.Text = "13";
            // 
            // tbX3
            // 
            this.tbX3.Location = new System.Drawing.Point(122, 149);
            this.tbX3.Name = "tbX3";
            this.tbX3.Size = new System.Drawing.Size(50, 22);
            this.tbX3.TabIndex = 10;
            this.tbX3.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "基站1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "基站2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "基站3:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1048, 548);
            this.Controls.Add(this.gbBaseSet);
            this.Controls.Add(this.gbMap);
            this.Controls.Add(this.picBoxMain);
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
    }
}

