using StdBE100;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VndBE100;
using static BasBE100.BasBETiposGcp;

namespace Primavera.ReservasStock
{
    public partial class FrmReservaDestino : Form
    {
        private static FuncoesComuns100.FuncoesBS funcoesComunsBS;

        private const string m_colSeleccionado = "Sel";

        private const string m_colDocumento = "Documento";
        private const string m_colDocumentoAux = "DocumentoAux";
        private const string m_colIdDocumento = "IdDocumento";
        private const string m_colDataEntrega = "DataEnt";
        private const string m_colIdLinha = "IdLinha";
        private const string m_colIdReserva = "IdReserva";
        private const string m_colEmModoEdicao = "EmModoEdicao";

        private const string m_colEstado = "Estado";
        private const string m_colQuantidadeOrig = "QuantOrig";
        private const string m_colQuantidadeDisponivel = "QuantDisp";
        private const string m_colQuantidadeSelec = "QuantSeleccionada";
        private const string m_colQuantidadeSelecOrg = "QuantSeleccionadaOrg";
        private const string m_colQuantidadeFinal = "QuantFinal";
        private const string m_colQuantPendReserva = "QuantPendReserva";
        private const string m_colLocalizacao = "Localizacao";
        private const string m_colLote = "Lote";
        private const string m_colArmazem = "Armazem";
        private const string m_colReservadoPor = "ReservadoPor";
        private const string m_colIdReservaOriginal = "IdReservaOriginal";
        private const string m_colTipoDoc = "TipoDoc";
        private const string m_colTipoEntidade = "TipoEntidade";
        private const string m_colEntidade = "Entidade";
        private const string m_colIdTipoOrigem = "IdTipoOrigem";
        private const string m_colAudit = "Audit";

        private const string m_colQuantidade = "Quantidade";
        private const string m_colArtigo = "Artigo";

        public FrmReservaDestino()
        {
            InitializeComponent();
            funcoesComunsBS = new FuncoesComuns100.FuncoesBS(PriEngine.Engine, ConstantesPrimavera100.AbreviaturasApl.Base);
        }

