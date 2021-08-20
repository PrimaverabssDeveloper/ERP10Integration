namespace Primavera.BaseEntities
{
    partial class frmItem
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
            this.txtBaseUnit = new System.Windows.Forms.TextBox();
            this.txtF4 = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblBaseUnit = new System.Windows.Forms.Label();
            this.F4Currency = new System.Windows.Forms.Button();
            this.F4BaseUnit = new System.Windows.Forms.Button();
            this.lblPVP1 = new System.Windows.Forms.Label();
            this.txtPVP1 = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPVP1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBaseUnit
            // 
            this.txtBaseUnit.Location = new System.Drawing.Point(269, 39);
            this.txtBaseUnit.Name = "txtBaseUnit";
            this.txtBaseUnit.Size = new System.Drawing.Size(80, 20);
            this.txtBaseUnit.TabIndex = 36;
            // 
            // txtF4
            // 
            this.txtF4.Location = new System.Drawing.Point(469, 13);
            this.txtF4.Name = "txtF4";
            this.txtF4.Size = new System.Drawing.Size(27, 20);
            this.txtF4.TabIndex = 35;
            this.txtF4.Text = "F4";
            this.txtF4.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(402, 139);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 25);
            this.cmdCancel.TabIndex = 34;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(302, 139);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(94, 25);
            this.CmdSave.TabIndex = 33;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(76, 39);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(80, 20);
            this.txtCurrency.TabIndex = 32;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(162, 13);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(301, 20);
            this.txtDescription.TabIndex = 31;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(76, 13);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(80, 20);
            this.txtItem.TabIndex = 30;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(12, 42);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 37;
            this.lblCurrency.Text = "Currency";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(12, 16);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(35, 13);
            this.lblItem.TabIndex = 38;
            this.lblItem.Text = "Name";
            // 
            // lblBaseUnit
            // 
            this.lblBaseUnit.AutoSize = true;
            this.lblBaseUnit.Location = new System.Drawing.Point(205, 42);
            this.lblBaseUnit.Name = "lblBaseUnit";
            this.lblBaseUnit.Size = new System.Drawing.Size(53, 13);
            this.lblBaseUnit.TabIndex = 39;
            this.lblBaseUnit.Text = "Base Unit";
            // 
            // F4Currency
            // 
            this.F4Currency.Location = new System.Drawing.Point(162, 38);
            this.F4Currency.Name = "F4Currency";
            this.F4Currency.Size = new System.Drawing.Size(27, 20);
            this.F4Currency.TabIndex = 40;
            this.F4Currency.Text = "F4";
            this.F4Currency.UseVisualStyleBackColor = true;
            // 
            // F4BaseUnit
            // 
            this.F4BaseUnit.Location = new System.Drawing.Point(355, 39);
            this.F4BaseUnit.Name = "F4BaseUnit";
            this.F4BaseUnit.Size = new System.Drawing.Size(27, 20);
            this.F4BaseUnit.TabIndex = 41;
            this.F4BaseUnit.Text = "F4";
            this.F4BaseUnit.UseVisualStyleBackColor = true;
            // 
            // lblPVP1
            // 
            this.lblPVP1.AutoSize = true;
            this.lblPVP1.Location = new System.Drawing.Point(12, 67);
            this.lblPVP1.Name = "lblPVP1";
            this.lblPVP1.Size = new System.Drawing.Size(34, 13);
            this.lblPVP1.TabIndex = 43;
            this.lblPVP1.Text = "PVP1";
            // 
            // txtPVP1
            // 
            this.txtPVP1.Location = new System.Drawing.Point(76, 65);
            this.txtPVP1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPVP1.Name = "txtPVP1";
            this.txtPVP1.Size = new System.Drawing.Size(80, 20);
            this.txtPVP1.TabIndex = 44;
            this.txtPVP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 20);
            this.button1.TabIndex = 46;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(76, 91);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(273, 20);
            this.txtImage.TabIndex = 45;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(13, 94);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(36, 13);
            this.lblImage.TabIndex = 47;
            this.lblImage.Text = "Image";
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 178);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtPVP1);
            this.Controls.Add(this.lblPVP1);
            this.Controls.Add(this.F4BaseUnit);
            this.Controls.Add(this.F4Currency);
            this.Controls.Add(this.lblBaseUnit);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtBaseUnit);
            this.Controls.Add(this.txtF4);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtItem);
            this.Name = "frmItem";
            this.Text = "Itens";
            ((System.ComponentModel.ISupportInitialize)(this.txtPVP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtBaseUnit;
        private System.Windows.Forms.Button txtF4;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button CmdSave;
        public System.Windows.Forms.TextBox txtCurrency;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblBaseUnit;
        private System.Windows.Forms.Button F4Currency;
        private System.Windows.Forms.Button F4BaseUnit;
        private System.Windows.Forms.Label lblPVP1;
        private System.Windows.Forms.NumericUpDown txtPVP1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lblImage;
    }
}