namespace PHPSolution
{
    partial class addsaleform
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
            this.addsale = new System.Windows.Forms.Button();
            this.saledate = new System.Windows.Forms.TextBox();
            this.pHPDatabaseDataSet = new PHPSolution.PHPDatabaseDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new PHPSolution.PHPDatabaseDataSetTableAdapters.TableAdapterManager();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.SaleTableAdapter();
            this.salechecklistbox = new System.Windows.Forms.CheckedListBox();
            this.salechecklistboxlabel = new System.Windows.Forms.Label();
            this.stockSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockSaleTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockSaleTableAdapter();
            this.searchterm = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addsale
            // 
            this.addsale.Location = new System.Drawing.Point(12, 265);
            this.addsale.Name = "addsale";
            this.addsale.Size = new System.Drawing.Size(449, 23);
            this.addsale.TabIndex = 19;
            this.addsale.Text = "Add Sale";
            this.addsale.UseVisualStyleBackColor = true;
            this.addsale.Click += new System.EventHandler(this.addsale_Click);
            // 
            // saledate
            // 
            this.saledate.Location = new System.Drawing.Point(12, 12);
            this.saledate.Name = "saledate";
            this.saledate.Size = new System.Drawing.Size(449, 20);
            this.saledate.TabIndex = 18;
            this.saledate.Text = "Date Purchased ( YYYY-MM-DD)";
            // 
            // pHPDatabaseDataSet
            // 
            this.pHPDatabaseDataSet.DataSetName = "PHPDatabaseDataSet";
            this.pHPDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.pHPDatabaseDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.StockSaleTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.UpdateOrder = PHPSolution.PHPDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.pHPDatabaseDataSet;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // salechecklistbox
            // 
            this.salechecklistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salechecklistbox.CheckOnClick = true;
            this.salechecklistbox.FormattingEnabled = true;
            this.salechecklistbox.Location = new System.Drawing.Point(12, 69);
            this.salechecklistbox.Name = "salechecklistbox";
            this.salechecklistbox.Size = new System.Drawing.Size(449, 182);
            this.salechecklistbox.TabIndex = 24;
            // 
            // salechecklistboxlabel
            // 
            this.salechecklistboxlabel.AutoSize = true;
            this.salechecklistboxlabel.Location = new System.Drawing.Point(11, 44);
            this.salechecklistboxlabel.Name = "salechecklistboxlabel";
            this.salechecklistboxlabel.Size = new System.Drawing.Size(167, 13);
            this.salechecklistboxlabel.TabIndex = 25;
            this.salechecklistboxlabel.Text = "Please select, or search for stock:";
            // 
            // stockSaleBindingSource
            // 
            this.stockSaleBindingSource.DataMember = "StockSale";
            this.stockSaleBindingSource.DataSource = this.pHPDatabaseDataSet;
            // 
            // stockSaleTableAdapter
            // 
            this.stockSaleTableAdapter.ClearBeforeFill = true;
            // 
            // searchterm
            // 
            this.searchterm.Location = new System.Drawing.Point(184, 41);
            this.searchterm.Name = "searchterm";
            this.searchterm.Size = new System.Drawing.Size(128, 20);
            this.searchterm.TabIndex = 26;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(318, 39);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 27;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(399, 38);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(62, 23);
            this.resetbutton.TabIndex = 28;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // addsaleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 304);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchterm);
            this.Controls.Add(this.salechecklistboxlabel);
            this.Controls.Add(this.salechecklistbox);
            this.Controls.Add(this.addsale);
            this.Controls.Add(this.saledate);
            this.Name = "addsaleform";
            this.Text = "Add Sale";
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSaleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addsale;
        private System.Windows.Forms.TextBox saledate;
        private PHPDatabaseDataSet pHPDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private PHPDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private PHPDatabaseDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private System.Windows.Forms.CheckedListBox salechecklistbox;
        private System.Windows.Forms.Label salechecklistboxlabel;
        private System.Windows.Forms.BindingSource stockSaleBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockSaleTableAdapter stockSaleTableAdapter;
        private System.Windows.Forms.TextBox searchterm;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button resetbutton;
    }
}