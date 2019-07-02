namespace Primavera.PlatformSamples.UserInterface
{
    partial class frmLogging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogging));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.grbTest = new System.Windows.Forms.GroupBox();
            this.linkClear = new System.Windows.Forms.LinkLabel();
            this.linkDeactivate = new System.Windows.Forms.LinkLabel();
            this.btTraceVerbosed = new System.Windows.Forms.Button();
            this.btTraceThrow = new System.Windows.Forms.Button();
            this.btTraceIgnored = new System.Windows.Forms.Button();
            this.btLog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLogType = new System.Windows.Forms.ComboBox();
            this.linkActivate = new System.Windows.Forms.LinkLabel();
            this.ckbIsActive = new System.Windows.Forms.CheckBox();
            this.grbPreview = new System.Windows.Forms.GroupBox();
            this.btReload = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.lblLogFile = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.grbTest.SuspendLayout();
            this.grbPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1092, 68);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Location = new System.Drawing.Point(66, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(224, 40);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Logging Sample";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Primavera.PlatformSamples.Properties.Resources.Document;
            this.picLogo.Location = new System.Drawing.Point(12, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(48, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBottom.Controls.Add(this.btClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 638);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1092, 42);
            this.pnlBottom.TabIndex = 3;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Location = new System.Drawing.Point(965, 10);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(115, 23);
            this.btClose.TabIndex = 0;
            this.btClose.TabStop = false;
            this.btClose.Text = "Close Me";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // grbTest
            // 
            this.grbTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTest.Controls.Add(this.linkClear);
            this.grbTest.Controls.Add(this.linkDeactivate);
            this.grbTest.Controls.Add(this.btTraceVerbosed);
            this.grbTest.Controls.Add(this.btTraceThrow);
            this.grbTest.Controls.Add(this.btTraceIgnored);
            this.grbTest.Controls.Add(this.btLog);
            this.grbTest.Controls.Add(this.label2);
            this.grbTest.Controls.Add(this.txtMessage);
            this.grbTest.Controls.Add(this.label1);
            this.grbTest.Controls.Add(this.cbbLogType);
            this.grbTest.Controls.Add(this.linkActivate);
            this.grbTest.Controls.Add(this.ckbIsActive);
            this.grbTest.Location = new System.Drawing.Point(12, 74);
            this.grbTest.Name = "grbTest";
            this.grbTest.Size = new System.Drawing.Size(1068, 157);
            this.grbTest.TabIndex = 4;
            this.grbTest.TabStop = false;
            this.grbTest.Text = "Logging Test";
            // 
            // linkClear
            // 
            this.linkClear.AutoSize = true;
            this.linkClear.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkClear.Location = new System.Drawing.Point(328, 31);
            this.linkClear.Name = "linkClear";
            this.linkClear.Size = new System.Drawing.Size(72, 13);
            this.linkClear.TabIndex = 11;
            this.linkClear.TabStop = true;
            this.linkClear.Text = "Clear log file";
            this.linkClear.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
            // 
            // linkDeactivate
            // 
            this.linkDeactivate.AutoSize = true;
            this.linkDeactivate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkDeactivate.Location = new System.Drawing.Point(227, 31);
            this.linkDeactivate.Name = "linkDeactivate";
            this.linkDeactivate.Size = new System.Drawing.Size(80, 13);
            this.linkDeactivate.TabIndex = 10;
            this.linkDeactivate.TabStop = true;
            this.linkDeactivate.Text = "Deactivate log";
            this.linkDeactivate.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkDeactivate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeactivate_LinkClicked);
            // 
            // btTraceVerbosed
            // 
            this.btTraceVerbosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTraceVerbosed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btTraceVerbosed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTraceVerbosed.Location = new System.Drawing.Point(792, 115);
            this.btTraceVerbosed.Name = "btTraceVerbosed";
            this.btTraceVerbosed.Size = new System.Drawing.Size(257, 22);
            this.btTraceVerbosed.TabIndex = 9;
            this.btTraceVerbosed.TabStop = false;
            this.btTraceVerbosed.Text = "Trace verbosed";
            this.btTraceVerbosed.UseVisualStyleBackColor = false;
            this.btTraceVerbosed.Click += new System.EventHandler(this.btTraceVerbosed_Click);
            // 
            // btTraceThrow
            // 
            this.btTraceThrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTraceThrow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btTraceThrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTraceThrow.Location = new System.Drawing.Point(529, 115);
            this.btTraceThrow.Name = "btTraceThrow";
            this.btTraceThrow.Size = new System.Drawing.Size(257, 22);
            this.btTraceThrow.TabIndex = 8;
            this.btTraceThrow.TabStop = false;
            this.btTraceThrow.Text = "Trace exception and throw it";
            this.btTraceThrow.UseVisualStyleBackColor = false;
            this.btTraceThrow.Click += new System.EventHandler(this.btTraceThrow_Click);
            // 
            // btTraceIgnored
            // 
            this.btTraceIgnored.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTraceIgnored.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btTraceIgnored.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTraceIgnored.Location = new System.Drawing.Point(266, 115);
            this.btTraceIgnored.Name = "btTraceIgnored";
            this.btTraceIgnored.Size = new System.Drawing.Size(257, 22);
            this.btTraceIgnored.TabIndex = 7;
            this.btTraceIgnored.TabStop = false;
            this.btTraceIgnored.Text = "Trace ignored exception";
            this.btTraceIgnored.UseVisualStyleBackColor = false;
            this.btTraceIgnored.Click += new System.EventHandler(this.btTraceIgnored_Click);
            // 
            // btLog
            // 
            this.btLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLog.Location = new System.Drawing.Point(949, 75);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(100, 22);
            this.btLog.TabIndex = 6;
            this.btLog.TabStop = false;
            this.btLog.Text = "Log";
            this.btLog.UseVisualStyleBackColor = false;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(266, 75);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(677, 22);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "Simple sample message to log";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trace type";
            // 
            // cbbLogType
            // 
            this.cbbLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLogType.FormattingEnabled = true;
            this.cbbLogType.Items.AddRange(new object[] {
            "Simple file trace",
            "File trace with indentation",
            "File trace enter function / method",
            "File trace exit function / method",
            "File trace exception"});
            this.cbbLogType.Location = new System.Drawing.Point(16, 76);
            this.cbbLogType.Name = "cbbLogType";
            this.cbbLogType.Size = new System.Drawing.Size(232, 21);
            this.cbbLogType.TabIndex = 2;
            // 
            // linkActivate
            // 
            this.linkActivate.AutoSize = true;
            this.linkActivate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkActivate.Location = new System.Drawing.Point(140, 31);
            this.linkActivate.Name = "linkActivate";
            this.linkActivate.Size = new System.Drawing.Size(67, 13);
            this.linkActivate.TabIndex = 1;
            this.linkActivate.TabStop = true;
            this.linkActivate.Text = "Activate log";
            this.linkActivate.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkActivate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkActivate_LinkClicked);
            // 
            // ckbIsActive
            // 
            this.ckbIsActive.AutoSize = true;
            this.ckbIsActive.Location = new System.Drawing.Point(16, 30);
            this.ckbIsActive.Name = "ckbIsActive";
            this.ckbIsActive.Size = new System.Drawing.Size(106, 17);
            this.ckbIsActive.TabIndex = 0;
            this.ckbIsActive.Text = "Logging active?";
            this.ckbIsActive.UseVisualStyleBackColor = true;
            this.ckbIsActive.CheckedChanged += new System.EventHandler(this.ckbIsActive_CheckedChanged);
            // 
            // grbPreview
            // 
            this.grbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPreview.Controls.Add(this.btReload);
            this.grbPreview.Controls.Add(this.txtPreview);
            this.grbPreview.Controls.Add(this.txtLogFile);
            this.grbPreview.Controls.Add(this.lblLogFile);
            this.grbPreview.Location = new System.Drawing.Point(12, 237);
            this.grbPreview.Name = "grbPreview";
            this.grbPreview.Size = new System.Drawing.Size(1068, 392);
            this.grbPreview.TabIndex = 5;
            this.grbPreview.TabStop = false;
            this.grbPreview.Text = "Preview";
            // 
            // btReload
            // 
            this.btReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReload.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btReload.Location = new System.Drawing.Point(874, 23);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(175, 22);
            this.btReload.TabIndex = 4;
            this.btReload.TabStop = false;
            this.btReload.Text = "Reload (last 50 lines)";
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreview.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.Location = new System.Drawing.Point(16, 51);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPreview.Size = new System.Drawing.Size(1033, 325);
            this.txtPreview.TabIndex = 2;
            // 
            // txtLogFile
            // 
            this.txtLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogFile.Location = new System.Drawing.Point(67, 23);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.ReadOnly = true;
            this.txtLogFile.Size = new System.Drawing.Size(801, 22);
            this.txtLogFile.TabIndex = 1;
            // 
            // lblLogFile
            // 
            this.lblLogFile.AutoSize = true;
            this.lblLogFile.Location = new System.Drawing.Point(13, 26);
            this.lblLogFile.Name = "lblLogFile";
            this.lblLogFile.Size = new System.Drawing.Size(45, 13);
            this.lblLogFile.TabIndex = 0;
            this.lblLogFile.Text = "Log file";
            // 
            // frmLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 680);
            this.Controls.Add(this.grbPreview);
            this.Controls.Add(this.grbTest);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmLogging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIMAVERA v10 - Platform Samples";
            this.Load += new System.EventHandler(this.frmLogging_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.grbTest.ResumeLayout(false);
            this.grbTest.PerformLayout();
            this.grbPreview.ResumeLayout(false);
            this.grbPreview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.GroupBox grbTest;
        private System.Windows.Forms.GroupBox grbPreview;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.Label lblLogFile;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.LinkLabel linkActivate;
        private System.Windows.Forms.CheckBox ckbIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLogType;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Button btTraceVerbosed;
        private System.Windows.Forms.Button btTraceThrow;
        private System.Windows.Forms.Button btTraceIgnored;
        private System.Windows.Forms.LinkLabel linkClear;
        private System.Windows.Forms.LinkLabel linkDeactivate;
    }
}