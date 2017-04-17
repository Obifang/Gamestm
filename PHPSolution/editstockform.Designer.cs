namespace PHPSolution
{
    partial class editstockform
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
            this.stockprice = new System.Windows.Forms.TextBox();
            this.stockquantity = new System.Windows.Forms.TextBox();
            this.stocktype = new System.Windows.Forms.TextBox();
            this.stockdesc = new System.Windows.Forms.TextBox();
            this.editstockrecordbutton = new System.Windows.Forms.Button();
            this.stockname = new System.Windows.Forms.TextBox();
            this.pHPDatabaseDataSet = new PHPSolution.PHPDatabaseDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new PHPSolution.PHPDatabaseDataSetTableAdapters.TableAdapterManager();
            this.stocknumber = new System.Windows.Forms.TextBox();
            this.editstocktextbox = new System.Windows.Forms.TextBox();
            this.selectstocktoedit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stockprice
            // 
            this.stockprice.Location = new System.Drawing.Point(12, 228);
            this.stockprice.Name = "stockprice";
            this.stockprice.Size = new System.Drawing.Size(449, 20);
            this.stockprice.TabIndex = 23;
            this.stockprice.Text = "Price";
            // 
            // stockquantity
            // 
            this.stockquantity.Location = new System.Drawing.Point(12, 202);
            this.stockquantity.Name = "stockquantity";
            this.stockquantity.Size = new System.Drawing.Size(449, 20);
            this.stockquantity.TabIndex = 22;
            this.stockquantity.Text = "Quantity";
            // 
            // stocktype
            // 
            this.stocktype.Location = new System.Drawing.Point(12, 176);
            this.stocktype.Name = "stocktype";
            this.stocktype.Size = new System.Drawing.Size(449, 20);
            this.stocktype.TabIndex = 21;
            this.stocktype.Text = "Type";
            // 
            // stockdesc
            // 
            this.stockdesc.Location = new System.Drawing.Point(12, 150);
            this.stockdesc.Name = "stockdesc";
            this.stockdesc.Size = new System.Drawing.Size(449, 20);
            this.stockdesc.TabIndex = 20;
            this.stockdesc.Text = "Decription";
            // 
            // editstockrecordbutton
            // 
            this.editstockrecordbutton.Location = new System.Drawing.Point(12, 284);
            this.editstockrecordbutton.Name = "editstockrecordbutton";
            this.editstockrecordbutton.Size = new System.Drawing.Size(449, 23);
            this.editstockrecordbutton.TabIndex = 19;
            this.editstockrecordbutton.Text = "Edit Stock";
            this.editstockrecordbutton.UseVisualStyleBackColor = true;
            this.editstockrecordbutton.Click += new System.EventHandler(this.editstockrecordbutton_Click);
            // 
            // stockname
            // 
            this.stockname.Location = new System.Drawing.Point(12, 124);
            this.stockname.Name = "stockname";
            this.stockname.Size = new System.Drawing.Size(449, 20);
            this.stockname.TabIndex = 18;
            this.stockname.Text = "Name";
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
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.UpdateOrder = PHPSolution.PHPDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stocknumber
            // 
            this.stocknumber.Location = new System.Drawing.Point(12, 98);
            this.stocknumber.Name = "stocknumber";
            this.stocknumber.ReadOnly = true;
            this.stocknumber.Size = new System.Drawing.Size(449, 20);
            this.stocknumber.TabIndex = 24;
            this.stocknumber.Text = "ID Number";
            // 
            // editstocktextbox
            // 
            this.editstocktextbox.Location = new System.Drawing.Point(12, 12);
            this.editstocktextbox.Name = "editstocktextbox";
            this.editstocktextbox.Size = new System.Drawing.Size(449, 20);
            this.editstocktextbox.TabIndex = 25;
            this.editstocktextbox.Text = "Stock To Edit (ID Number) - If changed must press select stock to edit";
            // 
            // selectstocktoedit
            // 
            this.selectstocktoedit.Location = new System.Drawing.Point(12, 38);
            this.selectstocktoedit.Name = "selectstocktoedit";
            this.selectstocktoedit.Size = new System.Drawing.Size(449, 23);
            this.selectstocktoedit.TabIndex = 26;
            this.selectstocktoedit.Text = "Select Stock To Edit";
            this.selectstocktoedit.UseVisualStyleBackColor = true;
            this.selectstocktoedit.Click += new System.EventHandler(this.selectstocktoedit_Click);
            // 
            // editstockform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 315);
            this.Controls.Add(this.selectstocktoedit);
            this.Controls.Add(this.editstocktextbox);
            this.Controls.Add(this.stocknumber);
            this.Controls.Add(this.stockprice);
            this.Controls.Add(this.stockquantity);
            this.Controls.Add(this.stocktype);
            this.Controls.Add(this.stockdesc);
            this.Controls.Add(this.editstockrecordbutton);
            this.Controls.Add(this.stockname);
            this.Name = "editstockform";
            this.Text = "Edit Stock";
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stockprice;
        private System.Windows.Forms.TextBox stockquantity;
        private System.Windows.Forms.TextBox stocktype;
        private System.Windows.Forms.TextBox stockdesc;
        private System.Windows.Forms.Button editstockrecordbutton;
        private System.Windows.Forms.TextBox stockname;
        private PHPDatabaseDataSet pHPDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private PHPDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox stocknumber;
        public System.Windows.Forms.TextBox editstocktextbox;
        private System.Windows.Forms.Button selectstocktoedit;
    }
}