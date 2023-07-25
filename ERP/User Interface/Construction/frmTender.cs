using Primavera.COP.Business;
using Primavera.COP.Entities;
using Primavera.COP.PlataformaNET;
using Primavera.COP.Platform;
using Primavera.COP.Platform.Engine.Entities;
using Primavera.Erp.Sample;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Primavera.Construction.Tender
{
    public partial class frmTender : Form
    {
        private Obra tender = null;
        private EngineContext contextoMotor = null;

        public frmTender()
        {
            InitializeComponent();
        }

        private void SetContractRegimeVisibility()
        {
            txtContractRegime.Enabled = ((KeyValuePair<string, string>)cmbType.SelectedItem).Key != "S";
        }

        private void ResetFields()
        {
            cmbType.SelectedValue = "O";
            txtDescription.Text = string.Empty;
            txtContractRegime.Text = string.Empty;
            txtContractRegimeDesc.Text = string.Empty;

            cmbType.Enabled = true;
            cbOnlyDescription.Enabled = false;
            SetContractRegimeVisibility();
        }

        private void FillTypes()
        {
            // Bind combobox to dictionary
            Dictionary<string, string> test = new Dictionary<string, string>
            {
                { "O", "Work" },
                { "S", "Subcontracting" },
                { "C", "Additional Contract" }
            };

            cmbType.DataSource = new BindingSource(test, null);
            cmbType.DisplayMember = "Value";
            cmbType.ValueMember = "Key";
        }

        private void FrmTender_Load(object sender, EventArgs e)
        {
            try
            {
                PlataformaNET.AtualizaERP(PriEngine.Platform, PriEngine.Engine);

                contextoMotor = new EngineContext((PlatformVersions)PriEngine.Platform.Contexto.TipoPlataforma, PlataformaNET.Contexto.Instancia,
                                                PlataformaNET.Contexto.CodEmpresa, PlataformaNET.Contexto.Utilizador, PlataformaNET.Contexto.Password);

                if (contextoMotor == null)
                {
                    MessageBox.Show($"Construction context not inicialized!");

                    CancelForm();
                    return;
                }

                FillTypes();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to inicialize Construction context:{Environment.NewLine + ex.Message}");

                CancelForm();
                return;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (tender == null)
            {
                // Create new tender
                tender = new Obra
                {
                    Codigo = txtCode.Text,
                    Descricao = txtDescription.Text,
                    Tipo = ((KeyValuePair<string, string>)cmbType.SelectedItem).Key,
                    TipoEmpreitadaID = Proxy.TipoEmpreitadas().GetID(contextoMotor, txtContractRegime.Text)
                };

                Proxy.Obras().Update(contextoMotor, ref tender);

                return;
            }

            if (!cbOnlyDescription.Checked)
            {
                // Edit all fields
                tender.Descricao = txtDescription.Text;
                tender.TipoEmpreitadaID = Proxy.TipoEmpreitadas().GetID(contextoMotor, txtContractRegime.Text);

                Proxy.Obras().Update(contextoMotor, ref tender);
            }
            else
            {
                //Edit description
                string descricao = nameof(Obra.Descricao);

                Proxy.Obras().UpdateField(contextoMotor, txtCode.Text, ((KeyValuePair<string, string>)cmbType.SelectedItem).Key, ref descricao, txtDescription.Text);
            }

            this.CancelForm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelForm();
        }

        private void CancelForm()
        {
            this.Close();
            this.Dispose();
        }

        private void TxtCode_Validated(object sender, EventArgs e)
        {
            try
            {
                string type = ((KeyValuePair<string, string>)cmbType.SelectedItem).Key;

                if (Proxy.Obras().Exists(contextoMotor, txtCode.Text, type))
                {
                    tender = Proxy.Obras().Edit(contextoMotor, txtCode.Text, type);

                    txtDescription.Text = tender.Descricao;
                    cmbType.SelectedValue = tender.Tipo;

                    TipoEmpreitada contractRegime = Proxy.TipoEmpreitadas().Edit(contextoMotor, tender.TipoEmpreitadaID);
                    txtContractRegime.Text = contractRegime.Tipo;
                    txtContractRegimeDesc.Text = contractRegime.Descricao;

                    cmbType.Enabled = false;
                    cbOnlyDescription.Enabled = true;
                }
                else if (tender != null)
                {
                    tender = null;

                    ResetFields();
                }
            }
            catch (Exception)
            {
                ResetFields();
            }
        }

        private void TxtContractRegime_Validated(object sender, EventArgs e)
        {
            if (Proxy.TipoEmpreitadas().Exists(contextoMotor, txtContractRegime.Text))
            {
                txtContractRegimeDesc.Text = Proxy.TipoEmpreitadas().Edit(contextoMotor, txtContractRegime.Text).Descricao;
            }
            else
            {
                txtContractRegimeDesc.Text = string.Empty;
            }
        }

        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetContractRegimeVisibility();
        }
    }
}
