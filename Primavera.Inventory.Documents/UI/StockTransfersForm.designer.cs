namespace Primavera.Inventory.Documents
{
    partial class StockTransfersForm
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
            this.docTypeLabel = new System.Windows.Forms.Label();
            this.docTypeTextBox = new System.Windows.Forms.TextBox();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.documentLinesGroupBox = new System.Windows.Forms.GroupBox();
            this.sourceStateTextBox = new System.Windows.Forms.TextBox();
            this.sourceStateLabel = new System.Windows.Forms.Label();
            this.sourceLotTextBox = new System.Windows.Forms.TextBox();
            this.sourceLotLabel = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.NumericUpDown();
            this.valueLabel = new System.Windows.Forms.Label();
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.warehouseTextBox = new System.Windows.Forms.TextBox();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.documentLinesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityTextBox = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.docTypeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.targetsGroupBox = new System.Windows.Forms.GroupBox();
            this.targetStateTextBox = new System.Windows.Forms.TextBox();
            this.targetStateLabel = new System.Windows.Forms.Label();
            this.targetLotTextBox = new System.Windows.Forms.TextBox();
            this.targetLotLabel = new System.Windows.Forms.Label();
            this.targetWarehouseLabel = new System.Windows.Forms.Label();
            this.targetWarehouseTextBox = new System.Windows.Forms.TextBox();
            this.tagetAddButton = new System.Windows.Forms.Button();
            this.targetLinesListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.relatedDataCheckBox = new System.Windows.Forms.CheckBox();
            this.documentLinesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTextBox)).BeginInit();
            this.targetsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // docTypeLabel
            // 
            this.docTypeLabel.AutoSize = true;
            this.docTypeLabel.Location = new System.Drawing.Point(17, 18);
            this.docTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.docTypeLabel.Name = "docTypeLabel";
            this.docTypeLabel.Size = new System.Drawing.Size(73, 17);
            this.docTypeLabel.TabIndex = 0;
            this.docTypeLabel.Text = "Doc. Type";
            // 
            // docTypeTextBox
            // 
            this.docTypeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.docTypeTextBox.Location = new System.Drawing.Point(140, 15);
            this.docTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.docTypeTextBox.Name = "docTypeTextBox";
            this.docTypeTextBox.Size = new System.Drawing.Size(91, 22);
            this.docTypeTextBox.TabIndex = 0;
            this.docTypeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.docTypeTextBox_Validating);
            // 
            // seriesLabel
            // 
            this.seriesLabel.AutoSize = true;
            this.seriesLabel.Location = new System.Drawing.Point(17, 60);
            this.seriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(48, 17);
            this.seriesLabel.TabIndex = 2;
            this.seriesLabel.Text = "Series";
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.seriesTextBox.Location = new System.Drawing.Point(140, 60);
            this.seriesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(91, 22);
            this.seriesTextBox.TabIndex = 1;
            this.seriesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.seriesTextBox_Validating);
            // 
            // documentLinesGroupBox
            // 
            this.documentLinesGroupBox.Controls.Add(this.sourceStateTextBox);
            this.documentLinesGroupBox.Controls.Add(this.sourceStateLabel);
            this.documentLinesGroupBox.Controls.Add(this.sourceLotTextBox);
            this.documentLinesGroupBox.Controls.Add(this.sourceLotLabel);
            this.documentLinesGroupBox.Controls.Add(this.valueTextBox);
            this.documentLinesGroupBox.Controls.Add(this.valueLabel);
            this.documentLinesGroupBox.Controls.Add(this.warehouseLabel);
            this.documentLinesGroupBox.Controls.Add(this.warehouseTextBox);
            this.documentLinesGroupBox.Controls.Add(this.itemDescriptionTextBox);
            this.documentLinesGroupBox.Controls.Add(this.addButton);
            this.documentLinesGroupBox.Controls.Add(this.documentLinesListView);
            this.documentLinesGroupBox.Controls.Add(this.quantityTextBox);
            this.documentLinesGroupBox.Controls.Add(this.quantityLabel);
            this.documentLinesGroupBox.Controls.Add(this.itemLabel);
            this.documentLinesGroupBox.Controls.Add(this.itemTextBox);
            this.documentLinesGroupBox.Location = new System.Drawing.Point(16, 94);
            this.documentLinesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.documentLinesGroupBox.Name = "documentLinesGroupBox";
            this.documentLinesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.documentLinesGroupBox.Size = new System.Drawing.Size(627, 310);
            this.documentLinesGroupBox.TabIndex = 3;
            this.documentLinesGroupBox.TabStop = false;
            this.documentLinesGroupBox.Text = "Document Lines";
            // 
            // sourceStateTextBox
            // 
            this.sourceStateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sourceStateTextBox.Location = new System.Drawing.Point(330, 93);
            this.sourceStateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceStateTextBox.Name = "sourceStateTextBox";
            this.sourceStateTextBox.Size = new System.Drawing.Size(91, 22);
            this.sourceStateTextBox.TabIndex = 5;
            this.sourceStateTextBox.Text = "DISP";
            this.sourceStateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sourceStateTextBox_Validating);
            // 
            // sourceStateLabel
            // 
            this.sourceStateLabel.AutoSize = true;
            this.sourceStateLabel.Location = new System.Drawing.Point(232, 98);
            this.sourceStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceStateLabel.Name = "sourceStateLabel";
            this.sourceStateLabel.Size = new System.Drawing.Size(90, 17);
            this.sourceStateLabel.TabIndex = 19;
            this.sourceStateLabel.Text = "Source State";
            // 
            // sourceLotTextBox
            // 
            this.sourceLotTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sourceLotTextBox.Location = new System.Drawing.Point(124, 93);
            this.sourceLotTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceLotTextBox.Name = "sourceLotTextBox";
            this.sourceLotTextBox.Size = new System.Drawing.Size(91, 22);
            this.sourceLotTextBox.TabIndex = 4;
            // 
            // sourceLotLabel
            // 
            this.sourceLotLabel.AutoSize = true;
            this.sourceLotLabel.Location = new System.Drawing.Point(19, 98);
            this.sourceLotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceLotLabel.Name = "sourceLotLabel";
            this.sourceLotLabel.Size = new System.Drawing.Size(28, 17);
            this.sourceLotLabel.TabIndex = 17;
            this.sourceLotLabel.Text = "Lot";
            // 
            // valueTextBox
            // 
            this.valueTextBox.DecimalPlaces = 2;
            this.valueTextBox.Location = new System.Drawing.Point(524, 52);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valueTextBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(92, 22);
            this.valueTextBox.TabIndex = 3;
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(472, 57);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(44, 17);
            this.valueLabel.TabIndex = 16;
            this.valueLabel.Text = "Value";
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.Location = new System.Drawing.Point(19, 57);
            this.warehouseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(81, 17);
            this.warehouseLabel.TabIndex = 14;
            this.warehouseLabel.Text = "Warehouse";
            // 
            // warehouseTextBox
            // 
            this.warehouseTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.warehouseTextBox.Location = new System.Drawing.Point(124, 53);
            this.warehouseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseTextBox.Name = "warehouseTextBox";
            this.warehouseTextBox.Size = new System.Drawing.Size(91, 22);
            this.warehouseTextBox.TabIndex = 1;
            this.warehouseTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.warehouseTextBox_Validating);
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(224, 21);
            this.itemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.ReadOnly = true;
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(392, 22);
            this.itemDescriptionTextBox.TabIndex = 14;
            this.itemDescriptionTextBox.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(544, 139);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 28);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // documentLinesListView
            // 
            this.documentLinesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4});
            this.documentLinesListView.FullRowSelect = true;
            this.documentLinesListView.Location = new System.Drawing.Point(8, 175);
            this.documentLinesListView.Margin = new System.Windows.Forms.Padding(4);
            this.documentLinesListView.MultiSelect = false;
            this.documentLinesListView.Name = "documentLinesListView";
            this.documentLinesListView.Size = new System.Drawing.Size(608, 125);
            this.documentLinesListView.TabIndex = 7;
            this.documentLinesListView.TabStop = false;
            this.documentLinesListView.UseCompatibleStateImageBehavior = false;
            this.documentLinesListView.View = System.Windows.Forms.View.Details;
            this.documentLinesListView.SelectedIndexChanged += new System.EventHandler(this.documentLinesListView_SelectedIndexChanged);
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
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 75;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DecimalPlaces = 2;
            this.quantityTextBox.Location = new System.Drawing.Point(330, 51);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(92, 22);
            this.quantityTextBox.TabIndex = 2;
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(232, 58);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 10;
            this.quantityLabel.Text = "Quantity";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(19, 25);
            this.itemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(34, 17);
            this.itemLabel.TabIndex = 0;
            this.itemLabel.Text = "Item";
            // 
            // itemTextBox
            // 
            this.itemTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.itemTextBox.Location = new System.Drawing.Point(124, 21);
            this.itemTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(91, 22);
            this.itemTextBox.TabIndex = 0;
            this.itemTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.itemTextBox_Validating);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(651, 645);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 28);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(651, 609);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 28);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // docTypeDescriptionTextBox
            // 
            this.docTypeDescriptionTextBox.Location = new System.Drawing.Point(240, 15);
            this.docTypeDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.docTypeDescriptionTextBox.Name = "docTypeDescriptionTextBox";
            this.docTypeDescriptionTextBox.ReadOnly = true;
            this.docTypeDescriptionTextBox.Size = new System.Drawing.Size(403, 22);
            this.docTypeDescriptionTextBox.TabIndex = 0;
            this.docTypeDescriptionTextBox.TabStop = false;
            // 
            // targetsGroupBox
            // 
            this.targetsGroupBox.Controls.Add(this.targetStateTextBox);
            this.targetsGroupBox.Controls.Add(this.targetStateLabel);
            this.targetsGroupBox.Controls.Add(this.targetLotTextBox);
            this.targetsGroupBox.Controls.Add(this.targetLotLabel);
            this.targetsGroupBox.Controls.Add(this.targetWarehouseLabel);
            this.targetsGroupBox.Controls.Add(this.targetWarehouseTextBox);
            this.targetsGroupBox.Controls.Add(this.tagetAddButton);
            this.targetsGroupBox.Controls.Add(this.targetLinesListView);
            this.targetsGroupBox.Location = new System.Drawing.Point(16, 423);
            this.targetsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.targetsGroupBox.Name = "targetsGroupBox";
            this.targetsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.targetsGroupBox.Size = new System.Drawing.Size(630, 250);
            this.targetsGroupBox.TabIndex = 4;
            this.targetsGroupBox.TabStop = false;
            this.targetsGroupBox.Text = "Targets";
            // 
            // targetStateTextBox
            // 
            this.targetStateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.targetStateTextBox.Location = new System.Drawing.Point(124, 66);
            this.targetStateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.targetStateTextBox.Name = "targetStateTextBox";
            this.targetStateTextBox.Size = new System.Drawing.Size(91, 22);
            this.targetStateTextBox.TabIndex = 2;
            this.targetStateTextBox.Text = "DISP";
            this.targetStateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.targetStateTextBox_Validating);
            // 
            // targetStateLabel
            // 
            this.targetStateLabel.AutoSize = true;
            this.targetStateLabel.Location = new System.Drawing.Point(19, 71);
            this.targetStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.targetStateLabel.Name = "targetStateLabel";
            this.targetStateLabel.Size = new System.Drawing.Size(87, 17);
            this.targetStateLabel.TabIndex = 17;
            this.targetStateLabel.Text = "Target State";
            // 
            // targetLotTextBox
            // 
            this.targetLotTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.targetLotTextBox.Location = new System.Drawing.Point(268, 23);
            this.targetLotTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.targetLotTextBox.Name = "targetLotTextBox";
            this.targetLotTextBox.Size = new System.Drawing.Size(91, 22);
            this.targetLotTextBox.TabIndex = 1;
            // 
            // targetLotLabel
            // 
            this.targetLotLabel.AutoSize = true;
            this.targetLotLabel.Location = new System.Drawing.Point(232, 28);
            this.targetLotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.targetLotLabel.Name = "targetLotLabel";
            this.targetLotLabel.Size = new System.Drawing.Size(28, 17);
            this.targetLotLabel.TabIndex = 15;
            this.targetLotLabel.Text = "Lot";
            // 
            // targetWarehouseLabel
            // 
            this.targetWarehouseLabel.AutoSize = true;
            this.targetWarehouseLabel.Location = new System.Drawing.Point(19, 28);
            this.targetWarehouseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.targetWarehouseLabel.Name = "targetWarehouseLabel";
            this.targetWarehouseLabel.Size = new System.Drawing.Size(81, 17);
            this.targetWarehouseLabel.TabIndex = 14;
            this.targetWarehouseLabel.Text = "Warehouse";
            // 
            // targetWarehouseTextBox
            // 
            this.targetWarehouseTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.targetWarehouseTextBox.Location = new System.Drawing.Point(124, 23);
            this.targetWarehouseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.targetWarehouseTextBox.Name = "targetWarehouseTextBox";
            this.targetWarehouseTextBox.Size = new System.Drawing.Size(91, 22);
            this.targetWarehouseTextBox.TabIndex = 0;
            this.targetWarehouseTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.targetWarehouseTextBox_Validating);
            // 
            // tagetAddButton
            // 
            this.tagetAddButton.Location = new System.Drawing.Point(547, 85);
            this.tagetAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.tagetAddButton.Name = "tagetAddButton";
            this.tagetAddButton.Size = new System.Drawing.Size(72, 28);
            this.tagetAddButton.TabIndex = 3;
            this.tagetAddButton.Text = "Add";
            this.tagetAddButton.UseVisualStyleBackColor = true;
            this.tagetAddButton.Click += new System.EventHandler(this.targetAddButton_Click);
            // 
            // targetLinesListView
            // 
            this.targetLinesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.targetLinesListView.FullRowSelect = true;
            this.targetLinesListView.Location = new System.Drawing.Point(8, 121);
            this.targetLinesListView.Margin = new System.Windows.Forms.Padding(4);
            this.targetLinesListView.MultiSelect = false;
            this.targetLinesListView.Name = "targetLinesListView";
            this.targetLinesListView.Size = new System.Drawing.Size(611, 121);
            this.targetLinesListView.TabIndex = 4;
            this.targetLinesListView.TabStop = false;
            this.targetLinesListView.UseCompatibleStateImageBehavior = false;
            this.targetLinesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Warehouse";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quantity";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 75;
            // 
            // relatedDataCheckBox
            // 
            this.relatedDataCheckBox.AutoSize = true;
            this.relatedDataCheckBox.Location = new System.Drawing.Point(240, 60);
            this.relatedDataCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.relatedDataCheckBox.Name = "relatedDataCheckBox";
            this.relatedDataCheckBox.Size = new System.Drawing.Size(142, 21);
            this.relatedDataCheckBox.TabIndex = 2;
            this.relatedDataCheckBox.Text = "Fill Related Data?";
            this.relatedDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // StockTransfersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 686);
            this.Controls.Add(this.relatedDataCheckBox);
            this.Controls.Add(this.targetsGroupBox);
            this.Controls.Add(this.docTypeDescriptionTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.documentLinesGroupBox);
            this.Controls.Add(this.seriesTextBox);
            this.Controls.Add(this.seriesLabel);
            this.Controls.Add(this.docTypeTextBox);
            this.Controls.Add(this.docTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockTransfersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Transfers Sample";
            this.documentLinesGroupBox.ResumeLayout(false);
            this.documentLinesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTextBox)).EndInit();
            this.targetsGroupBox.ResumeLayout(false);
            this.targetsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label docTypeLabel;
        private System.Windows.Forms.TextBox docTypeTextBox;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.GroupBox documentLinesGroupBox;
        private System.Windows.Forms.ListView documentLinesListView;
        private System.Windows.Forms.NumericUpDown quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox docTypeDescriptionTextBox;
        private System.Windows.Forms.NumericUpDown valueTextBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label warehouseLabel;
        private System.Windows.Forms.TextBox warehouseTextBox;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox targetsGroupBox;
        private System.Windows.Forms.Label targetWarehouseLabel;
        private System.Windows.Forms.TextBox targetWarehouseTextBox;
        private System.Windows.Forms.Button tagetAddButton;
        private System.Windows.Forms.ListView targetLinesListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.CheckBox relatedDataCheckBox;
        private System.Windows.Forms.Label sourceLotLabel;
        private System.Windows.Forms.TextBox sourceLotTextBox;
        private System.Windows.Forms.TextBox sourceStateTextBox;
        private System.Windows.Forms.Label sourceStateLabel;
        private System.Windows.Forms.Label targetLotLabel;
        private System.Windows.Forms.TextBox targetLotTextBox;
        private System.Windows.Forms.Label targetStateLabel;
        private System.Windows.Forms.TextBox targetStateTextBox;
    }
}