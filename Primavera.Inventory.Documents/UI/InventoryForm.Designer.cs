namespace Primavera.Inventory.Documents
{
    partial class InventoryForm
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
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.warehouseTextBox = new System.Windows.Forms.TextBox();
            this.warehouseDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.documentLinesGroupBox = new System.Windows.Forms.GroupBox();
            this.unityTextBox = new System.Windows.Forms.TextBox();
            this.unityLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.documentLinesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valueLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.personInChargeLabel = new System.Windows.Forms.Label();
            this.personInChargeTextBox = new System.Windows.Forms.TextBox();
            this.docState = new System.Windows.Forms.Label();
            this.stateTexBox = new System.Windows.Forms.TextBox();
            this.stockReceiptDocumentLabel = new System.Windows.Forms.Label();
            this.stockReceiptTextBox = new System.Windows.Forms.TextBox();
            this.stockReceiptDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.stockIssueDocumentLabel = new System.Windows.Forms.Label();
            this.stockIssueTextBox = new System.Windows.Forms.TextBox();
            this.stockIssueDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.entrySeriesLabel = new System.Windows.Forms.Label();
            this.entrySeriesTextBox = new System.Windows.Forms.TextBox();
            this.outputSeriesLabel = new System.Windows.Forms.Label();
            this.outputSeriesTextBox = new System.Windows.Forms.TextBox();
            this.documentLinesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(17, 18);
            this.inventoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(66, 17);
            this.inventoryLabel.TabIndex = 0;
            this.inventoryLabel.Text = "Inventory";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(140, 15);
            this.inventoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(91, 22);
            this.inventoryTextBox.TabIndex = 0;
            // 
            // inventoryDescriptionTextBox
            // 
            this.inventoryDescriptionTextBox.Location = new System.Drawing.Point(240, 15);
            this.inventoryDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryDescriptionTextBox.Name = "inventoryDescriptionTextBox";
            this.inventoryDescriptionTextBox.Size = new System.Drawing.Size(464, 22);
            this.inventoryDescriptionTextBox.TabIndex = 1;
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.Location = new System.Drawing.Point(17, 50);
            this.warehouseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(81, 17);
            this.warehouseLabel.TabIndex = 1;
            this.warehouseLabel.Text = "Warehouse";
            // 
            // warehouseTextBox
            // 
            this.warehouseTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.warehouseTextBox.Location = new System.Drawing.Point(140, 47);
            this.warehouseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseTextBox.Name = "warehouseTextBox";
            this.warehouseTextBox.Size = new System.Drawing.Size(91, 22);
            this.warehouseTextBox.TabIndex = 2;
            this.warehouseTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.warehouseTextBox_Validating);
            // 
            // warehouseDescriptionTextBox
            // 
            this.warehouseDescriptionTextBox.Location = new System.Drawing.Point(240, 47);
            this.warehouseDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseDescriptionTextBox.Name = "warehouseDescriptionTextBox";
            this.warehouseDescriptionTextBox.ReadOnly = true;
            this.warehouseDescriptionTextBox.Size = new System.Drawing.Size(104, 22);
            this.warehouseDescriptionTextBox.TabIndex = 1;
            this.warehouseDescriptionTextBox.TabStop = false;
            // 
            // documentLinesGroupBox
            // 
            this.documentLinesGroupBox.Controls.Add(this.unityTextBox);
            this.documentLinesGroupBox.Controls.Add(this.unityLabel);
            this.documentLinesGroupBox.Controls.Add(this.addButton);
            this.documentLinesGroupBox.Controls.Add(this.documentLinesListView);
            this.documentLinesGroupBox.Controls.Add(this.priceNumericUpDown);
            this.documentLinesGroupBox.Controls.Add(this.valueLabel);
            this.documentLinesGroupBox.Controls.Add(this.quantityNumericUpDown);
            this.documentLinesGroupBox.Controls.Add(this.quantityLabel);
            this.documentLinesGroupBox.Controls.Add(this.locationTextBox);
            this.documentLinesGroupBox.Controls.Add(this.locationLabel);
            this.documentLinesGroupBox.Controls.Add(this.itemDescriptionTextBox);
            this.documentLinesGroupBox.Controls.Add(this.itemTextBox);
            this.documentLinesGroupBox.Controls.Add(this.itemLabel);
            this.documentLinesGroupBox.Location = new System.Drawing.Point(20, 221);
            this.documentLinesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.documentLinesGroupBox.Name = "documentLinesGroupBox";
            this.documentLinesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.documentLinesGroupBox.Size = new System.Drawing.Size(684, 281);
            this.documentLinesGroupBox.TabIndex = 9;
            this.documentLinesGroupBox.TabStop = false;
            this.documentLinesGroupBox.Text = "Document Lines";
            // 
            // unityTextBox
            // 
            this.unityTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.unityTextBox.Location = new System.Drawing.Point(585, 53);
            this.unityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.unityTextBox.Name = "unityTextBox";
            this.unityTextBox.Size = new System.Drawing.Size(91, 22);
            this.unityTextBox.TabIndex = 4;
            this.unityTextBox.Text = "UN";
            // 
            // unityLabel
            // 
            this.unityLabel.AutoSize = true;
            this.unityLabel.Location = new System.Drawing.Point(537, 57);
            this.unityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unityLabel.Name = "unityLabel";
            this.unityLabel.Size = new System.Drawing.Size(40, 17);
            this.unityLabel.TabIndex = 19;
            this.unityLabel.Text = "Unity";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(604, 112);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 28);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // documentLinesListView
            // 
            this.documentLinesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.documentLinesListView.Location = new System.Drawing.Point(8, 148);
            this.documentLinesListView.Margin = new System.Windows.Forms.Padding(4);
            this.documentLinesListView.Name = "documentLinesListView";
            this.documentLinesListView.Size = new System.Drawing.Size(668, 125);
            this.documentLinesListView.TabIndex = 5;
            this.documentLinesListView.TabStop = false;
            this.documentLinesListView.UseCompatibleStateImageBehavior = false;
            this.documentLinesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qtt";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 100;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(415, 54);
            this.priceNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(92, 22);
            this.priceNumericUpDown.TabIndex = 3;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(367, 56);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(40, 17);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Price";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.DecimalPlaces = 2;
            this.quantityNumericUpDown.Location = new System.Drawing.Point(258, 54);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(92, 22);
            this.quantityNumericUpDown.TabIndex = 2;
            this.quantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(223, 58);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(27, 17);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Qtt";
            // 
            // locationTextBox
            // 
            this.locationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.locationTextBox.Location = new System.Drawing.Point(124, 53);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(91, 22);
            this.locationTextBox.TabIndex = 1;
            this.locationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.locationTextBox_Validating);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(19, 57);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(62, 17);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Location";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(224, 21);
            this.itemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.ReadOnly = true;
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(452, 22);
            this.itemDescriptionTextBox.TabIndex = 20;
            this.itemDescriptionTextBox.TabStop = false;
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
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(19, 25);
            this.itemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(34, 17);
            this.itemLabel.TabIndex = 4;
            this.itemLabel.Text = "Item";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(712, 430);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 28);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(712, 466);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 28);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // personInChargeLabel
            // 
            this.personInChargeLabel.AutoSize = true;
            this.personInChargeLabel.Location = new System.Drawing.Point(370, 52);
            this.personInChargeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personInChargeLabel.Name = "personInChargeLabel";
            this.personInChargeLabel.Size = new System.Drawing.Size(118, 17);
            this.personInChargeLabel.TabIndex = 3;
            this.personInChargeLabel.Text = "Person in Charge";
            // 
            // personInChargeTextBox
            // 
            this.personInChargeTextBox.Location = new System.Drawing.Point(496, 47);
            this.personInChargeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.personInChargeTextBox.Name = "personInChargeTextBox";
            this.personInChargeTextBox.Size = new System.Drawing.Size(208, 22);
            this.personInChargeTextBox.TabIndex = 3;
            // 
            // docState
            // 
            this.docState.AutoSize = true;
            this.docState.Location = new System.Drawing.Point(17, 89);
            this.docState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.docState.Name = "docState";
            this.docState.Size = new System.Drawing.Size(41, 17);
            this.docState.TabIndex = 4;
            this.docState.Text = "State";
            // 
            // stateTexBox
            // 
            this.stateTexBox.Location = new System.Drawing.Point(140, 86);
            this.stateTexBox.Margin = new System.Windows.Forms.Padding(4);
            this.stateTexBox.Name = "stateTexBox";
            this.stateTexBox.Size = new System.Drawing.Size(91, 22);
            this.stateTexBox.TabIndex = 4;
            // 
            // stockReceiptDocumentLabel
            // 
            this.stockReceiptDocumentLabel.AutoSize = true;
            this.stockReceiptDocumentLabel.Location = new System.Drawing.Point(239, 91);
            this.stockReceiptDocumentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockReceiptDocumentLabel.Name = "stockReceiptDocumentLabel";
            this.stockReceiptDocumentLabel.Size = new System.Drawing.Size(99, 17);
            this.stockReceiptDocumentLabel.TabIndex = 5;
            this.stockReceiptDocumentLabel.Text = "Stock Receipt ";
            // 
            // stockReceiptTextBox
            // 
            this.stockReceiptTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.stockReceiptTextBox.Location = new System.Drawing.Point(346, 86);
            this.stockReceiptTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockReceiptTextBox.Name = "stockReceiptTextBox";
            this.stockReceiptTextBox.Size = new System.Drawing.Size(91, 22);
            this.stockReceiptTextBox.TabIndex = 5;
            this.stockReceiptTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.stockReceiptTextBox_Validating);
            // 
            // stockReceiptDescriptionTextBox
            // 
            this.stockReceiptDescriptionTextBox.Location = new System.Drawing.Point(445, 86);
            this.stockReceiptDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockReceiptDescriptionTextBox.Name = "stockReceiptDescriptionTextBox";
            this.stockReceiptDescriptionTextBox.ReadOnly = true;
            this.stockReceiptDescriptionTextBox.Size = new System.Drawing.Size(259, 22);
            this.stockReceiptDescriptionTextBox.TabIndex = 14;
            this.stockReceiptDescriptionTextBox.TabStop = false;
            // 
            // stockIssueDocumentLabel
            // 
            this.stockIssueDocumentLabel.AutoSize = true;
            this.stockIssueDocumentLabel.Location = new System.Drawing.Point(241, 129);
            this.stockIssueDocumentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockIssueDocumentLabel.Name = "stockIssueDocumentLabel";
            this.stockIssueDocumentLabel.Size = new System.Drawing.Size(80, 17);
            this.stockIssueDocumentLabel.TabIndex = 13;
            this.stockIssueDocumentLabel.Text = "Stock Issue";
            // 
            // stockIssueTextBox
            // 
            this.stockIssueTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.stockIssueTextBox.Location = new System.Drawing.Point(346, 126);
            this.stockIssueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockIssueTextBox.Name = "stockIssueTextBox";
            this.stockIssueTextBox.Size = new System.Drawing.Size(91, 22);
            this.stockIssueTextBox.TabIndex = 7;
            this.stockIssueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.stockIssueTextBox_Validating);
            // 
            // stockIssueDescriptionTextBox
            // 
            this.stockIssueDescriptionTextBox.Location = new System.Drawing.Point(445, 126);
            this.stockIssueDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockIssueDescriptionTextBox.Name = "stockIssueDescriptionTextBox";
            this.stockIssueDescriptionTextBox.ReadOnly = true;
            this.stockIssueDescriptionTextBox.Size = new System.Drawing.Size(259, 22);
            this.stockIssueDescriptionTextBox.TabIndex = 15;
            this.stockIssueDescriptionTextBox.TabStop = false;
            // 
            // entrySeriesLabel
            // 
            this.entrySeriesLabel.AutoSize = true;
            this.entrySeriesLabel.Location = new System.Drawing.Point(17, 131);
            this.entrySeriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entrySeriesLabel.Name = "entrySeriesLabel";
            this.entrySeriesLabel.Size = new System.Drawing.Size(85, 17);
            this.entrySeriesLabel.TabIndex = 16;
            this.entrySeriesLabel.Text = "Entry Series";
            // 
            // entrySeriesTextBox
            // 
            this.entrySeriesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entrySeriesTextBox.Location = new System.Drawing.Point(140, 126);
            this.entrySeriesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.entrySeriesTextBox.Name = "entrySeriesTextBox";
            this.entrySeriesTextBox.Size = new System.Drawing.Size(91, 22);
            this.entrySeriesTextBox.TabIndex = 6;
            this.entrySeriesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.entrySeriesTextBox_Validating);
            // 
            // outputSeriesLabel
            // 
            this.outputSeriesLabel.AutoSize = true;
            this.outputSeriesLabel.Location = new System.Drawing.Point(17, 176);
            this.outputSeriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputSeriesLabel.Name = "outputSeriesLabel";
            this.outputSeriesLabel.Size = new System.Drawing.Size(95, 17);
            this.outputSeriesLabel.TabIndex = 18;
            this.outputSeriesLabel.Text = "Output Series";
            // 
            // outputSeriesTextBox
            // 
            this.outputSeriesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.outputSeriesTextBox.Location = new System.Drawing.Point(140, 173);
            this.outputSeriesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputSeriesTextBox.Name = "outputSeriesTextBox";
            this.outputSeriesTextBox.Size = new System.Drawing.Size(91, 22);
            this.outputSeriesTextBox.TabIndex = 8;
            this.outputSeriesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.outputSeriesTextBox_Validating);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.Controls.Add(this.outputSeriesTextBox);
            this.Controls.Add(this.outputSeriesLabel);
            this.Controls.Add(this.entrySeriesTextBox);
            this.Controls.Add(this.entrySeriesLabel);
            this.Controls.Add(this.stockIssueDescriptionTextBox);
            this.Controls.Add(this.stockIssueTextBox);
            this.Controls.Add(this.stockIssueDocumentLabel);
            this.Controls.Add(this.stockReceiptDescriptionTextBox);
            this.Controls.Add(this.stockReceiptTextBox);
            this.Controls.Add(this.stockReceiptDocumentLabel);
            this.Controls.Add(this.stateTexBox);
            this.Controls.Add(this.docState);
            this.Controls.Add(this.personInChargeTextBox);
            this.Controls.Add(this.personInChargeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.documentLinesGroupBox);
            this.Controls.Add(this.warehouseDescriptionTextBox);
            this.Controls.Add(this.warehouseTextBox);
            this.Controls.Add(this.warehouseLabel);
            this.Controls.Add(this.inventoryDescriptionTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Sample";
            this.documentLinesGroupBox.ResumeLayout(false);
            this.documentLinesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox inventoryDescriptionTextBox;
        private System.Windows.Forms.Label warehouseLabel;
        private System.Windows.Forms.TextBox warehouseTextBox;
        private System.Windows.Forms.TextBox warehouseDescriptionTextBox;
        private System.Windows.Forms.GroupBox documentLinesGroupBox;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.ListView documentLinesListView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label personInChargeLabel;
        private System.Windows.Forms.TextBox personInChargeTextBox;
        private System.Windows.Forms.Label docState;
        private System.Windows.Forms.TextBox stateTexBox;
        private System.Windows.Forms.Label stockReceiptDocumentLabel;
        private System.Windows.Forms.TextBox stockReceiptTextBox;
        private System.Windows.Forms.TextBox stockReceiptDescriptionTextBox;
        private System.Windows.Forms.Label stockIssueDocumentLabel;
        private System.Windows.Forms.TextBox stockIssueTextBox;
        private System.Windows.Forms.TextBox stockIssueDescriptionTextBox;
        private System.Windows.Forms.Label entrySeriesLabel;
        private System.Windows.Forms.TextBox entrySeriesTextBox;
        private System.Windows.Forms.Label outputSeriesLabel;
        private System.Windows.Forms.TextBox outputSeriesTextBox;
        private System.Windows.Forms.TextBox unityTextBox;
        private System.Windows.Forms.Label unityLabel;
    }
}