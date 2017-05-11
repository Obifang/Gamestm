using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSolution
{
    public class SalesClass
    {
        //Stock Items.
        private StockClass[] _StockItems;
        //A list to keep track of sales.
        private List<StockSale> _StockSold;
        //Quantity of stock.
        private int _StockCount;
        //Date stock item was sold.
        private DateTime _SalesDate;
        //stock sold.
        //private StockClass[] _Stocksold;
        //I think we can reference stock class here as well to check the user input.

        //reference stock class or stock.
        public SalesClass()
        {
            _StockItems = null;
            _SalesDate = default(DateTime);
            _StockCount = 0;
            _StockSold = new List<StockSale>();
            //StockClass[] StockItems = null;
            //DateTime SalesDate = default(DateTime);
            //double ItemCost = 0;
            //int StockCount = 0;
            //_StockSold = StockSold;
        }

        //Getters and setters. add fields to each item.
        //assign price to stock item.
        //bring up stock data in set messages.
        public StockClass[] StockItems
        { //^[A-Za-z]\S*$
            get
            {
                return _StockItems;
            }
        }

        //with each stock added - increase quantity of item.
        //calculate the amount of purchases of each sales item.
        public int StockCount
        {//[0-9]
            get
            {
                return _StockCount;
            }
        }

        /*function validateDate(testdate)
        {
            var date_regex = /^\d{ 2}\/\d{ 2}\/\d{ 4}$/ ;
            return date_regex.test(testdate);
        }*/

        //enable the sales date to synchronise with the clock on the computer.
        public DateTime SalesDate
        {
            get
            {

                return _SalesDate;
            }
        }

        //calculate the total stock sold and profit.
        public List<StockSale> StockSold
        {
            get
            {
                return _StockSold;
            }
        }

        private void UpdateStock(string StockName, int StockSold)
        {
            //Just need to know what to insert here.
            StockSale Temp;
            Temp = _StockSold.Find(x => x.GetStockName == StockName);
            //might increase stock sold with each item added to the database.
            //Temp.UpdateStockSold = StockSold;
            Temp.UpdateStockSold = StockSold;
        }

        public void AddStockToSale(string StockName, int StockSold)
        {
          //Just need to know what to insert here.
          _StockSold.Add(new StockSale(StockName, StockSold));
          UpdateStock(StockName, StockSold);
        }
    }
}