        /// <summary>
        /// Creates a new invoice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdReservar_Click(object sender, EventArgs e)
        {
            try
            {
                InvBE100.InvBELinhasReserva objReservas = new InvBE100.InvBELinhasReserva();
                double dblQtdEncomenda = priGrelhaEncomendas.GetGRID_GetValorCelula(priGrelhaEncomendas.Grelha.ActiveRow, m_colQuantidade);
                double dblQtdReserva = 0;

                for (int i = 1; i <= priGrelhaDocs.Grelha.DataRowCnt; i++)
                {
                    if (dblQtdReserva > dblQtdEncomenda)
                    {
                        break;
                    }

                    if (priGrelhaDocs.GetGRID_GetValorCelula(i, m_colSeleccionado) == 1)
                    {
                        InvBE100.InvBELinhaReserva objLinhaReserva = new InvBE100.InvBELinhaReserva();
                        objLinhaReserva.Artigo = priGrelhaEncomendas.GetGRID_GetValorCelula(priGrelhaEncomendas.Grelha.ActiveRow, m_colArtigo);
                        objLinhaReserva.Armazem = priGrelhaDocs.GetGRID_GetValorCelula(i, m_colArmazem);
                        objLinhaReserva.Localizacao = priGrelhaDocs.GetGRID_GetValorCelula(i, m_colLocalizacao);
                        objLinhaReserva.Lote = priGrelhaDocs.GetGRID_GetValorCelula(i, m_colLote);
                        objLinhaReserva.IdTipoOrigemDestino = PriEngine.Engine.Inventario.TiposOrigem.DaIDTipoOrigem(ConstantesPrimavera100.AbreviaturasApl.Vendas, ConstantesPrimavera100.Modulos.Vendas);

                        //Indicamos a origem apenas se a reserva não é de stock disponível
                        string strIdTipoOrigem = priGrelhaDocs.GetGRID_GetValorCelula(i, m_colIdTipoOrigem);
                        if (!string.IsNullOrWhiteSpace(strIdTipoOrigem))
                        {
                            objLinhaReserva.IdTipoOrigemOrigem = strIdTipoOrigem;
                            objLinhaReserva.IdChaveOrigem = priGrelhaDocs.GetGRID_GetValorCelula(i, m_colIdLinha);
                            objLinhaReserva.DescricaoOrigem = priGrelhaDocs.GetGRID_GetValorCelula(i, m_colDocumento);
                            objLinhaReserva.EstadoOrigem = priGrelhaDocs.GetGRID_GetValorCelula(i, m_colEstado);
                            objLinhaReserva.EstadoDestino = "PREV.RES";
                        }
                        else
                        {
                            objLinhaReserva.EstadoOrigem = priGrelhaDocs.GetGRID_GetValorCelula(i, m_colEstado);
                            objLinhaReserva.EstadoDestino = "RES";
                        }

                        objLinhaReserva.DescricaoDestino = priGrelhaEncomendas.GetGRID_GetValorCelula(priGrelhaEncomendas.Grelha.ActiveRow, m_colDocumento);
                        objLinhaReserva.IdChaveDestino = priGrelhaEncomendas.GetGRID_GetValorCelula(priGrelhaEncomendas.Grelha.ActiveRow, m_colIdLinha);

                        objLinhaReserva.Quantidade = priGrelhaDocs.GetGRID_GetValorCelula(i, m_colQuantidadeDisponivel);

                        dblQtdReserva += objLinhaReserva.Quantidade;
                        if (dblQtdReserva > dblQtdEncomenda)
                        {
                            objLinhaReserva.Quantidade = priGrelhaDocs.GetGRID_GetValorCelula(i, m_colQuantidadeDisponivel) - (dblQtdReserva - dblQtdEncomenda);
                        }

                        objLinhaReserva.QuantidadePendente = objLinhaReserva.Quantidade;
                        objLinhaReserva.ReservadoPor = InvBE100.InvBETipos.EnumReservadoPor.Destino;

                        objReservas.Insere(objLinhaReserva);
                    }
                }

                if (dblQtdReserva == 0)
                {
                    MessageBox.Show("Não exitem reservas a efetuar.");
                    return;
                }

                string strIdEncomenda = priGrelhaEncomendas.GetGRID_GetValorCelula(priGrelhaEncomendas.Grelha.ActiveRow, m_colIdDocumento);
                string strIdLinha = priGrelhaEncomendas.GetGRID_GetValorCelula(priGrelhaEncomendas.Grelha.ActiveRow, m_colIdLinha);

                VndBEDocumentoVenda objDoc = PriEngine.Engine.Vendas.Documentos.EditaID(strIdEncomenda);

                VndBELinhaDocumentoVenda objLinha = ((IEnumerable<VndBELinhaDocumentoVenda>)objDoc.Linhas).FirstOrDefault(x => x.IdLinha == strIdLinha);
                InvBE100.InvBEReserva objReserva = new InvBE100.InvBEReserva();
                objReserva.Linhas = objReservas;
                objLinha.ReservaStock = objReserva;

                PriEngine.Engine.Vendas.Documentos.Actualiza(objDoc);

                MessageBox.Show("Reserva criada com sucesso");
            }
            catch (Exception ex)
            {
                PriEngine.Platform.Dialogos.MostraErro("Erro ao executar a operação", StdPlatBS100.StdBSTipos.IconId.PRI_Exclama, ex.Message);
            }
        }

        private void InicializaColunasGrelhaReservas()
        {
            string strTitulo = "";
            string strCampoBD = "";

            priGrelhaDocs.RemoveConfiguracaoCols();

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 777);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = 0", m_colSeleccionado);
            priGrelhaDocs.AddColKey(m_colSeleccionado, UpgradeHelpers.Spread.FpCellType.CellTypeCheckBox, strTitulo, 7, false, true, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false, false, false);

            //Coluna escondida para ter o documento origem ou destino consoante a origem
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = CAST(NULL AS NVARCHAR(255))", m_colDocumentoAux);
            priGrelhaDocs.AddColKey(m_colDocumentoAux, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, "", 20, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 65);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.Documento", m_colDocumento);
            priGrelhaDocs.AddColKey(m_colDocumento, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 20, true, true, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, true, false, false);

