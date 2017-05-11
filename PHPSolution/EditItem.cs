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
        int oldQuantity;

        public EditItem(string salenumber, string stocknumber)
        {
            InitializeComponent();

            //Loads data into 'pHPDatabaseDataSet.Stock' and 'pHPDatabaseDataSet.StockSale'.
            try
            {
                stockTableAdapter.Fill(pHPDatabaseDataSet.Stock);
                stockSaleTableAdapter.Fill(pHPDatabaseDataSet.StockSale);
            }

            catch (Exception ex)
            {   
                //Catches an error and displays a messagebox.
                MessageBox.Show("Fill stocksale and stock failed");
            }

            //Fetches and dispalys stock name.
            PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(int.Parse(stocknumber));
            stockname.Text = stockRow.Name;

            //Fetch data from database.
            try
            {
                //Fetch stocksale row of item using FindByStock_NoSale_No.
                PHPDatabaseDataSet.StockSaleRow stockSaleRow = pHPDatabaseDataSet.StockSale.FindByStock_NoSale_No(int.Parse(stocknumber), int.Parse(salenumber));
                //Sets values of textboxes using stockSaleRow.
                stockno.Text = stockSaleRow.Stock_No.ToString();
                stockquantity.Text = stockSaleRow.Quantity_Sold.ToString();
                stockprice.Text = stockSaleRow.Sale_Price.ToString();

                oldQuantity = int.Parse(stockSaleRow.Quantity_Sold.ToString());
            }

            catch (Exception ex)
            {
                //Catches an error and displays a messagebox.
                MessageBox.Show("Fetch data for item edit failed");
                //Dispalys error message using a textbox.
                MessageBox.Show(ex.ToString());
            }
        }

        private void edititembutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(stockquantity.Text.Trim()) <= 0)
                {
                    //Dispalys an error message.
                    MessageBox.Show("Please insert a value more than 0!");
                    //Exits function.
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid quantity");
                return;
            }

            try
            {
                if (decimal.Parse(stockprice.Text.Trim()) <= 0)
                {
                    //Dispalys an error message.
                    MessageBox.Show("Please insert a number more than 0!");
                    //Exits function.
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid price");
                return;
            }
            //Closes form.
            Close();
        }

        private void defaultpricebutton_Click(object sender, EventArgs e)
        {
            //Searches pHPDatabaseDataSet.Stock for a entry with the entered stock_no and assigns it to stockRow.
            PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(int.Parse(stockno.Text.Trim()));
            //Sets text of textbox with the price of the stock.
            stockprice.Text = stockRow.Price.ToString();
        }

        //Uses public getters so that the data entered can be obtained after the form is closed.
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

        public int OldQuantity
        {
            get { return oldQuantity; }
        }
    }
}