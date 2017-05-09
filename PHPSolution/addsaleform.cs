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
    public partial class addsaleform : Form
    {
        public addsaleform()
        {
            InitializeComponent();

            //Sets localtime
            DateTime localTime = DateTime.Now;
            //Creates string with current date
            string currentDate = localTime.Year + "-" + localTime.Month + "-" + localTime.Day;
            //Assigns string to text of textbox
            saledate.Text = currentDate;

            // Loads data into 'pHPDatabaseDataSet.Stock'
            try
            {
                stockTableAdapter.Fill(pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Fill stock failed");
            }

            refreshchecklistbox();
        }

        private void refreshchecklistbox()
        {
            //Disaply stock items in a checkbox
            try
            {
                // Clears checklistbox
                salechecklistbox.Items.Clear();

                // Creates stockdatatable and populates it with the entirety of pHPDatabaseDataSet.Stock
                PHPDatabaseDataSet.StockDataTable stockTable = pHPDatabaseDataSet.Stock;

                // Iterates through stockTable, adding each item to a checklistbox
                foreach (PHPDatabaseDataSet.StockRow stockrow in stockTable)
                {
                    // Adds stock to checklistbox as a string
                    salechecklistbox.Items.Add("No: " + stockrow.Stock_No.ToString() + "     Name : " + stockrow.Name.TrimEnd());
                }
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Refreshing checklistbox failed");
            }
        }

        private void addsale_Click(object sender, EventArgs e)
        {
            //It needs to make sure the textbox does not contain anything but letters
            if (!System.Text.RegularExpressions.Regex.IsMatch(saledate.Text.Trim(), @"^[0-9]{4}[-][0-9]{1,2}[-][0-9]{1,2}$"))
            {
                //Dispalys an error message
                MessageBox.Show("Please insert a date to use, it must not contain anything else");
                //Exits function
                return;
            }

            /*if (Quantity_Sold <= 0)
            {
                //Dispalys an error message
                MessageBox.Show("Please insert a value more than 0!");
                //Exits function
                return;
            }

            if (sale_Price <= 0)
            {
                //Dispalys an error message
                MessageBox.Show("Please insert a number more than 0!");
                //Exits function
                return;
            }*/

            // Create a new sale row.
            PHPDatabaseDataSet.SaleRow newSaleRow = pHPDatabaseDataSet.Sale.NewSaleRow();
           
            // Insert date from textbox into new sale row
            newSaleRow.Date = Convert.ToDateTime(saledate.Text);

            // Add the row to the Stock table and update database
            pHPDatabaseDataSet.Sale.Rows.Add(newSaleRow);
            saleTableAdapter.Update(pHPDatabaseDataSet.Sale);

            // Iterates through each checked item in the checklistbox
            for (int i = 0; i < salechecklistbox.Items.Count; i++)
            {
                if (salechecklistbox.GetItemChecked(i))
                {
                    //Gets stocknumber by fetching the string enterered into the checklistbox and using substing
                    string strtemp = (string)salechecklistbox.Items[i];
                    string stockno = strtemp.Substring(3, 4).Trim();
                    // Creates new form of type additemform
                    var additemform = new AddItem(stockno);
                    // Disable's current form an opens add item form
                    additemform.ShowDialog(this);
                    //Create new stocksale row
                    PHPDatabaseDataSet.StockSaleRow newStockSaleRow = pHPDatabaseDataSet.StockSale.NewStockSaleRow();
                    //Gets highest saleno

                    //Searches for any sale entries where sale_no is not null and sorts them, highest at the top
                    //This was the only way i could find to access the last sale no that was generated (i.e the one for the item being entered)
                    //In order to sort the sale entries i needed a filter, hecne sale_no is not null, as that will always be true
                    //Assigns the the results to an array of data rows
                    DataRow[] newResultRow = pHPDatabaseDataSet.Sale.Select("Sale_No is not NULL","Sale_No DESC");
                    var array = newResultRow[0].ItemArray;
                    //Assigns the first(highest) results first entry(Sale_No) as saleno
                    string saleno = array[0].ToString();
                    //Inserts the saleno we just got into stocksale row
                    newStockSaleRow.Sale_No = int.Parse(saleno);
                    //Gets data from additemform using public getters and enters it into new stocksale row
                    //try catch for each field before storing

                    try
                    {
                        newStockSaleRow.Stock_No = int.Parse(additemform.StockNo);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Please enter a valid stock number");
                        return;
                    }

                    try
                    {
                        newStockSaleRow.Quantity_Sold = int.Parse(additemform.Quantity);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Please enter a valid quantity");
                        return;
                    }

                    try
                    {
                        newStockSaleRow.Sale_Price = decimal.Parse(additemform.Price);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please enter a valid price");
                        return;
                    }

                    //after try/catching data values, try/catch to add to database
                    try
                    {
                        // Add the row to the Stock table and update database
                        pHPDatabaseDataSet.StockSale.Rows.Add(newStockSaleRow);
                        stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);
                        // Closes form
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Add sales record failed; please enter valid data and try again");
                    }  
                        return;
                    }
                }          
            }        

        private void searchbutton_Click(object sender, EventArgs e)
        {
            //Disaply stock items in a checkbox
            try
            {
                //Searches for any stock entries with a name containing the stirng entered in searchterm
                //Assigns the the results to an array of data rows
                DataRow[] newResultRow = pHPDatabaseDataSet.Stock.Select("[Name] like '%" + searchterm.Text.Trim() + "%'");

                // Clears checklistbox
                salechecklistbox.Items.Clear();

                // Iterates through stockTable, adding each item to a checklistbox
                int i = 0;
                foreach (PHPDatabaseDataSet.StockRow stockrow in newResultRow)
                {
                    // Assigns a single data row to an array
                    // ItemArray can only be access this way, it cannot be accessed using value.ItemArray, hence this method
                    var array = newResultRow[i].ItemArray;

                    // Adds stock to checklistbox as a string
                    salechecklistbox.Items.Add("No: " + array[0].ToString().TrimEnd() + "     Name : " + array[1].ToString().TrimEnd());

                    i++;
                }
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Searching checklistbox failed");
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            refreshchecklistbox();
        }
    }
}