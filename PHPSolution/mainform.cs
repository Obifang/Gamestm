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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pHPDatabaseDataSet);
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            // Loads data into the 'pHPDatabaseDataSet.Stock' table
            try
            {
                this.stockTableAdapter.Fill(this.pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill failed");
            }

            // Clears labels
            stockno.Text = "";
            stockname.Text = "";
            stockdesc.Text = "";
            stocktype.Text = "";
            stockquantity.Text = "";
            stockprice.Text = "";
        }

        //Currently only works if value is hardcoded
        private void showstockrecord_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] newResultRow = pHPDatabaseDataSet.Stock.Select("[Stock_No]=5");//+showstocksearchbox);
                var array = newResultRow[0].ItemArray;

               stockno.Text = "ID Number:   " + array[0].ToString();
               stockname.Text = "Name:          " + array[1].ToString();
               stockdesc.Text = "Desc:           " + array[2].ToString();
               stocktype.Text = "Type:            " + array[3].ToString();
               stockquantity.Text = "Quantity:      " + array[4].ToString();
               stockprice.Text = "Price:            " + array[5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetch data for show stock record failed");
            }
        }

        private void addstockrecord_Click(object sender, EventArgs e)
        {
            var addstockform = new addstockform();
            addstockform.Show(this);
        }

        private void editstockrecord_Click(object sender, EventArgs e)
        {
            var editstockform = new editstockform();
            editstockform.Show(this);
        }

        private void searchstock_Click(object sender, EventArgs e)
        {
            //Allows the user to search their stock to find the stock_no, also gives extra info if there are duplicate names
            try
            {
                DataRow[] newResultRow = pHPDatabaseDataSet.Stock.Select("[Name] like '"+searchstocktextbox.Text+"'");
                int i = 0;
                searchstockresult.Text = "";
                foreach (DataRow value in newResultRow)
                {
                    var array = newResultRow[i].ItemArray;

                    searchstockresult.Text += ""+(i+1)+"st result." + Environment.NewLine;

                    searchstockresult.Text += "ID Number: "+array[0].ToString() + Environment.NewLine;
                    searchstockresult.Text += "Name: " + array[1].ToString().TrimEnd() + Environment.NewLine;
                    searchstockresult.Text += "Desc: " + array[2].ToString().TrimEnd() + Environment.NewLine;
                    searchstockresult.Text += "Price: "+ array[5].ToString() + Environment.NewLine + Environment.NewLine;

                    //searchstockresult.Text += "Type: "+array[3].ToString().TrimEnd() + Environment.NewLine;
                    //searchstockresult.Text += "Quantity: "+array[4].ToString() + Environment.NewLine;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search for ID query failed");
            }
        }
    }
}