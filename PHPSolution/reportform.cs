using System;
using System.Collections;
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

        private void generatereport(string startdate, string enddate)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog='C:\\USERS\\BRENDAN\\DOCUMENTS\\GITHUB\\GAMESTM\\PHPSOLUTION\\BIN\\DEBUG\\PHPDATABASE.MDF';Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User ID=DESKTOP-4A7DDVC\\Brendan Pert;Password=;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataReader reader;

            cmd.CommandText = "SELECT [Stock].[Name], [Stock].[Stock_No], [Stock].[Quantity], [Stock].[Price],COUNT(*) as NoOfPurchases,AVG([StockSale].[Quantity_Sold]) as AvgPurchased,SUM([StockSale].[Quantity_Sold]) as SumPurchased,AVG([StockSale].[Sale_Price] * [StockSale].[Quantity_Sold]) as AvgValue,SUM([StockSale].[Sale_Price] * [StockSale].[Quantity_Sold]) as SumValue FROM[Sale] INNER JOIN StockSale ON StockSale.Sale_No = Sale.Sale_No INNER JOIN Stock ON Stock.Stock_No = StockSale.Stock_No WHERE [Date] BETWEEN " + startdate + " AND " + enddate + " GROUP BY[Stock].[Stock_No], [Stock].[Name], [Stock].[Quantity], [Stock].[Price];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            List<List<string>> readerArray = new List<List<string>>();

            int i = 0;
            while (reader.Read())
            {
                List<string> tempList = new List<string>();
                readerArray.Add(tempList);
                readerArray[i].Add(reader.GetString(0).Trim()); 
                //Name.
                readerArray[i].Add(reader.GetInt32(1).ToString()); 
                //Stock_No.
                readerArray[i].Add(reader.GetInt32(2).ToString()); 
                //Quantity.
                readerArray[i].Add(reader.GetDecimal(3).ToString());
                //Price.
                readerArray[i].Add(reader.GetInt32(4).ToString()); 
                //NoOfPurchases.
                readerArray[i].Add(reader.GetInt32(5).ToString()); 
                //AvgPurchased.
                readerArray[i].Add(reader.GetInt32(6).ToString()); 
                //SumPurchased.
                readerArray[i].Add(reader.GetDecimal(7).ToString()); 
                //AvgValue.
                readerArray[i].Add(reader.GetDecimal(8).ToString());
                //SumValue.
                i++;
            }
            reader.Close();

            multiline.Text = "NAME, STOCK_NO, QUANTITY, PRICE, NOOFPURCHASES, AVGPURCHASED, SUMPURCHASED, AVGTOTAL, SUMTOTAL" + Environment.NewLine;

            for (int j = 0; j < readerArray.Count; j++)
            {
                for (int k = 0; k < readerArray[j].Count - 2; k++)
                {
                    multiline.Text += readerArray[j][k] + ", ";
                }
                multiline.Text += Environment.NewLine;
            }

            CSVGenerator file = new CSVGenerator();
            file.NewCSVFile("Test");
            file.WriteToFile(readerArray);

            MessageBox.Show(file.GetFilePath + " has been saved");

            sqlConnection1.Close();
        }

        private void weeklyreport_Click(object sender, EventArgs e)
        {
            //Sets localtime.
            DateTime localTime = DateTime.Now;
            //Creates string with current date.
            string currentDate = localTime.Year + "-" + localTime.Month + "-" + localTime.Day;
            string aWeekAgo = "";

            if (localTime.Day - 7 > 0)
            {
                aWeekAgo = localTime.Year + "-" + localTime.Month + "-" + (localTime.Day - 7).ToString();
            }
            else
            {
                int amount = localTime.Day - 7;

                if (localTime.Month - 1 == 1 || localTime.Month - 1 == 3 || localTime.Month - 1 == 5 || localTime.Month - 1 == 7 || localTime.Month - 1 == 8 || localTime.Month - 1 == 10 || localTime.Month - 1 == 12)
                {
                    //31 days.
                    aWeekAgo = localTime.Year + "-" + (localTime.Month - 1).ToString() + "-" + (31-amount).ToString();
                }
                else if (localTime.Month - 1 == 2)
                {
                    //28 days.
                    aWeekAgo = localTime.Year + "-" + (localTime.Month - 1).ToString() + "-" + (28-amount).ToString();
                }
                else
                {
                    //30 days.
                    aWeekAgo = localTime.Year + "-" + (localTime.Month - 1).ToString() + "-" + (30 - amount).ToString();
                }
            }

            string startdate = "'"+aWeekAgo+"'";
            string enddate = "'"+currentDate+"'";

            generatereport(startdate, enddate);
        }
    }
}
