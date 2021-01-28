namespace Primavera.PlatformSamples.UserInterface
{
    partial class frmAttachments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttachments));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.grbAttach = new System.Windows.Forms.GroupBox();
            this.btSave = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.lstAttachs = new System.Windows.Forms.ListBox();
            this.btChooseFile = new System.Windows.Forms.Button();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.lblAttachLocation = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblEntity = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.ckbEncrypt = new System.Windows.Forms.CheckBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.grbAttach.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(656, 68);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Location = new System.Drawing.Point(66, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(280, 40);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Attachments Sample";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Primavera.PlatformSamples.Properties.Resources.Attach;
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
            this.pnlBottom.Location = new System.Drawing.Point(0, 458);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(656, 42);
            this.pnlBottom.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Location = new System.Drawing.Point(529, 10);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(115, 23);
            this.btClose.TabIndex = 0;
            this.btClose.TabStop = false;
            this.btClose.Text = "Close Me";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // grbAttach
            // 
            this.grbAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAttach.Controls.Add(this.ckbEncrypt);
            this.grbAttach.Controls.Add(this.btSave);
            this.grbAttach.Controls.Add(this.lblList);
            this.grbAttach.Controls.Add(this.lstAttachs);
            this.grbAttach.Controls.Add(this.btChooseFile);
            this.grbAttach.Controls.Add(this.txtFileLocation);
            this.grbAttach.Controls.Add(this.lblAttachLocation);
            this.grbAttach.Controls.Add(this.txtDescription);
            this.grbAttach.Controls.Add(this.txtCode);
            this.grbAttach.Controls.Add(this.lblEntity);
            this.grbAttach.Controls.Add(this.cbbCategory);
            this.grbAttach.Controls.Add(this.lblCategory);
            this.grbAttach.Location = new System.Drawing.Point(12, 74);
            this.grbAttach.Name = "grbAttach";
            this.grbAttach.Size = new System.Drawing.Size(632, 372);
            this.grbAttach.TabIndex = 3;
            this.grbAttach.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btSave.Enabled = false;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Location = new System.Drawing.Point(491, 169);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(121, 22);
            this.btSave.TabIndex = 10;
            this.btSave.TabStop = false;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(21, 199);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(106, 13);
            this.lblList.TabIndex = 9;
            this.lblList.Text = "List of attachments";
            // 
            // lstAttachs
            // 
            this.lstAttachs.FormattingEnabled = true;
            this.lstAttachs.Location = new System.Drawing.Point(21, 216);
            this.lstAttachs.Name = "lstAttachs";
            this.lstAttachs.Size = new System.Drawing.Size(591, 134);
            this.lstAttachs.TabIndex = 4;
            // 
            // btChooseFile
            // 
            this.btChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChooseFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btChooseFile.Location = new System.Drawing.Point(576, 141);
            this.btChooseFile.Name = "btChooseFile";
            this.btChooseFile.Size = new System.Drawing.Size(36, 22);
            this.btChooseFile.TabIndex = 3;
            this.btChooseFile.TabStop = false;
            this.btChooseFile.Text = "...";
            this.btChooseFile.UseVisualStyleBackColor = false;
            this.btChooseFile.Click += new System.EventHandler(this.btChooseFile_Click);
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Location = new System.Drawing.Point(21, 141);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(549, 22);
            this.txtFileLocation.TabIndex = 2;
            // 
            // lblAttachLocation
            // 
            this.lblAttachLocation.AutoSize = true;
            this.lblAttachLocation.Location = new System.Drawing.Point(21, 124);
            this.lblAttachLocation.Name = "lblAttachLocation";
            this.lblAttachLocation.Size = new System.Drawing.Size(111, 13);
            this.lblAttachLocation.TabIndex = 5;
            this.lblAttachLocation.Text = "Attachment location";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(198, 92);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(414, 22);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(21, 92);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(168, 22);
            this.txtCode.TabIndex = 1;
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(21, 75);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(64, 13);
            this.lblEntity.TabIndex = 2;
            this.lblEntity.Text = "Entity code";
            // 
            // cbbCategory
            // 
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Items.AddRange(new object[] {
            "Clients",
            "Suppliers"});
            this.cbbCategory.Location = new System.Drawing.Point(21, 44);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(168, 21);
            this.cbbCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(21, 27);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(105, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Select the category";
            // 
            // ckbEncrypt
            // 
            this.ckbEncrypt.AutoSize = true;
            this.ckbEncrypt.Location = new System.Drawing.Point(386, 173);
            this.ckbEncrypt.Name = "ckbEncrypt";
            this.ckbEncrypt.Size = new System.Drawing.Size(82, 17);
            this.ckbEncrypt.TabIndex = 11;
            this.ckbEncrypt.Text = "Encriptado";
            this.ckbEncrypt.UseVisualStyleBackColor = true;
            // 
            // frmAttachments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 500);
            this.Controls.Add(this.grbAttach);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAttachments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIMAVERA v10 - Platform Samples";
            this.Load += new System.EventHandler(this.frmAttachments_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.grbAttach.ResumeLayout(false);
            this.grbAttach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.GroupBox grbAttach;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lstAttachs;
        private System.Windows.Forms.Button btChooseFile;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.Label lblAttachLocation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox ckbEncrypt;
    }
}