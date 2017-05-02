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
    public partial class addstockform : Form
    {
        public addstockform()
        {
            InitializeComponent();
        }

        private void addstock_Click(object sender, EventArgs e)
        {
            //Gets values from textboxes
            string strname = stockname.Text;
            string strdesc = stockdesc.Text;
            string strtype = stocktype.Text;
            int intQuantity;
            Int32.TryParse(stockquantity.Text, out intQuantity);
            decimal decPrice = Convert.ToDecimal(stockprice.Text); ;
            
            // Creates a new row.
            PHPDatabaseDataSet.StockRow newStockRow = pHPDatabaseDataSet.Stock.NewStockRow();

            // Inserts data into new row
            newStockRow.Name = strname;
            newStockRow.Desc = strdesc;
            newStockRow.Type = strtype;
            newStockRow.Quantity = intQuantity;
            newStockRow.Price = decPrice;

            // Adds the new row to pHPDatabaseDataSet.Stock
            pHPDatabaseDataSet.Stock.Rows.Add(newStockRow);

            // Save the new row to the database
            try
            {
                //Updates stockTableAdapter with the new information from pHPDatabaseDataSet.Stock
                stockTableAdapter.Update(pHPDatabaseDataSet.Stock);
                // Closes form
                Close();
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Add stock failed");
            }
        }
    }
}