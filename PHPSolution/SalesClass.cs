using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSolution
{
    class SalesClass
    {
        //Stock Items.
        private StockClass[] _StockItems;
        //A list to keep track of sales.
        private List<StockSale> _StockSold;
        //Quantity of stock.
        private int _StockCount;
        //Date stock item was sold.
        private DateTime _SalesDate;

        //reference stock class or stock.
        public SalesClass()
        {
            _StockSold = new List<StockSale>();
            _StockItems = null;
            _SalesDate = default(DateTime);
            _StockCount = 0;
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
        {//[RegularExpression(@"\d{2,2}/\d{2,2}/\d{4,4} \d{2,2}:\d{2,2}:\d{2,2}")]
            get
            {

                return _SalesDate;
            }
        }

        //calculate the total stock sold and profit.
        public List<StockSale> StockSold
        {//[0-9]
            //^(?:\d|[1-3]\d|4[0-5])$
            get
            {
                return _StockSold;
            }
        }

        private void UpdateStock(string StockName, int StockSold)
        {
            StockSale Temp;
            Temp = _StockSold.Find(x => x.GetStockName == StockName);

            Temp.UpdateStockSold = StockSold;
        }

        public void AddStockToSale(string StockName, int StockSold)
        {
            _StockSold.Add(new StockSale(StockName, StockSold));
            UpdateStock(StockName, StockSold);
        }
    }
}