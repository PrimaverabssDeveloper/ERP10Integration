namespace Primavera.Base.Party
{
    partial class FrmCustomer
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lblNif = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.lblUserFields = new System.Windows.Forms.Label();
            this.listViewCDU = new System.Windows.Forms.ListView();
            this.txtF4 = new System.Windows.Forms.Button();
            this.txtAdress2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(80, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(167, 14);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(301, 20);
            this.TxtDescription.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 99);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(81, 96);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(132, 20);
            this.txtphone.TabIndex = 5;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(15, 43);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 0;
            this.lblAdress.Text = "Adress";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(81, 40);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(420, 20);
            this.txtAdress.TabIndex = 4;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(307, 267);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(94, 25);
            this.CmdSave.TabIndex = 9;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(407, 267);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 25);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(15, 125);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(24, 13);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "NIF";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(81, 122);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(132, 20);
            this.txtNif.TabIndex = 6;
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Location = new System.Drawing.Point(81, 150);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(80, 17);
            this.chkEdit.TabIndex = 7;
            this.chkEdit.Text = "Edit Mode?";
            this.chkEdit.UseVisualStyleBackColor = true;
            // 
            // lblUserFields
            // 
            this.lblUserFields.AutoSize = true;
            this.lblUserFields.Location = new System.Drawing.Point(15, 171);
            this.lblUserFields.Name = "lblUserFields";
            this.lblUserFields.Size = new System.Drawing.Size(56, 13);
            this.lblUserFields.TabIndex = 6;
            this.lblUserFields.Text = "User fields";
            // 
            // listViewCDU
            // 
            this.listViewCDU.Location = new System.Drawing.Point(81, 173);
            this.listViewCDU.Name = "listViewCDU";
            this.listViewCDU.Size = new System.Drawing.Size(420, 88);
            this.listViewCDU.TabIndex = 11;
            this.listViewCDU.UseCompatibleStateImageBehavior = false;
            // 
            // txtF4
            // 
            this.txtF4.Location = new System.Drawing.Point(474, 14);
            this.txtF4.Name = "txtF4";
            this.txtF4.Size = new System.Drawing.Size(27, 20);
            this.txtF4.TabIndex = 12;
            this.txtF4.Text = "F4";
            this.txtF4.UseVisualStyleBackColor = true;
            this.txtF4.Click += new System.EventHandler(this.txtF4_Click);
            // 
            // txtAdress2
            // 
            this.txtAdress2.Location = new System.Drawing.Point(81, 66);
            this.txtAdress2.Name = "txtAdress2";
            this.txtAdress2.Size = new System.Drawing.Size(420, 20);
            this.txtAdress2.TabIndex = 13;
            // 
            // FrmCustomer
            // 
            this.AcceptButton = this.CmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(516, 299);
            this.Controls.Add(this.txtAdress2);
            this.Controls.Add(this.txtF4);
            this.Controls.Add(this.listViewCDU);
            this.Controls.Add(this.lblUserFields);
            this.Controls.Add(this.chkEdit);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.Label lblUserFields;
        private System.Windows.Forms.ListView listViewCDU;
        private System.Windows.Forms.Button txtF4;
        private System.Windows.Forms.TextBox txtAdress2;
    }
}