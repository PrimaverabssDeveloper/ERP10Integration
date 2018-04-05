using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BasBE100;
using StdBE100;

namespace Primavera.Base.Party
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a new customer on the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdSave_Click(object sender, EventArgs e)
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
        }

        /// <summary>
        /// Load the entity data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Validated(object sender, EventArgs e)
        {
            BasBECliente customer = new BasBECliente();
            StringBuilder CamposUtil= new StringBuilder();
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
                            ColumnHeader columnHeader =  new ColumnHeader
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
                catch(Exception ex)
                {
                    MessageBox.Show("It was not possible to load the entity. \n" + ex.Message);    
                }
            }

        }

        /// <summary>
        /// Close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Create a list of customers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtF4_Click(object sender, EventArgs e)
        {
            PriEngine.Platform.Listas.GetF4SQL("Customer", "SELECT Cliente, Nome FROM CLIENTES ORDER BY cliente ASC", "Cliente",this,txtName);
        }
    }
}