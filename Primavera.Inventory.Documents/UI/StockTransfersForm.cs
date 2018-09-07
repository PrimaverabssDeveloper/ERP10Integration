using InvBE100;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static StdPlatBS100.StdBSTipos;
using System.Linq;

namespace Primavera.Inventory.Documents
{
    public partial class StockTransfersForm : Form
    {
        class TargetLines
        {
            public int Index { get; set; }
            public InvBELinhaOrigemTransf LinhaOrigem { get; set; }
        }

        List<TargetLines>targetLines;

        public StockTransfersForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add line to the listView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (PriEngine.Engine.Base.Artigos.Existe(itemTextBox.Text))
            {
                // Add row to the Listiew.
                string[] row = { itemTextBox.Text, warehouseTextBox.Text, quantityTextBox.Value.ToString(), valueTextBox.Value.ToString() };
                var listViewItem = new ListViewItem(row);
                documentLinesListView.Items.Add(listViewItem);

                if (targetLines == null)
                    targetLines = new List<TargetLines>();

                targetLines.Add(new TargetLines()
                {
                    LinhaOrigem = new InvBELinhaOrigemTransf()
                    {
                        Artigo = itemTextBox.Text,
                        Armazem = warehouseTextBox.Text,
                        Localizacao = warehouseTextBox.Text,
                        Lote = sourceLotTextBox.Text,
                        Quantidade = Convert.ToDouble(quantityTextBox.Value),
                        PrecUnit = Convert.ToDouble(valueTextBox.Value),
                        INV_EstadoOrigem = sourceStateTextBox.Text
                    },
                    Index = documentLinesListView.Items.Count - 1
                });

                documentLinesListView.Items[documentLinesListView.Items.Count - 1].Focused = true;
                documentLinesListView.Items[documentLinesListView.Items.Count - 1].Selected = true;
                itemTextBox.Clear();
                itemDescriptionTextBox.Clear();
                warehouseTextBox.Clear();
                sourceLotTextBox.Clear();
            }
            else
            {
                ShowMessage("The selected item doesn't exist.");

                itemTextBox.Clear();
                itemTextBox.Focus();
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
        /// Creates a stock transfers document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            InvBEDocumentoTransf objStockTransfer = new InvBEDocumentoTransf()
            {
                Tipodoc = docTypeTextBox.Text,
                Serie = seriesTextBox.Text,
                Data = DateTime.Today
            };
            string errors = string.Empty;

            try
            {
                if (relatedDataCheckBox.Checked)
                    // Set all related information.
                    PriEngine.Engine.Inventario.Transferencias.PreencheDadosRelacionados(objStockTransfer);

                if (documentLinesListView.Items.Count > 0)
                {
                    foreach (var lines in targetLines)
                    {
                        // Insert lines.
                        objStockTransfer.LinhasOrigem.Insere(lines.LinhaOrigem);
                    }
                }
                else
                {
                    ShowMessage("There are no items.");
                } 

                // Creates the transfer document.
                PriEngine.Engine.Inventario.Transferencias.Actualiza(objStockTransfer, ref errors);

                if (errors.Length > 0)
                {
                    ShowMessage($"Error writing document.{Environment.NewLine}" + errors);
                }
                else
                {
                    ShowMessage("Document created successfully!", iconId: IconId.PRI_Informativo);
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Unable to save document. \n" + ex.Message);
            }
        }

        /// <summary>
        /// Validate document type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void docTypeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.TabTransferencias.Existe(docTypeTextBox.Text) & (docTypeTextBox.Text.Length > 0))
            {
                ShowMessage("The document type doesn't exist.");
                docTypeTextBox.Clear();
                docTypeTextBox.Focus();
                docTypeDescriptionTextBox.Text = string.Empty;
            }
            else
            {
                docTypeDescriptionTextBox.Text = Convert.ToString(PriEngine.Engine.Inventario.TabTransferencias.DaValorAtributo(docTypeTextBox.Text, "Descricao"));
            } 
        }

        /// <summary>
        /// Validate Item.
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
            else
            {
                itemDescriptionTextBox.Text = Convert.ToString(PriEngine.Engine.Base.Artigos.DaValorAtributo(itemTextBox.Text, "Descricao"));
            }              
        }

