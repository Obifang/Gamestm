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

            //Fill the stock table
            stockSaleTableAdapter.Fill(pHPDatabaseDataSet.StockSale);
            saleTableAdapter.Fill(pHPDatabaseDataSet.Sale);

            //Only show items for this sale
            stockSaleBindingSource.Filter = "[Sale_No] = " + salenotoedit;

            //Fetch data from database
            try
            {
                DataRow[] saleRow = pHPDatabaseDataSet.Sale.Select("[Sale_No]=" + salenotoedit);
                var array = saleRow[0].ItemArray;

                saleno.Text = array[0].ToString();
                saledate.Text = array[1].ToString().Substring(0,10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetch data for sale edit failed");
            }

            //Disaply stock items in a checkbox
            try
            {
                DataRow[] stockSaleRow = pHPDatabaseDataSet.StockSale.Select("[Sale_No]=" + salenotoedit);

                foreach (DataRow stockrow in stockSaleRow)
                {
                    var array = stockSaleRow[0].ItemArray;
                    salechecklistbox.Items.Add("No: " + array[0].ToString() + "     Quantity : " + array[2].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entering data into checklistbox failed");
                MessageBox.Show(ex.ToString());
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            // Find row you want to modify.
            PHPDatabaseDataSet.SaleRow saleRow = pHPDatabaseDataSet.Sale.FindBySale_No(int.Parse(saleno.Text.Trim()));

            // Insert data into old row
            saleRow.Date = Convert.ToDateTime(saledate.Text.Trim());

            // Save the new row to the database
            try
            {
                Validate();
                stockBindingSource.EndEdit();
                saleTableAdapter.Update(pHPDatabaseDataSet.Sale);
                stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);
                //Close window
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit sale failed");
            }
        }

        private void newitem_Click(object sender, EventArgs e)
        {
            var additemform = new AddItem(0.ToString());
            additemform.ShowDialog(this);

            //Create new stocksale row
            PHPDatabaseDataSet.StockSaleRow newStockSaleRow = pHPDatabaseDataSet.StockSale.NewStockSaleRow();
            
            //Insert data into new stocksale row
            newStockSaleRow.Sale_No = int.Parse(saleno.Text.Trim());
            newStockSaleRow.Stock_No = int.Parse(additemform.StockNo);
            newStockSaleRow.Quantity_Sold = int.Parse(additemform.Quantity);
            newStockSaleRow.Sale_Price = decimal.Parse(additemform.Price);

            // Add the row to the Stock table and update database
            pHPDatabaseDataSet.StockSale.Rows.Add(newStockSaleRow);
            stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);
        }

        private void editselecteditems_Click(object sender, EventArgs e)
        {
            // Edit items
            for (int i = 0; i < salechecklistbox.Items.Count; i++)
            {
                if (salechecklistbox.GetItemChecked(i))
                {
                    string strtemp = (string)salechecklistbox.Items[i];
                    int intstockno = int.Parse(strtemp.Substring(3, 4).Trim());
                    int intsaleno = int.Parse(saleno.Text.Trim());

                    var edititemform = new EditItem(intsaleno.ToString(), intstockno.ToString());
                    edititemform.ShowDialog(this);

                    //Fetch stocksale row of item
                    PHPDatabaseDataSet.StockSaleRow stockSaleRow = pHPDatabaseDataSet.StockSale.FindByStock_NoSale_No(intstockno, intsaleno);

                    //Insert data into stocksale row
                    stockSaleRow.Sale_No = intsaleno;
                    stockSaleRow.Stock_No = intstockno;
                    stockSaleRow.Quantity_Sold = int.Parse(edititemform.Quantity);
                    stockSaleRow.Sale_Price = decimal.Parse(edititemform.Price);

                    // Update database
                    pHPDatabaseDataSet.AcceptChanges();
                    stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);
                }
            }
        }
    }
}
