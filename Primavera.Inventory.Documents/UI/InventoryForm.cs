using InvBE100;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static StdPlatBS100.StdBSTipos;
using System.Linq;

namespace Primavera.Inventory.Documents
{
    public partial class InventoryForm : Form
    {
        class Lines
        {
            // public int Index { get; set; }
            public InvBELinhaInventario InventoryLines { get; set; }
        }

        List<Lines> lines;
        public InventoryForm()
        {
            InitializeComponent();
            inventoryTextBox.Text = PriEngine.Platform.Utils.FStr(SuggestNumber());
        }

        /// <summary>
        /// Suggest inventory number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int SuggestNumber()
        {
            string strSQL = "";
            strSQL = strSQL + "SELECT  NumDoc = ISNULL(MAX(I.NumDoc) + 1, (YEAR(GETDATE()) * 1000000) + 1)" + Environment.NewLine;
            strSQL = strSQL + "FROM    INV_CabecInventarios I" + Environment.NewLine;
            strSQL = strSQL + "WHERE   YEAR(I.[DataDoc]) = YEAR(GETDATE())" + Environment.NewLine;
            long docNumber = PriEngine.Platform.Utils.FInt(PriEngine.Engine.Consulta(strSQL).Valor("NumDoc"));
            if (((int)docNumber) < 1000000)
            {
                //UPGRADE_WARNING: (6021) Casting 'int' to Enum may cause different behaviour. More Information: http://www.vbtonet.com/ewis/ewi6021.aspx
                docNumber = (long)(DateTime.Today.Year * 1000000 + 1);
            }
            return (int)docNumber;
        }


        /// <summary>
        /// Validate warehouse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void warehouseTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.Armazens.Existe(warehouseTextBox.Text) && warehouseTextBox.Text.Length > 0)
            {
                ShowMessage("The warehouse doesn't exist.");
                warehouseTextBox.Clear();
                warehouseTextBox.Focus();
            }
            else warehouseDescriptionTextBox.Text = (string)PriEngine.Engine.Inventario.Armazens.DaValorAtributo(warehouseTextBox.Text, "Descricao");
        }

