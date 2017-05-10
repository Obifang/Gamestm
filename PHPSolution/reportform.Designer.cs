namespace PHPSolution
{
    partial class reportform
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
            this.stockSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockSale1DataGridView = new System.Windows.Forms.DataGridView();
            this.stockSale1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHPDatabaseDataSet = new PHPSolution.PHPDatabaseDataSet();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.ReportTableAdapter();
            this.tableAdapterManager = new PHPSolution.PHPDatabaseDataSetTableAdapters.TableAdapterManager();
            this.stockSaleTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockSaleTableAdapter();
            this.stockSale1TableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockSale1TableAdapter();
            this.stockNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPurchasdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgPurchasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSale1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSale1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stockSale1DataGridView
            // 
            this.stockSale1DataGridView.AutoGenerateColumns = false;
            this.stockSale1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockSale1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalValueDataGridViewTextBoxColumn,
            this.totalPurchasdDataGridViewTextBoxColumn,
            this.avgPurchasedDataGridViewTextBoxColumn,
            this.avgValueDataGridViewTextBoxColumn});
            this.stockSale1DataGridView.DataSource = this.stockSale1BindingSource;
            this.stockSale1DataGridView.Location = new System.Drawing.Point(12, 12);
            this.stockSale1DataGridView.Name = "stockSale1DataGridView";
            this.stockSale1DataGridView.Size = new System.Drawing.Size(1199, 481);
            this.stockSale1DataGridView.TabIndex = 0;
            // 
            // stockSale1BindingSource
            // 
            this.stockSale1BindingSource.DataMember = "StockSale1";
            this.stockSale1BindingSource.DataSource = this.pHPDatabaseDataSet;
            // 
            // pHPDatabaseDataSet
            // 
            this.pHPDatabaseDataSet.DataSetName = "PHPDatabaseDataSet";
            this.pHPDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "Report";
            this.reportBindingSource.DataSource = this.pHPDatabaseDataSet;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.StockSaleTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PHPSolution.PHPDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stockSaleTableAdapter
            // 
            this.stockSaleTableAdapter.ClearBeforeFill = true;
            // 
            // stockSale1TableAdapter
            // 
            this.stockSale1TableAdapter.ClearBeforeFill = true;
            // 
            // stockNoDataGridViewTextBoxColumn
            // 
            this.stockNoDataGridViewTextBoxColumn.DataPropertyName = "Stock_No";
            this.stockNoDataGridViewTextBoxColumn.HeaderText = "Stock_No";
            this.stockNoDataGridViewTextBoxColumn.Name = "stockNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "Desc";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalValueDataGridViewTextBoxColumn
            // 
            this.totalValueDataGridViewTextBoxColumn.DataPropertyName = "TotalValue";
            this.totalValueDataGridViewTextBoxColumn.HeaderText = "TotalValue";
            this.totalValueDataGridViewTextBoxColumn.Name = "totalValueDataGridViewTextBoxColumn";
            this.totalValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPurchasdDataGridViewTextBoxColumn
            // 
            this.totalPurchasdDataGridViewTextBoxColumn.DataPropertyName = "TotalPurchasd";
            this.totalPurchasdDataGridViewTextBoxColumn.HeaderText = "TotalPurchasd";
            this.totalPurchasdDataGridViewTextBoxColumn.Name = "totalPurchasdDataGridViewTextBoxColumn";
            this.totalPurchasdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avgPurchasedDataGridViewTextBoxColumn
            // 
            this.avgPurchasedDataGridViewTextBoxColumn.DataPropertyName = "AvgPurchased";
            this.avgPurchasedDataGridViewTextBoxColumn.HeaderText = "AvgPurchased";
            this.avgPurchasedDataGridViewTextBoxColumn.Name = "avgPurchasedDataGridViewTextBoxColumn";
            this.avgPurchasedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avgValueDataGridViewTextBoxColumn
            // 
            this.avgValueDataGridViewTextBoxColumn.DataPropertyName = "AvgValue";
            this.avgValueDataGridViewTextBoxColumn.HeaderText = "AvgValue";
            this.avgValueDataGridViewTextBoxColumn.Name = "avgValueDataGridViewTextBoxColumn";
            this.avgValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 505);
            this.Controls.Add(this.stockSale1DataGridView);
            this.Name = "reportform";
            this.Text = "reportform";
            this.Load += new System.EventHandler(this.reportform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSale1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSale1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PHPDatabaseDataSet pHPDatabaseDataSet;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private PHPDatabaseDataSetTableAdapters.ReportTableAdapter reportTableAdapter;
        private PHPDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource stockSaleBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockSaleTableAdapter stockSaleTableAdapter;
        private System.Windows.Forms.BindingSource stockSale1BindingSource;
        private PHPDatabaseDataSetTableAdapters.StockSale1TableAdapter stockSale1TableAdapter;
        private System.Windows.Forms.DataGridView stockSale1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchasdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgPurchasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgValueDataGridViewTextBoxColumn;
    }
}