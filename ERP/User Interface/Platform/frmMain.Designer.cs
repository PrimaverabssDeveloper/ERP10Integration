namespace Primavera.Erp.Sample
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emplooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesInvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesInvoiceReversalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invetárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReservationOrigemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReservationDestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primaveraAccountingDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.invetárioToolStripMenuItem,
            this.internosToolStripMenuItem,
            this.contabilidadeToolStripMenuItem,
            this.recursosHumanosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem1,
            this.loginToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem1.Text = "Login";
            this.loginToolStripMenuItem1.Click += new System.EventHandler(this.loginToolStripMenuItem1_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Exit";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emplooToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.itemToolStripMenuItem});
            this.sistemaToolStripMenuItem.Enabled = false;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.sistemaToolStripMenuItem.Text = "Tables";
            // 
            // emplooToolStripMenuItem
            // 
            this.emplooToolStripMenuItem.Name = "emplooToolStripMenuItem";
            this.emplooToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emplooToolStripMenuItem.Text = "Employee";
            this.emplooToolStripMenuItem.Click += new System.EventHandler(this.EmployeeMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesInvToolStripMenuItem,
            this.salesInvoiceReversalToolStripMenuItem});
            this.vendasToolStripMenuItem.Enabled = false;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.vendasToolStripMenuItem.Text = "Sales";
            // 
            // salesInvToolStripMenuItem
            // 
            this.salesInvToolStripMenuItem.Name = "salesInvToolStripMenuItem";
            this.salesInvToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.salesInvToolStripMenuItem.Text = "Sales Invoice";
            this.salesInvToolStripMenuItem.Click += new System.EventHandler(this.salesInvoiceMenuItem_Click);
            // 
            // salesInvoiceReversalToolStripMenuItem
            // 
            this.salesInvoiceReversalToolStripMenuItem.Name = "salesInvoiceReversalToolStripMenuItem";
            this.salesInvoiceReversalToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.salesInvoiceReversalToolStripMenuItem.Text = "Sales Invoice Reversal";
            this.salesInvoiceReversalToolStripMenuItem.Click += new System.EventHandler(this.salesInvoiceReversaMenuItem_Click);
            // 
            // invetárioToolStripMenuItem
            // 
            this.invetárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockReservationOrigemToolStripMenuItem,
            this.stockReservationDestToolStripMenuItem,
            this.stockTransferToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.compositionToolStripMenuItem});
            this.invetárioToolStripMenuItem.Enabled = false;
            this.invetárioToolStripMenuItem.Name = "invetárioToolStripMenuItem";
            this.invetárioToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.invetárioToolStripMenuItem.Text = "Inventory";
            // 
            // stockReservationOrigemToolStripMenuItem
            // 
            this.stockReservationOrigemToolStripMenuItem.Name = "stockReservationOrigemToolStripMenuItem";
            this.stockReservationOrigemToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.stockReservationOrigemToolStripMenuItem.Text = "Stock Reservation (Source)";
            this.stockReservationOrigemToolStripMenuItem.Click += new System.EventHandler(this.stockReservationOrigemMenuItem_Click);
            // 
            // stockReservationDestToolStripMenuItem
            // 
            this.stockReservationDestToolStripMenuItem.Name = "stockReservationDestToolStripMenuItem";
            this.stockReservationDestToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.stockReservationDestToolStripMenuItem.Text = "Stock Reservation (Destination)";
            this.stockReservationDestToolStripMenuItem.Click += new System.EventHandler(this.stockReservationDestMenuItem_Click);
            // 
            // stockTransferToolStripMenuItem
            // 
            this.stockTransferToolStripMenuItem.Name = "stockTransferToolStripMenuItem";
            this.stockTransferToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.stockTransferToolStripMenuItem.Text = "Stock Transfer";
            this.stockTransferToolStripMenuItem.Click += new System.EventHandler(this.stockTransferMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.inventoryToolStripMenuItem.Text = "Stock Document";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryMenuItem_Click);
            // 
            // compositionToolStripMenuItem
            // 
            this.compositionToolStripMenuItem.Name = "compositionToolStripMenuItem";
            this.compositionToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.compositionToolStripMenuItem.Text = "Compositions/Breakdowns";
            this.compositionToolStripMenuItem.Click += new System.EventHandler(this.compositionMenuItem_Click);
            // 
            // internosToolStripMenuItem
            // 
            this.internosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentToolStripMenuItem});
            this.internosToolStripMenuItem.Enabled = false;
            this.internosToolStripMenuItem.Name = "internosToolStripMenuItem";
            this.internosToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.internosToolStripMenuItem.Text = "Internal";
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.documentToolStripMenuItem.Text = "Document";
            this.documentToolStripMenuItem.Click += new System.EventHandler(this.documentToolStripMenuItem_Click);
            // 
            // contabilidadeToolStripMenuItem
            // 
            this.contabilidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primaveraAccountingDocumentsToolStripMenuItem});
            this.contabilidadeToolStripMenuItem.Enabled = false;
            this.contabilidadeToolStripMenuItem.Name = "contabilidadeToolStripMenuItem";
            this.contabilidadeToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.contabilidadeToolStripMenuItem.Text = "Accounting";
            // 
            // primaveraAccountingDocumentsToolStripMenuItem
            // 
            this.primaveraAccountingDocumentsToolStripMenuItem.Name = "primaveraAccountingDocumentsToolStripMenuItem";
            this.primaveraAccountingDocumentsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.primaveraAccountingDocumentsToolStripMenuItem.Text = "Documents";
            this.primaveraAccountingDocumentsToolStripMenuItem.Click += new System.EventHandler(this.primaveraAccountingDocuments_MenuItemClick);
            // 
            // recursosHumanosToolStripMenuItem
            // 
            this.recursosHumanosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyChangesToolStripMenuItem,
            this.payrollToolStripMenuItem});
            this.recursosHumanosToolStripMenuItem.Enabled = false;
            this.recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            this.recursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.recursosHumanosToolStripMenuItem.Text = "Human Resources";
            // 
            // monthlyChangesToolStripMenuItem
            // 
            this.monthlyChangesToolStripMenuItem.Name = "monthlyChangesToolStripMenuItem";
            this.monthlyChangesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.monthlyChangesToolStripMenuItem.Text = "Monthly Changes";
            this.monthlyChangesToolStripMenuItem.Click += new System.EventHandler(this.monthlyChangesMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.payrollToolStripMenuItem.Text = "Payroll";
            this.payrollToolStripMenuItem.Click += new System.EventHandler(this.payrollMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1189, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemToolStripMenuItem.Text = "Item";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 669);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Primavera Erp Sample";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invetárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesInvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesInvoiceReversalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReservationOrigemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReservationDestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emplooToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primaveraAccountingDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
    }
}