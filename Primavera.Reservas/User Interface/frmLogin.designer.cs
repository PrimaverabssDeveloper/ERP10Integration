namespace Primavera.ReservasStock
{
    partial class Login
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCriaReservaOrigem = new System.Windows.Forms.Button();
            this.cmdCriaReservaDestino = new System.Windows.Forms.Button();
            this.priMemorizaLayout1 = new MemorizaLayout100.PriMemorizaLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(26, 353);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 1;
            // 
            // cmdLogin
            // 
            this.cmdLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogin.ForeColor = System.Drawing.Color.White;
            this.cmdLogin.Location = new System.Drawing.Point(440, 273);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(121, 29);
            this.cmdLogin.TabIndex = 4;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = false;
            this.cmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(230, 233);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(67, 14);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Utilizador:";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(323, 188);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(238, 22);
            this.txtpass.TabIndex = 2;
            // 
            // txtempresa
            // 
            this.txtempresa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempresa.Location = new System.Drawing.Point(323, 230);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(238, 22);
            this.txtempresa.TabIndex = 3;
            this.txtempresa.Text = "DEMO";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(323, 160);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(238, 22);
            this.txtuser.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Primavera.ReservasStock.Properties.Resources.Primavera_;
            this.pictureBox1.Location = new System.Drawing.Point(29, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdCriaReservaOrigem);
            this.panel1.Controls.Add(this.cmdCriaReservaDestino);
            this.panel1.Location = new System.Drawing.Point(221, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 205);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // cmdCriaReservaOrigem
            // 
            this.cmdCriaReservaOrigem.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmdCriaReservaOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCriaReservaOrigem.ForeColor = System.Drawing.Color.White;
            this.cmdCriaReservaOrigem.Location = new System.Drawing.Point(30, 105);
            this.cmdCriaReservaOrigem.Name = "cmdCriaReservaOrigem";
            this.cmdCriaReservaOrigem.Size = new System.Drawing.Size(298, 64);
            this.cmdCriaReservaOrigem.TabIndex = 6;
            this.cmdCriaReservaOrigem.Text = "Cria Reservas na origem";
            this.cmdCriaReservaOrigem.UseVisualStyleBackColor = false;
            this.cmdCriaReservaOrigem.Click += new System.EventHandler(this.cmdCreateReversal_Click);
            // 
            // cmdCriaReservaDestino
            // 
            this.cmdCriaReservaDestino.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmdCriaReservaDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCriaReservaDestino.ForeColor = System.Drawing.Color.White;
            this.cmdCriaReservaDestino.Location = new System.Drawing.Point(30, 27);
            this.cmdCriaReservaDestino.Name = "cmdCriaReservaDestino";
            this.cmdCriaReservaDestino.Size = new System.Drawing.Size(298, 64);
            this.cmdCriaReservaDestino.TabIndex = 5;
            this.cmdCriaReservaDestino.Text = "Criar Reservas no destino";
            this.cmdCriaReservaDestino.UseVisualStyleBackColor = false;
            this.cmdCriaReservaDestino.Click += new System.EventHandler(this.CreateInvoice_Click);
            // 
            // priMemorizaLayout1
            // 
            this.priMemorizaLayout1.CarregouDefinicoes = false;
            this.priMemorizaLayout1.ChaveJanela = "";
            this.priMemorizaLayout1.Location = new System.Drawing.Point(372, 323);
            this.priMemorizaLayout1.Modulo = "PRI";
            this.priMemorizaLayout1.Name = "priMemorizaLayout1";
            this.priMemorizaLayout1.ObjectosGravaDados = "txtempresa;txtuser";
            this.priMemorizaLayout1.Size = new System.Drawing.Size(38, 37);
            this.priMemorizaLayout1.TabIndex = 0;
            this.priMemorizaLayout1.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.cmdLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(615, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.priMemorizaLayout1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.txtuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "PRIMAVERA ERP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCriaReservaDestino;
		private System.Windows.Forms.Button cmdCriaReservaOrigem;
        private MemorizaLayout100.PriMemorizaLayout priMemorizaLayout1;
    }
}