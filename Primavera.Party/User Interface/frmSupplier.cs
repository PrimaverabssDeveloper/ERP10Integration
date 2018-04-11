using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BasBE100;
using StdBE100;

namespace Primavera.Party
{
    public partial class frmSupplier : Primavera.Party.frmPartyBase
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        public override void OnSave()
        {
            if (Convert.ToBoolean(PriEngine.Engine.Base.Fornecedores.NumeroContribuintesRepetidos(txtNif.Text)) && !chkEdit.Checked)
            {
                MessageBox.Show("Cannot continue because the NIF for the current entity already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BasBEFornecedor supplier = new BasBEFornecedor();

                supplier.Nome = TxtDescription.Text;
                supplier.Fornecedor = txtName.Text;
                supplier.Morada = txtAdress.Text;
                supplier.Morada2 = txtAdress2.Text;
                supplier.Telefone = txtphone.Text;
                supplier.NumContribuinte = txtNif.Text;
                supplier.Moeda = "EUR";

                // Check if entity already exist.
                // If exists them set this flag to true to tell the system to perform an update operation.
                supplier.EmModoEdicao = PriEngine.Engine.Base.Fornecedores.Existe(txtName.Text) ? true : false;

                try
                {
                    PriEngine.Engine.Base.Fornecedores.Actualiza(supplier);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to save client. \n" + ex.Message);
                }
            }

            base.OnSave();
        }

        public override void OnF4Custumer()
        {
            PriEngine.Platform.Listas.GetF4SQL("Supplier", "SELECT Fornecedor, Nome FROM FORNECEDORES ORDER BY fornecedor ASC", "Fornecedor", this, txtName);
            base.OnF4Custumer();
        }

        public override void OnValidateParty()
        {
            BasBEFornecedor supplier = new BasBEFornecedor();
            StringBuilder CamposUtil = new StringBuilder();
            List<string> row = new List<string>();

            listViewCDU.Clear();
            listViewCDU.View = View.Details;
            listViewCDU.HeaderStyle = ColumnHeaderStyle.Clickable;

            if (txtName.Text.Length != 0)
            {
                try
                {
                    if (PriEngine.Engine.Base.Fornecedores.Existe(txtName.Text))
                    {
                        supplier = PriEngine.Engine.Base.Fornecedores.Edita(txtName.Text);

                        txtName.Text = supplier.Fornecedor;
                        TxtDescription.Text = supplier.Nome;
                        txtAdress.Text = supplier.Morada;
                        txtAdress2.Text = supplier.Morada2;
                        txtphone.Text = supplier.Telefone;
                        txtNif.Text = supplier.NumContribuinte;

                        chkEdit.Checked = supplier.EmModoEdicao;

                        // load user fields
                        foreach (StdBECampo objCDU in supplier.CamposUtil)
                        {
                            ColumnHeader columnHeader = new ColumnHeader
                            {
                                Name = objCDU.Nome,
                                Text = objCDU.Nome,
                                Width = 100
                            };

                            listViewCDU.Columns.Add(columnHeader);

                            row.Add(Convert.ToString(objCDU.Valor));
                        }

                        ListViewItem listViewItem = new ListViewItem(row.ToArray());
                        listViewCDU.Items.Add(listViewItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("It was not possible to load the entity. \n" + ex.Message);
                }
            }

            base.OnValidateParty();
        }
    }
}
