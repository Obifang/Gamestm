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
    public partial class reportform : Form
    {
        public reportform()
        {
            InitializeComponent();
        }

        private void reportform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHPDatabaseDataSet.StockSale1' table. You can move, or remove it, as needed.
            this.stockSale1TableAdapter.Fill(this.pHPDatabaseDataSet.StockSale1);
            // TODO: This line of code loads data into the 'pHPDatabaseDataSet.StockSale' table. You can move, or remove it, as needed.
            this.stockSaleTableAdapter.Fill(this.pHPDatabaseDataSet.StockSale);
            // TODO: This line of code loads data into the 'pHPDatabaseDataSet.StockSale1' table. You can move, or remove it, as needed.
            this.stockSale1TableAdapter.Fill(this.pHPDatabaseDataSet.StockSale1);
            // Loads data into the 'pHPDatabaseDataSet.Report' table.
            try
            {
                reportTableAdapter.Fill(pHPDatabaseDataSet.Report);
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show("Report not loaded correctly");
                return;
            }
            

        }
    }
}
