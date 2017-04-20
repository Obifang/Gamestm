namespace PHPSolution
{
    partial class editsaleform
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
            this.saledate = new System.Windows.Forms.TextBox();
            this.pHPDatabaseDataSet = new PHPSolution.PHPDatabaseDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new PHPSolution.PHPDatabaseDataSetTableAdapters.TableAdapterManager();
            this.saleno = new System.Windows.Forms.TextBox();
            this.stockSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockSaleTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockSaleTableAdapter();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.SaleTableAdapter();
            this.newitem = new System.Windows.Forms.Button();
            this.salechecklistboxlabel = new System.Windows.Forms.Label();
            this.salechecklistbox = new System.Windows.Forms.CheckedListBox();
            this.editselecteditems = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saledate
            // 
            this.saledate.Location = new System.Drawing.Point(12, 42);
            this.saledate.Name = "saledate";
            this.saledate.Size = new System.Drawing.Size(449, 20);
            this.saledate.TabIndex = 27;
            this.saledate.Text = "Date";
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
            // saleno
            // 
            this.saleno.Location = new System.Drawing.Point(12, 16);
            this.saleno.Name = "saleno";
            this.saleno.ReadOnly = true;
            this.saleno.Size = new System.Drawing.Size(449, 20);
            this.saleno.TabIndex = 33;
            this.saleno.Text = "ID Number";
            // 
            // stockSaleBindingSource
            // 
            this.stockSaleBindingSource.DataMember = "StockSale";
            this.stockSaleBindingSource.DataSource = this.pHPDatabaseDataSet;
            this.stockSaleBindingSource.Filter = "";
            // 
            // stockSaleTableAdapter
            // 
            this.stockSaleTableAdapter.ClearBeforeFill = true;
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
            // newitem
            // 
            this.newitem.Location = new System.Drawing.Point(242, 285);
            this.newitem.Name = "newitem";
            this.newitem.Size = new System.Drawing.Size(220, 23);
            this.newitem.TabIndex = 35;
            this.newitem.Text = "Add New Item";
            this.newitem.UseVisualStyleBackColor = true;
            this.newitem.Click += new System.EventHandler(this.newitem_Click);
            // 
            // salechecklistboxlabel
            // 
            this.salechecklistboxlabel.AutoSize = true;
            this.salechecklistboxlabel.Location = new System.Drawing.Point(11, 72);
            this.salechecklistboxlabel.Name = "salechecklistboxlabel";
            this.salechecklistboxlabel.Size = new System.Drawing.Size(165, 13);
            this.salechecklistboxlabel.TabIndex = 37;
            this.salechecklistboxlabel.Text = "Please select stock to edit below:";
            // 
            // salechecklistbox
            // 
            this.salechecklistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salechecklistbox.CheckOnClick = true;
            this.salechecklistbox.FormattingEnabled = true;
            this.salechecklistbox.Location = new System.Drawing.Point(12, 97);
            this.salechecklistbox.Name = "salechecklistbox";
            this.salechecklistbox.Size = new System.Drawing.Size(449, 182);
            this.salechecklistbox.TabIndex = 36;
            // 
            // editselecteditems
            // 
            this.editselecteditems.Location = new System.Drawing.Point(12, 285);
            this.editselecteditems.Name = "editselecteditems";
            this.editselecteditems.Size = new System.Drawing.Size(220, 23);
            this.editselecteditems.TabIndex = 38;
            this.editselecteditems.Text = "Edit Selected Items";
            this.editselecteditems.UseVisualStyleBackColor = true;
            this.editselecteditems.Click += new System.EventHandler(this.editselecteditems_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(12, 314);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(450, 23);
            this.exitbutton.TabIndex = 28;
            this.exitbutton.Text = "Save and Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // editsaleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 350);
            this.Controls.Add(this.editselecteditems);
            this.Controls.Add(this.salechecklistboxlabel);
            this.Controls.Add(this.salechecklistbox);
            this.Controls.Add(this.newitem);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.saledate);
            this.Controls.Add(this.saleno);
            this.Name = "editsaleform";
            this.Text = "Edit Sale";
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox saledate;
        private PHPDatabaseDataSet pHPDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private PHPDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox saleno;
        private System.Windows.Forms.BindingSource stockSaleBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockSaleTableAdapter stockSaleTableAdapter;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private PHPDatabaseDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private System.Windows.Forms.Button newitem;
        private System.Windows.Forms.Label salechecklistboxlabel;
        private System.Windows.Forms.CheckedListBox salechecklistbox;
        private System.Windows.Forms.Button editselecteditems;
        private System.Windows.Forms.Button exitbutton;
    }
}