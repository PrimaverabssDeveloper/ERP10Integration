namespace Primavera.Inventory.Documents
{
    partial class LoginForm
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.inventoryEditorsPanel = new System.Windows.Forms.Panel();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.primaveraPictureBox = new System.Windows.Forms.PictureBox();
            this.compositionsBreakdowsButton = new System.Windows.Forms.Button();
            this.inventoryEditorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primaveraPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(35, 434);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(291, 17);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Context information will be display here.";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(587, 336);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(161, 36);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(307, 235);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 18);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password:";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.White;
            this.companyLabel.Location = new System.Drawing.Point(307, 287);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(87, 18);
            this.companyLabel.TabIndex = 13;
            this.companyLabel.Text = "Company:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(307, 201);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(98, 18);
            this.userNameLabel.TabIndex = 14;
            this.userNameLabel.Text = "User Name:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(431, 231);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(316, 26);
            this.passwordTextBox.TabIndex = 1;
            // 
            // companyTextBox
            // 
            this.companyTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyTextBox.Location = new System.Drawing.Point(431, 283);
            this.companyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(316, 26);
            this.companyTextBox.TabIndex = 2;
            this.companyTextBox.Text = "DEMO";
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(431, 197);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(316, 26);
            this.userTextBox.TabIndex = 0;
            // 
            // inventoryEditorsPanel
            // 
            this.inventoryEditorsPanel.Controls.Add(this.compositionsBreakdowsButton);
            this.inventoryEditorsPanel.Controls.Add(this.inventoryButton);
            this.inventoryEditorsPanel.Controls.Add(this.transferButton);
            this.inventoryEditorsPanel.Location = new System.Drawing.Point(310, 141);
            this.inventoryEditorsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryEditorsPanel.Name = "inventoryEditorsPanel";
            this.inventoryEditorsPanel.Size = new System.Drawing.Size(467, 252);
            this.inventoryEditorsPanel.TabIndex = 17;
            this.inventoryEditorsPanel.Visible = false;
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.ForeColor = System.Drawing.Color.White;
            this.inventoryButton.Location = new System.Drawing.Point(36, 94);
            this.inventoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(397, 66);
            this.inventoryButton.TabIndex = 9;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.ForeColor = System.Drawing.Color.White;
            this.transferButton.Location = new System.Drawing.Point(36, 16);
            this.transferButton.Margin = new System.Windows.Forms.Padding(4);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(397, 66);
            this.transferButton.TabIndex = 8;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // primaveraPictureBox
            // 
            this.primaveraPictureBox.Image = global::Primavera.Inventory.Documents.Properties.Resources.Primavera_;
            this.primaveraPictureBox.Location = new System.Drawing.Point(39, 32);
            this.primaveraPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.primaveraPictureBox.Name = "primaveraPictureBox";
            this.primaveraPictureBox.Size = new System.Drawing.Size(344, 85);
            this.primaveraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.primaveraPictureBox.TabIndex = 16;
            this.primaveraPictureBox.TabStop = false;
            // 
            // compositionsBreakdowsButton
            // 
            this.compositionsBreakdowsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.compositionsBreakdowsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compositionsBreakdowsButton.ForeColor = System.Drawing.Color.White;
            this.compositionsBreakdowsButton.Location = new System.Drawing.Point(36, 172);
            this.compositionsBreakdowsButton.Margin = new System.Windows.Forms.Padding(4);
            this.compositionsBreakdowsButton.Name = "compositionsBreakdowsButton";
            this.compositionsBreakdowsButton.Size = new System.Drawing.Size(397, 66);
            this.compositionsBreakdowsButton.TabIndex = 10;
            this.compositionsBreakdowsButton.Text = "Compositions and Breakdowns";
            this.compositionsBreakdowsButton.UseVisualStyleBackColor = false;
            this.compositionsBreakdowsButton.Click += new System.EventHandler(this.compositionsBreakdowsButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(820, 460);
            this.Controls.Add(this.inventoryEditorsPanel);
            this.Controls.Add(this.primaveraPictureBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.userTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "PRIMAVERA ERP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.inventoryEditorsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.primaveraPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.PictureBox primaveraPictureBox;
        private System.Windows.Forms.Panel inventoryEditorsPanel;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button compositionsBreakdowsButton;
    }
}