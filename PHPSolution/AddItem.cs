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
        public AddItem(string stocknumber)
        {
            InitializeComponent();

            stockno.Text = "No: " + stocknumber;

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

        private void defaultpricebutton_Click(object sender, EventArgs e)
        {
            PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(Int32.Parse(stockno.Text.Substring(3).Trim()));
            stockprice.Text =  stockRow.Price.ToString();
        }

        private void additembutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string StockNo
        {
            get { return stockno.Text.Substring(3).Trim(); }
        }

        public string Quantity
        {
            get { return stockquantity.Text.Trim(); }
        }

        public string Price
        {
            get { return stockprice.Text.Trim(); }
        }
    }
}
