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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            // Loads data into 'pHPDatabaseDataSet.StockSale'
            try
            {
                this.stockSaleTableAdapter.Fill(this.pHPDatabaseDataSet.StockSale);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill stock sale failed");
            }

            // Loads data into 'pHPDatabaseDataSet.Sale'
            try
            {
                this.saleTableAdapter.Fill(this.pHPDatabaseDataSet.Sale);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill sale failed");
            }

            // Loads data into 'pHPDatabaseDataSet.Stock'
            try
            {
                this.stockTableAdapter.Fill(this.pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill stock failed");
            }

            // Clears labels
            stockno.Text = "";
            stockname.Text = "";
            stockdesc.Text = "";
            stocktype.Text = "";
            stockquantity.Text = "";
            stockprice.Text = "";
        }

        //Provides complete data for a stock number.
        private void showstockrecord_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] newResultRow = pHPDatabaseDataSet.Stock.Select("[Stock_No]="+showstocksearchbox.Text.Trim());
                var array = newResultRow[0].ItemArray;

                stockno.Text = "ID Number:   " + array[0].ToString();
                stockname.Text = "Name:          " + array[1].ToString();
                stockdesc.Text = "Desc:           " + array[2].ToString();
                stocktype.Text = "Type:            " + array[3].ToString();
                stockquantity.Text = "Quantity:      " + array[4].ToString();
                stockprice.Text = "Price:            " + array[5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetch data for show stock record failed");
            }
        }

        private void addstockrecord_Click(object sender, EventArgs e)
        {
            var addstockform = new addstockform();
            addstockform.Show(this);
        }

        private void editstockrecord_Click(object sender, EventArgs e)
        {
            var editstockform = new editstockform();
            editstockform.Show(this);
        }

        private void searchstock_Click(object sender, EventArgs e)
        {
            //Allows the user to search their stock to find the stock_no, also gives extra info if there are duplicate names
            try
            {
                DataRow[] newResultRow = pHPDatabaseDataSet.Stock.Select("[Name] like '"+searchstocktextbox.Text+"'");
                int i = 0;
                searchstockresult.Text = "";
                foreach (DataRow value in newResultRow)
                {
                    var array = newResultRow[i].ItemArray;

                    searchstockresult.Text += ""+(i+1)+"st Result." + Environment.NewLine;

                    searchstockresult.Text += "ID Number: "+array[0].ToString() + Environment.NewLine;
                    searchstockresult.Text += "Name: " + array[1].ToString().TrimEnd() + Environment.NewLine;
                    searchstockresult.Text += "Desc: " + array[2].ToString().TrimEnd() + Environment.NewLine;
                    searchstockresult.Text += "Price: "+ array[5].ToString() + Environment.NewLine + Environment.NewLine;

                    //searchstockresult.Text += "Type: "+array[3].ToString().TrimEnd() + Environment.NewLine;
                    //searchstockresult.Text += "Quantity: "+array[4].ToString() + Environment.NewLine;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search for ID query failed");
            }
        }

        private void refreshdatabase_Click(object sender, EventArgs e)
        {
            try
            {
                this.stockTableAdapter.Fill(this.pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh failed");
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            try
            {
                this.saleTableAdapter.Fill(this.pHPDatabaseDataSet.Sale);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh failed");
            }
        }

        private void showsalebutton_Click(object sender, EventArgs e)
        {
            //Disaply sale and stocksale records for the entered sale number
            try
            {
                //Initialise saleno
                int saleno;
                Int32.TryParse(showsalesearchbox.Text.Trim(), out saleno);

                PHPDatabaseDataSet.SaleRow saleRow = pHPDatabaseDataSet.Sale.FindBySale_No(saleno);

                showsalerecordmultiline.Text = "";
                showsalerecordmultiline.Text += "Sale Number: " + saleRow.Sale_No.ToString() + Environment.NewLine;
                showsalerecordmultiline.Text += "Sale Date: " + saleRow.Date.ToString() + Environment.NewLine;

                DataRow[] stocksaleRow = pHPDatabaseDataSet.StockSale.Select("[Sale_No] ='" + saleno.ToString() + "'");
                int i = 0;
                foreach (DataRow value in stocksaleRow)
                {
                    var array = stocksaleRow[i].ItemArray;

                    showsalerecordmultiline.Text += Environment.NewLine;
                    showsalerecordmultiline.Text += "" + (i + 1) + "st Item." + Environment.NewLine;

                    showsalerecordmultiline.Text += "Stock No: " + array[0].ToString() + Environment.NewLine;
                    showsalerecordmultiline.Text += "Quantity: " + array[2].ToString() + Environment.NewLine;
                    showsalerecordmultiline.Text += "Price: " + array[3].ToString() + Environment.NewLine;

                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search for Sale Number query failed");
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            try
            {
                this.stockSaleTableAdapter.Fill(this.pHPDatabaseDataSet.StockSale);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh failed");
            }
        }

        private void searchsalebutton_Click(object sender, EventArgs e)
        {
            //Allows the user to search for a sale number made on a date
            try
            {
                DataRow[] newResultRow = pHPDatabaseDataSet.Sale.Select("[Date] = '" + searchsaletextbox.Text.Trim() + "'");
                int i = 0;
                searchsalemultiline.Text = "";
                foreach (DataRow value in newResultRow)
                {
                    var array = newResultRow[i].ItemArray;

                    searchsalemultiline.Text += "" + (i + 1) + "st Result." + Environment.NewLine;
                    searchsalemultiline.Text += "Sale Number: " + array[0].ToString() + Environment.NewLine;

                    searchsalemultiline.Text += Environment.NewLine;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search for Sale Date failed");
            }
        }

        private void addsalebutton_Click(object sender, EventArgs e)
        {
            var addsaleform = new addsaleform();
            addsaleform.Show(this);
        }
    }
}