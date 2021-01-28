namespace Primavera.BaseEntities
{
    partial class FrmEmployee
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
            this.SourcePaymentMethods = new System.Windows.Forms.BindingSource(this.components);
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtSocialSec = new System.Windows.Forms.TextBox();
            this.txtVacantions = new System.Windows.Forms.TextBox();
            this.txtWorkLocation = new System.Windows.Forms.TextBox();
            this.txtWorkPolicy = new System.Windows.Forms.TextBox();
            this.txtChristmas = new System.Windows.Forms.TextBox();
            this.txtIncomeType = new System.Windows.Forms.TextBox();
            this.txtSituation = new System.Windows.Forms.TextBox();
            this.lblSocialSec = new System.Windows.Forms.Label();
            this.lblIncomeTax = new System.Windows.Forms.Label();
            this.lblVacantions = new System.Windows.Forms.Label();
            this.lblChristmas = new System.Windows.Forms.Label();
            this.lblWorkLocation = new System.Windows.Forms.Label();
            this.lblWorkPolicy = new System.Windows.Forms.Label();
            this.lblSituation = new System.Windows.Forms.Label();
            this.dtHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.txtIncomeTax = new System.Windows.Forms.TextBox();
            this.lblIncomeType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtF4 = new System.Windows.Forms.Button();
            this.lblChristAlloMonth = new System.Windows.Forms.Label();
            this.lblVacationAlloMonth = new System.Windows.Forms.Label();
            this.cmbChristAlloMonth = new System.Windows.Forms.ComboBox();
            this.cmbVacationAlloMonth = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.SourcePaymentMethods)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourcePaymentMethods
            // 
            this.SourcePaymentMethods.DataSource = typeof(RhpBE100.RhpBEFormaPagamento);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(460, 219);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 28;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(379, 219);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 27;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtSocialSec
            // 
            this.txtSocialSec.Location = new System.Drawing.Point(97, 144);
            this.txtSocialSec.Name = "txtSocialSec";
            this.txtSocialSec.Size = new System.Drawing.Size(130, 20);
            this.txtSocialSec.TabIndex = 13;
            // 
            // txtVacantions
            // 
            this.txtVacantions.Location = new System.Drawing.Point(369, 117);
            this.txtVacantions.Name = "txtVacantions";
            this.txtVacantions.Size = new System.Drawing.Size(142, 20);
            this.txtVacantions.TabIndex = 21;
            // 
            // txtWorkLocation
            // 
            this.txtWorkLocation.Location = new System.Drawing.Point(97, 118);
            this.txtWorkLocation.Name = "txtWorkLocation";
            this.txtWorkLocation.Size = new System.Drawing.Size(130, 20);
            this.txtWorkLocation.TabIndex = 11;
            // 
            // txtWorkPolicy
            // 
            this.txtWorkPolicy.Location = new System.Drawing.Point(97, 92);
            this.txtWorkPolicy.Name = "txtWorkPolicy";
            this.txtWorkPolicy.Size = new System.Drawing.Size(130, 20);
            this.txtWorkPolicy.TabIndex = 9;
            // 
            // txtChristmas
            // 
            this.txtChristmas.Location = new System.Drawing.Point(369, 92);
            this.txtChristmas.Name = "txtChristmas";
            this.txtChristmas.Size = new System.Drawing.Size(142, 20);
            this.txtChristmas.TabIndex = 19;
            // 
            // txtIncomeType
            // 
            this.txtIncomeType.Location = new System.Drawing.Point(369, 66);
            this.txtIncomeType.Name = "txtIncomeType";
            this.txtIncomeType.Size = new System.Drawing.Size(142, 20);
            this.txtIncomeType.TabIndex = 17;
            // 
            // txtSituation
            // 
            this.txtSituation.Location = new System.Drawing.Point(97, 66);
            this.txtSituation.Name = "txtSituation";
            this.txtSituation.Size = new System.Drawing.Size(130, 20);
            this.txtSituation.TabIndex = 7;
            // 
            // lblSocialSec
            // 
            this.lblSocialSec.AutoSize = true;
            this.lblSocialSec.Location = new System.Drawing.Point(6, 147);
            this.lblSocialSec.Name = "lblSocialSec";
            this.lblSocialSec.Size = new System.Drawing.Size(64, 13);
            this.lblSocialSec.TabIndex = 12;
            this.lblSocialSec.Text = "Social Sec.:";
            // 
            // lblIncomeTax
            // 
            this.lblIncomeTax.AutoSize = true;
            this.lblIncomeTax.Location = new System.Drawing.Point(237, 42);
            this.lblIncomeTax.Name = "lblIncomeTax";
            this.lblIncomeTax.Size = new System.Drawing.Size(66, 13);
            this.lblIncomeTax.TabIndex = 14;
            this.lblIncomeTax.Text = "Income Tax:";
            // 
            // lblVacantions
            // 
            this.lblVacantions.AutoSize = true;
            this.lblVacantions.Location = new System.Drawing.Point(237, 120);
            this.lblVacantions.Name = "lblVacantions";
            this.lblVacantions.Size = new System.Drawing.Size(127, 13);
            this.lblVacantions.TabIndex = 20;
            this.lblVacantions.Text = "Vacation Allo. pay. meth.:";
            // 
            // lblChristmas
            // 
            this.lblChristmas.AutoSize = true;
            this.lblChristmas.Location = new System.Drawing.Point(237, 95);
            this.lblChristmas.Name = "lblChristmas";
            this.lblChristmas.Size = new System.Drawing.Size(130, 13);
            this.lblChristmas.TabIndex = 18;
            this.lblChristmas.Text = "Christmas Allo. pay. meth.:";
            // 
            // lblWorkLocation
            // 
            this.lblWorkLocation.AutoSize = true;
            this.lblWorkLocation.Location = new System.Drawing.Point(6, 120);
            this.lblWorkLocation.Name = "lblWorkLocation";
            this.lblWorkLocation.Size = new System.Drawing.Size(80, 13);
            this.lblWorkLocation.TabIndex = 10;
            this.lblWorkLocation.Text = "Work Location:";
            // 
            // lblWorkPolicy
            // 
            this.lblWorkPolicy.AutoSize = true;
            this.lblWorkPolicy.Location = new System.Drawing.Point(6, 94);
            this.lblWorkPolicy.Name = "lblWorkPolicy";
            this.lblWorkPolicy.Size = new System.Drawing.Size(67, 13);
            this.lblWorkPolicy.TabIndex = 8;
            this.lblWorkPolicy.Text = "Work Policy:";
            // 
            // lblSituation
            // 
            this.lblSituation.AutoSize = true;
            this.lblSituation.Location = new System.Drawing.Point(6, 69);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(51, 13);
            this.lblSituation.TabIndex = 6;
            this.lblSituation.Text = "Situation:";
            // 
            // dtHireDate
            // 
            this.dtHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHireDate.Location = new System.Drawing.Point(98, 40);
            this.dtHireDate.Name = "dtHireDate";
            this.dtHireDate.Size = new System.Drawing.Size(129, 20);
            this.dtHireDate.TabIndex = 5;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(6, 42);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(55, 13);
            this.lblHireDate.TabIndex = 4;
            this.lblHireDate.Text = "Hire Date:";
            // 
            // txtIncomeTax
            // 
            this.txtIncomeTax.Location = new System.Drawing.Point(369, 40);
            this.txtIncomeTax.Name = "txtIncomeTax";
            this.txtIncomeTax.Size = new System.Drawing.Size(142, 20);
            this.txtIncomeTax.TabIndex = 15;
            // 
            // lblIncomeType
            // 
            this.lblIncomeType.AutoSize = true;
            this.lblIncomeType.Location = new System.Drawing.Point(237, 69);
            this.lblIncomeType.Name = "lblIncomeType";
            this.lblIncomeType.Size = new System.Drawing.Size(72, 13);
            this.lblIncomeType.TabIndex = 16;
            this.lblIncomeType.Text = "Income Type:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(6, 16);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(56, 13);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Validated += new System.EventHandler(this.txtID_Validated);
            // 
            // txtF4
            // 
            this.txtF4.Location = new System.Drawing.Point(485, 13);
            this.txtF4.Name = "txtF4";
            this.txtF4.Size = new System.Drawing.Size(27, 20);
            this.txtF4.TabIndex = 3;
            this.txtF4.Text = "F4";
            this.txtF4.UseVisualStyleBackColor = true;
            this.txtF4.Click += new System.EventHandler(this.txtF4_Click);
            // 
            // lblChristAlloMonth
            // 
            this.lblChristAlloMonth.AutoSize = true;
            this.lblChristAlloMonth.Location = new System.Drawing.Point(237, 147);
            this.lblChristAlloMonth.Name = "lblChristAlloMonth";
            this.lblChristAlloMonth.Size = new System.Drawing.Size(114, 13);
            this.lblChristAlloMonth.TabIndex = 22;
            this.lblChristAlloMonth.Text = "Christmas Allo. Month: ";
            // 
            // lblVacationAlloMonth
            // 
            this.lblVacationAlloMonth.AutoSize = true;
            this.lblVacationAlloMonth.Location = new System.Drawing.Point(237, 173);
            this.lblVacationAlloMonth.Name = "lblVacationAlloMonth";
            this.lblVacationAlloMonth.Size = new System.Drawing.Size(111, 13);
            this.lblVacationAlloMonth.TabIndex = 24;
            this.lblVacationAlloMonth.Text = "Vacation Allo. Month: ";
            // 
            // cmbChristAlloMonth
            // 
            this.cmbChristAlloMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChristAlloMonth.FormattingEnabled = true;
            this.cmbChristAlloMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "November",
            "December"});
            this.cmbChristAlloMonth.Location = new System.Drawing.Point(369, 143);
            this.cmbChristAlloMonth.Name = "cmbChristAlloMonth";
            this.cmbChristAlloMonth.Size = new System.Drawing.Size(142, 21);
            this.cmbChristAlloMonth.TabIndex = 23;
            // 
            // cmbVacationAlloMonth
            // 
            this.cmbVacationAlloMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacationAlloMonth.FormattingEnabled = true;
            this.cmbVacationAlloMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "November",
            "December"});
            this.cmbVacationAlloMonth.Location = new System.Drawing.Point(369, 170);
            this.cmbVacationAlloMonth.Name = "cmbVacationAlloMonth";
            this.cmbVacationAlloMonth.Size = new System.Drawing.Size(142, 21);
            this.cmbVacationAlloMonth.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmployee);
            this.groupBox1.Controls.Add(this.cmbVacationAlloMonth);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cmbChristAlloMonth);
            this.groupBox1.Controls.Add(this.lblIncomeType);
            this.groupBox1.Controls.Add(this.lblVacationAlloMonth);
            this.groupBox1.Controls.Add(this.txtIncomeTax);
            this.groupBox1.Controls.Add(this.lblChristAlloMonth);
            this.groupBox1.Controls.Add(this.lblHireDate);
            this.groupBox1.Controls.Add(this.txtF4);
            this.groupBox1.Controls.Add(this.dtHireDate);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblSituation);
            this.groupBox1.Controls.Add(this.lblWorkPolicy);
            this.groupBox1.Controls.Add(this.lblWorkLocation);
            this.groupBox1.Controls.Add(this.txtSocialSec);
            this.groupBox1.Controls.Add(this.lblChristmas);
            this.groupBox1.Controls.Add(this.txtVacantions);
            this.groupBox1.Controls.Add(this.lblVacantions);
            this.groupBox1.Controls.Add(this.txtWorkLocation);
            this.groupBox1.Controls.Add(this.lblIncomeTax);
            this.groupBox1.Controls.Add(this.txtWorkPolicy);
            this.groupBox1.Controls.Add(this.lblSocialSec);
            this.groupBox1.Controls.Add(this.txtChristmas);
            this.groupBox1.Controls.Add(this.txtSituation);
            this.groupBox1.Controls.Add(this.txtIncomeType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 201);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 250);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.SourcePaymentMethods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtSocialSec;
        private System.Windows.Forms.TextBox txtVacantions;
        private System.Windows.Forms.TextBox txtWorkLocation;
        private System.Windows.Forms.TextBox txtWorkPolicy;
        private System.Windows.Forms.TextBox txtChristmas;
        private System.Windows.Forms.TextBox txtIncomeType;
        private System.Windows.Forms.TextBox txtSituation;
        private System.Windows.Forms.Label lblSocialSec;
        private System.Windows.Forms.Label lblIncomeTax;
        private System.Windows.Forms.Label lblVacantions;
        private System.Windows.Forms.Label lblChristmas;
        private System.Windows.Forms.Label lblWorkLocation;
        private System.Windows.Forms.Label lblWorkPolicy;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.DateTimePicker dtHireDate;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.TextBox txtIncomeTax;
        private System.Windows.Forms.Label lblIncomeType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button txtF4;
        private System.Windows.Forms.BindingSource SourcePaymentMethods;
        private System.Windows.Forms.Label lblChristAlloMonth;
        private System.Windows.Forms.Label lblVacationAlloMonth;
        private System.Windows.Forms.ComboBox cmbChristAlloMonth;
        private System.Windows.Forms.ComboBox cmbVacationAlloMonth;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}