﻿using System;
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
        public editstockform(string stocktoedit)
        {
            InitializeComponent();

            // Loads data into 'pHPDatabaseDataSet.Stock'
            try
            {
                stockTableAdapter.Fill(pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Fill stock failed");
            }

            //Fetch data from database
            try
            {
                // Searches pHPDatabaseDataSet.Stock for a entry with the entered stock no and assigns it to newStockRow
                PHPDatabaseDataSet.StockRow newStockRow = pHPDatabaseDataSet.Stock.FindByStock_No(int.Parse(stocktoedit));

                // Populates textboxes with data from newStockRow
                stocknumber.Text = newStockRow.Stock_No.ToString();
                stockname.Text = newStockRow.Name;
                stockdesc.Text = newStockRow.Desc;
                stocktype.Text = newStockRow.Type;
                stockquantity.Text = newStockRow.Quantity.ToString();
                stockprice.Text = newStockRow.Price.ToString();
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Fetch data for row edits failed");
            }
        }

        private void editstockrecordbutton_Click(object sender, EventArgs e)
        {
            //Initialise stockedit, it complains unless you provide a value, which is later overwritten
            int stocktoedit = 1;
            try
            {
                stocktoedit = Int32.Parse(stocknumber.Text.Trim());
            }
            catch (Exception ex)
            {
                // Catches an error and displays a messagebox
                MessageBox.Show("Stock Edit Parse failed");
                // Dispalys error message in a messagebox
                MessageBox.Show("String Value : " + stocknumber.Text.Trim() + "");
            }

            //Gets new values from textboxes
            string strname = stockname.Text;
            string strdesc = stockdesc.Text;
            string strtype = stocktype.Text;
            int intQuantity;
            Int32.TryParse(stockquantity.Text, out intQuantity);
            decimal decPrice = Convert.ToDecimal(stockprice.Text);

            // Find row you want to modify, using FindByStock_No
            PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(stocktoedit);

            // Insert data into old row
            stockRow.Name = strname;
            stockRow.Desc = strdesc;
            stockRow.Type = strtype;
            stockRow.Quantity = intQuantity;
            stockRow.Price = decPrice;

            // Save the row to the database
            try
            {
                //Updates stockTableAdapter with the new information from pHPDatabaseDataSet.Stock
                stockTableAdapter.Update(pHPDatabaseDataSet.Stock);
                // Closes form
                Close();
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Edit stock failed");
            }
        }
    }
}
