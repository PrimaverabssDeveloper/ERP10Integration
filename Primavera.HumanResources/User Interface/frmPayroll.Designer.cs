namespace Primavera.Base.Party
{
    partial class frmPayroll
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblProcDate = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.dtProcDate = new System.Windows.Forms.DateTimePicker();
            this.dtAbsOvertime = new System.Windows.Forms.DateTimePicker();
            this.lblAbsOvertime = new System.Windows.Forms.Label();
            this.lblProcType = new System.Windows.Forms.Label();
            this.cmbProcType = new System.Windows.Forms.ComboBox();
            this.grpProcessingData = new System.Windows.Forms.GroupBox();
            this.chkPayslips = new System.Windows.Forms.CheckBox();
            this.chkSocialSecurity = new System.Windows.Forms.CheckBox();
            this.grpProcessingData.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(437, 170);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(356, 170);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblProcDate
            // 
            this.lblProcDate.AutoSize = true;
            this.lblProcDate.Location = new System.Drawing.Point(7, 79);
            this.lblProcDate.Name = "lblProcDate";
            this.lblProcDate.Size = new System.Drawing.Size(88, 13);
            this.lblProcDate.TabIndex = 6;
            this.lblProcDate.Text = "Processing Date:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(6, 26);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(101, 23);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(95, 20);
            this.txtEmployeeID.TabIndex = 1;
            this.txtEmployeeID.Validated += new System.EventHandler(this.txtEmployeeID_Validated);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(202, 23);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(290, 20);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // dtProcDate
            // 
            this.dtProcDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProcDate.Location = new System.Drawing.Point(101, 76);
            this.dtProcDate.Name = "dtProcDate";
            this.dtProcDate.Size = new System.Drawing.Size(95, 20);
            this.dtProcDate.TabIndex = 7;
            // 
            // dtAbsOvertime
            // 
            this.dtAbsOvertime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAbsOvertime.Location = new System.Drawing.Point(100, 101);
            this.dtAbsOvertime.Name = "dtAbsOvertime";
            this.dtAbsOvertime.Size = new System.Drawing.Size(95, 20);
            this.dtAbsOvertime.TabIndex = 9;
            // 
            // lblAbsOvertime
            // 
            this.lblAbsOvertime.AutoSize = true;
            this.lblAbsOvertime.Location = new System.Drawing.Point(7, 104);
            this.lblAbsOvertime.Name = "lblAbsOvertime";
            this.lblAbsOvertime.Size = new System.Drawing.Size(81, 13);
            this.lblAbsOvertime.TabIndex = 8;
            this.lblAbsOvertime.Text = "Absen/Overtim:";
            // 
            // lblProcType
            // 
            this.lblProcType.AutoSize = true;
            this.lblProcType.Location = new System.Drawing.Point(6, 53);
            this.lblProcType.Name = "lblProcType";
            this.lblProcType.Size = new System.Drawing.Size(89, 13);
            this.lblProcType.TabIndex = 3;
            this.lblProcType.Text = "Processing Type:";
            // 
            // cmbProcType
            // 
            this.cmbProcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcType.FormattingEnabled = true;
            this.cmbProcType.Items.AddRange(new object[] {
            "Salary",
            "Vacation Allowance",
            "Christmas Allowance",
            "End of contract",
            "Extras"});
            this.cmbProcType.Location = new System.Drawing.Point(101, 49);
            this.cmbProcType.Name = "cmbProcType";
            this.cmbProcType.Size = new System.Drawing.Size(95, 21);
            this.cmbProcType.TabIndex = 4;
            // 
            // grpProcessingData
            // 
            this.grpProcessingData.Controls.Add(this.chkSocialSecurity);
            this.grpProcessingData.Controls.Add(this.chkPayslips);
            this.grpProcessingData.Controls.Add(this.lblEmployee);
            this.grpProcessingData.Controls.Add(this.cmbProcType);
            this.grpProcessingData.Controls.Add(this.lblProcDate);
            this.grpProcessingData.Controls.Add(this.lblProcType);
            this.grpProcessingData.Controls.Add(this.txtEmployeeName);
            this.grpProcessingData.Controls.Add(this.dtAbsOvertime);
            this.grpProcessingData.Controls.Add(this.txtEmployeeID);
            this.grpProcessingData.Controls.Add(this.lblAbsOvertime);
            this.grpProcessingData.Controls.Add(this.dtProcDate);
            this.grpProcessingData.Location = new System.Drawing.Point(12, 12);
            this.grpProcessingData.Name = "grpProcessingData";
            this.grpProcessingData.Size = new System.Drawing.Size(500, 152);
            this.grpProcessingData.TabIndex = 0;
            this.grpProcessingData.TabStop = false;
            this.grpProcessingData.Text = "Processing Data";
            // 
            // chkPayslips
            // 
            this.chkPayslips.AutoSize = true;
            this.chkPayslips.Location = new System.Drawing.Point(9, 129);
            this.chkPayslips.Name = "chkPayslips";
            this.chkPayslips.Size = new System.Drawing.Size(105, 17);
            this.chkPayslips.TabIndex = 5;
            this.chkPayslips.Text = "Process Payslips";
            this.chkPayslips.UseVisualStyleBackColor = true;
            // 
            // chkSocialSecurity
            // 
            this.chkSocialSecurity.AutoSize = true;
            this.chkSocialSecurity.Location = new System.Drawing.Point(140, 129);
            this.chkSocialSecurity.Name = "chkSocialSecurity";
            this.chkSocialSecurity.Size = new System.Drawing.Size(137, 17);
            this.chkSocialSecurity.TabIndex = 10;
            this.chkSocialSecurity.Text = "Process Social Security";
            this.chkSocialSecurity.UseVisualStyleBackColor = true;
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 202);
            this.Controls.Add(this.grpProcessingData);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payroll";
            this.grpProcessingData.ResumeLayout(false);
            this.grpProcessingData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label lblProcDate;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.DateTimePicker dtProcDate;
        private System.Windows.Forms.DateTimePicker dtAbsOvertime;
        private System.Windows.Forms.Label lblAbsOvertime;
        private System.Windows.Forms.Label lblProcType;
        private System.Windows.Forms.ComboBox cmbProcType;
        private System.Windows.Forms.GroupBox grpProcessingData;
        private System.Windows.Forms.CheckBox chkPayslips;
        private System.Windows.Forms.CheckBox chkSocialSecurity;
    }
}