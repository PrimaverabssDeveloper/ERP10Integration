namespace Primavera.PlatformSamples.UserInterface
{
    partial class frmAlertManager
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("", 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlertManager));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.grbAlerts = new System.Windows.Forms.GroupBox();
            this.rdbCustom = new System.Windows.Forms.RadioButton();
            this.lstImages = new System.Windows.Forms.ListView();
            this.imgImagens = new System.Windows.Forms.ImageList(this.components);
            this.btShowAlert = new System.Windows.Forms.Button();
            this.grbCustom = new System.Windows.Forms.GroupBox();
            this.btShowCustom = new System.Windows.Forms.Button();
            this.txtCustomDesc = new System.Windows.Forms.TextBox();
            this.lblCustomDesc = new System.Windows.Forms.Label();
            this.txtCustomTitle = new System.Windows.Forms.TextBox();
            this.lblCustomTitle = new System.Windows.Forms.Label();
            this.txtAlertDesc = new System.Windows.Forms.TextBox();
            this.lblAlertDesc = new System.Windows.Forms.Label();
            this.txtAlertTitle = new System.Windows.Forms.TextBox();
            this.lblAlertTitle = new System.Windows.Forms.Label();
            this.rdbSuccess = new System.Windows.Forms.RadioButton();
            this.rdbMessage = new System.Windows.Forms.RadioButton();
            this.rdbError = new System.Windows.Forms.RadioButton();
            this.rdbInfo = new System.Windows.Forms.RadioButton();
            this.lblAlertType = new System.Windows.Forms.Label();
            this.picError = new System.Windows.Forms.PictureBox();
            this.picSuccess = new System.Windows.Forms.PictureBox();
            this.picWarning = new System.Windows.Forms.PictureBox();
            this.picMessage = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.grbAlerts.SuspendLayout();
            this.grbCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(649, 68);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Location = new System.Drawing.Point(66, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(192, 40);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Alerts Sample";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBottom.Controls.Add(this.btClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 440);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(649, 42);
            this.pnlBottom.TabIndex = 3;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Location = new System.Drawing.Point(522, 10);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(115, 23);
            this.btClose.TabIndex = 0;
            this.btClose.TabStop = false;
            this.btClose.Text = "Close Me";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // grbAlerts
            // 
            this.grbAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAlerts.Controls.Add(this.rdbCustom);
            this.grbAlerts.Controls.Add(this.btShowAlert);
            this.grbAlerts.Controls.Add(this.grbCustom);
            this.grbAlerts.Controls.Add(this.txtAlertDesc);
            this.grbAlerts.Controls.Add(this.lblAlertDesc);
            this.grbAlerts.Controls.Add(this.txtAlertTitle);
            this.grbAlerts.Controls.Add(this.lblAlertTitle);
            this.grbAlerts.Controls.Add(this.picError);
            this.grbAlerts.Controls.Add(this.picSuccess);
            this.grbAlerts.Controls.Add(this.picWarning);
            this.grbAlerts.Controls.Add(this.picMessage);
            this.grbAlerts.Controls.Add(this.rdbSuccess);
            this.grbAlerts.Controls.Add(this.rdbMessage);
            this.grbAlerts.Controls.Add(this.rdbError);
            this.grbAlerts.Controls.Add(this.rdbInfo);
            this.grbAlerts.Controls.Add(this.lblAlertType);
            this.grbAlerts.Location = new System.Drawing.Point(12, 74);
            this.grbAlerts.Name = "grbAlerts";
            this.grbAlerts.Size = new System.Drawing.Size(625, 355);
            this.grbAlerts.TabIndex = 4;
            this.grbAlerts.TabStop = false;
            // 
            // rdbCustom
            // 
            this.rdbCustom.AutoSize = true;
            this.rdbCustom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCustom.Location = new System.Drawing.Point(34, 184);
            this.rdbCustom.Name = "rdbCustom";
            this.rdbCustom.Size = new System.Drawing.Size(93, 17);
            this.rdbCustom.TabIndex = 13;
            this.rdbCustom.TabStop = true;
            this.rdbCustom.Text = "Custom Alert";
            this.rdbCustom.UseVisualStyleBackColor = true;
            this.rdbCustom.CheckedChanged += new System.EventHandler(this.rdbCustom_CheckedChanged);
            // 
            // lstImages
            // 
            this.lstImages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstImages.HideSelection = false;
            this.lstImages.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.lstImages.LargeImageList = this.imgImagens;
            this.lstImages.Location = new System.Drawing.Point(11, 31);
            this.lstImages.MultiSelect = false;
            this.lstImages.Name = "lstImages";
            this.lstImages.Scrollable = false;
            this.lstImages.Size = new System.Drawing.Size(551, 56);
            this.lstImages.TabIndex = 18;
            this.lstImages.UseCompatibleStateImageBehavior = false;
            // 
            // imgImagens
            // 
            this.imgImagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgImagens.ImageStream")));
            this.imgImagens.TransparentColor = System.Drawing.Color.WhiteSmoke;
            this.imgImagens.Images.SetKeyName(0, "error.png");
            this.imgImagens.Images.SetKeyName(1, "message.png");
            this.imgImagens.Images.SetKeyName(2, "success.png");
            this.imgImagens.Images.SetKeyName(3, "tip.png");
            this.imgImagens.Images.SetKeyName(4, "warning.png");
            // 
            // btShowAlert
            // 
            this.btShowAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btShowAlert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btShowAlert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btShowAlert.Location = new System.Drawing.Point(497, 145);
            this.btShowAlert.Name = "btShowAlert";
            this.btShowAlert.Size = new System.Drawing.Size(104, 22);
            this.btShowAlert.TabIndex = 15;
            this.btShowAlert.TabStop = false;
            this.btShowAlert.Text = "Show";
            this.btShowAlert.UseVisualStyleBackColor = false;
            this.btShowAlert.Click += new System.EventHandler(this.btShowAlert_Click);
            // 
            // grbCustom
            // 
            this.grbCustom.Controls.Add(this.btShowCustom);
            this.grbCustom.Controls.Add(this.lstImages);
            this.grbCustom.Controls.Add(this.txtCustomDesc);
            this.grbCustom.Controls.Add(this.lblCustomDesc);
            this.grbCustom.Controls.Add(this.txtCustomTitle);
            this.grbCustom.Controls.Add(this.lblCustomTitle);
            this.grbCustom.Enabled = false;
            this.grbCustom.Location = new System.Drawing.Point(23, 185);
            this.grbCustom.Name = "grbCustom";
            this.grbCustom.Size = new System.Drawing.Size(578, 153);
            this.grbCustom.TabIndex = 14;
            this.grbCustom.TabStop = false;
            // 
            // btShowCustom
            // 
            this.btShowCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btShowCustom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btShowCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btShowCustom.Location = new System.Drawing.Point(464, 114);
            this.btShowCustom.Name = "btShowCustom";
            this.btShowCustom.Size = new System.Drawing.Size(98, 22);
            this.btShowCustom.TabIndex = 19;
            this.btShowCustom.TabStop = false;
            this.btShowCustom.Text = "Show";
            this.btShowCustom.UseVisualStyleBackColor = false;
            this.btShowCustom.Click += new System.EventHandler(this.btShowCustom_Click);
            // 
            // txtCustomDesc
            // 
            this.txtCustomDesc.Location = new System.Drawing.Point(140, 114);
            this.txtCustomDesc.Name = "txtCustomDesc";
            this.txtCustomDesc.Size = new System.Drawing.Size(318, 22);
            this.txtCustomDesc.TabIndex = 17;
            this.txtCustomDesc.Text = "Custom description to show in alert";
            // 
            // lblCustomDesc
            // 
            this.lblCustomDesc.AutoSize = true;
            this.lblCustomDesc.Location = new System.Drawing.Point(137, 98);
            this.lblCustomDesc.Name = "lblCustomDesc";
            this.lblCustomDesc.Size = new System.Drawing.Size(66, 13);
            this.lblCustomDesc.TabIndex = 16;
            this.lblCustomDesc.Text = "Description";
            // 
            // txtCustomTitle
            // 
            this.txtCustomTitle.Location = new System.Drawing.Point(11, 114);
            this.txtCustomTitle.Name = "txtCustomTitle";
            this.txtCustomTitle.Size = new System.Drawing.Size(123, 22);
            this.txtCustomTitle.TabIndex = 15;
            this.txtCustomTitle.Text = "Custom Title";
            // 
            // lblCustomTitle
            // 
            this.lblCustomTitle.AutoSize = true;
            this.lblCustomTitle.Location = new System.Drawing.Point(8, 97);
            this.lblCustomTitle.Name = "lblCustomTitle";
            this.lblCustomTitle.Size = new System.Drawing.Size(28, 13);
            this.lblCustomTitle.TabIndex = 14;
            this.lblCustomTitle.Text = "Title";
            // 
            // txtAlertDesc
            // 
            this.txtAlertDesc.Location = new System.Drawing.Point(173, 145);
            this.txtAlertDesc.Name = "txtAlertDesc";
            this.txtAlertDesc.Size = new System.Drawing.Size(318, 22);
            this.txtAlertDesc.TabIndex = 12;
            this.txtAlertDesc.Text = "Sample message to display";
            // 
            // lblAlertDesc
            // 
            this.lblAlertDesc.AutoSize = true;
            this.lblAlertDesc.Location = new System.Drawing.Point(170, 128);
            this.lblAlertDesc.Name = "lblAlertDesc";
            this.lblAlertDesc.Size = new System.Drawing.Size(92, 13);
            this.lblAlertDesc.TabIndex = 11;
            this.lblAlertDesc.Text = "Alert descritpion";
            // 
            // txtAlertTitle
            // 
            this.txtAlertTitle.Location = new System.Drawing.Point(33, 145);
            this.txtAlertTitle.Name = "txtAlertTitle";
            this.txtAlertTitle.Size = new System.Drawing.Size(123, 22);
            this.txtAlertTitle.TabIndex = 10;
            this.txtAlertTitle.Text = "Sample Title";
            // 
            // lblAlertTitle
            // 
            this.lblAlertTitle.AutoSize = true;
            this.lblAlertTitle.Location = new System.Drawing.Point(30, 128);
            this.lblAlertTitle.Name = "lblAlertTitle";
            this.lblAlertTitle.Size = new System.Drawing.Size(54, 13);
            this.lblAlertTitle.TabIndex = 9;
            this.lblAlertTitle.Text = "Alert title";
            // 
            // rdbSuccess
            // 
            this.rdbSuccess.AutoSize = true;
            this.rdbSuccess.Location = new System.Drawing.Point(223, 53);
            this.rdbSuccess.Name = "rdbSuccess";
            this.rdbSuccess.Size = new System.Drawing.Size(64, 17);
            this.rdbSuccess.TabIndex = 4;
            this.rdbSuccess.Text = "Success";
            this.rdbSuccess.UseVisualStyleBackColor = true;
            this.rdbSuccess.CheckedChanged += new System.EventHandler(this.rdbSuccess_CheckedChanged);
            // 
            // rdbMessage
            // 
            this.rdbMessage.AutoSize = true;
            this.rdbMessage.Location = new System.Drawing.Point(128, 53);
            this.rdbMessage.Name = "rdbMessage";
            this.rdbMessage.Size = new System.Drawing.Size(70, 17);
            this.rdbMessage.TabIndex = 3;
            this.rdbMessage.Text = "Message";
            this.rdbMessage.UseVisualStyleBackColor = true;
            this.rdbMessage.CheckedChanged += new System.EventHandler(this.rdbMessage_CheckedChanged);
            // 
            // rdbError
            // 
            this.rdbError.AutoSize = true;
            this.rdbError.Location = new System.Drawing.Point(319, 53);
            this.rdbError.Name = "rdbError";
            this.rdbError.Size = new System.Drawing.Size(50, 17);
            this.rdbError.TabIndex = 2;
            this.rdbError.Text = "Error";
            this.rdbError.UseVisualStyleBackColor = true;
            this.rdbError.CheckedChanged += new System.EventHandler(this.rdbError_CheckedChanged);
            // 
            // rdbInfo
            // 
            this.rdbInfo.AutoSize = true;
            this.rdbInfo.Checked = true;
            this.rdbInfo.Location = new System.Drawing.Point(33, 53);
            this.rdbInfo.Name = "rdbInfo";
            this.rdbInfo.Size = new System.Drawing.Size(86, 17);
            this.rdbInfo.TabIndex = 1;
            this.rdbInfo.TabStop = true;
            this.rdbInfo.Text = "Information";
            this.rdbInfo.UseVisualStyleBackColor = true;
            this.rdbInfo.CheckedChanged += new System.EventHandler(this.rdbInfo_CheckedChanged);
            // 
            // lblAlertType
            // 
            this.lblAlertType.AutoSize = true;
            this.lblAlertType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertType.Location = new System.Drawing.Point(20, 28);
            this.lblAlertType.Name = "lblAlertType";
            this.lblAlertType.Size = new System.Drawing.Size(132, 13);
            this.lblAlertType.TabIndex = 0;
            this.lblAlertType.Text = "Choose the type of alert";
            // 
            // picError
            // 
            this.picError.Enabled = false;
            this.picError.Image = global::Primavera.PlatformSamples.Properties.Resources.Icon_Alert;
            this.picError.Location = new System.Drawing.Point(319, 76);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(48, 48);
            this.picError.TabIndex = 8;
            this.picError.TabStop = false;
            this.picError.Visible = false;
            // 
            // picSuccess
            // 
            this.picSuccess.Enabled = false;
            this.picSuccess.Image = global::Primavera.PlatformSamples.Properties.Resources.Icon_Success;
            this.picSuccess.Location = new System.Drawing.Point(223, 76);
            this.picSuccess.Name = "picSuccess";
            this.picSuccess.Size = new System.Drawing.Size(48, 48);
            this.picSuccess.TabIndex = 7;
            this.picSuccess.TabStop = false;
            this.picSuccess.Visible = false;
            // 
            // picWarning
            // 
            this.picWarning.Enabled = false;
            this.picWarning.Image = global::Primavera.PlatformSamples.Properties.Resources.Icon_Message;
            this.picWarning.Location = new System.Drawing.Point(128, 76);
            this.picWarning.Name = "picWarning";
            this.picWarning.Size = new System.Drawing.Size(48, 48);
            this.picWarning.TabIndex = 6;
            this.picWarning.TabStop = false;
            this.picWarning.Visible = false;
            // 
            // picMessage
            // 
            this.picMessage.Image = global::Primavera.PlatformSamples.Properties.Resources.Icon_Info;
            this.picMessage.Location = new System.Drawing.Point(33, 76);
            this.picMessage.Name = "picMessage";
            this.picMessage.Size = new System.Drawing.Size(48, 48);
            this.picMessage.TabIndex = 5;
            this.picMessage.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Primavera.PlatformSamples.Properties.Resources.Notification;
            this.picLogo.InitialImage = global::Primavera.PlatformSamples.Properties.Resources.Notification;
            this.picLogo.Location = new System.Drawing.Point(12, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(48, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // frmAlertManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 482);
            this.Controls.Add(this.grbAlerts);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlertManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIMAVERA v10 - Platform Samples";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.grbAlerts.ResumeLayout(false);
            this.grbAlerts.PerformLayout();
            this.grbCustom.ResumeLayout(false);
            this.grbCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.GroupBox grbAlerts;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.PictureBox picSuccess;
        private System.Windows.Forms.PictureBox picWarning;
        private System.Windows.Forms.PictureBox picMessage;
        private System.Windows.Forms.RadioButton rdbSuccess;
        private System.Windows.Forms.RadioButton rdbMessage;
        private System.Windows.Forms.RadioButton rdbError;
        private System.Windows.Forms.RadioButton rdbInfo;
        private System.Windows.Forms.Label lblAlertType;
        private System.Windows.Forms.TextBox txtAlertDesc;
        private System.Windows.Forms.Label lblAlertDesc;
        private System.Windows.Forms.TextBox txtAlertTitle;
        private System.Windows.Forms.Label lblAlertTitle;
        private System.Windows.Forms.GroupBox grbCustom;
        private System.Windows.Forms.RadioButton rdbCustom;
        private System.Windows.Forms.TextBox txtCustomDesc;
        private System.Windows.Forms.Label lblCustomDesc;
        private System.Windows.Forms.TextBox txtCustomTitle;
        private System.Windows.Forms.Label lblCustomTitle;
        private System.Windows.Forms.ListView lstImages;
        private System.Windows.Forms.Button btShowAlert;
        private System.Windows.Forms.Button btShowCustom;
        private System.Windows.Forms.ImageList imgImagens;
    }
}