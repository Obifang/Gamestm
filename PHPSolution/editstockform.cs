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
    public partial class editstockform : Form
    {
        //Allows access to a field on another form
        private Main MainForm = new Main();
        int stocktoedit = 3;
        
        //The idea is to have the old values popup, which the user will edit and the new edited values and any old values the user
        //did not change will be pushed back into the database
        public editstockform()
        {
            InitializeComponent();
            //Int32.TryParse(MainForm.editstocktextbox.Text, out stocktoedit);
            try
            {
                //Currently doesn't work even though identical code is used in mainform.
                //Perhaps has something to do with the tableadapters?
                DataRow[] newResultRow = pHPDatabaseDataSet.Stock.Select("[Stock_No]=5");//+stocktoedit);
                var array = newResultRow[0].ItemArray;

                stocknumber.Text = array[0].ToString();
                stockname.Text = array[1].ToString();
                stockdesc.Text = array[2].ToString();
                stocktype.Text = array[3].ToString();
                stockquantity.Text = array[4].ToString();
                stockprice.Text = array[5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetch data for row edits failed");
            }
        }
       
        private void editstock_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(MainForm.editstocktextbox.Text, out stocktoedit);
            
        }
    }
}
