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
            //It needs to make sure the textbox does not contain anything but letters
            if (!System.Text.RegularExpressions.Regex.IsMatch(showstocksearchbox.Text.Trim(), @"^[0-9]+$"))
            {
                //Dispalys an error message
                MessageBox.Show("Please insert a number to search");
                //Exits function
                return;
            }

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
        {   // doesn't need a message to pop up.
            // Creates new form of type addstockform
            var addstockform = new addstockform();

            // Disable's current form an opens add stock form
            addstockform.ShowDialog(this);

            // Reloads data into pHPDatabaseSet
            loadIntopHPDatabaseSet();
        }

        private void editstockrecord_Click(object sender, EventArgs e)
        {
            //It needs to make sure the textbox does not contain anything but letters
            if (!System.Text.RegularExpressions.Regex.IsMatch(editstocktextbox.Text.Trim(), @"^[0-9]+$"))
            {
                //Dispalys an error message
                MessageBox.Show("Please insert a number!");
                //Exits function
                return;
            }

            // Creates new form of type editstockform and parses text of editstocktextbox
            var editstockform = new editstockform(editstocktextbox.Text.Trim());

            // Disable's current form an opens edit stock form
            editstockform.ShowDialog(this);
             
            // Reloads data into pHPDatabaseSet
            loadIntopHPDatabaseSet();
        }

        private void searchstock_Click(object sender, EventArgs e)
        {
            //It needs to make sure the textbox does not contain anything but letters
            if (!System.Text.RegularExpressions.Regex.IsMatch(searchstocktextbox.Text.Trim(), @"^[A-Za-z ]+$"))
            {
                //Dispalys an error message
                MessageBox.Show("Please insert the name to search for, it must not contain numbers");
                //Exits function
                return;
            }

            //Allows the user to search their stock by name to find the stock_no, also gives extra info if there are duplicate names
            try
            {
                //Searches for any stock entries with the same name as entered in searchstocktextbox
                //Assigns the the results to an array of data rows
                DataRow[] newResultRow = pHPDatabaseDataSet.Stock.Select("[Name] like '" + searchstocktextbox.Text + "'");
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
                    searchstockresult.Text += "" + (i + 1) + "st Result." + Environment.NewLine;
                    // Displays the information for the result number
                    searchstockresult.Text += "ID Number: " + array[0].ToString() + Environment.NewLine;
                    searchstockresult.Text += "Name: " + array[1].ToString().TrimEnd() + Environment.NewLine;
                    searchstockresult.Text += "Desc: " + array[2].ToString().TrimEnd() + Environment.NewLine;
                    searchstockresult.Text += "Price: " + array[5].ToString() + Environment.NewLine + Environment.NewLine;

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
            //It needs to make sure the textbox does not contain anything but letters
            if (!System.Text.RegularExpressions.Regex.IsMatch(showsalesearchbox.Text.Trim(), @"^[0-9]+$"))
            {
                //Dispalys an error message
                MessageBox.Show("Please insert a number in this field!");
                //Exits function
                return;
            }

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
           //It needs to make sure the textbox does not contain anything but letters
           if (!System.Text.RegularExpressions.Regex.IsMatch(searchsaletextbox.Text.Trim(), @"^[0-9]{4}[-][0-9]{1,2}[-][0-9]{1,2}$"))
           {
               //Dispalys an error message
               MessageBox.Show("Please insert a date!");
               //Exits function
               return;
           }

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
        {   //doesn't need message box to show up.
            // Creates new form of type addsaleform
            var addsaleform = new addsaleform();

            // Disable's current form an opens add sale form
            addsaleform.ShowDialog(this);

            // Reloads data into pHPDatabaseSet
            loadIntopHPDatabaseSet();
        }

        private void editsalebutton_Click(object sender, EventArgs e)
        {
            //It needs to make sure the textbox does not contain anything but letters
            if (!System.Text.RegularExpressions.Regex.IsMatch(editsalenotextbox.Text.Trim(), @"^[0-9]+$"))
            {
                //Dispalys an error message
                MessageBox.Show("Please insert a Sale ID to search for, it must not contain letters");
                //Exits function
                return;
            }

            // Creates new form of type editsaleform and parses text of editsalenotextbox
            var editsaleform = new editsaleform(editsalenotextbox.Text.TrimEnd());
            //It needs to make sure the textbox does not contain anything but letters
            if (!System.Text.RegularExpressions.Regex.IsMatch(editsalenotextbox.Text.Trim(), @"^[0-9]+$"))
            {
                //Dispalys an error message
                MessageBox.Show("Please insert a number, it must not contain letters");
                //Exits function
                return;
            }
            // Disable's current form an opens edit sale form
            editsaleform.ShowDialog(this);

            // Reloads data into pHPDatabaseSet
            loadIntopHPDatabaseSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create CSV generator class
            CSVGenerator file = new CSVGenerator();

            //Check to ensure there is a name for the file
            if (CSVFileName.Text != "")
            {
                //Create new CSV file
                file.NewCSVFile(CSVFileName.Text);
            }
            else
            {
                //If no name prompt the user to enter a name
                MessageBox.Show("Please enter a filename!");
                return;
            }

            //Prompt the user that their data has been successfully saved
            MessageBox.Show(file.GetFilePath + " has been saved!");
            return;
        }

        private void CSVFileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}