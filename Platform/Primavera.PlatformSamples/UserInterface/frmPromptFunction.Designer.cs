namespace Primavera.PlatformSamples.UserInterface
{
    partial class frmPromptFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromptFunction));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.grbAlerts = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblContext = new System.Windows.Forms.Label();
            this.imgImagens = new System.Windows.Forms.ImageList(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.grbAlerts.SuspendLayout();
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
            this.lblHeader.Size = new System.Drawing.Size(436, 40);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Execute Prompt Function Sample";
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
            this.grbAlerts.Controls.Add(this.btnSend);
            this.grbAlerts.Controls.Add(this.txtPrompt);
            this.grbAlerts.Controls.Add(this.txtData);
            this.grbAlerts.Controls.Add(this.txtContext);
            this.grbAlerts.Controls.Add(this.lblPrompt);
            this.grbAlerts.Controls.Add(this.lblData);
            this.grbAlerts.Controls.Add(this.lblContext);
            this.grbAlerts.Location = new System.Drawing.Point(12, 74);
            this.grbAlerts.Name = "grbAlerts";
            this.grbAlerts.Size = new System.Drawing.Size(625, 355);
            this.grbAlerts.TabIndex = 4;
            this.grbAlerts.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(504, 319);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 23);
            this.btnSend.TabIndex = 20;
            this.btnSend.TabStop = false;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtPrompt
            // 
            this.txtPrompt.AcceptsReturn = true;
            this.txtPrompt.Location = new System.Drawing.Point(9, 233);
            this.txtPrompt.Multiline = true;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(610, 80);
            this.txtPrompt.TabIndex = 14;
            // 
            // txtData
            // 
            this.txtData.AcceptsReturn = true;
            this.txtData.Location = new System.Drawing.Point(9, 134);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(610, 80);
            this.txtData.TabIndex = 12;
            // 
            // txtContext
            // 
            this.txtContext.AcceptsReturn = true;
            this.txtContext.Location = new System.Drawing.Point(9, 34);
            this.txtContext.Multiline = true;
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(610, 80);
            this.txtContext.TabIndex = 10;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(6, 217);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(170, 13);
            this.lblPrompt.TabIndex = 13;
            this.lblPrompt.Text = "Response Instructions (Prompt):";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(6, 118);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Data:";
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Location = new System.Drawing.Point(6, 18);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(115, 13);
            this.lblContext.TabIndex = 9;
            this.lblContext.Text = "Data Source Context:";
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
            // frmPromptFunction
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
            this.Name = "frmPromptFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIMAVERA v10 - Platform Samples";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.grbAlerts.ResumeLayout(false);
            this.grbAlerts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.GroupBox grbAlerts;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.ImageList imgImagens;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblPrompt;
    }
}