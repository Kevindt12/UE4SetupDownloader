namespace UE4SetupInstaler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBMac = new System.Windows.Forms.CheckBox();
            this.CBVS2015 = new System.Windows.Forms.CheckBox();
            this.CBVS2013 = new System.Windows.Forms.CheckBox();
            this.CBVS2012 = new System.Windows.Forms.CheckBox();
            this.CBOSX64 = new System.Windows.Forms.CheckBox();
            this.CBOSX32 = new System.Windows.Forms.CheckBox();
            this.CBWinRT = new System.Windows.Forms.CheckBox();
            this.CBAndriod = new System.Windows.Forms.CheckBox();
            this.CBHTML5 = new System.Windows.Forms.CheckBox();
            this.CBLinux32 = new System.Windows.Forms.CheckBox();
            this.CBLinux64 = new System.Windows.Forms.CheckBox();
            this.CBIOS = new System.Windows.Forms.CheckBox();
            this.BtnPath = new System.Windows.Forms.Button();
            this.BtnRun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBMac);
            this.groupBox1.Controls.Add(this.CBVS2015);
            this.groupBox1.Controls.Add(this.CBVS2013);
            this.groupBox1.Controls.Add(this.CBVS2012);
            this.groupBox1.Controls.Add(this.CBOSX64);
            this.groupBox1.Controls.Add(this.CBOSX32);
            this.groupBox1.Controls.Add(this.CBWinRT);
            this.groupBox1.Controls.Add(this.CBAndriod);
            this.groupBox1.Controls.Add(this.CBHTML5);
            this.groupBox1.Controls.Add(this.CBLinux32);
            this.groupBox1.Controls.Add(this.CBLinux64);
            this.groupBox1.Controls.Add(this.CBIOS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select wat you want";
            // 
            // CBMac
            // 
            this.CBMac.AutoSize = true;
            this.CBMac.Location = new System.Drawing.Point(5, 285);
            this.CBMac.Name = "CBMac";
            this.CBMac.Size = new System.Drawing.Size(47, 17);
            this.CBMac.TabIndex = 11;
            this.CBMac.Text = "Mac";
            this.CBMac.UseVisualStyleBackColor = true;
            this.CBMac.CheckedChanged += new System.EventHandler(this.CBMac_CheckedChanged);
            // 
            // CBVS2015
            // 
            this.CBVS2015.AutoSize = true;
            this.CBVS2015.Location = new System.Drawing.Point(6, 262);
            this.CBVS2015.Name = "CBVS2015";
            this.CBVS2015.Size = new System.Drawing.Size(64, 17);
            this.CBVS2015.TabIndex = 10;
            this.CBVS2015.Text = "VS2015";
            this.CBVS2015.UseVisualStyleBackColor = true;
            this.CBVS2015.CheckedChanged += new System.EventHandler(this.CBVS2015_CheckedChanged);
            // 
            // CBVS2013
            // 
            this.CBVS2013.AutoSize = true;
            this.CBVS2013.Checked = true;
            this.CBVS2013.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBVS2013.Location = new System.Drawing.Point(6, 239);
            this.CBVS2013.Name = "CBVS2013";
            this.CBVS2013.Size = new System.Drawing.Size(64, 17);
            this.CBVS2013.TabIndex = 9;
            this.CBVS2013.Text = "VS2013";
            this.CBVS2013.UseVisualStyleBackColor = true;
            this.CBVS2013.CheckedChanged += new System.EventHandler(this.CBVS2013_CheckedChanged);
            // 
            // CBVS2012
            // 
            this.CBVS2012.AutoSize = true;
            this.CBVS2012.Checked = true;
            this.CBVS2012.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBVS2012.Location = new System.Drawing.Point(6, 216);
            this.CBVS2012.Name = "CBVS2012";
            this.CBVS2012.Size = new System.Drawing.Size(64, 17);
            this.CBVS2012.TabIndex = 8;
            this.CBVS2012.Text = "VS2012";
            this.CBVS2012.UseVisualStyleBackColor = true;
            this.CBVS2012.CheckedChanged += new System.EventHandler(this.CBVS2012_CheckedChanged);
            // 
            // CBOSX64
            // 
            this.CBOSX64.AutoSize = true;
            this.CBOSX64.Location = new System.Drawing.Point(6, 193);
            this.CBOSX64.Name = "CBOSX64";
            this.CBOSX64.Size = new System.Drawing.Size(60, 17);
            this.CBOSX64.TabIndex = 7;
            this.CBOSX64.Text = "OSX64";
            this.CBOSX64.UseVisualStyleBackColor = true;
            this.CBOSX64.CheckedChanged += new System.EventHandler(this.CBOSX64_CheckedChanged);
            // 
            // CBOSX32
            // 
            this.CBOSX32.AutoSize = true;
            this.CBOSX32.Location = new System.Drawing.Point(6, 170);
            this.CBOSX32.Name = "CBOSX32";
            this.CBOSX32.Size = new System.Drawing.Size(60, 17);
            this.CBOSX32.TabIndex = 6;
            this.CBOSX32.Text = "OSX32";
            this.CBOSX32.UseVisualStyleBackColor = true;
            this.CBOSX32.CheckedChanged += new System.EventHandler(this.CBOSX32_CheckedChanged);
            // 
            // CBWinRT
            // 
            this.CBWinRT.AutoSize = true;
            this.CBWinRT.Location = new System.Drawing.Point(6, 147);
            this.CBWinRT.Name = "CBWinRT";
            this.CBWinRT.Size = new System.Drawing.Size(88, 17);
            this.CBWinRT.TabIndex = 5;
            this.CBWinRT.Text = "Windows RT";
            this.CBWinRT.UseVisualStyleBackColor = true;
            this.CBWinRT.CheckedChanged += new System.EventHandler(this.CBWinRT_CheckedChanged);
            // 
            // CBAndriod
            // 
            this.CBAndriod.AutoSize = true;
            this.CBAndriod.Location = new System.Drawing.Point(6, 124);
            this.CBAndriod.Name = "CBAndriod";
            this.CBAndriod.Size = new System.Drawing.Size(62, 17);
            this.CBAndriod.TabIndex = 4;
            this.CBAndriod.Text = "Android";
            this.CBAndriod.UseVisualStyleBackColor = true;
            this.CBAndriod.CheckedChanged += new System.EventHandler(this.CBAndriod_CheckedChanged);
            // 
            // CBHTML5
            // 
            this.CBHTML5.AutoSize = true;
            this.CBHTML5.Location = new System.Drawing.Point(6, 101);
            this.CBHTML5.Name = "CBHTML5";
            this.CBHTML5.Size = new System.Drawing.Size(62, 17);
            this.CBHTML5.TabIndex = 3;
            this.CBHTML5.Text = "HTML5";
            this.CBHTML5.UseVisualStyleBackColor = true;
            this.CBHTML5.CheckedChanged += new System.EventHandler(this.CBHTML5_CheckedChanged);
            // 
            // CBLinux32
            // 
            this.CBLinux32.AutoSize = true;
            this.CBLinux32.Checked = true;
            this.CBLinux32.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBLinux32.Location = new System.Drawing.Point(6, 78);
            this.CBLinux32.Name = "CBLinux32";
            this.CBLinux32.Size = new System.Drawing.Size(63, 17);
            this.CBLinux32.TabIndex = 2;
            this.CBLinux32.Text = "Linux32";
            this.CBLinux32.UseVisualStyleBackColor = true;
            this.CBLinux32.CheckedChanged += new System.EventHandler(this.CBLinux32_CheckedChanged);
            // 
            // CBLinux64
            // 
            this.CBLinux64.AutoSize = true;
            this.CBLinux64.Location = new System.Drawing.Point(6, 55);
            this.CBLinux64.Name = "CBLinux64";
            this.CBLinux64.Size = new System.Drawing.Size(63, 17);
            this.CBLinux64.TabIndex = 1;
            this.CBLinux64.Text = "Linux64";
            this.CBLinux64.UseVisualStyleBackColor = true;
            this.CBLinux64.CheckedChanged += new System.EventHandler(this.CBLinux64_CheckedChanged);
            // 
            // CBIOS
            // 
            this.CBIOS.AutoSize = true;
            this.CBIOS.Location = new System.Drawing.Point(6, 32);
            this.CBIOS.Name = "CBIOS";
            this.CBIOS.Size = new System.Drawing.Size(44, 17);
            this.CBIOS.TabIndex = 0;
            this.CBIOS.Text = "IOS";
            this.CBIOS.UseVisualStyleBackColor = true;
            this.CBIOS.CheckedChanged += new System.EventHandler(this.CBIOS_CheckedChanged);
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(12, 328);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(75, 23);
            this.BtnPath.TabIndex = 2;
            this.BtnPath.Text = "Path";
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // BtnRun
            // 
            this.BtnRun.Enabled = false;
            this.BtnRun.Location = new System.Drawing.Point(102, 329);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 3;
            this.BtnRun.Text = "Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 351);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.BtnPath);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(215, 390);
            this.MinimumSize = new System.Drawing.Size(215, 390);
            this.Name = "Form1";
            this.Text = "Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.CheckBox CBVS2015;
        private System.Windows.Forms.CheckBox CBVS2013;
        private System.Windows.Forms.CheckBox CBVS2012;
        private System.Windows.Forms.CheckBox CBOSX64;
        private System.Windows.Forms.CheckBox CBOSX32;
        private System.Windows.Forms.CheckBox CBWinRT;
        private System.Windows.Forms.CheckBox CBAndriod;
        private System.Windows.Forms.CheckBox CBHTML5;
        private System.Windows.Forms.CheckBox CBLinux32;
        private System.Windows.Forms.CheckBox CBLinux64;
        private System.Windows.Forms.CheckBox CBIOS;
        private System.Windows.Forms.CheckBox CBMac;
    }
}