        /// <summary>
        /// Messages from Platform.
        /// </summary>
        private void ShowMessage(string strMessage, TipoMsg msgType = TipoMsg.PRI_SimplesOk, IconId iconId = IconId.PRI_Exclama)
        {
            PriEngine.Platform.Dialogos.MostraMensagem(msgType, strMessage, iconId);
        }
        /// <summary>
        /// Validate Target Warehouse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void targetWarehouseTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.Armazens.Existe(targetWarehouseTextBox.Text) && targetWarehouseTextBox.Text.Length > 0)
            {
                ShowMessage("The warehouse doesn't exist.");
                targetWarehouseTextBox.Clear();
                targetWarehouseTextBox.Focus();
            }
        }

        /// <summary>
        /// Add line to the listView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void targetAddButton_Click(object sender, EventArgs e)
        {
            if (PriEngine.Engine.Inventario.Armazens.Existe(targetWarehouseTextBox.Text) && targetWarehouseTextBox.Text.Length > 0)
            {
                // Add row to the Listiew.
                string[] rowDestino = { targetWarehouseTextBox.Text, quantityTextBox.Value.ToString(), valueTextBox.Value.ToString() };
                var listViewItemDestino = new ListViewItem(rowDestino);
                targetLinesListView.Items.Add(listViewItemDestino);

                if (documentLinesListView.SelectedIndices.Count == 0)
                    return;

                var sourceLine = targetLines.Where(r => r.Index == documentLinesListView.SelectedIndices[0]).FirstOrDefault();

                if (sourceLine != null)
                {
                    sourceLine.LinhaOrigem.LinhasDestino.Add(new InvBELinhaDestinoTransf()
                    {
                        Armazem = targetWarehouseTextBox.Text,
                        Localizacao = targetWarehouseTextBox.Text,
                        Lote = targetLotTextBox.Text,
                        Artigo = sourceLine.LinhaOrigem.Artigo,
                        Quantidade = Convert.ToDouble(quantityTextBox.Value),
                        PrecUnit = Convert.ToDouble(valueTextBox.Value),
                        INV_EstadoDestino = targetStateTextBox.Text
                    });
                }
                targetWarehouseTextBox.Clear();
                targetLotTextBox.Clear();
            }
            else
            {
                ShowMessage("The selected item doesn't exist.");

                itemTextBox.Clear();
                itemTextBox.Focus();
            }
        }

        /// <summary>
        /// validate selected index of the list view.
        /// </summary>
        /// /// <param name="sender"></param>
        /// <param name="e"></param>
        private void documentLinesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (documentLinesListView.SelectedIndices.Count == 0)
                return;

            targetLinesListView.Items.Clear();

            int index = documentLinesListView.SelectedIndices[0];
            var sourceLine = targetLines.Where(r => r.Index == index).FirstOrDefault();

            if (sourceLine != null)
                LoadTargetLines(sourceLine);
        }

        /// <summary>
        /// Load target lines.
        /// </summary>
        private void LoadTargetLines(TargetLines linhaOrigem)
        {
            foreach (InvBELinhaDestinoTransf targetLine in linhaOrigem.LinhaOrigem.LinhasDestino)
            {
                targetLinesListView.Items.Add(new ListViewItem(new string[] {
                    targetLine.Armazem,
                    targetLine.Quantidade.ToString(),
                    targetLine.PrecUnit.ToString()
                }));
            }
        }

        /// <summary>
        /// Validate document Series.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seriesTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Series.Existe("T", docTypeTextBox.Text, seriesTextBox.Text) & (seriesTextBox.Text.Length > 0))
            {
                ShowMessage("The series is not defined for the selected document type.");
                seriesTextBox.Clear();
                seriesTextBox.Focus();
            }
        }

        /// <summary>
        /// Validate Warehouse.
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
        }

        /// <summary>
        /// Validate state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sourceStateTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.EstadosInventario.Existe(sourceStateTextBox.Text))
            {
                ShowMessage("The state doesn't exist.");
                targetLotTextBox.Clear();
                targetLotTextBox.Focus();
            }
        }

        /// <summary>
        /// Validate state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void targetStateTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.EstadosInventario.Existe(targetStateTextBox.Text))
            {
                ShowMessage("The state doesn't exist.");
                targetStateTextBox.Clear();
                targetStateTextBox.Focus();
            }
        }
    }
}
