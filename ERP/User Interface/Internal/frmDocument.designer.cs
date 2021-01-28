namespace Primavera.Internal.Documents
{
    partial class frmDocument
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.chkDadosRelacionados = new System.Windows.Forms.CheckBox();
            this.Linhas = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArmazem = new System.Windows.Forms.TextBox();
            this.txtArtigoDescricao = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lvLinhas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtQtd = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArtigo = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.Linhas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doc. Type";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoDoc.Location = new System.Drawing.Point(105, 12);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(69, 20);
            this.txtTipoDoc.TabIndex = 1;
            this.txtTipoDoc.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTipoDoc_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Series";
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(105, 38);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(69, 20);
            this.txtSerie.TabIndex = 2;
            this.txtSerie.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSerie_Validating);
            // 
            // chkDadosRelacionados
            // 
            this.chkDadosRelacionados.AutoSize = true;
            this.chkDadosRelacionados.Location = new System.Drawing.Point(105, 64);
            this.chkDadosRelacionados.Name = "chkDadosRelacionados";
            this.chkDadosRelacionados.Size = new System.Drawing.Size(110, 17);
            this.chkDadosRelacionados.TabIndex = 3;
            this.chkDadosRelacionados.Text = "Fill Related Data?";
            this.chkDadosRelacionados.UseVisualStyleBackColor = true;
            // 
            // Linhas
            // 
            this.Linhas.Controls.Add(this.txtPreco);
            this.Linhas.Controls.Add(this.label4);
            this.Linhas.Controls.Add(this.label2);
            this.Linhas.Controls.Add(this.txtArmazem);
            this.Linhas.Controls.Add(this.txtArtigoDescricao);
            this.Linhas.Controls.Add(this.cmdAdd);
            this.Linhas.Controls.Add(this.lvLinhas);
            this.Linhas.Controls.Add(this.txtQtd);
            this.Linhas.Controls.Add(this.label7);
            this.Linhas.Controls.Add(this.label6);
            this.Linhas.Controls.Add(this.txtArtigo);
            this.Linhas.Location = new System.Drawing.Point(12, 87);
            this.Linhas.Name = "Linhas";
            this.Linhas.Size = new System.Drawing.Size(405, 232);
            this.Linhas.TabIndex = 8;
            this.Linhas.TabStop = false;
            this.Linhas.Text = "Document Lines";
            // 
            // txtPreco
            // 
            this.txtPreco.DecimalPlaces = 2;
            this.txtPreco.Location = new System.Drawing.Point(93, 95);
            this.txtPreco.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(69, 20);
            this.txtPreco.TabIndex = 7;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreco.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Warehouse";
            // 
            // txtArmazem
            // 
            this.txtArmazem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArmazem.Location = new System.Drawing.Point(93, 43);
            this.txtArmazem.Name = "txtArmazem";
            this.txtArmazem.Size = new System.Drawing.Size(69, 20);
            this.txtArmazem.TabIndex = 5;
            this.txtArmazem.Validating += new System.ComponentModel.CancelEventHandler(this.txtArmazem_Validating);
            // 
            // txtArtigoDescricao
            // 
            this.txtArtigoDescricao.Location = new System.Drawing.Point(168, 17);
            this.txtArtigoDescricao.Name = "txtArtigoDescricao";
            this.txtArtigoDescricao.ReadOnly = true;
            this.txtArtigoDescricao.Size = new System.Drawing.Size(229, 20);
            this.txtArtigoDescricao.TabIndex = 12;
            this.txtArtigoDescricao.TabStop = false;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(343, 95);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(54, 23);
            this.cmdAdd.TabIndex = 8;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // lvLinhas
            // 
            this.lvLinhas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4});
            this.lvLinhas.HideSelection = false;
            this.lvLinhas.Location = new System.Drawing.Point(6, 124);
            this.lvLinhas.Name = "lvLinhas";
            this.lvLinhas.Size = new System.Drawing.Size(391, 99);
            this.lvLinhas.TabIndex = 11;
            this.lvLinhas.TabStop = false;
            this.lvLinhas.UseCompatibleStateImageBehavior = false;
            this.lvLinhas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Warehouse";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qtt";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 75;
            // 
            // txtQtd
            // 
            this.txtQtd.DecimalPlaces = 2;
            this.txtQtd.Location = new System.Drawing.Point(93, 69);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(69, 20);
            this.txtQtd.TabIndex = 6;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Qtt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Item";
            // 
            // txtArtigo
            // 
            this.txtArtigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArtigo.Location = new System.Drawing.Point(93, 17);
            this.txtArtigo.Name = "txtArtigo";
            this.txtArtigo.Size = new System.Drawing.Size(69, 20);
            this.txtArtigo.TabIndex = 4;
            this.txtArtigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtArtigo_Validating);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(423, 296);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 23);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(423, 267);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(94, 23);
            this.cmdSave.TabIndex = 9;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(180, 12);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(229, 20);
            this.txtDescricao.TabIndex = 11;
            this.txtDescricao.TabStop = false;
            // 
            // frmDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 330);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.Linhas);
            this.Controls.Add(this.chkDadosRelacionados);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipoDoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDocument";
            this.Text = "Internal Document Sample";
            this.Load += new System.EventHandler(this.frmDocument_Load);
            this.Linhas.ResumeLayout(false);
            this.Linhas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.CheckBox chkDadosRelacionados;
        private System.Windows.Forms.GroupBox Linhas;
        private System.Windows.Forms.ListView lvLinhas;
        private System.Windows.Forms.NumericUpDown txtQtd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArtigo;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.NumericUpDown txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArmazem;
        private System.Windows.Forms.TextBox txtArtigoDescricao;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}