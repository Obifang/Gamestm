namespace PHPSolution
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.stockBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stockBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.showstockrecord = new System.Windows.Forms.Button();
            this.stockno = new System.Windows.Forms.Label();
            this.stockname = new System.Windows.Forms.Label();
            this.stockdesc = new System.Windows.Forms.Label();
            this.stocktype = new System.Windows.Forms.Label();
            this.stockquantity = new System.Windows.Forms.Label();
            this.stockprice = new System.Windows.Forms.Label();
            this.addstockrecord = new System.Windows.Forms.Button();
            this.editstocktextbox = new System.Windows.Forms.TextBox();
            this.searchstocktextbox = new System.Windows.Forms.TextBox();
            this.searchstock = new System.Windows.Forms.Button();
            this.editstockrecord = new System.Windows.Forms.Button();
            this.showstocksearchbox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHPDatabaseDataSet = new PHPSolution.PHPDatabaseDataSet();
            this.stockTableAdapter = new PHPSolution.PHPDatabaseDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new PHPSolution.PHPDatabaseDataSetTableAdapters.TableAdapterManager();
            this.searchstockresult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingNavigator)).BeginInit();
            this.stockBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // stockBindingNavigator
            // 
            this.stockBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stockBindingNavigator.BindingSource = this.stockBindingSource;
            this.stockBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stockBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stockBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stockBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.stockBindingNavigatorSaveItem});
            this.stockBindingNavigator.Location = new System.Drawing.Point(0, 507);
            this.stockBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stockBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stockBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stockBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stockBindingNavigator.Name = "stockBindingNavigator";
            this.stockBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stockBindingNavigator.Size = new System.Drawing.Size(643, 25);
            this.stockBindingNavigator.TabIndex = 0;
            this.stockBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // stockBindingNavigatorSaveItem
            // 
            this.stockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stockBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stockBindingNavigatorSaveItem.Image")));
            this.stockBindingNavigatorSaveItem.Name = "stockBindingNavigatorSaveItem";
            this.stockBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stockBindingNavigatorSaveItem.Text = "Save Data";
            this.stockBindingNavigatorSaveItem.Click += new System.EventHandler(this.stockBindingNavigatorSaveItem_Click);
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AutoGenerateColumns = false;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.stockDataGridView.DataSource = this.stockBindingSource;
            this.stockDataGridView.Location = new System.Drawing.Point(0, 383);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.Size = new System.Drawing.Size(643, 121);
            this.stockDataGridView.TabIndex = 1;
            // 
            // showstockrecord
            // 
            this.showstockrecord.Location = new System.Drawing.Point(238, 38);
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
            this.stockno.Location = new System.Drawing.Point(248, 84);
            this.stockno.Name = "stockno";
            this.stockno.Size = new System.Drawing.Size(55, 13);
            this.stockno.TabIndex = 3;
            this.stockno.Text = "Stock No:";
            // 
            // stockname
            // 
            this.stockname.AutoSize = true;
            this.stockname.Location = new System.Drawing.Point(248, 97);
            this.stockname.Name = "stockname";
            this.stockname.Size = new System.Drawing.Size(69, 13);
            this.stockname.TabIndex = 4;
            this.stockname.Text = "Stock Name:";
            // 
            // stockdesc
            // 
            this.stockdesc.AutoSize = true;
            this.stockdesc.Location = new System.Drawing.Point(248, 110);
            this.stockdesc.Name = "stockdesc";
            this.stockdesc.Size = new System.Drawing.Size(66, 13);
            this.stockdesc.TabIndex = 5;
            this.stockdesc.Text = "Stock Desc:";
            // 
            // stocktype
            // 
            this.stocktype.AutoSize = true;
            this.stocktype.Location = new System.Drawing.Point(248, 123);
            this.stocktype.Name = "stocktype";
            this.stocktype.Size = new System.Drawing.Size(65, 13);
            this.stocktype.TabIndex = 6;
            this.stocktype.Text = "Stock Type:";
            // 
            // stockquantity
            // 
            this.stockquantity.AutoSize = true;
            this.stockquantity.Location = new System.Drawing.Point(248, 136);
            this.stockquantity.Name = "stockquantity";
            this.stockquantity.Size = new System.Drawing.Size(80, 13);
            this.stockquantity.TabIndex = 7;
            this.stockquantity.Text = "Stock Quantity:";
            // 
            // stockprice
            // 
            this.stockprice.AutoSize = true;
            this.stockprice.Location = new System.Drawing.Point(248, 149);
            this.stockprice.Name = "stockprice";
            this.stockprice.Size = new System.Drawing.Size(65, 13);
            this.stockprice.TabIndex = 8;
            this.stockprice.Text = "Stock Price:";
            // 
            // addstockrecord
            // 
            this.addstockrecord.Location = new System.Drawing.Point(456, 12);
            this.addstockrecord.Name = "addstockrecord";
            this.addstockrecord.Size = new System.Drawing.Size(175, 23);
            this.addstockrecord.TabIndex = 9;
            this.addstockrecord.Text = "Add Stock Record";
            this.addstockrecord.UseVisualStyleBackColor = true;
            this.addstockrecord.Click += new System.EventHandler(this.addstockrecord_Click);
            // 
            // editstocktextbox
            // 
            this.editstocktextbox.Location = new System.Drawing.Point(456, 175);
            this.editstocktextbox.Name = "editstocktextbox";
            this.editstocktextbox.Size = new System.Drawing.Size(175, 20);
            this.editstocktextbox.TabIndex = 13;
            this.editstocktextbox.Text = "Stock to edit (ID Number)";
            // 
            // searchstocktextbox
            // 
            this.searchstocktextbox.Location = new System.Drawing.Point(12, 12);
            this.searchstocktextbox.Name = "searchstocktextbox";
            this.searchstocktextbox.Size = new System.Drawing.Size(175, 20);
            this.searchstocktextbox.TabIndex = 12;
            this.searchstocktextbox.Text = "Name to seach for (exact)";
            // 
            // searchstock
            // 
            this.searchstock.Location = new System.Drawing.Point(12, 38);
            this.searchstock.Name = "searchstock";
            this.searchstock.Size = new System.Drawing.Size(175, 23);
            this.searchstock.TabIndex = 11;
            this.searchstock.Text = "Search Stock";
            this.searchstock.UseVisualStyleBackColor = true;
            this.searchstock.Click += new System.EventHandler(this.searchstock_Click);
            // 
            // editstockrecord
            // 
            this.editstockrecord.Location = new System.Drawing.Point(456, 201);
            this.editstockrecord.Name = "editstockrecord";
            this.editstockrecord.Size = new System.Drawing.Size(175, 23);
            this.editstockrecord.TabIndex = 16;
            this.editstockrecord.Text = "Edit Stock Record";
            this.editstockrecord.UseVisualStyleBackColor = true;
            this.editstockrecord.Click += new System.EventHandler(this.editstockrecord_Click);
            // 
            // showstocksearchbox
            // 
            this.showstocksearchbox.Location = new System.Drawing.Point(238, 12);
            this.showstocksearchbox.Name = "showstocksearchbox";
            this.showstocksearchbox.Size = new System.Drawing.Size(175, 20);
            this.showstocksearchbox.TabIndex = 17;
            this.showstocksearchbox.Text = "Stock to show (ID Number)";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Stock_No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Stock_No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Desc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Desc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // searchstockresult
            // 
            this.searchstockresult.Location = new System.Drawing.Point(13, 68);
            this.searchstockresult.Multiline = true;
            this.searchstockresult.Name = "searchstockresult";
            this.searchstockresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.searchstockresult.Size = new System.Drawing.Size(174, 296);
            this.searchstockresult.TabIndex = 18;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 532);
            this.Controls.Add(this.searchstockresult);
            this.Controls.Add(this.showstocksearchbox);
            this.Controls.Add(this.editstockrecord);
            this.Controls.Add(this.editstocktextbox);
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
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.stockBindingNavigator);
            this.Name = "Main";
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingNavigator)).EndInit();
            this.stockBindingNavigator.ResumeLayout(false);
            this.stockBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHPDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PHPDatabaseDataSet pHPDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private PHPDatabaseDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private PHPDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stockBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton stockBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
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
        public System.Windows.Forms.TextBox editstocktextbox;
        private System.Windows.Forms.TextBox searchstockresult;
    }
}