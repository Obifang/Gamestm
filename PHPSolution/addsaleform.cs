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

            //Disaply stock items in a checkbox
            try
            {
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
                MessageBox.Show("Entering data into checklistbox failed");
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
                    }

                    try
                    {
                        newStockSaleRow.Quantity_Sold = int.Parse(additemform.Quantity);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Please enter a valid quantity");
                    }

                    try
                    {
                        newStockSaleRow.Sale_Price = decimal.Parse(additemform.Price);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please enter a valid price");
                    }

                    //after try/catching data values, try/catch to add to database
                    try
                    {
                        // Add the row to the Stock table and update database
                        pHPDatabaseDataSet.StockSale.Rows.Add(newStockSaleRow);
                        stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Add sales record failed; please enter valid data and try again");
                    }  
                }
            }
            // Closes form
            Close();
        }
    }
}