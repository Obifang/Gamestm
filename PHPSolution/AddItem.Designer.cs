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
            this.stockno = new System.Windows.Forms.Label();
            this.defaultpricebutton = new System.Windows.Forms.Button();
            this.stockquantity = new System.Windows.Forms.TextBox();
            this.stockprice = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.additembutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.panel.SuspendLayout();
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
            // stockno
            // 
            this.stockno.AutoSize = true;
            this.stockno.Location = new System.Drawing.Point(5, 6);
            this.stockno.Name = "stockno";
            this.stockno.Size = new System.Drawing.Size(27, 13);
            this.stockno.TabIndex = 0;
            this.stockno.Text = "No: ";
            // 
            // defaultpricebutton
            // 
            this.defaultpricebutton.Location = new System.Drawing.Point(333, 2);
            this.defaultpricebutton.Name = "defaultpricebutton";
            this.defaultpricebutton.Size = new System.Drawing.Size(111, 22);
            this.defaultpricebutton.TabIndex = 1;
            this.defaultpricebutton.Text = "Current Price";
            this.defaultpricebutton.UseVisualStyleBackColor = true;
            this.defaultpricebutton.Click += new System.EventHandler(this.defaultpricebutton_Click);
            // 
            // stockquantity
            // 
            this.stockquantity.Location = new System.Drawing.Point(46, 3);
            this.stockquantity.Name = "stockquantity";
            this.stockquantity.Size = new System.Drawing.Size(158, 20);
            this.stockquantity.TabIndex = 2;
            this.stockquantity.Text = "Quantity Purchased";
            // 
            // stockprice
            // 
            this.stockprice.Location = new System.Drawing.Point(210, 3);
            this.stockprice.Name = "stockprice";
            this.stockprice.Size = new System.Drawing.Size(117, 20);
            this.stockprice.TabIndex = 3;
            this.stockprice.Text = "Purchase Price";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.stockprice);
            this.panel.Controls.Add(this.stockquantity);
            this.panel.Controls.Add(this.defaultpricebutton);
            this.panel.Controls.Add(this.stockno);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(449, 28);
            this.panel.TabIndex = 28;
            // 
            // additembutton
            // 
            this.additembutton.Location = new System.Drawing.Point(12, 52);
            this.additembutton.Name = "additembutton";
            this.additembutton.Size = new System.Drawing.Size(449, 23);
            this.additembutton.TabIndex = 29;
            this.additembutton.Text = "Add Item";
            this.additembutton.UseVisualStyleBackColor = true;
            this.additembutton.Click += new System.EventHandler(this.additembutton_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 87);
            this.Controls.Add(this.additembutton);
            this.Controls.Add(this.panel);
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PHPDatabaseDataSet pHPDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private PHPDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label stockno;
        private System.Windows.Forms.Button defaultpricebutton;
        private System.Windows.Forms.TextBox stockquantity;
        private System.Windows.Forms.TextBox stockprice;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button additembutton;
    }
}