namespace Primavera.Platform.ExtensionsUpgrader
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbpPlatform = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrimaveraInstallFolder = new System.Windows.Forms.TextBox();
            this.ckbProfessional = new System.Windows.Forms.CheckBox();
            this.cmdOpenPlatform = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.lblInstance = new System.Windows.Forms.Label();
            this.tbpManager = new System.Windows.Forms.TabPage();
            this.ckbOnlyCompany = new System.Windows.Forms.CheckBox();
            this.cmdOpenfile = new System.Windows.Forms.Button();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.lblCopyPath = new System.Windows.Forms.Label();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.lblMetadata = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFileLocation = new System.Windows.Forms.Label();
            this.tbpLogger = new System.Windows.Forms.TabPage();
            this.txtLogger = new System.Windows.Forms.TextBox();
            this.lblPEX = new System.Windows.Forms.Label();
            this.ckbCopyFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tbpPlatform.SuspendLayout();
            this.tbpManager.SuspendLayout();
            this.tbpLogger.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHeader
            // 
            this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHeader.Image = global::Primavera.Platform.ExtensionsUpgrader.Properties.Resources.Primavera;
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(494, 59);
            this.picHeader.TabIndex = 0;
            this.picHeader.TabStop = false;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbpPlatform);
            this.tabMain.Controls.Add(this.tbpManager);
            this.tabMain.Controls.Add(this.tbpLogger);
            this.tabMain.Location = new System.Drawing.Point(12, 65);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(473, 273);
            this.tabMain.TabIndex = 2;
            // 
            // tbpPlatform
            // 
            this.tbpPlatform.BackColor = System.Drawing.Color.White;
            this.tbpPlatform.Controls.Add(this.label1);
            this.tbpPlatform.Controls.Add(this.txtPrimaveraInstallFolder);
            this.tbpPlatform.Controls.Add(this.ckbProfessional);
            this.tbpPlatform.Controls.Add(this.cmdOpenPlatform);
            this.tbpPlatform.Controls.Add(this.txtPassword);
            this.tbpPlatform.Controls.Add(this.lblPassword);
            this.tbpPlatform.Controls.Add(this.txtUser);
            this.tbpPlatform.Controls.Add(this.lblUser);
            this.tbpPlatform.Controls.Add(this.txtCompany);
            this.tbpPlatform.Controls.Add(this.lblCompany);
            this.tbpPlatform.Controls.Add(this.txtInstance);
            this.tbpPlatform.Controls.Add(this.lblInstance);
            this.tbpPlatform.Location = new System.Drawing.Point(4, 22);
            this.tbpPlatform.Name = "tbpPlatform";
            this.tbpPlatform.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPlatform.Size = new System.Drawing.Size(465, 247);
            this.tbpPlatform.TabIndex = 0;
            this.tbpPlatform.Text = "Abrir Plataforma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Primavera Install Folder";
            // 
            // txtPrimaveraInstallFolder
            // 
            this.txtPrimaveraInstallFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPrimaveraInstallFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtPrimaveraInstallFolder.Location = new System.Drawing.Point(138, 17);
            this.txtPrimaveraInstallFolder.Name = "txtPrimaveraInstallFolder";
            this.txtPrimaveraInstallFolder.Size = new System.Drawing.Size(321, 22);
            this.txtPrimaveraInstallFolder.TabIndex = 11;
            this.txtPrimaveraInstallFolder.Leave += new System.EventHandler(this.txtPrimaveraInstallFolder_Leave);
            // 
            // ckbProfessional
            // 
            this.ckbProfessional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbProfessional.Location = new System.Drawing.Point(108, 51);
            this.ckbProfessional.Name = "ckbProfessional";
            this.ckbProfessional.Size = new System.Drawing.Size(249, 19);
            this.ckbProfessional.TabIndex = 10;
            this.ckbProfessional.Text = "Professional? (default = Executive)";
            this.ckbProfessional.UseVisualStyleBackColor = true;
            // 
            // cmdOpenPlatform
            // 
            this.cmdOpenPlatform.BackColor = System.Drawing.Color.White;
            this.cmdOpenPlatform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOpenPlatform.Location = new System.Drawing.Point(112, 190);
            this.cmdOpenPlatform.Name = "cmdOpenPlatform";
            this.cmdOpenPlatform.Size = new System.Drawing.Size(245, 32);
            this.cmdOpenPlatform.TabIndex = 9;
            this.cmdOpenPlatform.Text = "Abrir plataforma";
            this.cmdOpenPlatform.UseVisualStyleBackColor = false;
            this.cmdOpenPlatform.Click += new System.EventHandler(this.cmdOpenPlatform_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(183, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(174, 22);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(109, 164);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(183, 133);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(174, 22);
            this.txtUser.TabIndex = 6;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(109, 136);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Utilizador";
            // 
            // txtCompany
            // 
            this.txtCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompany.Location = new System.Drawing.Point(183, 105);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(174, 22);
            this.txtCompany.TabIndex = 4;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(109, 108);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(50, 13);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Empresa";
            // 
            // txtInstance
            // 
            this.txtInstance.Location = new System.Drawing.Point(183, 77);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(174, 22);
            this.txtInstance.TabIndex = 2;
            this.txtInstance.Text = "DEFAULT";
            // 
            // lblInstance
            // 
            this.lblInstance.AutoSize = true;
            this.lblInstance.Location = new System.Drawing.Point(109, 80);
            this.lblInstance.Name = "lblInstance";
            this.lblInstance.Size = new System.Drawing.Size(53, 13);
            this.lblInstance.TabIndex = 1;
            this.lblInstance.Text = "Instancia";
            // 
            // tbpManager
            // 
            this.tbpManager.BackColor = System.Drawing.Color.White;
            this.tbpManager.Controls.Add(this.ckbCopyFile);
            this.tbpManager.Controls.Add(this.ckbOnlyCompany);
            this.tbpManager.Controls.Add(this.cmdOpenfile);
            this.tbpManager.Controls.Add(this.cmdCopy);
            this.tbpManager.Controls.Add(this.lblCopyPath);
            this.tbpManager.Controls.Add(this.cmdInsert);
            this.tbpManager.Controls.Add(this.lblMetadata);
            this.tbpManager.Controls.Add(this.txtFilePath);
            this.tbpManager.Controls.Add(this.lblFileLocation);
            this.tbpManager.Location = new System.Drawing.Point(4, 22);
            this.tbpManager.Name = "tbpManager";
            this.tbpManager.Padding = new System.Windows.Forms.Padding(3);
            this.tbpManager.Size = new System.Drawing.Size(465, 247);
            this.tbpManager.TabIndex = 1;
            this.tbpManager.Text = "Gerir Extensões";
            // 
            // ckbOnlyCompany
            // 
            this.ckbOnlyCompany.Checked = true;
            this.ckbOnlyCompany.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOnlyCompany.Location = new System.Drawing.Point(11, 115);
            this.ckbOnlyCompany.Name = "ckbOnlyCompany";
            this.ckbOnlyCompany.Size = new System.Drawing.Size(249, 19);
            this.ckbOnlyCompany.TabIndex = 12;
            this.ckbOnlyCompany.Text = "Inserir apenas para a empresa atual";
            this.ckbOnlyCompany.UseVisualStyleBackColor = true;
            // 
            // cmdOpenfile
            // 
            this.cmdOpenfile.BackColor = System.Drawing.Color.White;
            this.cmdOpenfile.Enabled = false;
            this.cmdOpenfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdOpenfile.Location = new System.Drawing.Point(433, 28);
            this.cmdOpenfile.Name = "cmdOpenfile";
            this.cmdOpenfile.Size = new System.Drawing.Size(26, 22);
            this.cmdOpenfile.TabIndex = 11;
            this.cmdOpenfile.Text = "...";
            this.cmdOpenfile.UseVisualStyleBackColor = false;
            this.cmdOpenfile.Click += new System.EventHandler(this.cmdOpenfile_Click);
            // 
            // cmdCopy
            // 
            this.cmdCopy.BackColor = System.Drawing.Color.White;
            this.cmdCopy.Enabled = false;
            this.cmdCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCopy.Location = new System.Drawing.Point(287, 211);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(172, 30);
            this.cmdCopy.TabIndex = 9;
            this.cmdCopy.Text = "Copiar para localização final";
            this.cmdCopy.UseVisualStyleBackColor = false;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // lblCopyPath
            // 
            this.lblCopyPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCopyPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCopyPath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCopyPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyPath.Location = new System.Drawing.Point(11, 165);
            this.lblCopyPath.Name = "lblCopyPath";
            this.lblCopyPath.Size = new System.Drawing.Size(448, 43);
            this.lblCopyPath.TabIndex = 10;
            // 
            // cmdInsert
            // 
            this.cmdInsert.BackColor = System.Drawing.Color.White;
            this.cmdInsert.Enabled = false;
            this.cmdInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdInsert.Location = new System.Drawing.Point(287, 115);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(172, 31);
            this.cmdInsert.TabIndex = 8;
            this.cmdInsert.Text = "Inserir extensão";
            this.cmdInsert.UseVisualStyleBackColor = false;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // lblMetadata
            // 
            this.lblMetadata.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMetadata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetadata.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMetadata.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetadata.Location = new System.Drawing.Point(11, 53);
            this.lblMetadata.Name = "lblMetadata";
            this.lblMetadata.Size = new System.Drawing.Size(448, 59);
            this.lblMetadata.TabIndex = 7;
            // 
            // txtFilePath
            // 
            this.txtFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtFilePath.Location = new System.Drawing.Point(11, 28);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(419, 22);
            this.txtFilePath.TabIndex = 6;
            // 
            // lblFileLocation
            // 
            this.lblFileLocation.AutoSize = true;
            this.lblFileLocation.Location = new System.Drawing.Point(8, 12);
            this.lblFileLocation.Name = "lblFileLocation";
            this.lblFileLocation.Size = new System.Drawing.Size(124, 13);
            this.lblFileLocation.TabIndex = 5;
            this.lblFileLocation.Text = "Localização do ficheiro";
            // 
            // tbpLogger
            // 
            this.tbpLogger.Controls.Add(this.txtLogger);
            this.tbpLogger.Location = new System.Drawing.Point(4, 22);
            this.tbpLogger.Name = "tbpLogger";
            this.tbpLogger.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLogger.Size = new System.Drawing.Size(465, 247);
            this.tbpLogger.TabIndex = 2;
            this.tbpLogger.Text = "Logger";
            this.tbpLogger.UseVisualStyleBackColor = true;
            // 
            // txtLogger
            // 
            this.txtLogger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogger.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogger.Location = new System.Drawing.Point(3, 3);
            this.txtLogger.Multiline = true;
            this.txtLogger.Name = "txtLogger";
            this.txtLogger.ReadOnly = true;
            this.txtLogger.Size = new System.Drawing.Size(459, 241);
            this.txtLogger.TabIndex = 0;
            // 
            // lblPEX
            // 
            this.lblPEX.AutoSize = true;
            this.lblPEX.BackColor = System.Drawing.Color.Transparent;
            this.lblPEX.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEX.ForeColor = System.Drawing.Color.White;
            this.lblPEX.Location = new System.Drawing.Point(14, 23);
            this.lblPEX.Name = "lblPEX";
            this.lblPEX.Size = new System.Drawing.Size(261, 25);
            this.lblPEX.TabIndex = 3;
            this.lblPEX.Text = "PEX - Primavera EXtensibility";
            // 
            // ckbCopyFile
            // 
            this.ckbCopyFile.Checked = true;
            this.ckbCopyFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCopyFile.Location = new System.Drawing.Point(11, 136);
            this.ckbCopyFile.Name = "ckbCopyFile";
            this.ckbCopyFile.Size = new System.Drawing.Size(249, 19);
            this.ckbCopyFile.TabIndex = 13;
            this.ckbCopyFile.Text = "Copiar ficheiro para a pasta de extensões";
            this.ckbCopyFile.UseVisualStyleBackColor = true;
            this.ckbCopyFile.CheckedChanged += new System.EventHandler(this.ckbCopyFile_CheckedChanged);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(494, 350);
            this.Controls.Add(this.lblPEX);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.picHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERP v10 - Extensions Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tbpPlatform.ResumeLayout(false);
            this.tbpPlatform.PerformLayout();
            this.tbpManager.ResumeLayout(false);
            this.tbpManager.PerformLayout();
            this.tbpLogger.ResumeLayout(false);
            this.tbpLogger.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbpPlatform;
        private System.Windows.Forms.TabPage tbpManager;
        private System.Windows.Forms.Button cmdCopy;
        private System.Windows.Forms.Label lblCopyPath;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Label lblMetadata;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFileLocation;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.Label lblInstance;
        private System.Windows.Forms.Button cmdOpenfile;
        private System.Windows.Forms.Button cmdOpenPlatform;
        private System.Windows.Forms.TabPage tbpLogger;
        private System.Windows.Forms.TextBox txtLogger;
        private System.Windows.Forms.CheckBox ckbProfessional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrimaveraInstallFolder;
        private System.Windows.Forms.Label lblPEX;
        private System.Windows.Forms.CheckBox ckbOnlyCompany;
        private System.Windows.Forms.CheckBox ckbCopyFile;
    }
}