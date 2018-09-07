namespace Primavera.Inventory.Documents
{
    partial class CompositionsBreakdownsForm
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
            this.docTypeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.relatedDataCheckBox = new System.Windows.Forms.CheckBox();
            this.documentLinesGroupBox = new System.Windows.Forms.GroupBox();
            this.targetStateTextBox = new System.Windows.Forms.TextBox();
            this.targetStateLabel = new System.Windows.Forms.Label();
            this.sourceStateTextBox = new System.Windows.Forms.TextBox();
            this.sourceStateLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.documentLinesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.warehouseTextBox = new System.Windows.Forms.TextBox();
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.componentsGroupBox = new System.Windows.Forms.GroupBox();
            this.componentTargetStateTextBox = new System.Windows.Forms.TextBox();
            this.componentTargetStateLabel = new System.Windows.Forms.Label();
            this.componentSourceStateTextBox = new System.Windows.Forms.TextBox();
            this.componentSourceStateLabel = new System.Windows.Forms.Label();
            this.lotTextBox = new System.Windows.Forms.TextBox();
            this.lotLabel = new System.Windows.Forms.Label();
            this.addComponentButton = new System.Windows.Forms.Button();
            this.componentsListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueComponentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valueComponentLabel = new System.Windows.Forms.Label();
            this.quantityComponentLabel = new System.Windows.Forms.Label();
            this.quantityComponentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.warehouseComponentTextBox = new System.Windows.Forms.TextBox();
            this.warehouseComponentLabel = new System.Windows.Forms.Label();
            this.componentItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.componentItemTextBox = new System.Windows.Forms.TextBox();
            this.componentItemlabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.documentLinesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.componentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueComponentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityComponentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // docTypeLabel
            // 
            this.docTypeLabel.AutoSize = true;
            this.docTypeLabel.Location = new System.Drawing.Point(23, 20);
            this.docTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.docTypeLabel.Name = "docTypeLabel";
            this.docTypeLabel.Size = new System.Drawing.Size(73, 17);
            this.docTypeLabel.TabIndex = 0;
            this.docTypeLabel.Text = "Doc. Type";
            // 
            // docTypeTextBox
            // 
            this.docTypeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.docTypeTextBox.Location = new System.Drawing.Point(116, 15);
            this.docTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.docTypeTextBox.Name = "docTypeTextBox";
            this.docTypeTextBox.Size = new System.Drawing.Size(91, 22);
            this.docTypeTextBox.TabIndex = 0;
            this.docTypeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.docTypeTextBox_Validating);
            // 
            // docTypeDescriptionTextBox
            // 
            this.docTypeDescriptionTextBox.Location = new System.Drawing.Point(215, 15);
            this.docTypeDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.docTypeDescriptionTextBox.Name = "docTypeDescriptionTextBox";
            this.docTypeDescriptionTextBox.ReadOnly = true;
            this.docTypeDescriptionTextBox.Size = new System.Drawing.Size(304, 22);
            this.docTypeDescriptionTextBox.TabIndex = 0;
            this.docTypeDescriptionTextBox.TabStop = false;
            // 
            // seriesLabel
            // 
            this.seriesLabel.AutoSize = true;
            this.seriesLabel.Location = new System.Drawing.Point(544, 22);
            this.seriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(48, 17);
            this.seriesLabel.TabIndex = 1;
            this.seriesLabel.Text = "Series";
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.seriesTextBox.Location = new System.Drawing.Point(600, 17);
            this.seriesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(91, 22);
            this.seriesTextBox.TabIndex = 1;
            this.seriesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.seriesTextBox_Validating);
            // 
            // relatedDataCheckBox
            // 
            this.relatedDataCheckBox.AutoSize = true;
            this.relatedDataCheckBox.Location = new System.Drawing.Point(26, 59);
            this.relatedDataCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.relatedDataCheckBox.Name = "relatedDataCheckBox";
            this.relatedDataCheckBox.Size = new System.Drawing.Size(142, 21);
            this.relatedDataCheckBox.TabIndex = 2;
            this.relatedDataCheckBox.Text = "Fill Related Data?";
            this.relatedDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // documentLinesGroupBox
            // 
            this.documentLinesGroupBox.Controls.Add(this.targetStateTextBox);
            this.documentLinesGroupBox.Controls.Add(this.targetStateLabel);
            this.documentLinesGroupBox.Controls.Add(this.sourceStateTextBox);
            this.documentLinesGroupBox.Controls.Add(this.sourceStateLabel);
            this.documentLinesGroupBox.Controls.Add(this.addButton);
            this.documentLinesGroupBox.Controls.Add(this.documentLinesListView);
            this.documentLinesGroupBox.Controls.Add(this.valueLabel);
            this.documentLinesGroupBox.Controls.Add(this.valueNumericUpDown);
            this.documentLinesGroupBox.Controls.Add(this.quantityNumericUpDown);
            this.documentLinesGroupBox.Controls.Add(this.quantityLabel);
            this.documentLinesGroupBox.Controls.Add(this.warehouseTextBox);
            this.documentLinesGroupBox.Controls.Add(this.warehouseLabel);
            this.documentLinesGroupBox.Controls.Add(this.itemDescriptionTextBox);
            this.documentLinesGroupBox.Controls.Add(this.itemTextBox);
            this.documentLinesGroupBox.Controls.Add(this.itemLabel);
            this.documentLinesGroupBox.Location = new System.Drawing.Point(16, 107);
            this.documentLinesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.documentLinesGroupBox.Name = "documentLinesGroupBox";
            this.documentLinesGroupBox.Size = new System.Drawing.Size(675, 316);
            this.documentLinesGroupBox.TabIndex = 3;
            this.documentLinesGroupBox.TabStop = false;
            this.documentLinesGroupBox.Text = "Document Lines";
            // 
            // targetStateTextBox
            // 
            this.targetStateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.targetStateTextBox.Location = new System.Drawing.Point(323, 103);
            this.targetStateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.targetStateTextBox.Name = "targetStateTextBox";
            this.targetStateTextBox.Size = new System.Drawing.Size(91, 22);
            this.targetStateTextBox.TabIndex = 5;
            this.targetStateTextBox.Text = "DISP";
            this.targetStateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.targetStateTextBox_Validating);
            // 
            // targetStateLabel
            // 
            this.targetStateLabel.AutoSize = true;
            this.targetStateLabel.Location = new System.Drawing.Point(226, 106);
            this.targetStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.targetStateLabel.Name = "targetStateLabel";
            this.targetStateLabel.Size = new System.Drawing.Size(87, 17);
            this.targetStateLabel.TabIndex = 13;
            this.targetStateLabel.Text = "Target State";
            // 
            // sourceStateTextBox
            // 
            this.sourceStateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sourceStateTextBox.Location = new System.Drawing.Point(123, 101);
            this.sourceStateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceStateTextBox.Name = "sourceStateTextBox";
            this.sourceStateTextBox.Size = new System.Drawing.Size(91, 22);
            this.sourceStateTextBox.TabIndex = 4;
            this.sourceStateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sourceStateTextBox_Validating);
            // 
            // sourceStateLabel
            // 
            this.sourceStateLabel.AutoSize = true;
            this.sourceStateLabel.Location = new System.Drawing.Point(19, 106);
            this.sourceStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceStateLabel.Name = "sourceStateLabel";
            this.sourceStateLabel.Size = new System.Drawing.Size(90, 17);
            this.sourceStateLabel.TabIndex = 11;
            this.sourceStateLabel.Text = "Source State";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(596, 149);
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
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.documentLinesListView.FullRowSelect = true;
            this.documentLinesListView.Location = new System.Drawing.Point(7, 185);
            this.documentLinesListView.Margin = new System.Windows.Forms.Padding(4);
            this.documentLinesListView.MultiSelect = false;
            this.documentLinesListView.Name = "documentLinesListView";
            this.documentLinesListView.Size = new System.Drawing.Size(660, 121);
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
            // columnHeader2
            // 
            this.columnHeader2.Text = "Warehouse";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 100;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(453, 61);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(44, 17);
            this.valueLabel.TabIndex = 8;
            this.valueLabel.Text = "Value";
            // 
            // valueNumericUpDown
            // 
            this.valueNumericUpDown.DecimalPlaces = 2;
            this.valueNumericUpDown.Location = new System.Drawing.Point(505, 60);
            this.valueNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.valueNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.valueNumericUpDown.Name = "valueNumericUpDown";
            this.valueNumericUpDown.Size = new System.Drawing.Size(92, 22);
            this.valueNumericUpDown.TabIndex = 3;
            this.valueNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.DecimalPlaces = 2;
            this.quantityNumericUpDown.Location = new System.Drawing.Point(322, 59);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
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
            this.quantityLabel.Location = new System.Drawing.Point(253, 62);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity";
            // 
            // warehouseTextBox
            // 
            this.warehouseTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.warehouseTextBox.Location = new System.Drawing.Point(123, 59);
            this.warehouseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseTextBox.Name = "warehouseTextBox";
            this.warehouseTextBox.Size = new System.Drawing.Size(91, 22);
            this.warehouseTextBox.TabIndex = 1;
            this.warehouseTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.warehouseTextBox_Validating);
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.Location = new System.Drawing.Point(19, 62);
            this.warehouseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(81, 17);
            this.warehouseLabel.TabIndex = 3;
            this.warehouseLabel.Text = "Warehouse";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(224, 21);
            this.itemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.ReadOnly = true;
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(373, 22);
            this.itemDescriptionTextBox.TabIndex = 0;
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
            this.itemLabel.TabIndex = 0;
            this.itemLabel.Text = "Item";
            // 
            // componentsGroupBox
            // 
            this.componentsGroupBox.Controls.Add(this.componentTargetStateTextBox);
            this.componentsGroupBox.Controls.Add(this.componentTargetStateLabel);
            this.componentsGroupBox.Controls.Add(this.componentSourceStateTextBox);
            this.componentsGroupBox.Controls.Add(this.componentSourceStateLabel);
            this.componentsGroupBox.Controls.Add(this.lotTextBox);
            this.componentsGroupBox.Controls.Add(this.lotLabel);
            this.componentsGroupBox.Controls.Add(this.addComponentButton);
            this.componentsGroupBox.Controls.Add(this.componentsListView);
            this.componentsGroupBox.Controls.Add(this.valueComponentNumericUpDown);
            this.componentsGroupBox.Controls.Add(this.valueComponentLabel);
            this.componentsGroupBox.Controls.Add(this.quantityComponentLabel);
            this.componentsGroupBox.Controls.Add(this.quantityComponentNumericUpDown);
            this.componentsGroupBox.Controls.Add(this.warehouseComponentTextBox);
            this.componentsGroupBox.Controls.Add(this.warehouseComponentLabel);
            this.componentsGroupBox.Controls.Add(this.componentItemDescriptionTextBox);
            this.componentsGroupBox.Controls.Add(this.componentItemTextBox);
            this.componentsGroupBox.Controls.Add(this.componentItemlabel);
            this.componentsGroupBox.Location = new System.Drawing.Point(16, 441);
            this.componentsGroupBox.Name = "componentsGroupBox";
            this.componentsGroupBox.Size = new System.Drawing.Size(675, 338);
            this.componentsGroupBox.TabIndex = 4;
            this.componentsGroupBox.TabStop = false;
            this.componentsGroupBox.Text = "Components";
            // 
            // componentTargetStateTextBox
            // 
            this.componentTargetStateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.componentTargetStateTextBox.Location = new System.Drawing.Point(124, 147);
            this.componentTargetStateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.componentTargetStateTextBox.Name = "componentTargetStateTextBox";
            this.componentTargetStateTextBox.Size = new System.Drawing.Size(91, 22);
            this.componentTargetStateTextBox.TabIndex = 6;
            this.componentTargetStateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.componentTargetStateTextBox_Validating);
            // 
            // componentTargetStateLabel
            // 
            this.componentTargetStateLabel.AutoSize = true;
            this.componentTargetStateLabel.Location = new System.Drawing.Point(19, 150);
            this.componentTargetStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.componentTargetStateLabel.Name = "componentTargetStateLabel";
            this.componentTargetStateLabel.Size = new System.Drawing.Size(87, 17);
            this.componentTargetStateLabel.TabIndex = 15;
            this.componentTargetStateLabel.Text = "Taregt State";
            // 
            // componentSourceStateTextBox
            // 
            this.componentSourceStateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.componentSourceStateTextBox.Location = new System.Drawing.Point(322, 98);
            this.componentSourceStateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.componentSourceStateTextBox.Name = "componentSourceStateTextBox";
            this.componentSourceStateTextBox.Size = new System.Drawing.Size(91, 22);
            this.componentSourceStateTextBox.TabIndex = 5;
            this.componentSourceStateTextBox.Text = "DISP";
            this.componentSourceStateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.componentSourceStateTextBox_Validating);
            // 
            // componentSourceStateLabel
            // 
            this.componentSourceStateLabel.AutoSize = true;
            this.componentSourceStateLabel.Location = new System.Drawing.Point(223, 104);
            this.componentSourceStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.componentSourceStateLabel.Name = "componentSourceStateLabel";
            this.componentSourceStateLabel.Size = new System.Drawing.Size(90, 17);
            this.componentSourceStateLabel.TabIndex = 13;
            this.componentSourceStateLabel.Text = "Source State";
            // 
            // lotTextBox
            // 
            this.lotTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lotTextBox.Location = new System.Drawing.Point(322, 57);
            this.lotTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lotTextBox.Name = "lotTextBox";
            this.lotTextBox.Size = new System.Drawing.Size(91, 22);
            this.lotTextBox.TabIndex = 2;
            this.lotTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.lotTextBox_Validating);
            // 
            // lotLabel
            // 
            this.lotLabel.AutoSize = true;
            this.lotLabel.Location = new System.Drawing.Point(285, 60);
            this.lotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lotLabel.Name = "lotLabel";
            this.lotLabel.Size = new System.Drawing.Size(28, 17);
            this.lotLabel.TabIndex = 11;
            this.lotLabel.Text = "Lot";
            // 
            // addComponentButton
            // 
            this.addComponentButton.Location = new System.Drawing.Point(596, 173);
            this.addComponentButton.Margin = new System.Windows.Forms.Padding(4);
            this.addComponentButton.Name = "addComponentButton";
            this.addComponentButton.Size = new System.Drawing.Size(72, 28);
            this.addComponentButton.TabIndex = 7;
            this.addComponentButton.Text = "Add";
            this.addComponentButton.UseVisualStyleBackColor = true;
            this.addComponentButton.Click += new System.EventHandler(this.addComponentButton_Click);
            // 
            // componentsListView
            // 
            this.componentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.componentsListView.FullRowSelect = true;
            this.componentsListView.Location = new System.Drawing.Point(9, 209);
            this.componentsListView.Margin = new System.Windows.Forms.Padding(4);
            this.componentsListView.MultiSelect = false;
            this.componentsListView.Name = "componentsListView";
            this.componentsListView.Size = new System.Drawing.Size(659, 121);
            this.componentsListView.TabIndex = 8;
            this.componentsListView.TabStop = false;
            this.componentsListView.UseCompatibleStateImageBehavior = false;
            this.componentsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Warehouse";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quantity";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Value";
            this.columnHeader8.Width = 100;
            // 
            // valueComponentNumericUpDown
            // 
            this.valueComponentNumericUpDown.DecimalPlaces = 2;
            this.valueComponentNumericUpDown.Location = new System.Drawing.Point(123, 99);
            this.valueComponentNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.valueComponentNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.valueComponentNumericUpDown.Name = "valueComponentNumericUpDown";
            this.valueComponentNumericUpDown.Size = new System.Drawing.Size(92, 22);
            this.valueComponentNumericUpDown.TabIndex = 4;
            this.valueComponentNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueComponentNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valueComponentLabel
            // 
            this.valueComponentLabel.AutoSize = true;
            this.valueComponentLabel.Location = new System.Drawing.Point(19, 104);
            this.valueComponentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueComponentLabel.Name = "valueComponentLabel";
            this.valueComponentLabel.Size = new System.Drawing.Size(44, 17);
            this.valueComponentLabel.TabIndex = 7;
            this.valueComponentLabel.Text = "Value";
            // 
            // quantityComponentLabel
            // 
            this.quantityComponentLabel.AutoSize = true;
            this.quantityComponentLabel.Location = new System.Drawing.Point(436, 60);
            this.quantityComponentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityComponentLabel.Name = "quantityComponentLabel";
            this.quantityComponentLabel.Size = new System.Drawing.Size(61, 17);
            this.quantityComponentLabel.TabIndex = 6;
            this.quantityComponentLabel.Text = "Quantity";
            // 
            // quantityComponentNumericUpDown
            // 
            this.quantityComponentNumericUpDown.DecimalPlaces = 2;
            this.quantityComponentNumericUpDown.Location = new System.Drawing.Point(505, 56);
            this.quantityComponentNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.quantityComponentNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.quantityComponentNumericUpDown.Name = "quantityComponentNumericUpDown";
            this.quantityComponentNumericUpDown.Size = new System.Drawing.Size(92, 22);
            this.quantityComponentNumericUpDown.TabIndex = 3;
            this.quantityComponentNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityComponentNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // warehouseComponentTextBox
            // 
            this.warehouseComponentTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.warehouseComponentTextBox.Location = new System.Drawing.Point(124, 55);
            this.warehouseComponentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseComponentTextBox.Name = "warehouseComponentTextBox";
            this.warehouseComponentTextBox.Size = new System.Drawing.Size(91, 22);
            this.warehouseComponentTextBox.TabIndex = 1;
            this.warehouseComponentTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.warehouseComponentTextBox_Validating);
            // 
            // warehouseComponentLabel
            // 
            this.warehouseComponentLabel.AutoSize = true;
            this.warehouseComponentLabel.Location = new System.Drawing.Point(19, 60);
            this.warehouseComponentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warehouseComponentLabel.Name = "warehouseComponentLabel";
            this.warehouseComponentLabel.Size = new System.Drawing.Size(81, 17);
            this.warehouseComponentLabel.TabIndex = 1;
            this.warehouseComponentLabel.Text = "Warehouse";
            // 
            // componentItemDescriptionTextBox
            // 
            this.componentItemDescriptionTextBox.Location = new System.Drawing.Point(224, 21);
            this.componentItemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.componentItemDescriptionTextBox.Name = "componentItemDescriptionTextBox";
            this.componentItemDescriptionTextBox.ReadOnly = true;
            this.componentItemDescriptionTextBox.Size = new System.Drawing.Size(373, 22);
            this.componentItemDescriptionTextBox.TabIndex = 0;
            this.componentItemDescriptionTextBox.TabStop = false;
            // 
            // componentItemTextBox
            // 
            this.componentItemTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.componentItemTextBox.Location = new System.Drawing.Point(124, 22);
            this.componentItemTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.componentItemTextBox.Name = "componentItemTextBox";
            this.componentItemTextBox.Size = new System.Drawing.Size(91, 22);
            this.componentItemTextBox.TabIndex = 0;
            this.componentItemTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.componentItemTextBox_Validating);
            // 
            // componentItemlabel
            // 
            this.componentItemlabel.AutoSize = true;
            this.componentItemlabel.Location = new System.Drawing.Point(19, 27);
            this.componentItemlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.componentItemlabel.Name = "componentItemlabel";
            this.componentItemlabel.Size = new System.Drawing.Size(34, 17);
            this.componentItemlabel.TabIndex = 0;
            this.componentItemlabel.Text = "Item";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(698, 707);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 28);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(698, 743);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 28);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CompositionsBreakdownsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 791);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.componentsGroupBox);
            this.Controls.Add(this.documentLinesGroupBox);
            this.Controls.Add(this.relatedDataCheckBox);
            this.Controls.Add(this.seriesTextBox);
            this.Controls.Add(this.seriesLabel);
            this.Controls.Add(this.docTypeDescriptionTextBox);
            this.Controls.Add(this.docTypeTextBox);
            this.Controls.Add(this.docTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompositionsBreakdownsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compositions/Breakdowns Sample";
            this.documentLinesGroupBox.ResumeLayout(false);
            this.documentLinesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.componentsGroupBox.ResumeLayout(false);
            this.componentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueComponentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityComponentNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label docTypeLabel;
        private System.Windows.Forms.TextBox docTypeTextBox;
        private System.Windows.Forms.TextBox docTypeDescriptionTextBox;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.CheckBox relatedDataCheckBox;
        private System.Windows.Forms.GroupBox documentLinesGroupBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.Label warehouseLabel;
        private System.Windows.Forms.TextBox warehouseTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.NumericUpDown valueNumericUpDown;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.ListView documentLinesListView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox componentsGroupBox;
        private System.Windows.Forms.TextBox componentItemDescriptionTextBox;
        private System.Windows.Forms.TextBox componentItemTextBox;
        private System.Windows.Forms.Label componentItemlabel;
        private System.Windows.Forms.Label quantityComponentLabel;
        private System.Windows.Forms.NumericUpDown quantityComponentNumericUpDown;
        private System.Windows.Forms.TextBox warehouseComponentTextBox;
        private System.Windows.Forms.Label warehouseComponentLabel;
        private System.Windows.Forms.NumericUpDown valueComponentNumericUpDown;
        private System.Windows.Forms.Label valueComponentLabel;
        private System.Windows.Forms.Button addComponentButton;
        private System.Windows.Forms.ListView componentsListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label sourceStateLabel;
        private System.Windows.Forms.TextBox sourceStateTextBox;
        private System.Windows.Forms.Label targetStateLabel;
        private System.Windows.Forms.TextBox targetStateTextBox;
        private System.Windows.Forms.Label lotLabel;
        private System.Windows.Forms.TextBox lotTextBox;
        private System.Windows.Forms.Label componentSourceStateLabel;
        private System.Windows.Forms.TextBox componentSourceStateTextBox;
        private System.Windows.Forms.TextBox componentTargetStateTextBox;
        private System.Windows.Forms.Label componentTargetStateLabel;
    }
}