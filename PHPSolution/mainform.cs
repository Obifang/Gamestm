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
            //Loads data into pHPDatabaseSet
            loadIntopHPDatabaseSet();

            // Clears labels
            stockno.Text = "";
            stockname.Text = "";
            stockdesc.Text = "";
            stocktype.Text = "";
            stockquantity.Text = "";
            stockprice.Text = "";
        }

        /*if (stockno.Length == 0){
          MessageBox.Show("Please insert a Stock number")
          return false;
          }
        */

        /*if (stockname.Length == 0){
         MessageBox.Show("Please insert the name of the stock item")
         return false;
         }
       */

        //A description might not be required but it is there just in case.
        /*if (stockdesc.Length == 0){
         MessageBox.Show("Please insert the name of the stock item")
         return false;
         }
       */

        /*if (stocktype.Length == 0){
         MessageBox.Show("Please insert the stock type")
         return false;
         }
       */

        /*if (stockquantity.Length == 0){
         MessageBox.Show("Please insert the quantity of stock item")
         return false;
         }
       */

        /*if (stockquantity.value < 0){
         MessageBox.Show("Quantity of stock cannot be a negative number")
         return false;
         }
       */

        /*if (stockprice.Length == 0){
         MessageBox.Show("Please insert the price of stock item")
         return false;
         }
       */

        /*if (stockprice.value < 0){
         MessageBox.Show("Price of stock cannot be a negative number")
         return false;
         }
       */


        //stock stuff is here from line 20 to 147
        private void loadIntopHPDatabaseSet()
        {
            // Loads data into 'pHPDatabaseDataSet.StockSale'
            try
            {
                this.stockSaleTableAdapter.Fill(this.pHPDatabaseDataSet.StockSale);
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Fill stock sale failed");
            }

            // Loads data into 'pHPDatabaseDataSet.Sale'
            try
            {
                this.saleTableAdapter.Fill(this.pHPDatabaseDataSet.Sale);
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Fill sale failed");
            }

            // Loads data into 'pHPDatabaseDataSet.Stock'
            try
            {
                this.stockTableAdapter.Fill(this.pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Fill stock failed");
            }
        }

        //Displays a stock number.
        private void showstockrecord_Click(object sender, EventArgs e)
        {
            try
            {   
                // Searches pHPDatabaseDataSet.Stock for a entry with the entered stock no and assigns it to newStockRow
                PHPDatabaseDataSet.StockRow newStockRow = pHPDatabaseDataSet.Stock.FindByStock_No(int.Parse(showstocksearchbox.Text.Trim()));

                // Displays information in newStockRow using labels
                stockno.Text = "ID Number:   " + newStockRow.Stock_No;
                stockname.Text = "Name:          " + newStockRow.Name;
                stockdesc.Text = "Desc:           " + newStockRow.Desc;
                stocktype.Text = "Type:            " + newStockRow.Type;
                stockquantity.Text = "Quantity:      " + newStockRow.Quantity;
                stockprice.Text = "Price:            " + newStockRow.Price;
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Fetch data for show stock record failed");
            }
        }

        private void addstockrecord_Click(object sender, EventArgs e)
        {
            // Creates new form of type addstockform
            var addstockform = new addstockform();

            // Disable's current form an opens add stock form
            addstockform.ShowDialog(this);

            // Reloads data into pHPDatabaseSet
            loadIntopHPDatabaseSet();
        }

        private void editstockrecord_Click(object sender, EventArgs e)
        {
            // Creates new form of type editstockform and parses text of editstocktextbox
            var editstockform = new editstockform(editstocktextbox.Text.Trim());

            // Disable's current form an opens edit stock form
            editstockform.ShowDialog(this);

            // Reloads data into pHPDatabaseSet
            loadIntopHPDatabaseSet();
        }

        private void searchstock_Click(object sender, EventArgs e)
        {
            //Allows the user to search their stock by name to find the stock_no, also gives extra info if there are duplicate names
            try
            {
                //Searches for any stock entries with the same name as entered in searchstocktextbox
                //Assigns the the results to an array of data rows
                DataRow[] newResultRow = pHPDatabaseDataSet.Stock.Select("[Name] like '"+searchstocktextbox.Text+"'");
                //Clears searchstockresult textbox
                searchstockresult.Text = "";
                // Iterates through and displays relevant information, that could be used to distinguish between entries with the same name
                int i = 0;
                foreach (DataRow value in newResultRow)
                {
                    // Assigns a single data row to an array
                    // ItemArray can only be access this way, it cannot be accessed using value.ItemArray, hence this method
                    var array = newResultRow[i].ItemArray;

                    // Numbers the result for readability sake
                    searchstockresult.Text += ""+(i+1)+"st Result." + Environment.NewLine;
                    // Displays the information for the result number
                    searchstockresult.Text += "ID Number: "+array[0].ToString() + Environment.NewLine;
                    searchstockresult.Text += "Name: " + array[1].ToString().TrimEnd() + Environment.NewLine;
                    searchstockresult.Text += "Desc: " + array[2].ToString().TrimEnd() + Environment.NewLine;
                    searchstockresult.Text += "Price: "+ array[5].ToString() + Environment.NewLine + Environment.NewLine;

                    i++;
                }
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Search for ID query failed");
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

                // Searches pHPDatabaseDataSet.Sale for a entry with the entered sale no and assigns it to SaleRow
                PHPDatabaseDataSet.SaleRow saleRow = pHPDatabaseDataSet.Sale.FindBySale_No(saleno);

                // Clears showsalerecordmultiline
                showsalerecordmultiline.Text = "";
                // Displays sale no and date of the sale
                showsalerecordmultiline.Text += "Sale Number: " + saleRow.Sale_No.ToString() + Environment.NewLine;
                showsalerecordmultiline.Text += "Sale Date: " + saleRow.Date.ToString().Substring(0,10) + Environment.NewLine;

                //Searches through stockSale for any items bought with the provided sale no
                //Assigns the the results to an array of data rows
                DataRow[] stocksaleRow = pHPDatabaseDataSet.StockSale.Select("[Sale_No] ='" + saleno.ToString() + "'");

                // Iterates through and displays information for each item 
                int i = 0;
                foreach (DataRow value in stocksaleRow)
                {
                    // Assigns a single data row to an array
                    // ItemArray can only be access this way, it cannot be accessed using value.ItemArray, hence this method
                    var array = stocksaleRow[i].ItemArray;

                    //Creates a blank line, seperating items
                    showsalerecordmultiline.Text += Environment.NewLine;
                    // Numbers the item for readability sake
                    showsalerecordmultiline.Text += "" + (i + 1) + "st Item." + Environment.NewLine;
                    // Displays the information for the item
                    showsalerecordmultiline.Text += "Stock No: " + array[0].ToString() + Environment.NewLine;
                    showsalerecordmultiline.Text += "Quantity: " + array[2].ToString() + Environment.NewLine;
                    showsalerecordmultiline.Text += "Price: " + array[3].ToString() + Environment.NewLine;

                    i++;
                }
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Search for Sale Number query failed");
            }
        }

        private void searchsalebutton_Click(object sender, EventArgs e)
        {
            //Allows the user to search for a sale number made on a date
            try
            {
                //Searches Sale for sales made on the provided date
                //Assigns the the results to an array of data rows
                DataRow[] newResultRow = pHPDatabaseDataSet.Sale.Select("[Date] = '" + searchsaletextbox.Text.Trim() + "'");
                // Clears the searchsalemultiline textbox
                searchsalemultiline.Text = "";

                // Iterates through and displays information for each sale in the array of datarows 
                int i = 0;
                foreach (DataRow value in newResultRow)
                {
                    // Assigns a single data row to an array
                    // ItemArray can only be access this way, it cannot be accessed using value.ItemArray, hence this method
                    var array = newResultRow[i].ItemArray;

                    // Numbers the result for readability sake
                    searchsalemultiline.Text += "" + (i + 1) + "- Result." + Environment.NewLine;
                    //Displays sale number
                    searchsalemultiline.Text += "Sale Number: " + array[0].ToString() + Environment.NewLine;

                    //Searches stockSale for items made on the provided sale no
                    //Assigns the the results to an array of data rows
                    DataRow[] stockSaleRow = pHPDatabaseDataSet.StockSale.Select("[Sale_No] = "+ array[0].ToString().Trim());

                    // Iterates through and displays information for each item in the array of datarows 
                    int j = 0;
                    foreach (DataRow stockSale in stockSaleRow)
                    {
                        // Assigns a single data row to an array
                        // ItemArray can only be access this way, it cannot be accessed using value.ItemArray, hence this method
                        var stockSaleArray = stockSaleRow[j].ItemArray;

                        // Numbers the item for readability sake
                        searchsalemultiline.Text += "" +(j + 1) + "- Stock" + Environment.NewLine;
                        // Displays relevent item information
                        searchsalemultiline.Text += "Stock Number: " + stockSaleArray[0].ToString() + Environment.NewLine;
                        searchsalemultiline.Text += "Stock Quantity: " + stockSaleArray[2].ToString() + Environment.NewLine;
                        j++;
                    }

                    //Creates a blank line, seperating items
                    searchsalemultiline.Text += Environment.NewLine;
                    i++;
                }
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Search for Sale Date failed");
                // Display error message in messagebox
                MessageBox.Show(ex.ToString());
            }
        }

        private void addsalebutton_Click(object sender, EventArgs e)
        {
            // Creates new form of type addsaleform
            var addsaleform = new addsaleform();

            // Disable's current form an opens add sale form
            addsaleform.ShowDialog(this);

            // Reloads data into pHPDatabaseSet
            loadIntopHPDatabaseSet();
        }

        private void editsalebutton_Click(object sender, EventArgs e)
        {
            // Creates new form of type editsaleform and parses text of editsalenotextbox
            var editsaleform = new editsaleform(editsalenotextbox.Text.TrimEnd());

            // Disable's current form an opens edit sale form
            editsaleform.ShowDialog(this);

            // Reloads data into pHPDatabaseSet
            loadIntopHPDatabaseSet();
        }
    }
}