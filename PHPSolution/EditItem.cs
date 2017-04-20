using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHPSolution
{
    public partial class EditItem : Form
    {
        private int initialQuantity;
        private int saleNo;

        public EditItem(string salenumber, string stocknumber)
        {
            InitializeComponent();

            saleNo = int.Parse(salenumber);

            // Loads data into 'pHPDatabaseDataSet.Stock' and 'pHPDatabaseDataSet.StockSale'
            try
            {
                this.stockTableAdapter.Fill(this.pHPDatabaseDataSet.Stock);
                this.stockSaleTableAdapter.Fill(this.pHPDatabaseDataSet.StockSale);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill stocksale failed");
            }

            //Fetch data from database
            try
            {
                PHPDatabaseDataSet.StockSaleRow stockSaleRow = pHPDatabaseDataSet.StockSale.FindByStock_NoSale_No(int.Parse(stocknumber), int.Parse(salenumber));
                stockno.Text = stockSaleRow.Stock_No.ToString();
                stockquantity.Text = stockSaleRow.Quantity_Sold.ToString();
                stockprice.Text = stockSaleRow.Sale_Price.ToString();
                initialQuantity =  stockSaleRow.Quantity_Sold;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetch data for item edit failed");
                MessageBox.Show(ex.ToString());
            }
        }

        private void edititembutton_Click(object sender, EventArgs e)
        {
            //Alter stock values to reflect sales
            try
            {
                PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(Int32.Parse(stockno.Text.Trim()));
                int change = stockRow.Quantity - Int32.Parse(stockquantity.Text.Trim());
                stockRow.Quantity += change;
                stockTableAdapter.Update(pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alter stock to reflect sales failed");
            }
            Close();
        }

        private void defaultpricebutton_Click(object sender, EventArgs e)
        {
            PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(Int32.Parse(stockno.Text.Trim()));
            stockprice.Text = stockRow.Price.ToString();
        }

        private void deleteitem_Click(object sender, EventArgs e)
        { 
            //Alter stock values to reflect sales
            try
            {
                PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(Int32.Parse(stockno.Text.Trim()));
                stockRow.Quantity += initialQuantity;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alter stock to reflect sales failed");
            }

            //Deletes the item
            PHPDatabaseDataSet.StockSaleRow stockSaleRow = pHPDatabaseDataSet.StockSale.FindByStock_NoSale_No(int.Parse(stockno.Text.Trim()), saleNo);
            stockSaleRow.Delete();
            stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);

            MessageBox.Show("The Item has been deleted");
            Close();
        }

        public string StockNo
        {
            get { return stockno.Text.Trim(); }
        }

        public string Quantity
        {
            get { return stockquantity.Text.Trim(); }
        }

        public string Price
        {
            get { return stockprice.Text.Trim(); }
        }
    }
}