namespace PHPSolution
{
    partial class mainform
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
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHPDatabaseDataSet = new PHPSolution.PHPDatabaseDataSet();
            this.showstockrecord = new System.Windows.Forms.Button();
            this.stockno = new System.Windows.Forms.Label();
            this.stockname = new System.Windows.Forms.Label();
            this.stockdesc = new System.Windows.Forms.Label();
            this.stocktype = new System.Windows.Forms.Label();
            this.stockquantity = new System.Windows.Forms.Label();
            this.stockprice = new System.Windows.Forms.Label();
            this.addstockrecord = new System.Windows.Forms.Button();
            this.searchstocktextbox = new System.Windows.Forms.TextBox();
            this.searchstock = new System.Windows.Forms.Button();
            this.editstockrecord = new System.Windows.Forms.Button();
            this.showstocksearchbox = new System.Windows.Forms.TextBox();
            this.searchstockresult = new System.Windows.Forms.TextBox();
            this.searchsalemultiline = new System.Windows.Forms.TextBox();
            this.showsalesearchbox = new System.Windows.Forms.TextBox();
            this.editsalebutton = new System.Windows.Forms.Button();
            this.searchsaletextbox = new System.Windows.Forms.TextBox();
            this.searchsalebutton = new System.Windows.Forms.Button();
            this.addsalebutton = new System.Windows.Forms.Button();
            this.showsalebutton = new System.Windows.Forms.Button();
            this.stockTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new PHPSolution.PHPDatabaseDataSetTableAdapters.TableAdapterManager();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.SaleTableAdapter();
            this.showsalerecordmultiline = new System.Windows.Forms.TextBox();
            this.stockSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockSaleTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockSaleTableAdapter();
            this.editsalenotextbox = new System.Windows.Forms.TextBox();
            this.editstocktextbox = new System.Windows.Forms.TextBox();
            this.createreport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.pHPDatabaseDataSet;
            // 
            // pHPDatabaseDataSet
            // 
            this.pHPDatabaseDataSet.DataSetName = "PHPDatabaseDataSet";
            this.pHPDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showstockrecord
            // 
            this.showstockrecord.Location = new System.Drawing.Point(241, 120);
            this.showstockrecord.Name = "showstockrecord";
            this.showstockrecord.Size = new System.Drawing.Size(175, 23);
            this.showstockrecord.TabIndex = 2;
            this.showstockrecord.Text = "Show Stock Record";
            this.showstockrecord.UseVisualStyleBackColor = true;
            this.showstockrecord.Click += new System.EventHandler(this.showstockrecord_Click);
            // 
            // stockno
            // 
            this.stockno.AutoSize = true;
            this.stockno.Location = new System.Drawing.Point(251, 166);
            this.stockno.Name = "stockno";
            this.stockno.Size = new System.Drawing.Size(55, 13);
            this.stockno.TabIndex = 3;
            this.stockno.Text = "Stock No:";
            // 
            // stockname
            // 
            this.stockname.AutoSize = true;
            this.stockname.Location = new System.Drawing.Point(251, 179);
            this.stockname.Name = "stockname";
            this.stockname.Size = new System.Drawing.Size(69, 13);
            this.stockname.TabIndex = 4;
            this.stockname.Text = "Stock Name:";
            // 
            // stockdesc
            // 
            this.stockdesc.AutoSize = true;
            this.stockdesc.Location = new System.Drawing.Point(251, 192);
            this.stockdesc.Name = "stockdesc";
            this.stockdesc.Size = new System.Drawing.Size(66, 13);
            this.stockdesc.TabIndex = 5;
            this.stockdesc.Text = "Stock Desc:";
            // 
            // stocktype
            // 
            this.stocktype.AutoSize = true;
            this.stocktype.Location = new System.Drawing.Point(251, 205);
            this.stocktype.Name = "stocktype";
            this.stocktype.Size = new System.Drawing.Size(65, 13);
            this.stocktype.TabIndex = 6;
            this.stocktype.Text = "Stock Type:";
            // 
            // stockquantity
            // 
            this.stockquantity.AutoSize = true;
            this.stockquantity.Location = new System.Drawing.Point(251, 218);
            this.stockquantity.Name = "stockquantity";
            this.stockquantity.Size = new System.Drawing.Size(80, 13);
            this.stockquantity.TabIndex = 7;
            this.stockquantity.Text = "Stock Quantity:";
            // 
            // stockprice
            // 
            this.stockprice.AutoSize = true;
            this.stockprice.Location = new System.Drawing.Point(251, 231);
            this.stockprice.Name = "stockprice";
            this.stockprice.Size = new System.Drawing.Size(65, 13);
            this.stockprice.TabIndex = 8;
            this.stockprice.Text = "Stock Price:";
            // 
            // addstockrecord
            // 
            this.addstockrecord.Location = new System.Drawing.Point(241, 10);
            this.addstockrecord.Name = "addstockrecord";
            this.addstockrecord.Size = new System.Drawing.Size(175, 23);
            this.addstockrecord.TabIndex = 9;
            this.addstockrecord.Text = "Add Stock Record";
            this.addstockrecord.UseVisualStyleBackColor = true;
            this.addstockrecord.Click += new System.EventHandler(this.addstockrecord_Click);
            // 
            // searchstocktextbox
            // 
            this.searchstocktextbox.Location = new System.Drawing.Point(11, 12);
            this.searchstocktextbox.Name = "searchstocktextbox";
            this.searchstocktextbox.Size = new System.Drawing.Size(175, 20);
            this.searchstocktextbox.TabIndex = 12;
            this.searchstocktextbox.Text = "Name to seach for (exact)";
            // 
            // searchstock
            // 
            this.searchstock.Location = new System.Drawing.Point(11, 38);
            this.searchstock.Name = "searchstock";
            this.searchstock.Size = new System.Drawing.Size(175, 23);
            this.searchstock.TabIndex = 11;
            this.searchstock.Text = "Search Stock";
            this.searchstock.UseVisualStyleBackColor = true;
            this.searchstock.Click += new System.EventHandler(this.searchstock_Click);
            // 
            // editstockrecord
            // 
            this.editstockrecord.Location = new System.Drawing.Point(241, 65);
            this.editstockrecord.Name = "editstockrecord";
            this.editstockrecord.Size = new System.Drawing.Size(175, 23);
            this.editstockrecord.TabIndex = 16;
            this.editstockrecord.Text = "Edit Stock Record";
            this.editstockrecord.UseVisualStyleBackColor = true;
            this.editstockrecord.Click += new System.EventHandler(this.editstockrecord_Click);
            // 
            // showstocksearchbox
            // 
            this.showstocksearchbox.Location = new System.Drawing.Point(241, 94);
            this.showstocksearchbox.Name = "showstocksearchbox";
            this.showstocksearchbox.Size = new System.Drawing.Size(175, 20);
            this.showstocksearchbox.TabIndex = 17;
            this.showstocksearchbox.Text = "Stock to Display (ID Number)";
            // 
            // searchstockresult
            // 
            this.searchstockresult.Location = new System.Drawing.Point(12, 68);
            this.searchstockresult.Multiline = true;
            this.searchstockresult.Name = "searchstockresult";
            this.searchstockresult.ReadOnly = true;
            this.searchstockresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.searchstockresult.Size = new System.Drawing.Size(174, 296);
            this.searchstockresult.TabIndex = 18;
            // 
            // searchsalemultiline
            // 
            this.searchsalemultiline.Location = new System.Drawing.Point(488, 67);
            this.searchsalemultiline.Multiline = true;
            this.searchsalemultiline.Name = "searchsalemultiline";
            this.searchsalemultiline.ReadOnly = true;
            this.searchsalemultiline.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.searchsalemultiline.Size = new System.Drawing.Size(174, 296);
            this.searchsalemultiline.TabIndex = 33;
            // 
            // showsalesearchbox
            // 
            this.showsalesearchbox.Location = new System.Drawing.Point(717, 95);
            this.showsalesearchbox.Name = "showsalesearchbox";
            this.showsalesearchbox.Size = new System.Drawing.Size(175, 20);
            this.showsalesearchbox.TabIndex = 32;
            this.showsalesearchbox.Text = "Sale to Display (ID Number)";
            // 
            // editsalebutton
            // 
            this.editsalebutton.Location = new System.Drawing.Point(717, 65);
            this.editsalebutton.Name = "editsalebutton";
            this.editsalebutton.Size = new System.Drawing.Size(175, 23);
            this.editsalebutton.TabIndex = 31;
            this.editsalebutton.Text = "Edit Sale Record";
            this.editsalebutton.UseVisualStyleBackColor = true;
            this.editsalebutton.Click += new System.EventHandler(this.editsalebutton_Click);
            // 
            // searchsaletextbox
            // 
            this.searchsaletextbox.Location = new System.Drawing.Point(487, 11);
            this.searchsaletextbox.Name = "searchsaletextbox";
            this.searchsaletextbox.Size = new System.Drawing.Size(175, 20);
            this.searchsaletextbox.TabIndex = 30;
            this.searchsaletextbox.Text = "Date to seach for (YYYY-MM-DD)";
            // 
            // searchsalebutton
            // 
            this.searchsalebutton.Location = new System.Drawing.Point(487, 37);
            this.searchsalebutton.Name = "searchsalebutton";
            this.searchsalebutton.Size = new System.Drawing.Size(175, 23);
            this.searchsalebutton.TabIndex = 29;
            this.searchsalebutton.Text = "Search Sale";
            this.searchsalebutton.UseVisualStyleBackColor = true;
            this.searchsalebutton.Click += new System.EventHandler(this.searchsalebutton_Click);
            // 
            // addsalebutton
            // 
            this.addsalebutton.Location = new System.Drawing.Point(717, 9);
            this.addsalebutton.Name = "addsalebutton";
            this.addsalebutton.Size = new System.Drawing.Size(175, 23);
            this.addsalebutton.TabIndex = 28;
            this.addsalebutton.Text = "Add Sale Record";
            this.addsalebutton.UseVisualStyleBackColor = true;
            this.addsalebutton.Click += new System.EventHandler(this.addsalebutton_Click);
            // 
            // showsalebutton
            // 
            this.showsalebutton.Location = new System.Drawing.Point(717, 121);
            this.showsalebutton.Name = "showsalebutton";
            this.showsalebutton.Size = new System.Drawing.Size(175, 23);
            this.showsalebutton.TabIndex = 21;
            this.showsalebutton.Text = "Show Sale Record";
            this.showsalebutton.UseVisualStyleBackColor = true;
            this.showsalebutton.Click += new System.EventHandler(this.showsalebutton_Click);
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
            // showsalerecordmultiline
            // 
            this.showsalerecordmultiline.Location = new System.Drawing.Point(717, 153);
            this.showsalerecordmultiline.Multiline = true;
            this.showsalerecordmultiline.Name = "showsalerecordmultiline";
            this.showsalerecordmultiline.ReadOnly = true;
            this.showsalerecordmultiline.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showsalerecordmultiline.Size = new System.Drawing.Size(174, 210);
            this.showsalerecordmultiline.TabIndex = 40;
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
            // editsalenotextbox
            // 
            this.editsalenotextbox.Location = new System.Drawing.Point(717, 38);
            this.editsalenotextbox.Name = "editsalenotextbox";
            this.editsalenotextbox.Size = new System.Drawing.Size(174, 20);
            this.editsalenotextbox.TabIndex = 42;
            this.editsalenotextbox.Text = "Sale To Edit (ID Number)";
            // 
            // editstocktextbox
            // 
            this.editstocktextbox.Location = new System.Drawing.Point(241, 38);
            this.editstocktextbox.Name = "editstocktextbox";
            this.editstocktextbox.Size = new System.Drawing.Size(174, 20);
            this.editstocktextbox.TabIndex = 43;
            this.editstocktextbox.Text = "Stock To Edit (ID Number)";
            // 
            // createreport
            // 
            this.createreport.Location = new System.Drawing.Point(241, 340);
            this.createreport.Name = "createreport";
            this.createreport.Size = new System.Drawing.Size(174, 23);
            this.createreport.TabIndex = 46;
            this.createreport.Text = "Create Report";
            this.createreport.UseVisualStyleBackColor = true;
            this.createreport.Click += new System.EventHandler(this.createreport_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 373);
            this.Controls.Add(this.createreport);
            this.Controls.Add(this.editstocktextbox);
            this.Controls.Add(this.editsalenotextbox);
            this.Controls.Add(this.showsalerecordmultiline);
            this.Controls.Add(this.searchsalemultiline);
            this.Controls.Add(this.showsalesearchbox);
            this.Controls.Add(this.editsalebutton);
            this.Controls.Add(this.searchsaletextbox);
            this.Controls.Add(this.searchsalebutton);
            this.Controls.Add(this.addsalebutton);
            this.Controls.Add(this.showsalebutton);
            this.Controls.Add(this.searchstockresult);
            this.Controls.Add(this.showstocksearchbox);
            this.Controls.Add(this.editstockrecord);
            this.Controls.Add(this.searchstocktextbox);
            this.Controls.Add(this.searchstock);
            this.Controls.Add(this.addstockrecord);
            this.Controls.Add(this.stockprice);
            this.Controls.Add(this.stockquantity);
            this.Controls.Add(this.stocktype);
            this.Controls.Add(this.stockdesc);
            this.Controls.Add(this.stockname);
            this.Controls.Add(this.stockno);
            this.Controls.Add(this.showstockrecord);
            this.Name = "mainform";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSaleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PHPDatabaseDataSet pHPDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private PHPDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button showstockrecord;
        private System.Windows.Forms.Label stockno;
        private System.Windows.Forms.Label stockname;
        private System.Windows.Forms.Label stockdesc;
        private System.Windows.Forms.Label stocktype;
        private System.Windows.Forms.Label stockquantity;
        private System.Windows.Forms.Label stockprice;
        private System.Windows.Forms.Button addstockrecord;
        private System.Windows.Forms.TextBox searchstocktextbox;
        private System.Windows.Forms.Button searchstock;
        private System.Windows.Forms.Button editstockrecord;
        private System.Windows.Forms.TextBox showstocksearchbox;
        private System.Windows.Forms.TextBox searchstockresult;
        private System.Windows.Forms.TextBox searchsalemultiline;
        private System.Windows.Forms.TextBox showsalesearchbox;
        private System.Windows.Forms.Button editsalebutton;
        private System.Windows.Forms.TextBox searchsaletextbox;
        private System.Windows.Forms.Button searchsalebutton;
        private System.Windows.Forms.Button addsalebutton;
        private System.Windows.Forms.Button showsalebutton;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private PHPDatabaseDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private System.Windows.Forms.TextBox showsalerecordmultiline;
        private System.Windows.Forms.BindingSource stockSaleBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockSaleTableAdapter stockSaleTableAdapter;
        public System.Windows.Forms.TextBox editsalenotextbox;
        public System.Windows.Forms.TextBox editstocktextbox;
        private System.Windows.Forms.Button createreport;
    }
}