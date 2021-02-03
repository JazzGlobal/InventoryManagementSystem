namespace InventoryManagementSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsSearchTextBox = new System.Windows.Forms.TextBox();
            this.partsLabel = new System.Windows.Forms.Label();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.partsModifyButton = new System.Windows.Forms.Button();
            this.partsDeleteButton = new System.Windows.Forms.Button();
            this.productsDeleteButton = new System.Windows.Forms.Button();
            this.productsModifyButton = new System.Windows.Forms.Button();
            this.productsAddButton = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.productsSearchTextbox = new System.Windows.Forms.TextBox();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.partDataGridView = new System.Windows.Forms.DataGridView();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(155, 46);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.partsSearchButton.TabIndex = 1;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partsSearchTextBox
            // 
            this.partsSearchTextBox.Location = new System.Drawing.Point(236, 46);
            this.partsSearchTextBox.Name = "partsSearchTextBox";
            this.partsSearchTextBox.Size = new System.Drawing.Size(163, 20);
            this.partsSearchTextBox.TabIndex = 2;
            this.partsSearchTextBox.TextChanged += new System.EventHandler(this.partsSearchTextBox_TextChanged);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(16, 56);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(31, 13);
            this.partsLabel.TabIndex = 4;
            this.partsLabel.Text = "Parts";
            // 
            // partsAddButton
            // 
            this.partsAddButton.Location = new System.Drawing.Point(186, 386);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(51, 30);
            this.partsAddButton.TabIndex = 5;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            this.partsAddButton.Click += new System.EventHandler(this.partsAddButton_Click);
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.Location = new System.Drawing.Point(267, 386);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(51, 30);
            this.partsModifyButton.TabIndex = 6;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            this.partsModifyButton.Click += new System.EventHandler(this.partsModifyButton_Click);
            // 
            // partsDeleteButton
            // 
            this.partsDeleteButton.Location = new System.Drawing.Point(348, 386);
            this.partsDeleteButton.Name = "partsDeleteButton";
            this.partsDeleteButton.Size = new System.Drawing.Size(51, 30);
            this.partsDeleteButton.TabIndex = 7;
            this.partsDeleteButton.Text = "Delete";
            this.partsDeleteButton.UseVisualStyleBackColor = true;
            this.partsDeleteButton.Click += new System.EventHandler(this.partsDeleteButton_Click);
            // 
            // productsDeleteButton
            // 
            this.productsDeleteButton.Location = new System.Drawing.Point(767, 386);
            this.productsDeleteButton.Name = "productsDeleteButton";
            this.productsDeleteButton.Size = new System.Drawing.Size(51, 30);
            this.productsDeleteButton.TabIndex = 14;
            this.productsDeleteButton.Text = "Delete";
            this.productsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Location = new System.Drawing.Point(686, 386);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(51, 30);
            this.productsModifyButton.TabIndex = 13;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            this.productsModifyButton.Click += new System.EventHandler(this.productsModifyButton_Click);
            // 
            // productsAddButton
            // 
            this.productsAddButton.Location = new System.Drawing.Point(605, 386);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(51, 30);
            this.productsAddButton.TabIndex = 12;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            this.productsAddButton.Click += new System.EventHandler(this.productsAddButton_Click);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(435, 56);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(49, 13);
            this.productsLabel.TabIndex = 11;
            this.productsLabel.Text = "Products";
            // 
            // productsSearchTextbox
            // 
            this.productsSearchTextbox.Location = new System.Drawing.Point(655, 46);
            this.productsSearchTextbox.Name = "productsSearchTextbox";
            this.productsSearchTextbox.Size = new System.Drawing.Size(163, 20);
            this.productsSearchTextbox.TabIndex = 9;
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(574, 46);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productsSearchButton.TabIndex = 8;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(767, 425);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 30);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // partDataGridView
            // 
            this.partDataGridView.AutoGenerateColumns = false;
            this.partDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.partDataGridView.DataSource = this.partBindingSource1;
            this.partDataGridView.Location = new System.Drawing.Point(16, 75);
            this.partDataGridView.MultiSelect = false;
            this.partDataGridView.Name = "partDataGridView";
            this.partDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partDataGridView.Size = new System.Drawing.Size(410, 305);
            this.partDataGridView.TabIndex = 16;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.inStockDataGridViewTextBoxColumn1,
            this.minDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(438, 75);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(385, 305);
            this.productDataGridView.TabIndex = 17;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            this.inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn1.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            // 
            // minDataGridViewTextBoxColumn1
            // 
            this.minDataGridViewTextBoxColumn1.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn1.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            this.maxDataGridViewTextBoxColumn1.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn1.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(InventoryManagementSystem.Product);
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            // 
            // partBindingSource1
            // 
            this.partBindingSource1.DataSource = typeof(InventoryManagementSystem.Part);
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(InventoryManagementSystem.Part);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 468);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.partDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productsDeleteButton);
            this.Controls.Add(this.productsModifyButton);
            this.Controls.Add(this.productsAddButton);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.productsSearchTextbox);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.partsDeleteButton);
            this.Controls.Add(this.partsModifyButton);
            this.Controls.Add(this.partsAddButton);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.partsSearchTextBox);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.TextBox partsSearchTextBox;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Button partsAddButton;
        private System.Windows.Forms.Button partsModifyButton;
        private System.Windows.Forms.Button partsDeleteButton;
        private System.Windows.Forms.Button productsDeleteButton;
        private System.Windows.Forms.Button productsModifyButton;
        private System.Windows.Forms.Button productsAddButton;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.TextBox productsSearchTextbox;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.DataGridView partDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
    }
}

