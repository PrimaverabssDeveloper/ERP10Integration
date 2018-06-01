namespace Primavera.BaseEntities
{
    partial class frmPartyBase
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
            this.txtAdress2 = new System.Windows.Forms.TextBox();
            this.txtF4 = new System.Windows.Forms.Button();
            this.listViewCDU = new System.Windows.Forms.ListView();
            this.lblUserFields = new System.Windows.Forms.Label();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdress2
            // 
            this.txtAdress2.Location = new System.Drawing.Point(74, 63);
            this.txtAdress2.Name = "txtAdress2";
            this.txtAdress2.Size = new System.Drawing.Size(420, 20);
            this.txtAdress2.TabIndex = 29;
            // 
            // txtF4
            // 
            this.txtF4.Location = new System.Drawing.Point(467, 11);
            this.txtF4.Name = "txtF4";
            this.txtF4.Size = new System.Drawing.Size(27, 20);
            this.txtF4.TabIndex = 28;
            this.txtF4.Text = "F4";
            this.txtF4.UseVisualStyleBackColor = true;
            this.txtF4.Click += new System.EventHandler(this.txtF4_Click);
            // 
            // listViewCDU
            // 
            this.listViewCDU.Location = new System.Drawing.Point(74, 170);
            this.listViewCDU.Name = "listViewCDU";
            this.listViewCDU.Size = new System.Drawing.Size(420, 88);
            this.listViewCDU.TabIndex = 27;
            this.listViewCDU.UseCompatibleStateImageBehavior = false;
            // 
            // lblUserFields
            // 
            this.lblUserFields.AutoSize = true;
            this.lblUserFields.Location = new System.Drawing.Point(8, 168);
            this.lblUserFields.Name = "lblUserFields";
            this.lblUserFields.Size = new System.Drawing.Size(56, 13);
            this.lblUserFields.TabIndex = 22;
            this.lblUserFields.Text = "User fields";
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Location = new System.Drawing.Point(74, 147);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(80, 17);
            this.chkEdit.TabIndex = 24;
            this.chkEdit.Text = "Edit Mode?";
            this.chkEdit.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(400, 267);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 25);
            this.cmdCancel.TabIndex = 26;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(300, 267);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(94, 25);
            this.CmdSave.TabIndex = 25;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(74, 37);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(420, 20);
            this.txtAdress.TabIndex = 20;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(8, 40);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 14;
            this.lblAdress.Text = "Adress";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(74, 119);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(132, 20);
            this.txtNif.TabIndex = 23;
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(8, 122);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(24, 13);
            this.lblNif.TabIndex = 15;
            this.lblNif.Text = "NIF";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(74, 93);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(132, 20);
            this.txtphone.TabIndex = 21;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(8, 96);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(160, 11);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(301, 20);
            this.TxtDescription.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(80, 20);
            this.txtName.TabIndex = 18;
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // frmPartyBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 300);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPartyBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PartyBase";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPartyBase_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button txtF4;
        private System.Windows.Forms.Label lblUserFields;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtAdress2;
        public System.Windows.Forms.ListView listViewCDU;
        public System.Windows.Forms.CheckBox chkEdit;
        public System.Windows.Forms.TextBox txtAdress;
        public System.Windows.Forms.TextBox txtNif;
        public System.Windows.Forms.TextBox txtphone;
        public System.Windows.Forms.TextBox TxtDescription;
    }
}

