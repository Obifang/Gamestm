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

            if (Int32.Parse(stocknumber) != 0){
                stockno.Text = stocknumber;
            }
            else {
                stockno.Text = "No";
            }

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
            PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(Int32.Parse(stockno.Text.Trim()));
            stockprice.Text =  stockRow.Price.ToString();
        }

        private void additembutton_Click(object sender, EventArgs e)
        {
            //Alter stock values to reflect sales
            try
            {
                PHPDatabaseDataSet.StockRow stockRow = pHPDatabaseDataSet.Stock.FindByStock_No(Int32.Parse(stockno.Text.Trim()));
                stockRow.Quantity -= Int32.Parse(stockquantity.Text.Trim());
                stockTableAdapter.Update(pHPDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alter stock to reflect sales failed");
            }

            Close();
        }

        public string StockNo
        {
            get { return stockno.Text.Trim(); }
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
