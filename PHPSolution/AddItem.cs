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
        int saleno;

        public AddItem(string stocknumber, int salenumber)
        {
            InitializeComponent();

            saleno = salenumber;

            // Loads data into 'pHPDatabaseDataSet.Stock'
            try
            {
                stockTableAdapter.Fill(pHPDatabaseDataSet.Stock);
                stockSaleTableAdapter.Fill(pHPDatabaseDataSet.StockSale);
            }
            catch (Exception ex)
            {   // Catches an error and displays a messagebox
                MessageBox.Show("Fill pHPDatabaseDataSet failed");
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
                stockname.Text = "";
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
            //Validates each field using a try catch
            try
            {
                if (int.Parse(stockno.Text.Trim()) <= 0)
                {
                    //Dispalys an error message
                    MessageBox.Show("Please insert a value more than 0!");
                    //Exits function
                    return;
                }

                //Searches stockSale for items made on the provided sale no
                //Assigns the the results to an array of data rows
                DataRow[] stockSaleRow = pHPDatabaseDataSet.StockSale.Select("[Sale_No] = " + saleno);

                // Iterates through stockSaleRow
                int i = 0;
                foreach (DataRow stockSale in stockSaleRow)
                {
                    // Assigns a single data row to an array
                    // ItemArray can only be access this way, it cannot be accessed using value.ItemArray, hence this method
                    var stockSaleArray = stockSaleRow[i].ItemArray;

                    if (int.Parse(stockno.Text.Trim()) == int.Parse(stockSaleArray[0].ToString()))
                    {
                        //Dispalys an error message
                        MessageBox.Show("An entry for that stock number already exits");
                        //Exits function
                        return;
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid stock number");
                return;
            }
            
            try
            {
                if (int.Parse(stockquantity.Text.Trim()) <= 0)
                {
                    //Dispalys an error message
                    MessageBox.Show("Please insert a value more than 0!");
                    //Exits function
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid quantity");
                return;
            }

            try
            {
                if (decimal.Parse(stockprice.Text.Trim()) <= 0)
                {
                    //Dispalys an error message
                    MessageBox.Show("Please insert a number more than 0!");
                    //Exits function
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid price");
                return;
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

        private void AddItem_Load(object sender, EventArgs e)
        {

        }
    }
}