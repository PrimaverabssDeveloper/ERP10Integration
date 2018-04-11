using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BasBE100;
using StdBE100;

namespace Primavera.Party
{
    public partial class frmCustomer : Primavera.Party.frmPartyBase
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        public override void OnSave()
        {
            if (Convert.ToBoolean(PriEngine.Engine.Base.Clientes.NumeroContribuintesRepetidos(txtNif.Text)) && !chkEdit.Checked)
            {
                MessageBox.Show("Cannot continue because the NIF for the current entity already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BasBECliente customer = new BasBECliente();

                customer.Nome = TxtDescription.Text;
                customer.Cliente = txtName.Text;
                customer.Morada = txtAdress.Text;
                customer.Morada2 = txtAdress2.Text;
                customer.Telefone = txtphone.Text;
                customer.NumContribuinte = txtNif.Text;
                customer.Moeda = "EUR";

                // Check if entity already exist.
                // If exists them set this flag to true to tell the system to perform an update operation.
                customer.EmModoEdicao = PriEngine.Engine.Base.Clientes.Existe(txtName.Text) ? true : false;

                try
                {
                    PriEngine.Engine.Base.Clientes.Actualiza(customer);
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
            PriEngine.Platform.Listas.GetF4SQL("Customer", "SELECT Cliente, Nome FROM CLIENTES ORDER BY cliente ASC", "Cliente", this, txtName);
            base.OnF4Custumer();
        }

        public override void OnValidateParty()
        {
            BasBECliente customer = new BasBECliente();
            StringBuilder CamposUtil = new StringBuilder();
            List<string> row = new List<string>();

            listViewCDU.Clear();
            listViewCDU.View = View.Details;
            listViewCDU.HeaderStyle = ColumnHeaderStyle.Clickable;

            if (txtName.Text.Length != 0)
            {
                try
                {
                    if (PriEngine.Engine.Base.Clientes.Existe(txtName.Text))
                    {
                        customer = PriEngine.Engine.Base.Clientes.Edita(txtName.Text);

                        txtName.Text = customer.Cliente;
                        TxtDescription.Text = customer.Nome;
                        txtAdress.Text = customer.Morada;
                        txtAdress2.Text = customer.Morada2;
                        txtphone.Text = customer.Telefone;
                        txtNif.Text = customer.NumContribuinte;

                        chkEdit.Checked = customer.EmModoEdicao;

                        // load user fields
                        foreach (StdBECampo objCDU in customer.CamposUtil)
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
