namespace Primavera.Party.RelatedInfo
{
    partial class CurrentAccountInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridPendentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPendentes
            // 
            this.dataGridPendentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPendentes.Location = new System.Drawing.Point(3, 3);
            this.dataGridPendentes.Name = "dataGridPendentes";
            this.dataGridPendentes.Size = new System.Drawing.Size(403, 235);
            this.dataGridPendentes.TabIndex = 0;
            // 
            // Pendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridPendentes);
            this.Name = "Pendentes";
            this.Size = new System.Drawing.Size(411, 241);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPendentes;


    }
}