            //Coluna escondida com o tipo de entidade.
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.TipoEntidade", m_colTipoEntidade);
            priGrelhaDocs.AddColKey(m_colTipoEntidade, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, "", 20, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 341);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.Entidade", m_colEntidade);
            priGrelhaDocs.AddColKey(m_colEntidade, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 12, true, true, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, true, false, false);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 778);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.DataEntrega", m_colDataEntrega);
            priGrelhaDocs.AddColKey(m_colDataEntrega, UpgradeHelpers.Spread.FpCellType.CellTypeDate, strTitulo, 11, true, true, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, true);

            strTitulo = "Id Linha";
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.Id", m_colIdLinha);
            priGrelhaDocs.AddColKey(m_colIdLinha, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 10, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strTitulo = "Id Reserva";
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = CONVERT(UNIQUEIDENTIFIER,NULL)", m_colIdReserva);
            priGrelhaDocs.AddColKey(m_colIdReserva, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 10, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strTitulo = "EmModoEdicao";
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = 0", m_colEmModoEdicao);
            priGrelhaDocs.AddColKey(m_colEmModoEdicao, UpgradeHelpers.Spread.FpCellType.CellTypeCheckBox, strTitulo, 7, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false, false, false);

            strTitulo = "ReservadoPor";
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.ReservadoPor", m_colReservadoPor);
            priGrelhaDocs.AddColKey(m_colReservadoPor, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 10, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strTitulo = "Id Documento";
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.IdDocumento", m_colIdDocumento);
            priGrelhaDocs.AddColKey(m_colIdDocumento, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 10, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 202);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.EstadoDestino", m_colEstado);
            priGrelhaDocs.AddColKey(m_colEstado, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 10, true, PriEngine.Engine.Inventario.Params.EstadosInventario, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, PriEngine.Engine.Inventario.Params.EstadosInventario, false, false);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 780);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.Armazem", m_colArmazem);
            priGrelhaDocs.AddColKey(m_colArmazem, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 10, true, true, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, true, false, false);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 781);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.Localizacao", m_colLocalizacao);
            priGrelhaDocs.AddColKey(m_colLocalizacao, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 10, true, true, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, true, false, false);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 782);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = CASE WHEN A.Lote = '@2@' THEN '' ELSE A.LOTE END", m_colLote, ConstantesPrimavera100.Inventario.LotePorDefeito);
            priGrelhaDocs.AddColKey(m_colLote, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 10, true, true /*m_strModuloDocs == ConstantesPrimavera100.Modulos.Internos*/, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, true, false, false);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 783);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = ROUND(A.Quantidade,@2@)", m_colQuantidadeOrig, PriEngine.Engine.Inventario.Params.CasasDecimaisQnt);
            priGrelhaDocs.AddColKey(m_colQuantidadeOrig, UpgradeHelpers.Spread.FpCellType.CellTypeFloat, strTitulo, 13, true, true, -999999999, 999999999, PriEngine.Engine.Inventario.Params.CasasDecimaisQnt, 50, "", false, false, strCampoBD, true, true);
           
            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 785);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = ROUND(A.QuantidadeDisp,@2@)", m_colQuantidadeDisponivel, PriEngine.Engine.Inventario.Params.CasasDecimaisQnt);
            priGrelhaDocs.AddColKey(m_colQuantidadeDisponivel, UpgradeHelpers.Spread.FpCellType.CellTypeFloat, strTitulo, 13, true, true, -999999999, 999999999, PriEngine.Engine.Inventario.Params.CasasDecimaisQnt, 50, "", false, false, strCampoBD, true, true);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 786);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = CONVERT(FLOAT,0)", m_colQuantidadeSelec);
            priGrelhaDocs.AddColKey(m_colQuantidadeSelec, UpgradeHelpers.Spread.FpCellType.CellTypeFloat, strTitulo, 13, false, true, -999999999, 999999999, PriEngine.Engine.Inventario.Params.CasasDecimaisQnt, 50, "", false, false, strCampoBD, true, true);

            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = CONVERT(FLOAT,0)", m_colQuantidadeSelecOrg);
            priGrelhaDocs.AddColKey(m_colQuantidadeSelecOrg, UpgradeHelpers.Spread.FpCellType.CellTypeFloat, strTitulo, 13, false, false, -999999999, 999999999, PriEngine.Engine.Inventario.Params.CasasDecimaisQnt, 50, "", false, false, strCampoBD, false, true);

            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = CONVERT(FLOAT,0)", m_colQuantPendReserva);
            priGrelhaDocs.AddColKey(m_colQuantPendReserva, UpgradeHelpers.Spread.FpCellType.CellTypeFloat, "", 13, true, false, -999999999, 999999999, PriEngine.Engine.Inventario.Params.CasasDecimaisQnt, 50, "", false, false, strCampoBD, false);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 803);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = CONVERT(FLOAT,0)", m_colQuantidadeFinal);
            priGrelhaDocs.AddColKey(m_colQuantidadeFinal, UpgradeHelpers.Spread.FpCellType.CellTypeFloat, strTitulo, 13, true, false, -999999999, 999999999, PriEngine.Engine.Inventario.Params.CasasDecimaisQnt, 50, "", false, false, strCampoBD, true);

            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = CAST (NULL AS UNIQUEIDENTIFIER)", m_colIdReservaOriginal);
            priGrelhaDocs.AddColKey(m_colIdReservaOriginal, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, "", 13, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = A.TipoDoc", m_colTipoDoc);
            priGrelhaDocs.AddColKey(m_colTipoDoc, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, "", 13, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = CAST (@1@ AS UNIQUEIDENTIFIER)", m_colIdTipoOrigem);
            priGrelhaDocs.AddColKey(m_colIdTipoOrigem, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, "", 20, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strCampoBD = "Audit";
            priGrelhaDocs.AddColKey(m_colAudit, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, "", 20, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            priGrelhaDocs.PermiteDataFill = true;
            priGrelhaDocs.PermiteEdicao = false;
            priGrelhaDocs.PermiteActiveBar = false;
            priGrelhaDocs.PermiteActualizar = false;
            priGrelhaDocs.PermiteFiltros = true;
            priGrelhaDocs.PermiteGrandeTotal = false;
            priGrelhaDocs.PermiteVistas = true;
            priGrelhaDocs.BotaoConfigurarActiveBar = false;

            if (!priGrelhaDocs.LeXML(ConstantesPrimavera100.Modulos.Vendas, PriEngine.Engine.Contexto.UtilizadorActual, this.Name, this.Name, "10.00"))
            {
                priGrelhaDocs.FormataGrelha(true);
            }

            priGrelhaDocs.LimpaGrelha();
        }

        private void InicializaColunasGrelhaEncomendas()
        {
            string strTitulo = "";
            string strCampoBD = "";

            priGrelhaEncomendas.RemoveConfiguracaoCols();
                        
            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 65);
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = C.Documento", m_colDocumento);
            priGrelhaEncomendas.AddColKey(m_colDocumento, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 20, true, true, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, true, false, false);

            strTitulo = PriEngine.Platform.Localizacao.DaResString(ConstantesPrimavera100.AbreviaturasApl.Base, 341);
            priGrelhaEncomendas.AddColKey(m_colEntidade, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 12, true, true, -999999999, 999999999, 2, 50, "", false, false, m_colEntidade, true, false, false);

            strTitulo = "Artigo";
            priGrelhaEncomendas.AddColKey(m_colArtigo, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 12, true, true, -999999999, 999999999, 2, 50, "", false, false, m_colArtigo, true, false, false);


            strTitulo = "Id Linha";
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = L.Id", m_colIdLinha);
            priGrelhaEncomendas.AddColKey(m_colIdLinha, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 10, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strTitulo = "Id Documento";
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = C.Id", m_colIdDocumento);
            priGrelhaEncomendas.AddColKey(m_colIdDocumento, UpgradeHelpers.Spread.FpCellType.CellTypeStaticText, strTitulo, 10, true, false, -999999999, 999999999, 2, 50, "", false, false, strCampoBD, false);

            strTitulo = "Quantidade";
            strCampoBD = PriEngine.Platform.Strings.Formata("@1@ = ROUND(L.Quantidade,@2@)", m_colQuantidade, PriEngine.Engine.Inventario.Params.CasasDecimaisQnt);
            priGrelhaEncomendas.AddColKey(m_colQuantidade, UpgradeHelpers.Spread.FpCellType.CellTypeFloat, strTitulo, 13, true, true, -999999999, 999999999, PriEngine.Engine.Inventario.Params.CasasDecimaisQnt, 50, "", false, false, strCampoBD, true, true);


            priGrelhaEncomendas.PermiteDataFill = true;
            priGrelhaEncomendas.PermiteAgrupamentosUser = false;
            priGrelhaEncomendas.PermiteEdicao = false;
            priGrelhaEncomendas.PermiteActiveBar = false;
            priGrelhaEncomendas.PermiteActualizar = true;
            priGrelhaEncomendas.PermiteFiltros = true;
            priGrelhaEncomendas.PermiteGrandeTotal = false;
            priGrelhaEncomendas.PermiteVistas = false;
            priGrelhaEncomendas.BotaoConfigurarActiveBar = false;

            if (!priGrelhaEncomendas.LeXML(ConstantesPrimavera100.Modulos.Vendas, PriEngine.Engine.Contexto.UtilizadorActual, this.Name, this.Name + "Encomendas", "10.00"))
            {
                priGrelhaEncomendas.FormataGrelha(true);
            }

            priGrelhaEncomendas.LimpaGrelha();
        }

        private void CarregaOrigensPossiveis(string Artigo)
        {
            if (string.IsNullOrWhiteSpace(Artigo))
            {
                return;
            }
            string strTabelaTemp = PriEngine.Platform.TabelasTemporarias.CriaTabelaIdentificador("TempListaDocs", PriEngine.Platform.TabelasTemporarias.DaUID());

            StdBE100.StdBELista objListaDocs = funcoesComunsBS.Documentos.LstReservasOrigensPossiveis(Artigo, true, true, true
                                                                                    , priGrelhaDocs.DaCamposBDSelect().Replace("''", "'")
                                                                                    , new DateTime(DateTime.Today.Year, 1, 1), new DateTime(DateTime.Today.Year, 12, 31), false, "", strTabelaTemp
                                                                                    , ""
                                                                                    , "");
            priGrelhaDocs.DataBind(objListaDocs);
        }

        private void CarregaListaEncomendas()
        {
            string strSql = "SELECT " + priGrelhaEncomendas.DaCamposBDSelect() + " FROM LinhasDoc L" + Environment.NewLine;
            strSql += "INNER JOIN CabecDoc C ON C.Id = L.IdCabecDoc" + Environment.NewLine;
            strSql += "INNER JOIN CabecDocStatus CS ON CS.IdCabecDoc = C.Id" + Environment.NewLine;
            strSql += "INNER JOIN LinhasDocStatus LS ON LS.IdLinhasDoc = L.Id" + Environment.NewLine;
            strSql += "INNER JOIN DocumentosVenda D ON D.Documento = C.TipoDoc" + Environment.NewLine;
            strSql += "WHERE D.TipoDocumento = 2 AND CS.Fechado = 0 AND cs.Anulado = 0 AND" + Environment.NewLine;
            strSql += "      LS.Fechado = 0 AND Ls.QuantTrans = 0" + Environment.NewLine;
            strSql += "      AND Year(C.Data) = 2019 AND L.TipoLinha NOT IN (60,65)" + Environment.NewLine;
            strSql += "ORDER BY C.Data DESC" + Environment.NewLine;

            priGrelhaEncomendas.DataBind(PriEngine.Engine.Consulta(strSql));

            priGrelhaEncomendas.RedimencionaColunaGrelha();

            if (priGrelhaEncomendas.Grelha.DataRowCnt > 0)
            {
                CarregaOrigensPossiveis(priGrelhaEncomendas.GetGRID_GetValorCelula(1, m_colArtigo));
            }
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            priGrelhaDocs.Inicializa(PriEngine.PriSDKContexto);
            priGrelhaEncomendas.Inicializa(PriEngine.PriSDKContexto);

            InicializaColunasGrelhaEncomendas();
            InicializaColunasGrelhaReservas();

            CarregaListaEncomendas();
        }

        private void FrmReservaDestino_Resize(object sender, EventArgs e)
        {
            priGrelhaDocs.RedimencionaColunaGrelha();
            priGrelhaEncomendas.RedimencionaColunaGrelha();
        }

        private void priGrelhaEncomendas_LeaveCell(object Sender, PRISDK100.PriGrelha.LeaveCellEventArgs e)
        {
            CarregaOrigensPossiveis(priGrelhaEncomendas.GetGRID_GetValorCelula(e.NewRow, m_colArtigo));
        }
    }
}
