namespace Primavera.PlatformSamples
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btLogging = new System.Windows.Forms.Button();
            this.btAlerts = new System.Windows.Forms.Button();
            this.btAttachs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlActions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(26, 353);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(239, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Context information will be display here.";
            // 
            // cmdLogin
            // 
            this.cmdLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogin.ForeColor = System.Drawing.Color.White;
            this.cmdLogin.Location = new System.Drawing.Point(194, 175);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(121, 29);
            this.cmdLogin.TabIndex = 3;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = false;
            this.cmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEmpresa.Location = new System.Drawing.Point(24, 111);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(62, 15);
            this.lblEmpresa.TabIndex = 13;
            this.lblEmpresa.Text = "Company:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "User Name:";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(106, 66);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(209, 23);
            this.txtpass.TabIndex = 1;
            // 
            // txtempresa
            // 
            this.txtempresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtempresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempresa.Location = new System.Drawing.Point(106, 108);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(209, 23);
            this.txtempresa.TabIndex = 2;
            this.txtempresa.Text = "DEMOV10";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(106, 38);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(209, 23);
            this.txtuser.TabIndex = 0;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btLogging);
            this.pnlActions.Controls.Add(this.btAlerts);
            this.pnlActions.Controls.Add(this.btAttachs);
            this.pnlActions.Location = new System.Drawing.Point(23, 53);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(370, 290);
            this.pnlActions.TabIndex = 17;
            this.pnlActions.Visible = false;
            // 
            // btLogging
            // 
            this.btLogging.BackColor = System.Drawing.Color.DodgerBlue;
            this.btLogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogging.ForeColor = System.Drawing.Color.White;
            this.btLogging.Image = global::Primavera.PlatformSamples.Properties.Resources.Document;
            this.btLogging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogging.Location = new System.Drawing.Point(18, 154);
            this.btLogging.Name = "btLogging";
            this.btLogging.Size = new System.Drawing.Size(334, 64);
            this.btLogging.TabIndex = 2;
            this.btLogging.Text = "Logging Sample";
            this.btLogging.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogging.UseVisualStyleBackColor = false;
            this.btLogging.Click += new System.EventHandler(this.btLogging_Click);
            // 
            // btAlerts
            // 
            this.btAlerts.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlerts.ForeColor = System.Drawing.Color.White;
            this.btAlerts.Image = global::Primavera.PlatformSamples.Properties.Resources.Notification;
            this.btAlerts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlerts.Location = new System.Drawing.Point(18, 14);
            this.btAlerts.Name = "btAlerts";
            this.btAlerts.Size = new System.Drawing.Size(334, 64);
            this.btAlerts.TabIndex = 0;
            this.btAlerts.Text = "Alerts and Notification Sample";
            this.btAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlerts.UseVisualStyleBackColor = false;
            this.btAlerts.Click += new System.EventHandler(this.btAlerts_Click);
            // 
            // btAttachs
            // 
            this.btAttachs.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAttachs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAttachs.ForeColor = System.Drawing.Color.White;
            this.btAttachs.Image = global::Primavera.PlatformSamples.Properties.Resources.Attach;
            this.btAttachs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAttachs.Location = new System.Drawing.Point(18, 84);
            this.btAttachs.Name = "btAttachs";
            this.btAttachs.Size = new System.Drawing.Size(334, 64);
            this.btAttachs.TabIndex = 1;
            this.btAttachs.Text = "Attachments Sample";
            this.btAttachs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAttachs.UseVisualStyleBackColor = false;
            this.btAttachs.Click += new System.EventHandler(this.btAttachs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInstance);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.txtempresa);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.cmdLogin);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(254, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 291);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login:";
            // 
            // txtInstance
            // 
            this.txtInstance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInstance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstance.Location = new System.Drawing.Point(106, 137);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(209, 23);
            this.txtInstance.TabIndex = 15;
            this.txtInstance.Text = "DEFAULT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Instance:";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Primavera.PlatformSamples.Properties.Resources.primavera1;
            this.picLogo.Location = new System.Drawing.Point(23, 20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(177, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 16;
            this.picLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 314);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIMAVERA Platform Samples";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlActions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btAttachs;
        private System.Windows.Forms.Button btAlerts;
        private System.Windows.Forms.Button btLogging;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.Label label3;
    }
}