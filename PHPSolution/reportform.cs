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

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog='C:\\USERS\\BRENDAN PERT\\DOCUMENTS\\GITHUB\\GAMESTM\\PHPSOLUTION\\BIN\\DEBUG\\PHPDATABASE.MDF';Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User ID=DESKTOP-4A7DDVC\\Brendan Pert;Password=;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataReader reader;

            string startdate = "'2017-05-01'";
            string enddate = "'2017-05-09'";

            cmd.CommandText = "SELECT [Stock].[Name], [Stock].[Stock_No], [Stock].[Quantity], [Stock].[Price],COUNT(*) as NoOfPurchases,AVG([StockSale].[Quantity_Sold]) as AvgPurchased,SUM([StockSale].[Quantity_Sold]) as SumPurchased,AVG([StockSale].[Sale_Price] * [StockSale].[Quantity_Sold]) as AvgValue,SUM([StockSale].[Sale_Price] * [StockSale].[Quantity_Sold]) as SumValue FROM[Sale] INNER JOIN StockSale ON StockSale.Sale_No = Sale.Sale_No INNER JOIN Stock ON Stock.Stock_No = StockSale.Stock_No WHERE [Date] BETWEEN " + startdate + " AND " + enddate + " GROUP BY[Stock].[Stock_No], [Stock].[Name], [Stock].[Quantity], [Stock].[Price];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            string[,] readerArray = new string[50,9];
            int i = 0;
            while (reader.Read())
            {
                readerArray[i,0] = reader.GetString(0).Trim(); //Name
                readerArray[i,1] = reader.GetInt32(1).ToString(); //Stock_No
                readerArray[i,2] = reader.GetInt32(2).ToString(); //Quantity
                readerArray[i,3] = reader.GetDecimal(3).ToString(); //Price
                readerArray[i,4] = reader.GetInt32(4).ToString(); //NoOfPurchases
                readerArray[i,5] = reader.GetInt32(5).ToString(); //AvgPurchased
                readerArray[i,6] = reader.GetInt32(6).ToString(); //SumPurchased
                readerArray[i,7] = reader.GetDecimal(7).ToString(); //AvgValue
                readerArray[i,8] = reader.GetDecimal(8).ToString(); //SumValue
                i++;
            }
            reader.Close();

            multiline.Text = "";
            for (int j = 0; j < readerArray.GetLength(0); j++)
            {
                for (int k = 0; k < readerArray.GetLength(1); k++)
                {
                    multiline.Text += readerArray[j,k] + Environment.NewLine;
                }
            }

            CSVGenerator file = new CSVGenerator();
            file.NewCSVFile("Test");
            file.WriteToFile(readerArray);

            sqlConnection1.Close();
        }
    }
}
