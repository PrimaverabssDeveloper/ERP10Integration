namespace Primavera.Sales.Invoice
{
    partial class FrmInvoice
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntidade = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Linhas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtQtd = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArtigo = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.F4TipoDocumento = new System.Windows.Forms.Button();
            this.F4Cliente = new System.Windows.Forms.Button();
            this.Linhas.SuspendLayout();
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
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serie";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(105, 38);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(69, 20);
            this.txtSerie.TabIndex = 2;
            this.txtSerie.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSerie_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Entity";
            // 
            // txtEntidade
            // 
            this.txtEntidade.Location = new System.Drawing.Point(105, 64);
            this.txtEntidade.Name = "txtEntidade";
            this.txtEntidade.Size = new System.Drawing.Size(69, 20);
            this.txtEntidade.TabIndex = 3;
            this.txtEntidade.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEntidade_Validating);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(105, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Fill Related Data?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Linhas
            // 
            this.Linhas.Controls.Add(this.label2);
            this.Linhas.Controls.Add(this.txtobs);
            this.Linhas.Controls.Add(this.cmdAdd);
            this.Linhas.Controls.Add(this.listView1);
            this.Linhas.Controls.Add(this.txtQtd);
            this.Linhas.Controls.Add(this.label7);
            this.Linhas.Controls.Add(this.label6);
            this.Linhas.Controls.Add(this.txtArtigo);
            this.Linhas.Location = new System.Drawing.Point(12, 125);
            this.Linhas.Name = "Linhas";
            this.Linhas.Size = new System.Drawing.Size(405, 180);
            this.Linhas.TabIndex = 8;
            this.Linhas.TabStop = false;
            this.Linhas.Text = "Document Lines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Line observations";
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(17, 154);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(373, 20);
            this.txtobs.TabIndex = 7;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(188, 38);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(54, 19);
            this.cmdAdd.TabIndex = 7;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 69);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qtd";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(115, 37);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(67, 20);
            this.txtQtd.TabIndex = 6;
            this.txtQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Qtd";
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
            this.txtArtigo.Location = new System.Drawing.Point(17, 36);
            this.txtArtigo.Name = "txtArtigo";
            this.txtArtigo.Size = new System.Drawing.Size(92, 20);
            this.txtArtigo.TabIndex = 5;
            this.txtArtigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtArtigo_KeyUp);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(423, 282);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 23);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(423, 253);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(94, 23);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(180, 12);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(229, 20);
            this.txtDescricao.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(180, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(139, 20);
            this.txtNome.TabIndex = 12;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(325, 66);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(84, 20);
            this.txtNif.TabIndex = 13;
            this.txtNif.Validating += new System.ComponentModel.CancelEventHandler(this.txtNif_Validating);
            // 
            // F4TipoDocumento
            // 
            this.F4TipoDocumento.Location = new System.Drawing.Point(415, 12);
            this.F4TipoDocumento.Name = "F4TipoDocumento";
            this.F4TipoDocumento.Size = new System.Drawing.Size(30, 20);
            this.F4TipoDocumento.TabIndex = 14;
            this.F4TipoDocumento.Text = "F4";
            this.F4TipoDocumento.UseVisualStyleBackColor = true;
            this.F4TipoDocumento.Click += new System.EventHandler(this.F4TipoDocumento_Click);
            // 
            // F4Cliente
            // 
            this.F4Cliente.Location = new System.Drawing.Point(415, 67);
            this.F4Cliente.Name = "F4Cliente";
            this.F4Cliente.Size = new System.Drawing.Size(30, 20);
            this.F4Cliente.TabIndex = 15;
            this.F4Cliente.Text = "F4";
            this.F4Cliente.UseVisualStyleBackColor = true;
            this.F4Cliente.Click += new System.EventHandler(this.F4Cliente_Click);
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 317);
            this.Controls.Add(this.F4Cliente);
            this.Controls.Add(this.F4TipoDocumento);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.Linhas);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtEntidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipoDoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvoice";
            this.Text = "Sales Invoice Sample";
            this.Linhas.ResumeLayout(false);
            this.Linhas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntidade;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox Linhas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown txtQtd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArtigo;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Button F4TipoDocumento;
        private System.Windows.Forms.Button F4Cliente;
    }
}