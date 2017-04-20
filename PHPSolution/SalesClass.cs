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
        //Quantity of stock.
        private int _StockCount;
        //Date stock item was sold.
        private DateTime _SalesDate;

        public SalesClass()
        {
            //?.
            _StockItems = null;
            _SalesDate = default(DateTime);
            _StockCount = 0;
        }
        //bring up stock data in set messages.
public StockClass[] StockItems
        {
            get
            {
                return _StockItems;
            }
        }

        //with each stock added - increase quantity of item.
        //calculate the amount of purchases of each sales item.
        public int StockCount
        {
            get
            {
                return _StockCount;
            }
        }

        //enable the sales date to synchronise with the clock on the computer.
        public DateTime SalesDate
        {
            get
            {
                return _SalesDate;
            }
        }
    }
}