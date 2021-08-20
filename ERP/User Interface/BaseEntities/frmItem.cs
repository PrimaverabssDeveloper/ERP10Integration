using System;
using System.IO;
using System.Windows.Forms;
using BasBE100;
using Primavera.Erp.Sample;

namespace Primavera.BaseEntities
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a new item with the minimal information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdSave_Click(object sender, EventArgs e)
        {
            BasBEArtigo artigo = new BasBEArtigo();
            BasBEArtigoMoeda artigoMoeda = new BasBEArtigoMoeda();
            BasBEArtigoUnidade artigoUnidade = new BasBEArtigoUnidade();

            artigo.Artigo = txtItem.Text;
            artigo.Descricao = txtDescription.Text;
            artigo.UnidadeBase = txtBaseUnit.Text;

            // Fill the default item information.
            PriEngine.Engine.Base.Artigos.PreencheDadosRelacionados(artigo);

            // Set the item prices for the selectc currency.
            artigoMoeda.Artigo = artigo.Artigo;
            artigoMoeda.Unidade = artigo.UnidadeBase;
            artigoMoeda.Moeda = txtCurrency.Text;
            artigoMoeda.PVP1IvaIncluido = false;
            artigoMoeda.PVP1 = 100;

            artigoUnidade.Artigo = artigo.Artigo;
            artigoUnidade.FactorConversao = 1;
            artigoUnidade.UnidadeDestino = artigo.UnidadeBase;
            artigoUnidade.UnidadeOrigem = artigo.UnidadeBase;

            // Create a new attach.
            StdPlatBE100.StdBEAnexo anexo = new StdPlatBE100.StdBEAnexo();

            // The Attach ID.
            string anexoID = Guid.NewGuid().ToString();

            anexo.IdAnexo = anexoID;
            anexo.Data = DateTime.Today;
            anexo.Tabela = StdPlatBE100.StdBETipos.EnumTabelaAnexos.anxArtigos;
            anexo.Chave = artigo.Artigo;
            anexo.Descricao = artigo.Descricao;
            anexo.Utilizador = PriEngine.Engine.Contexto.UtilizadorActual;
            anexo.Idioma = (int)PriEngine.Platform.Contexto.Utilizador.Cultura;
            anexo.Tipo = "IMG";
            anexo.Web = true;
            anexo.FicheiroOrigem = @"c:\temp\img_test.png";

            // Insert the a new attach.
            PriEngine.Platform.Anexos.Actualiza(anexo);

            // Update or insert a new item
            PriEngine.Engine.Base.Artigos.Actualiza(artigo);
            PriEngine.Engine.Base.ArtigosPrecos.Actualiza(artigoMoeda);
            PriEngine.Engine.Base.ArtigosUnidades.Actualiza(ref artigoUnidade);

            // Format the attach file.
            anexoID = "{" + anexoID + "}";

            // Copy the file to the images folder.
            File.Copy(@"c:\temp\img_test.png", $@"C:\Program Files\PRIMAVERA\SG100\Dados\LE\ANEXOS\{anexoID}.png",true);
        }
    }
}
