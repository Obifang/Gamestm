using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHPSolution
{
    public partial class editsaleform : Form
    {
        public editsaleform(string salenotoedit)
        {
            InitializeComponent();

            //Enters saleno into textbox.
            saleno.Text = salenotoedit;

            //Renders the checklistbox.
            rendercheckbox();
        }

        private void rendercheckbox()
        {
            //Get saleno.
            string salenotoedit = saleno.Text.Trim();

            //Fill the phpDatabaseDataSet.
            stockSaleTableAdapter.Fill(pHPDatabaseDataSet.StockSale);
            stockTableAdapter.Fill(pHPDatabaseDataSet.Stock);
            saleTableAdapter.Fill(pHPDatabaseDataSet.Sale);

            //Filter stockSaleBindingSource to only show items for provided salenotoedit.
            stockSaleBindingSource.Filter = "[Sale_No] = " + salenotoedit;

            //Fetch data from database.
            try
            {
                //Searches pHPDatabaseDataSet.Sale for a entry with the entered sale no and assigns it to SaleRow.
                PHPDatabaseDataSet.SaleRow saleRow = pHPDatabaseDataSet.Sale.FindBySale_No(int.Parse(salenotoedit));

                //Enters date form saleRow into textboxes.
                saledate.Text = saleRow.Date.ToString().Substring(0, 10);
            }

            catch (Exception ex)
            {   //Catches an error and displays a messagebox.
                MessageBox.Show("Fetch data for sale edit failed");
            }

            //Dispaly stock items in a checkbox.
            try
            {
                //Searches through stockSale for any items bought with the provided sale no.
                //Assigns the the results to an array of data rows.
                DataRow[] stockSaleRow = pHPDatabaseDataSet.StockSale.Select("[Sale_No]=" + salenotoedit);

                //Clears checklistbox, so if it is refreshed using the same function, we dont get dupe data.
                salechecklistbox.Items.Clear();

                int i = 0;
                //Iterates through array of data rows and adds each item to the checklistbox.
                foreach (DataRow stockrow in stockSaleRow)
                {
                    //Assigns a single data row to an array.
                    //ItemArray can only be access this way, it cannot be accessed using value.ItemArray, hence this method.
                    var array = stockSaleRow[i].ItemArray;

                    //Adds item to checklistbox.
                    salechecklistbox.Items.Add("No: " + array[0].ToString() + "     Quantity : " + array[2].ToString());
                    i++;
                }
            }

            catch (Exception ex)
            {   //Catches an error and displays a messagebox.
                MessageBox.Show("Entering data into checklistbox failed");
                //Displays the error message using a messagebox.
                MessageBox.Show(ex.ToString());
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            //Find row you want to modify using FindBySale_No.
            PHPDatabaseDataSet.SaleRow saleRow = pHPDatabaseDataSet.Sale.FindBySale_No(int.Parse(saleno.Text.Trim()));

            //Insert new date from textbox into old row.
            saleRow.Date = Convert.ToDateTime(saledate.Text.Trim());

            //Save the new row to the database.
            try
            {
                Validate();
                stockBindingSource.EndEdit();
                saleTableAdapter.Update(pHPDatabaseDataSet.Sale);
                stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);
                //Close window.
                Close();
            }

            catch (Exception ex)
            {   //Catches an error and displays a messagebox.
                MessageBox.Show("Edit sale failed");
            }
        }

        private void newitem_Click(object sender, EventArgs e)
        {
            //Creates new form of type additenform, passing 0 to indicate it is not for any specific stock no.
            var additemform = new AddItem(0.ToString(),int.Parse(saleno.Text.Trim()));

            //Disable's current form an opens add item form.
            additemform.ShowDialog(this);

            //Create new stocksale row.
            PHPDatabaseDataSet.StockSaleRow newStockSaleRow = pHPDatabaseDataSet.StockSale.NewStockSaleRow();
            
            //Insert sale_no into new stocksale row.
            newStockSaleRow.Sale_No = int.Parse(saleno.Text.Trim());

            //Gets data from additemform using public getters and enters it into new stocksale row.
            //Still have try catch to prevent exiting additemform from crashing the program.
            try
            {
                newStockSaleRow.Stock_No = int.Parse(additemform.StockNo);
                newStockSaleRow.Quantity_Sold = int.Parse(additemform.Quantity);
                newStockSaleRow.Sale_Price = decimal.Parse(additemform.Price);
            }

            catch (Exception ex)
            {
                MessageBox.Show("You closed the window unnexpectedly, the item will not be added");
                return;
            }

            //Try catch adding data to the database and reducing stock quantity to avoid crashes and assure one does not occur without the other.
            try
            {
                //Add the row to the stockSale table and update database.
                pHPDatabaseDataSet.StockSale.Rows.Add(newStockSaleRow);
                stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);

                //Searches pHPDatabaseDataSet.Stock for a entry with the entered stock_no and assigns it to stockRow.
                PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(int.Parse(additemform.StockNo));
                //Reduces quantity by the amount purchased.
                stockRow.Quantity -= int.Parse(additemform.Quantity);
                //Updates database.
                stockTableAdapter.Update(pHPDatabaseDataSet.Stock);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to add stock no: " + additemform.StockNo + " to sale record");
            }

            //Renders the checklistbox, updating it with the new information.
            rendercheckbox();
        }

        private void editselecteditems_Click(object sender, EventArgs e)
        {
            //Iterates through each checked item in the checklistbox.
            for (int i = 0; i < salechecklistbox.Items.Count; i++)
            {
                if (salechecklistbox.GetItemChecked(i))
                {
                    //Gets stocknumber by fetching the string enterered into the checklistbox and using substing.
                    string strtemp = (string)salechecklistbox.Items[i];
                    int intstockno = int.Parse(strtemp.Substring(3, 4).Trim());
                    //Gets saleno from textbox.
                    int intsaleno = int.Parse(saleno.Text.Trim());
                    //Creates new form of type edititemform, passing stock_no and sale_no to identify the item.
                    var edititemform = new EditItem(intsaleno.ToString(), intstockno.ToString());
                    //Disable's current form an opens edit item form.
                    edititemform.ShowDialog(this);

                    //Fetch stocksale row of item using FindByStock_NoSale_No.
                    PHPDatabaseDataSet.StockSaleRow stockSaleRow = pHPDatabaseDataSet.StockSale.FindByStock_NoSale_No(intstockno, intsaleno);

                    //Gets data from edititemform using public getters and enters it into stocksale row.
                    //Still have try catch to prevent exiting additemform from crashing the program.
                    try
                    {
                        stockSaleRow.Quantity_Sold = int.Parse(edititemform.Quantity);
                        stockSaleRow.Sale_Price = decimal.Parse(edititemform.Price);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("You closed the window unnexpectedly, this item will be skipped");
                        continue;
                    }

                    //Try catch adding data to the database and reducing stock quantity to avoid crashes and assure one does not occur without,
                    //the other.
                    try
                    {
                        //Update database.
                        stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);

                        //Searches pHPDatabaseDataSet.Stock for a entry with the entered stock_no and assigns it to stockRow.
                        PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(intstockno);
                        //Alter quantity to reflect changes in quantity.
                        int change = edititemform.OldQuantity - int.Parse(edititemform.Quantity);
                        stockRow.Quantity += change;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to add stock no: " + intstockno + " to sale record");
                    }
                }
            }
            //Renders the checklistbox, updating it with the new information.
            rendercheckbox();
        }

        private void deleteitem_Click(object sender, EventArgs e)
        {
            //Iterates through each checked item in the checklistbox.
            for (int i = 0; i < salechecklistbox.Items.Count; i++)
            {
                if (salechecklistbox.GetItemChecked(i))
                {
                    //Gets stocknumber by fetching the string enterered into the checklistbox and using substing.
                    string strtemp = (string)salechecklistbox.Items[i];
                    int intstockno = int.Parse(strtemp.Substring(3, 4).Trim());
                    //Gets saleno from textbox.
                    int intsaleno = int.Parse(saleno.Text.Trim());

                    //Fetch stocksale row of item using FindByStock_NoSale_No.
                    PHPDatabaseDataSet.StockSaleRow stockSaleRow = pHPDatabaseDataSet.StockSale.FindByStock_NoSale_No(intstockno, intsaleno);

                    //Alter stock values to reflect sales.
                    try
                    {
                        //Fetch stock row using FindByStock_No and assign it to stockRow.
                        PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(intstockno);

                        //Alter quantity to reflect deletion of item.
                        stockRow.Quantity += stockSaleRow.Quantity_Sold;
                    }

                    catch (Exception ex)
                    {   //Catches an error and displays a messagebox.
                        MessageBox.Show("Alter stock to reflect sales failed");
                    }

                    //Deletes the item.
                    stockSaleRow.Delete();

                    //Updates the databases.
                    stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);
                    stockTableAdapter.Update(pHPDatabaseDataSet.Stock);

                    //Gives the user feedback in a messagebox.
                    MessageBox.Show("The Item has been deleted");
                }
            }
            //Renders the checklistbox, updating it with the new information.
            rendercheckbox();
        } 
    }
}