        /// <summary>
        /// Validate item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Artigos.Existe(itemTextBox.Text) && itemTextBox.Text.Length > 0)
            {
                ShowMessage("The item doesn't exist.");
                itemTextBox.Clear();
                itemTextBox.Focus();
                itemDescriptionTextBox.Text = string.Empty;
            }
            else itemDescriptionTextBox.Text = (string)PriEngine.Engine.Base.Artigos.DaValorAtributo(itemTextBox.Text, "Descricao");
        }

        /// <summary>
        /// Validate Location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locationTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.ArmazemLocalizacao.Existe(locationTextBox.Text) && locationTextBox.Text.Length > 0)
            {
                ShowMessage("The Location doesn't exist.");
                locationTextBox.Clear();
                locationTextBox.Focus();
            }
        }

        /// <summary>
        /// Add lines to the list view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (PriEngine.Engine.Base.Artigos.Existe(itemTextBox.Text))
            {
                //Add row to the Listiew
                string[] row = { itemTextBox.Text, locationTextBox.Text, quantityNumericUpDown.Value.ToString(), priceNumericUpDown.Value.ToString() };
                var listViewItem = new ListViewItem(row);
                documentLinesListView.Items.Add(listViewItem);

                if (lines == null)
                    lines = new List<Lines>();
                lines.Add(new Lines()
                {
                    InventoryLines = new InvBELinhaInventario()
                    {
                        ID = Guid.NewGuid().ToString(),
                        Artigo = itemTextBox.Text,
                        Localizacao = locationTextBox.Text,
                        QtdOriginal = (double)quantityNumericUpDown.Value,
                        PrecoCusto = (double)priceNumericUpDown.Value,
                        Unidade = unityTextBox.Text
                    },
                });

                itemTextBox.Clear();
                itemDescriptionTextBox.Clear();
                locationTextBox.Clear();
            }
            else
            {
                ShowMessage("The selected item doesn't exist.");

                itemTextBox.Clear();
                itemTextBox.Focus();
            }
        }

        /// <summary>
        /// Creates an inventory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            InvBEInventario objInventory = new InvBEInventario()
            {
                ID = Guid.NewGuid().ToString(),
                NumDoc = Int32.Parse(inventoryTextBox.Text),
                Descricao = inventoryDescriptionTextBox.Text,
                Armazem = warehouseTextBox.Text,
                DataDoc = DateTime.Today,
                DataStock = DateTime.Today,
                EstadoDoc = Int32.Parse(stateTexBox.Text),
                Responsavel = personInChargeTextBox.Text,
                TipoDocEntrada = stockReceiptTextBox.Text,
                TipoDocSaida = stockIssueTextBox.Text,
                SerieDocEntrada = entrySeriesTextBox.Text,
                SerieDocSaida = outputSeriesTextBox.Text
            };
            string errors = string.Empty;

            try
            {
                if (documentLinesListView.Items.Count > 0)
                {
                    foreach (var line in lines)
                    {
                        //Insert lines.
                        objInventory.LinhasInventarios.Insere(line.InventoryLines);            
                    }
                }
                else ShowMessage("There are no items.");

                //Creates the inventory document
                PriEngine.Engine.Inventario.Inventarios.Actualiza(objInventory, errors);

                if (errors.Length > 0)
                    ShowMessage($"Error writing document.{Environment.NewLine}" + errors);
                else ShowMessage("Document created successfully!", iconId: StdPlatBS100.StdBSTipos.IconId.PRI_Informativo);
            }
            catch (Exception ex)
            {
                ShowMessage("Unable to save document. \n" + ex.Message);
            }

        }

        /// <summary>
        /// Close form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        /// <summary>
        /// Messages from Platform.
        /// </summary>
        private void ShowMessage(string strMessage, TipoMsg msgType = TipoMsg.PRI_SimplesOk, IconId iconId = IconId.PRI_Exclama)
        {
            PriEngine.Platform.Dialogos.MostraMensagem(msgType, strMessage, iconId);
        }

        /// <summary>
        /// Validate Stock Receipt Document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockReceiptTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Internos.TabInternos.Existe(stockReceiptTextBox.Text) & (stockReceiptTextBox.Text.Length > 0))
            {
                ShowMessage("The document type don't exist.");
                stockReceiptTextBox.Clear();
                stockReceiptTextBox.Focus();
                stockReceiptDescriptionTextBox.Text = string.Empty;
            }
            else stockReceiptDescriptionTextBox.Text = (string)PriEngine.Engine.Internos.TabInternos.DaValorAtributo(stockReceiptTextBox.Text, "Descricao");
        }

        /// <summary>
        /// Validate document Series.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entrySeriesTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Series.Existe("N", stockReceiptTextBox.Text, entrySeriesTextBox.Text) & (entrySeriesTextBox.Text.Length > 0))
            {
                ShowMessage("The series is not defined for the selected document type.");
                entrySeriesTextBox.Clear();
                entrySeriesTextBox.Focus();
            }
        }

        /// <summary>
        /// Validate document Series.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outputSeriesTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Series.Existe("N", stockReceiptTextBox.Text, outputSeriesTextBox.Text) & (outputSeriesTextBox.Text.Length > 0))
            {
                ShowMessage("The series is not defined for the selected document type.");
                outputSeriesTextBox.Clear();
                outputSeriesTextBox.Focus();
            }
        }

        /// <summary>
        /// Validate Issue Receipt Document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockIssueTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Internos.TabInternos.Existe(stockIssueTextBox.Text) & (stockIssueTextBox.Text.Length > 0))
            {
                ShowMessage("The document type don't exist.");
                stockIssueTextBox.Clear();
                stockIssueTextBox.Focus();
                stockIssueDescriptionTextBox.Text = string.Empty;
            }
            else stockIssueDescriptionTextBox.Text = (string)PriEngine.Engine.Internos.TabInternos.DaValorAtributo(stockIssueTextBox.Text, "Descricao");           
        }
    }
}
