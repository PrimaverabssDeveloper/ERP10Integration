
namespace Primavera.Construction.Tender
{
    partial class frmTender
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
            this.cbOnlyDescription = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContractRegimeDesc = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblContractRegime = new System.Windows.Forms.Label();
            this.txtContractRegime = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbOnlyDescription
            // 
            this.cbOnlyDescription.AutoSize = true;
            this.cbOnlyDescription.Enabled = false;
            this.cbOnlyDescription.Location = new System.Drawing.Point(9, 173);
            this.cbOnlyDescription.Name = "cbOnlyDescription";
            this.cbOnlyDescription.Size = new System.Drawing.Size(121, 17);
            this.cbOnlyDescription.TabIndex = 9;
            this.cbOnlyDescription.Text = "Only edit description";
            this.cbOnlyDescription.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(361, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(261, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtContractRegimeDesc
            // 
            this.txtContractRegimeDesc.Enabled = false;
            this.txtContractRegimeDesc.Location = new System.Drawing.Point(183, 88);
            this.txtContractRegimeDesc.Name = "txtContractRegimeDesc";
            this.txtContractRegimeDesc.Size = new System.Drawing.Size(272, 20);
            this.txtContractRegimeDesc.TabIndex = 8;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "O",
            "C",
            "S"});
            this.cmbType.Location = new System.Drawing.Point(117, 61);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(120, 21);
            this.cmbType.TabIndex = 5;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.CmbType_SelectedIndexChanged);
            // 
            // lblContractRegime
            // 
            this.lblContractRegime.AutoSize = true;
            this.lblContractRegime.Location = new System.Drawing.Point(9, 91);
            this.lblContractRegime.Name = "lblContractRegime";
            this.lblContractRegime.Size = new System.Drawing.Size(86, 13);
            this.lblContractRegime.TabIndex = 6;
            this.lblContractRegime.Text = "Contract Regime";
            // 
            // txtContractRegime
            // 
            this.txtContractRegime.Location = new System.Drawing.Point(117, 88);
            this.txtContractRegime.Name = "txtContractRegime";
            this.txtContractRegime.Size = new System.Drawing.Size(60, 20);
            this.txtContractRegime.TabIndex = 7;
            this.txtContractRegime.Validated += new System.EventHandler(this.TxtContractRegime_Validated);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(9, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 38);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(117, 35);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(338, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(9, 12);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(117, 9);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(120, 20);
            this.txtCode.TabIndex = 1;
            this.txtCode.Validated += new System.EventHandler(this.TxtCode_Validated);
            // 
            // frmTender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 201);
            this.Controls.Add(this.cbOnlyDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContractRegimeDesc);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblContractRegime);
            this.Controls.Add(this.txtContractRegime);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTender";
            this.Text = "Construction Tender Sample";
            this.Load += new System.EventHandler(this.FrmTender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbOnlyDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtContractRegimeDesc;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblContractRegime;
        private System.Windows.Forms.TextBox txtContractRegime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
    }
}