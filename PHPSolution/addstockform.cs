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
            //Initial values
            string strname = stockname.Text;
            string strdesc = stockdesc.Text;
            string strtype = stocktype.Text;
            int intQuantity;
            Int32.TryParse(stockquantity.Text, out intQuantity);
            decimal decPrice = Convert.ToDecimal(stockprice.Text); ;
            
            // Create a new row.
            PHPDatabaseDataSet.StockRow newStockRow = pHPDatabaseDataSet.Stock.NewStockRow();

            // Insert data into new row
            newStockRow.Name = strname;
            newStockRow.Desc = strdesc;
            newStockRow.Type = strtype;
            newStockRow.Quantity = intQuantity;
            newStockRow.Price = decPrice;

            // Add the row to the Stock table
            pHPDatabaseDataSet.Stock.Rows.Add(newStockRow);

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