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
