namespace Primavera.Inventory
{
    partial class FrmReservaDestino
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdReservar = new System.Windows.Forms.Button();
            this.priGrelhaDocs = new PRISDK100.PriGrelha();
            this.priGrelhaEncomendas = new PRISDK100.PriGrelha();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priGrelhaDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priGrelhaEncomendas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdReservar
            // 
            this.cmdReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdReservar.Location = new System.Drawing.Point(695, 466);
            this.cmdReservar.Name = "cmdReservar";
            this.cmdReservar.Size = new System.Drawing.Size(94, 23);
            this.cmdReservar.TabIndex = 10;
            this.cmdReservar.Text = "ReservarStock";
            this.cmdReservar.UseVisualStyleBackColor = true;
            this.cmdReservar.Click += new System.EventHandler(this.CmdReservar_Click);
            // 
            // priGrelhaDocs
            // 
            this.priGrelhaDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priGrelhaDocs.BackColor = System.Drawing.Color.White;
            this.priGrelhaDocs.BandaMenuContexto = "";
            this.priGrelhaDocs.BotaoConfigurarActiveBar = true;
            this.priGrelhaDocs.BotaoProcurarActiveBar = false;
            this.priGrelhaDocs.CaminhoTemplateImpressao = "";
            this.priGrelhaDocs.Cols = null;
            this.priGrelhaDocs.ColsFrozen = -1;
            this.priGrelhaDocs.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.priGrelhaDocs.Location = new System.Drawing.Point(11, 249);
            this.priGrelhaDocs.Name = "priGrelhaDocs";
            this.priGrelhaDocs.NumeroMaxRegistosSemPag = 150000;
            this.priGrelhaDocs.NumeroRegistos = 0;
            this.priGrelhaDocs.NumLinhasCabecalho = 1;
            this.priGrelhaDocs.OrientacaoMapa = PRISDK100.clsSDKTypes.OrientacaoImpressao.oiDefault;
            this.priGrelhaDocs.ParentFormModal = false;
            this.priGrelhaDocs.PermiteActiveBar = false;
            this.priGrelhaDocs.PermiteActualizar = true;
            this.priGrelhaDocs.PermiteAgrupamentosUser = true;
            this.priGrelhaDocs.PermiteConfigurarDetalhes = false;
            this.priGrelhaDocs.PermiteContextoVazia = false;
            this.priGrelhaDocs.PermiteDataFill = false;
            this.priGrelhaDocs.PermiteDetalhes = true;
            this.priGrelhaDocs.PermiteEdicao = false;
            this.priGrelhaDocs.PermiteFiltros = true;
            this.priGrelhaDocs.PermiteGrafico = true;
            this.priGrelhaDocs.PermiteGrandeTotal = false;
            this.priGrelhaDocs.PermiteOrdenacao = true;
            this.priGrelhaDocs.PermitePaginacao = false;
            this.priGrelhaDocs.PermiteScrollBars = true;
            this.priGrelhaDocs.PermiteStatusBar = true;
            this.priGrelhaDocs.PermiteVistas = true;
            this.priGrelhaDocs.PosicionaColunaSeguinte = true;
            this.priGrelhaDocs.Size = new System.Drawing.Size(778, 208);
            this.priGrelhaDocs.TabIndex = 14;
            this.priGrelhaDocs.TituloGrelha = "";
            this.priGrelhaDocs.TituloMapa = "";
            this.priGrelhaDocs.TypeNameLinha = "";
            this.priGrelhaDocs.TypeNameLinhas = "";
            // 
            // priGrelhaEncomendas
            // 
            this.priGrelhaEncomendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priGrelhaEncomendas.BackColor = System.Drawing.Color.White;
            this.priGrelhaEncomendas.BandaMenuContexto = "";
            this.priGrelhaEncomendas.BotaoConfigurarActiveBar = true;
            this.priGrelhaEncomendas.BotaoProcurarActiveBar = false;
            this.priGrelhaEncomendas.CaminhoTemplateImpressao = "";
            this.priGrelhaEncomendas.Cols = null;
            this.priGrelhaEncomendas.ColsFrozen = -1;
            this.priGrelhaEncomendas.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.priGrelhaEncomendas.Location = new System.Drawing.Point(11, 31);
            this.priGrelhaEncomendas.Name = "priGrelhaEncomendas";
            this.priGrelhaEncomendas.NumeroMaxRegistosSemPag = 150000;
            this.priGrelhaEncomendas.NumeroRegistos = 0;
            this.priGrelhaEncomendas.NumLinhasCabecalho = 1;
            this.priGrelhaEncomendas.OrientacaoMapa = PRISDK100.clsSDKTypes.OrientacaoImpressao.oiDefault;
            this.priGrelhaEncomendas.ParentFormModal = false;
            this.priGrelhaEncomendas.PermiteActiveBar = false;
            this.priGrelhaEncomendas.PermiteActualizar = true;
            this.priGrelhaEncomendas.PermiteAgrupamentosUser = true;
            this.priGrelhaEncomendas.PermiteConfigurarDetalhes = false;
            this.priGrelhaEncomendas.PermiteContextoVazia = false;
            this.priGrelhaEncomendas.PermiteDataFill = false;
            this.priGrelhaEncomendas.PermiteDetalhes = true;
            this.priGrelhaEncomendas.PermiteEdicao = false;
            this.priGrelhaEncomendas.PermiteFiltros = true;
            this.priGrelhaEncomendas.PermiteGrafico = true;
            this.priGrelhaEncomendas.PermiteGrandeTotal = false;
            this.priGrelhaEncomendas.PermiteOrdenacao = true;
            this.priGrelhaEncomendas.PermitePaginacao = false;
            this.priGrelhaEncomendas.PermiteScrollBars = true;
            this.priGrelhaEncomendas.PermiteStatusBar = true;
            this.priGrelhaEncomendas.PermiteVistas = true;
            this.priGrelhaEncomendas.PosicionaColunaSeguinte = true;
            this.priGrelhaEncomendas.Size = new System.Drawing.Size(778, 185);
            this.priGrelhaEncomendas.TabIndex = 15;
            this.priGrelhaEncomendas.TituloGrelha = "";
            this.priGrelhaEncomendas.TituloMapa = "";
            this.priGrelhaEncomendas.TypeNameLinha = "";
            this.priGrelhaEncomendas.TypeNameLinhas = "";
            this.priGrelhaEncomendas.LeaveCell += new PRISDK100.PriGrelha.LeaveCellHandler(this.priGrelhaEncomendas_LeaveCell);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Selecione uma das linhas para consultar as origens possíveis para a reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Selecione as origens do stock a reservar";
            // 
            // FrmReservaDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priGrelhaEncomendas);
            this.Controls.Add(this.priGrelhaDocs);
            this.Controls.Add(this.cmdReservar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReservaDestino";
            this.Text = "Reserva efetuada no destino";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.Resize += new System.EventHandler(this.FrmReservaDestino_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.priGrelhaDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priGrelhaEncomendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdReservar;
        private PRISDK100.PriGrelha priGrelhaDocs;
        private PRISDK100.PriGrelha priGrelhaEncomendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}