namespace PHPSolution
{
    partial class AddItem
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
            this.pHPDatabaseDataSet = new PHPSolution.PHPDatabaseDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new PHPSolution.PHPDatabaseDataSetTableAdapters.TableAdapterManager();
            this.defaultpricebutton = new System.Windows.Forms.Button();
            this.stockquantity = new System.Windows.Forms.TextBox();
            this.stockprice = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.stockname = new System.Windows.Forms.TextBox();
            this.stockno = new System.Windows.Forms.TextBox();
            this.additembutton = new System.Windows.Forms.Button();
            this.stockSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockSaleTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockSaleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockSaleBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // defaultpricebutton
            // 
            this.defaultpricebutton.Location = new System.Drawing.Point(423, 2);
            this.defaultpricebutton.Name = "defaultpricebutton";
            this.defaultpricebutton.Size = new System.Drawing.Size(111, 22);
            this.defaultpricebutton.TabIndex = 1;
            this.defaultpricebutton.Text = "Current Price";
            this.defaultpricebutton.UseVisualStyleBackColor = true;
            this.defaultpricebutton.Click += new System.EventHandler(this.defaultpricebutton_Click);
            // 
            // stockquantity
            // 
            this.stockquantity.Location = new System.Drawing.Point(189, 4);
            this.stockquantity.Name = "stockquantity";
            this.stockquantity.Size = new System.Drawing.Size(111, 20);
            this.stockquantity.TabIndex = 2;
            this.stockquantity.Text = "Quantity Purchased";
            // 
            // stockprice
            // 
            this.stockprice.Location = new System.Drawing.Point(306, 4);
            this.stockprice.Name = "stockprice";
            this.stockprice.Size = new System.Drawing.Size(111, 20);
            this.stockprice.TabIndex = 3;
            this.stockprice.Text = "Purchase Price";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.stockname);
            this.panel.Controls.Add(this.stockno);
            this.panel.Controls.Add(this.stockprice);
            this.panel.Controls.Add(this.stockquantity);
            this.panel.Controls.Add(this.defaultpricebutton);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(538, 28);
            this.panel.TabIndex = 28;
            // 
            // stockname
            // 
            this.stockname.Location = new System.Drawing.Point(3, 4);
            this.stockname.Name = "stockname";
            this.stockname.ReadOnly = true;
            this.stockname.Size = new System.Drawing.Size(137, 20);
            this.stockname.TabIndex = 5;
            this.stockname.Text = "Name";
            // 
            // stockno
            // 
            this.stockno.Location = new System.Drawing.Point(146, 4);
            this.stockno.Name = "stockno";
            this.stockno.Size = new System.Drawing.Size(37, 20);
            this.stockno.TabIndex = 4;
            this.stockno.Text = "No:";
            // 
            // additembutton
            // 
            this.additembutton.Location = new System.Drawing.Point(12, 52);
            this.additembutton.Name = "additembutton";
            this.additembutton.Size = new System.Drawing.Size(538, 23);
            this.additembutton.TabIndex = 29;
            this.additembutton.Text = "Add Item";
            this.additembutton.UseVisualStyleBackColor = true;
            this.additembutton.Click += new System.EventHandler(this.additembutton_Click);
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
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 87);
            this.Controls.Add(this.additembutton);
            this.Controls.Add(this.panel);
            this.Name = "AddItem";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockSaleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PHPDatabaseDataSet pHPDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private PHPDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button defaultpricebutton;
        private System.Windows.Forms.TextBox stockquantity;
        private System.Windows.Forms.TextBox stockprice;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button additembutton;
        private System.Windows.Forms.TextBox stockno;
        private System.Windows.Forms.TextBox stockname;
        private System.Windows.Forms.BindingSource stockSaleBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockSaleTableAdapter stockSaleTableAdapter;
    }
}