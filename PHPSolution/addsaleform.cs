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
    public partial class addsaleform : Form
    {
        public addsaleform()
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

            //Disaply stock items in a checkbox
            try
            {
                PHPDatabaseDataSet.StockDataTable stockTable = pHPDatabaseDataSet.Stock;

                foreach (PHPDatabaseDataSet.StockRow stockrow in stockTable)
                {
                    salechecklistbox.Items.Add("No: " + stockrow.Stock_No.ToString() + "     Name : " + stockrow.Name.TrimEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entering data into checklistbox failed");
            }
        }

        private void addsale_Click(object sender, EventArgs e)
        {
            // Create a new sale row.
            PHPDatabaseDataSet.SaleRow newSaleRow = pHPDatabaseDataSet.Sale.NewSaleRow();
           
            // Insert data into new sale row
            newSaleRow.Date = Convert.ToDateTime(saledate.Text);

            // Add the row to the Stock table and update database
            pHPDatabaseDataSet.Sale.Rows.Add(newSaleRow);
            saleTableAdapter.Update(pHPDatabaseDataSet.Sale);

            // Add data to items
            for (int i = 0; i < salechecklistbox.Items.Count; i++)
            {
                if (salechecklistbox.GetItemChecked(i))
                {
                    string strtemp = (string)salechecklistbox.Items[i];
                    string stockno = strtemp.Substring(3, 4).Trim();

                    var additemform = new AddItem(stockno);
                    additemform.ShowDialog(this);

                    //Create new stocksale row
                    PHPDatabaseDataSet.StockSaleRow newStockSaleRow = pHPDatabaseDataSet.StockSale.NewStockSaleRow();

                    //Get highest saleno
                    DataRow[] newResultRow = pHPDatabaseDataSet.Sale.Select("Sale_No is not NULL","Sale_No DESC");
                    var array = newResultRow[0].ItemArray;
                    string saleno = array[0].ToString();

                    //Insert data into new stocksale row
                    newStockSaleRow.Sale_No = Int32.Parse(saleno);
                    newStockSaleRow.Stock_No = Int32.Parse(additemform.StockNo);
                    newStockSaleRow.Quantity_Sold = Int32.Parse(additemform.Quantity);
                    newStockSaleRow.Sale_Price = Decimal.Parse(additemform.Price);

                    // Add the row to the Stock table and update database
                    pHPDatabaseDataSet.StockSale.Rows.Add(newStockSaleRow);
                    stockSaleTableAdapter.Update(pHPDatabaseDataSet.StockSale);
                }
            }
            Close();
        }

        private void currentdatebutton_Click(object sender, EventArgs e)
        {
            DateTime localTime = DateTime.Now;
            string currentDate = localTime.Year +"-"+ localTime.Month +"-"+ localTime.Day;
            saledate.Text = currentDate;
        }
    }
}
