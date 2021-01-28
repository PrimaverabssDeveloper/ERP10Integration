using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StdPlatBS100.StdBSTipos;
using InvBE100;
using Primavera.Erp.Sample;

namespace Primavera.Inventory
{
    public partial class CompositionsBreakdownsForm : Form
    {
        class ComponentsLines
        {
            public int Index { get; set; }
            public InvBELinhaComposto LinhaComposto { get; set; }
        }

        List<ComponentsLines> componentsLines;
        public CompositionsBreakdownsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validate document type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void docTypeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.TabComposicoes.Existe(docTypeTextBox.Text) & (docTypeTextBox.Text.Length > 0))
            {
                ShowMessage("The document type doesn't exist.");
                docTypeTextBox.Clear();
                docTypeTextBox.Focus();
                docTypeDescriptionTextBox.Text = string.Empty;
            }
            else docTypeDescriptionTextBox.Text = Convert.ToString(PriEngine.Engine.Inventario.TabComposicoes.DaValorAtributo(docTypeTextBox.Text, "Descricao"));
        }

        /// <summary>
        /// Validate document Series.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seriesTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Series.Existe("S", docTypeTextBox.Text, seriesTextBox.Text) & (seriesTextBox.Text.Length > 0))
            {
                ShowMessage("The series is not defined for the selected document type.");
                seriesTextBox.Clear();
                seriesTextBox.Focus();
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
        /// Validate item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(PriEngine.Engine.Base.Artigos.DaValorAtributo(itemTextBox.Text, "TipoComponente" ) != 2))
            {
                ShowMessage("The item is not of the assembly item type.");
                itemTextBox.Clear();
                itemTextBox.Focus();
                itemDescriptionTextBox.Text = string.Empty;
            }
            else itemDescriptionTextBox.Text = Convert.ToString(PriEngine.Engine.Base.Artigos.DaValorAtributo(itemTextBox.Text, "Descricao"));
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
                // add row to the Listiew.
                string[] row = { itemTextBox.Text, warehouseTextBox.Text, quantityNumericUpDown.Value.ToString(), valueNumericUpDown.Value.ToString() };
                var listViewItem = new ListViewItem(row);
                documentLinesListView.Items.Add(listViewItem);

                if (componentsLines == null)
                    componentsLines = new List<ComponentsLines>();

                componentsLines.Add(new ComponentsLines()
                {
                    LinhaComposto = new InvBELinhaComposto()
                    {
                        Artigo = itemTextBox.Text,
                        Armazem = warehouseTextBox.Text,
                        Quantidade = Convert.ToDouble(quantityNumericUpDown.Value),
                        PrecUnit = Convert.ToDouble(valueNumericUpDown.Value),
                        INV_EstadoOrigem = sourceStateTextBox.Text,
                        INV_EstadoDestino = targetStateTextBox.Text                    
                    },
                    Index = documentLinesListView.Items.Count - 1
                });

                documentLinesListView.Items[documentLinesListView.Items.Count - 1].Focused = true;
                documentLinesListView.Items[documentLinesListView.Items.Count - 1].Selected = true;
                itemTextBox.Clear();
                itemDescriptionTextBox.Clear();
                warehouseTextBox.Clear();
            }
            else
            {
                ShowMessage("The selected item doesn't exist.");

                itemTextBox.Clear();
                itemTextBox.Focus();
            }
        }

        /// <summary>
        /// Validate item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void componentItemTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Artigos.Existe(componentItemTextBox.Text))
            {
                ShowMessage("The item doesn't exist.");
                componentItemTextBox.Clear();
                componentItemTextBox.Focus();
                componentItemDescriptionTextBox.Text = string.Empty;
            }
            else componentItemDescriptionTextBox.Text = Convert.ToString(PriEngine.Engine.Base.Artigos.DaValorAtributo(componentItemTextBox.Text, "Descricao"));
        }

        /// <summary>
        /// Validate warehouse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void warehouseComponentTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.Armazens.Existe(warehouseComponentTextBox.Text) && warehouseComponentTextBox.Text.Length > 0)
            {
                ShowMessage("The warehouse doesn't exist.");
                warehouseComponentTextBox.Clear();
                warehouseComponentTextBox.Focus();
            }
        }

        /// <summary>
        /// Add lines to the list view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addComponentButton_Click(object sender, EventArgs e)
        {
            if (PriEngine.Engine.Base.Artigos.Existe(componentItemTextBox.Text) && componentItemTextBox.Text.Length > 0)
            {
                // add row to the Listiew.
                string[] componentsRow = { componentItemTextBox.Text, warehouseComponentTextBox.Text, quantityComponentNumericUpDown.Value.ToString(), valueComponentNumericUpDown.Value.ToString() };
                var listViewItemComponents = new ListViewItem(componentsRow);
                componentsListView.Items.Add(listViewItemComponents);

                if (documentLinesListView.SelectedIndices.Count == 0)
                    return;

                var sourceLine = componentsLines.Where(r => r.Index == documentLinesListView.SelectedIndices[0]).FirstOrDefault();

                if (sourceLine != null)
                {
                    sourceLine.LinhaComposto.LinhasComponentes.Add(new InvBELinhaComponente()
                    {
                        Artigo = componentItemTextBox.Text,
                        Armazem = warehouseComponentTextBox.Text,
                        Quantidade = Convert.ToDouble(quantityComponentNumericUpDown.Value),
                        PrecUnit = Convert.ToDouble(valueComponentNumericUpDown.Value),
                        INV_EstadoOrigem = componentSourceStateTextBox.Text,
                        Lote = lotTextBox.Text
                    });
                }
                componentItemTextBox.Clear();
                componentItemDescriptionTextBox.Clear();
                warehouseComponentTextBox.Clear();
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

            componentsListView.Items.Clear();

            int index = documentLinesListView.SelectedIndices[0];
            var sourceLine = componentsLines.Where(r => r.Index == index).FirstOrDefault();

            if (sourceLine != null)
                LoadComponentsLines(sourceLine);
        }

        /// <summary>
        /// Load target lines.
        /// </summary>
        private void LoadComponentsLines(ComponentsLines linhaComposto)
        {
            foreach (InvBELinhaComponente componentline in linhaComposto.LinhaComposto.LinhasComponentes)
            {
                componentsListView.Items.Add(new ListViewItem(new string[] {
                    componentline.Artigo,
                    componentline.Armazem,
                    componentline.Quantidade.ToString(),
                    componentline.PrecUnit.ToString()
                }));
            }
        }

        /// <summary>
        /// Creates a Compositions/Breakdowns document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            InvBEDocumentoComposicao objComposition = new InvBEDocumentoComposicao()
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
                    PriEngine.Engine.Inventario.Composicoes.PreencheDadosRelacionados(objComposition);

                if (documentLinesListView.Items.Count > 0)
                {
                    foreach (var lines in componentsLines)
                    {
                        // Insert lines.
                        objComposition.LinhasCompostos.Insere(lines.LinhaComposto);
                    }
                }
                else
                {
                    ShowMessage("There are no items.");
                } 

                // Creates the Compositions/Breakdowns document.
                PriEngine.Engine.Inventario.Composicoes.Actualiza(objComposition, ref errors);

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
        /// Validate state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sourceStateTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.EstadosInventario.Existe(sourceStateTextBox.Text) && sourceStateTextBox.Text.Length > 0)
            {
                ShowMessage("The state doesn't exist.");
                sourceStateTextBox.Clear();
                sourceStateTextBox.Focus();
            }
        }

        /// <summary>
        /// Validate state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void targetStateTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.EstadosInventario.Existe(targetStateTextBox.Text) && targetStateTextBox.Text.Length > 0)
            {
                ShowMessage("The state doesn't exist.");
                targetStateTextBox.Clear();
                targetStateTextBox.Focus();
            }
        }

        /// <summary>
        /// Validate state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void componentTargetStateTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.EstadosInventario.Existe(componentTargetStateTextBox.Text) && componentTargetStateTextBox.Text.Length > 0)
            {
                ShowMessage("The state doesn't exist.");
                componentTargetStateTextBox.Clear();
                componentTargetStateTextBox.Focus();
            }
        }

        /// <summary>
        /// Validate state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void componentSourceStateTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.EstadosInventario.Existe(componentSourceStateTextBox.Text) && componentSourceStateTextBox.Text.Length > 0)
            {
                ShowMessage("The state doesn't exist.");
                componentSourceStateTextBox.Clear();
                componentSourceStateTextBox.Focus();
            }
        }

        /// <summary>
        /// Validate lot.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lotTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.ArtigosLotes.Existe(componentItemTextBox.Text, lotTextBox.Text))
            {
                ShowMessage("The lot doesn't exist.");
                componentSourceStateTextBox.Clear();
                componentSourceStateTextBox.Focus();
            }
        }
    }
}
