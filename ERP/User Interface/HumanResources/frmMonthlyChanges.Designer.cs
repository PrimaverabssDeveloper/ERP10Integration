namespace Primavera.HumanResources
{
    partial class frmMonthlyChanges
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
            this.txtAbsence = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAbsence = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.chkExcludeProc = new System.Windows.Forms.CheckBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.chkExcludeStatistics = new System.Windows.Forms.CheckBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.nupDuration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(411, 140);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 14;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(330, 140);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 13;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtAbsence
            // 
            this.txtAbsence.Location = new System.Drawing.Point(103, 36);
            this.txtAbsence.Name = "txtAbsence";
            this.txtAbsence.Size = new System.Drawing.Size(80, 20);
            this.txtAbsence.TabIndex = 4;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(9, 91);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(50, 13);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "Duration:";
            // 
            // lblAbsence
            // 
            this.lblAbsence.AutoSize = true;
            this.lblAbsence.Location = new System.Drawing.Point(9, 39);
            this.lblAbsence.Name = "lblAbsence";
            this.lblAbsence.Size = new System.Drawing.Size(52, 13);
            this.lblAbsence.TabIndex = 3;
            this.lblAbsence.Text = "Absence:";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(103, 10);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(80, 20);
            this.txtEmployee.TabIndex = 1;
            this.txtEmployee.Validated += new System.EventHandler(this.TxtEmployee_Validated);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(9, 13);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(56, 13);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee:";
            // 
            // chkExcludeProc
            // 
            this.chkExcludeProc.AutoSize = true;
            this.chkExcludeProc.Location = new System.Drawing.Point(190, 38);
            this.chkExcludeProc.Name = "chkExcludeProc";
            this.chkExcludeProc.Size = new System.Drawing.Size(92, 17);
            this.chkExcludeProc.TabIndex = 5;
            this.chkExcludeProc.Text = "Exclude Proc.";
            this.chkExcludeProc.UseVisualStyleBackColor = true;
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(103, 62);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(80, 20);
            this.dtDate.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(9, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            // 
            // chkExcludeStatistics
            // 
            this.chkExcludeStatistics.AutoSize = true;
            this.chkExcludeStatistics.Location = new System.Drawing.Point(330, 38);
            this.chkExcludeStatistics.Name = "chkExcludeStatistics";
            this.chkExcludeStatistics.Size = new System.Drawing.Size(112, 17);
            this.chkExcludeStatistics.TabIndex = 6;
            this.chkExcludeStatistics.Text = "Exclude Statistics.";
            this.chkExcludeStatistics.UseVisualStyleBackColor = true;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(9, 118);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(52, 13);
            this.lblRemarks.TabIndex = 11;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(103, 114);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(383, 20);
            this.txtRemarks.TabIndex = 12;
            // 
            // nupDuration
            // 
            this.nupDuration.DecimalPlaces = 2;
            this.nupDuration.Location = new System.Drawing.Point(103, 88);
            this.nupDuration.Name = "nupDuration";
            this.nupDuration.Size = new System.Drawing.Size(80, 20);
            this.nupDuration.TabIndex = 15;
            this.nupDuration.ThousandsSeparator = true;
            // 
            // frmMonthlyChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 168);
            this.Controls.Add(this.nupDuration);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.chkExcludeStatistics);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.chkExcludeProc);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.txtAbsence);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblAbsence);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Name = "frmMonthlyChanges";
            this.Text = "Monthly Changes";
            ((System.ComponentModel.ISupportInitialize)(this.nupDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtAbsence;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAbsence;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.CheckBox chkExcludeProc;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox chkExcludeStatistics;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.NumericUpDown nupDuration;
    }
}