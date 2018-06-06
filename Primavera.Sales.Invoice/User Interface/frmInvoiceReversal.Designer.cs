namespace Primavera.Sales.Invoice
{
    partial class frmInvoiceReversal
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEntidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRevMotivo = new System.Windows.Forms.TextBox();
            this.txtRevMotivoDescricao = new System.Windows.Forms.TextBox();
            this.txtRevDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtRevTipoDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRevSerie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRevTipoDocDescricao = new System.Windows.Forms.TextBox();
            this.txtRevNumDoc = new System.Windows.Forms.NumericUpDown();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRevNumDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(182, 23);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(229, 20);
            this.txtDescricao.TabIndex = 16;
            this.txtDescricao.TabStop = false;
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(107, 49);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(69, 20);
            this.txtSerie.TabIndex = 1;
            this.txtSerie.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerie_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Series";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoDoc.Location = new System.Drawing.Point(107, 23);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(69, 20);
            this.txtTipoDoc.TabIndex = 0;
            this.txtTipoDoc.Validating += new System.ComponentModel.CancelEventHandler(this.txtTipoDoc_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Doc. Type";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(107, 75);
            this.txtNumDoc.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(69, 20);
            this.txtNumDoc.TabIndex = 2;
            this.txtNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumDoc.ValueChanged += new System.EventHandler(this.txtNumDoc_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Doc. Number";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(182, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(229, 20);
            this.txtNome.TabIndex = 21;
            this.txtNome.TabStop = false;
            // 
            // txtEntidade
            // 
            this.txtEntidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntidade.Location = new System.Drawing.Point(107, 101);
            this.txtEntidade.Name = "txtEntidade";
            this.txtEntidade.ReadOnly = true;
            this.txtEntidade.Size = new System.Drawing.Size(69, 20);
            this.txtEntidade.TabIndex = 20;
            this.txtEntidade.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Entity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtTipoDoc);
            this.groupBox1.Controls.Add(this.txtEntidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtNumDoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 139);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Document";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtRevMotivo);
            this.groupBox2.Controls.Add(this.txtRevMotivoDescricao);
            this.groupBox2.Controls.Add(this.txtRevDate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtObservacoes);
            this.groupBox2.Controls.Add(this.txtRevTipoDoc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRevSerie);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRevTipoDocDescricao);
            this.groupBox2.Controls.Add(this.txtRevNumDoc);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 167);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reversal Document";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Reversal cause";
            // 
            // txtRevMotivo
            // 
            this.txtRevMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRevMotivo.Location = new System.Drawing.Point(107, 101);
            this.txtRevMotivo.Name = "txtRevMotivo";
            this.txtRevMotivo.Size = new System.Drawing.Size(69, 20);
            this.txtRevMotivo.TabIndex = 5;
            this.txtRevMotivo.Validating += new System.ComponentModel.CancelEventHandler(this.txtRevMotivo_Validating);
            // 
            // txtRevMotivoDescricao
            // 
            this.txtRevMotivoDescricao.Location = new System.Drawing.Point(182, 101);
            this.txtRevMotivoDescricao.Name = "txtRevMotivoDescricao";
            this.txtRevMotivoDescricao.ReadOnly = true;
            this.txtRevMotivoDescricao.Size = new System.Drawing.Size(229, 20);
            this.txtRevMotivoDescricao.TabIndex = 26;
            this.txtRevMotivoDescricao.TabStop = false;
            // 
            // txtRevDate
            // 
            this.txtRevDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtRevDate.Location = new System.Drawing.Point(215, 75);
            this.txtRevDate.Name = "txtRevDate";
            this.txtRevDate.Size = new System.Drawing.Size(111, 20);
            this.txtRevDate.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doc. Type";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(107, 127);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(304, 20);
            this.txtObservacoes.TabIndex = 6;
            // 
            // txtRevTipoDoc
            // 
            this.txtRevTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRevTipoDoc.Location = new System.Drawing.Point(107, 23);
            this.txtRevTipoDoc.Name = "txtRevTipoDoc";
            this.txtRevTipoDoc.ReadOnly = true;
            this.txtRevTipoDoc.Size = new System.Drawing.Size(69, 20);
            this.txtRevTipoDoc.TabIndex = 13;
            this.txtRevTipoDoc.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Series";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Observations";
            // 
            // txtRevSerie
            // 
            this.txtRevSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRevSerie.Location = new System.Drawing.Point(107, 49);
            this.txtRevSerie.Name = "txtRevSerie";
            this.txtRevSerie.Size = new System.Drawing.Size(69, 20);
            this.txtRevSerie.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Doc. Number";
            // 
            // txtRevTipoDocDescricao
            // 
            this.txtRevTipoDocDescricao.Location = new System.Drawing.Point(182, 23);
            this.txtRevTipoDocDescricao.Name = "txtRevTipoDocDescricao";
            this.txtRevTipoDocDescricao.ReadOnly = true;
            this.txtRevTipoDocDescricao.Size = new System.Drawing.Size(229, 20);
            this.txtRevTipoDocDescricao.TabIndex = 16;
            this.txtRevTipoDocDescricao.TabStop = false;
            // 
            // txtRevNumDoc
            // 
            this.txtRevNumDoc.Enabled = false;
            this.txtRevNumDoc.Location = new System.Drawing.Point(107, 75);
            this.txtRevNumDoc.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtRevNumDoc.Name = "txtRevNumDoc";
            this.txtRevNumDoc.ReadOnly = true;
            this.txtRevNumDoc.Size = new System.Drawing.Size(69, 20);
            this.txtRevNumDoc.TabIndex = 17;
            this.txtRevNumDoc.TabStop = false;
            this.txtRevNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(447, 272);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(94, 23);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(447, 301);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 23);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmInvoiceReversal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 338);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoiceReversal";
            this.Text = "Sales Invoice Reversal example";
            this.Load += new System.EventHandler(this.frmInvoiceReversal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRevNumDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtNumDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEntidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtRevTipoDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRevSerie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRevTipoDocDescricao;
        private System.Windows.Forms.NumericUpDown txtRevNumDoc;
        private System.Windows.Forms.DateTimePicker txtRevDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRevMotivo;
        private System.Windows.Forms.TextBox txtRevMotivoDescricao;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
    }
}