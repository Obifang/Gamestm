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
            // Loads data into the 'pHPDatabaseDataSet.Report' table.
            try
            {
                reportTableAdapter.FillBy(pHPDatabaseDataSet.Report);
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
