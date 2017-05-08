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
    public partial class AddItem : Form
    {
        public AddItem(string stocknumber) //, string Quantity, string Price
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

            //This is setup so that if the form is opened from addsaleform, it will alwasys be passed a number, and that no will be entered into the textbox
            //But if the form is opened from edit saleform, where it isn't passed a no, it will be passed 0 by default,
            //thus it will enter placeholder text, indicating to the user to enter a stock number

            //If stocknumber isnt 0, enter it into text of textbox
            if (int.Parse(stocknumber) != 0){
                stockno.Text = stocknumber;

                PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(int.Parse(stocknumber));
                stockname.Text = stockRow.Name;
            }
            else {
                //else enter placeholder text
                stockno.Text = "No";
<<<<<<< HEAD
            }

            /*if (int.Parse(Quantity) != 0)
            {
                stockquantity.Text = Quantity;
            }
            else
            {
                //else enter placeholder text
                stockquantity.Text = "Quantity";
            }

            if (int.Parse(Price) != 0)
            {
                stockprice.Text = Price;
            }
            else
            {
                //else enter placeholder text
                stockprice.Text = "Price";
            }*/

            // Loads data into 'pHPDatabaseDataSet.Stock'
            try
            {
                stockTableAdapter.Fill(pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Fill stock failed");
=======
                stockname.Text = "";
>>>>>>> origin/master
            }
        }

        private void defaultpricebutton_Click(object sender, EventArgs e)
        {
            // Searches pHPDatabaseDataSet.Stock for a entry with the entered stock_no and assigns it to stockRow
            PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(int.Parse(stockno.Text.Trim()));
            // Sets text of textbox with the price of the stock
            stockprice.Text =  stockRow.Price.ToString();
        }

        private void additembutton_Click(object sender, EventArgs e)
        {
            //Alter stock values to reflect sales
            try
            {
                // Searches pHPDatabaseDataSet.Stock for a entry with the entered stock_no and assigns it to stockRow
                PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(int.Parse(stockno.Text.Trim()));
                // Reduces quantity by the amount purchased
                stockRow.Quantity -= int.Parse(stockquantity.Text.Trim());
                // Updates database
                stockTableAdapter.Update(pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Alter stock to reflect sales failed");
            }
            // Closes form
            Close();
        }

        //Uses public getters so that the data entered can be obtained after the form is closed
        public string StockNo
        {
            get
            {
                return stockno.Text.Trim();
            }
        }

        public string Quantity
        {
            get
            {
                return stockquantity.Text.Trim();
            }
        }

        public string Price
        {
            get
            {
                return stockprice.Text.Trim();
            }
        }
    }
}