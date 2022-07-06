using System;
using System.Text;
using System.Windows.Forms;
using Primavera.Accounting.Documents;
using Primavera.BaseEntities;
using Primavera.HumanResources;
using Primavera.Internal.Documents;
using Primavera.Inventory;
using Primavera.Sales.Invoice;

namespace Primavera.Erp.Sample
{
    public partial class frmMain : Form
    {
        #region public
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Sales

        private void salesInvoiceMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvoice createInvoice = new FrmInvoice();
            createInvoice.MdiParent = this;
            createInvoice.Show();
        }

        private void salesInvoiceReversaMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoiceReversal objCreateReveral = new frmInvoiceReversal();
            objCreateReveral.MdiParent = this;
            objCreateReveral.Show();
        }

        #endregion

        #region Inventory

        private void stockReservationDestMenuItem_Click(object sender, EventArgs e)
        {
            FrmReservaDestino frmReservaDestino = new FrmReservaDestino();
            frmReservaDestino.MdiParent = this;
            frmReservaDestino.Show();
        }

        private void stockReservationOrigemMenuItem_Click(object sender, EventArgs e)
        {
            FrmReservaOrigem frmReservaOrigem = new FrmReservaOrigem();
            frmReservaOrigem.MdiParent = this;
            frmReservaOrigem.Show();
        }

        private void stockTransferMenuItem_Click(object sender, EventArgs e)
        {
            StockTransfersForm stockTransfersForm = new StockTransfersForm();
            stockTransfersForm.MdiParent = this;
            stockTransfersForm.Show();
        }

        private void inventoryMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.MdiParent = this;
            inventoryForm.Show();
        }

        private void compositionMenuItem_Click(object sender, EventArgs e)
        {
            CompositionsBreakdownsForm compositionsBreakdowns = new CompositionsBreakdownsForm();
            compositionsBreakdowns.MdiParent = this;
            compositionsBreakdowns.Show();
        }

        #endregion

        #region Internal

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocument objDocumento = new frmDocument();
            objDocumento.MdiParent = this;
            objDocumento.Show();
        }

        #endregion

        #region Base Entities

        private void EmployeeMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployee employee = new FrmEmployee();
            employee.MdiParent = this;
            employee.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.MdiParent = this;
            customer.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier supplier = new frmSupplier();
            supplier.MdiParent = this;
            supplier.Show();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem item = new frmItem();
            item.MdiParent = this;
            item.Show();
        }

        #endregion

        #region HumanResource

        private void payrollMenuItem_Click(object sender, EventArgs e)
        {
            frmPayroll Payroll = new frmPayroll();
            Payroll.MdiParent = this;
            Payroll.Show();
            frmPayroll payroll = new frmPayroll
            {
                MdiParent = this
            };
            payroll.Show();
        }

        private void monthlyChangesMenuItem_Click(object sender, EventArgs e)
        {
            frmMonthlyChanges MonthlyChanges = new frmMonthlyChanges();
            MonthlyChanges.MdiParent = this;
            MonthlyChanges.Show();
            frmMonthlyChanges monthlyChanges = new frmMonthlyChanges
            {
                MdiParent = this
            };
            monthlyChanges.Show();
        }

        private void registerContractLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSocialSecPlatBase socialSecPlatBase = new frmSocialSecPlatBase
            {
                MdiParent = this
            };
            socialSecPlatBase.Show();
        }
        #endregion

        #region Accounting

        private void primaveraAccountingDocuments_MenuItemClick(object sender, EventArgs e)
        {
            FrmAccountingDocument accountingDocument = new FrmAccountingDocument();
            accountingDocument.MdiParent = this;
            accountingDocument.Show();
        }

        #endregion

        #region Login
        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            login.Close();

            if (PriEngine.Platform != null)
            {
                StringBuilder status = new StringBuilder();

                status.Append("Company: " + PriEngine.Platform.Contexto.Empresa.CodEmp + " | ");
                status.Append("Company Name: " + PriEngine.Platform.Contexto.Empresa.IDNome + " | ");
                status.Append("Currency: " + PriEngine.Platform.Contexto.Empresa.MoedaBase);

                statusStrip1.Items[0].Text = status.ToString();

                foreach (ToolStripItem i in menuStrip1.Items)
                {
                    i.Enabled = true;
                }
            }

        }
        #endregion
    }
}
