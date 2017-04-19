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
    public partial class editstockform : Form
    {
        public editstockform()
        {
            InitializeComponent();

            // Loads data into 'pHPDatabaseDataSet.Stock'
            try
            {
                this.stockTableAdapter.Fill(this.pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill stock failed");
            }            
        }

        //Populate the fields with the old data
        private void selectstocktoedit_Click(object sender, EventArgs e)
        {
            //Initialise stockedit
            int stocktoedit = 1;
            try
            {
                stocktoedit = Int32.Parse(editstocktextbox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock Edit Parse failed");
                MessageBox.Show("String Value : " + editstocktextbox.Text.Trim() + "");
            }

            //Fetch data from database
            try
            {
                DataRow[] newResultRow = pHPDatabaseDataSet.Stock.Select("[Stock_No]=" + stocktoedit + "");
                var array = newResultRow[0].ItemArray;

                stocknumber.Text = array[0].ToString();
                stockname.Text = array[1].ToString();
                stockdesc.Text = array[2].ToString();
                stocktype.Text = array[3].ToString();
                stockquantity.Text = array[4].ToString();
                stockprice.Text = array[5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetch data for row edits failed");
            }
        }

        private void editstockrecordbutton_Click(object sender, EventArgs e)
        {
            //Initialise stockedit
            int stocktoedit = 1;
            try
            {
                stocktoedit = Int32.Parse(editstocktextbox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock Edit Parse failed");
                MessageBox.Show("String Value : " + editstocktextbox.Text.Trim() + "");
            }

            //Insert data back into database, overwriting the previous entry
            //Initial values
            string strname = stockname.Text;
            string strdesc = stockdesc.Text;
            string strtype = stocktype.Text;
            int intQuantity;
            Int32.TryParse(stockquantity.Text, out intQuantity);
            decimal decPrice = Convert.ToDecimal(stockprice.Text);

            // Find row you want to modify.
            PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(stocktoedit);

            // Insert data into old row
            stockRow.Name = strname;
            stockRow.Desc = strdesc;
            stockRow.Type = strtype;
            stockRow.Quantity = intQuantity;
            stockRow.Price = decPrice;

            // Save the new row to the database
            try
            {
                stockTableAdapter.Update(pHPDatabaseDataSet.Stock);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add stock failed");
            }
        }
    }
}
