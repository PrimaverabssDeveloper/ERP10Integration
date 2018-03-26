using StdBE100;
using StdPlatBE100;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Primavera.Party.RelatedInfo
{
    /// <summary>
    /// This component will display the party (costumer or supplier) current account amount.
    /// The information will be displayed on the sales editor context.
    /// The trigger will be caused when customer field change.
    /// </summary>
    public partial class CurrentAccountInfo : UserControl, IStdBEInfRelacionada
    {
        #region Public methods

        public CurrentAccountInfo()
        {
            InitializeComponent();
        }

        #endregion

        #region private variables

        private StdBECategoryInfo categoryInfo;
        private dynamic formContext;
        private dynamic plataform;
        private dynamic engine;

        #endregion

        #region Private properties

            private string EntityKey { get; set; }

        #endregion

        #region Private Methods

        /// <summary>
        /// Fill the grid with the selected entity account amount.
        /// </summary>
        void LoadGrid()
        {
            StringBuilder sql = new StringBuilder();
            string query = string.Empty;

            // Get the connection string from the context.
            string connectionString = plataform.BaseDados.DaConnectionStringNET
                                        (plataform.BaseDados.DaNomeBDdaEmpresa(engine.Contexto.CodEmp), "Default");

            sql.Append("SELECT TipoDoc,TipoConta, SUM(ValorPendente) AS Total , SUM(Valortotal) AS Pendente FROM");
            sql.Append(" Pendentes WHERE entidade='@1@'");
            sql.Append(" GROUP BY TipoConta,TipoDoc");

            query = sql.ToString();
            query = query.Replace("@1@", this.EntityKey);

            try
            {
                dataGridPendentes.ReadOnly = true;

                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder comBuilder = new SqlCommandBuilder(dataAdapter);

                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);
                dataGridPendentes.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        #endregion

        #region _IStdBEInfRelacionada Members

        /// <summary>
        /// This is the binded category info.
        /// </summary>
        StdBECategoryInfo IStdBEInfRelacionada.BECategoryInfo
        {
            get
            {
                return this.categoryInfo;
            }
            set
            {
                this.categoryInfo = value;
            }
        }

        /// <summary>
        /// This active ERP engine.
        /// </summary>
        dynamic IStdBEInfRelacionada.MotorAplicacao
        {
            set
            {
                this.engine = value;
            }
        }

        /// <summary>
        /// The active ERP platform.
        /// </summary>
        dynamic IStdBEInfRelacionada.Plataforma
        {
            set
            {
                this.plataform = value;
            }
        }

        /// <summary>
        /// This is the context form.
        /// </summary>
        dynamic IStdBEInfRelacionada.FormContexto
        {
            set
            {
                this.formContext = value;
            }
        }

        /// <summary>
        /// This is the binded category value.
        /// </summary>
        void IStdBEInfRelacionada.AdicionaChave(string Nome, dynamic Valor)
        {
            StdBECamposChave fields = new StdBECamposChave();

            fields.AddCampoChave(Nome, Valor);

            dynamic campo = fields.CamposChave;

            this.EntityKey = (string) campo[0].Valor;
        }
        
        /// <summary>
        /// This method are trigged by the ERP when the binded category value changes.
        /// </summary>
        void IStdBEInfRelacionada.Atualiza()
        {
            this.LoadGrid();
        }

        void IStdBEInfRelacionada.Limpa()
        {
            dataGridPendentes.DataSource = null;
        }
   
        #endregion
    }
}