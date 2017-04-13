using System;
using System.Collections.Generic;

namespace Gamestm_php_solution
{
    public class SalesClass
    {
        //Stock Items.
        private StockClass[] _StockItems;
        //Quantity of stock.
        private int _StockCount;
        //Cost of item.
        private double _ItemCost;
        //Date stock item was sold.
        private DateTime _SalesDate;
        //stock sold.
        private StockClass[] _Stocksold;
        //I think we can reference stock class here as well to check the user input.

        //reference stock class or stock.
        public SalesClass()
        {
            _StockItems = StockItems;
            _StockCount = StockCount;
            _ItemCost = ItemCost;
            _SalesDate = SalesDate;
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
        {
            get;
            private set;
        }

        //with each stock added - increase quantity of item.
        //calculate the amount of purchases of each sales item.
        public int StockCount
        {
            get;
            private set;
        }

        //calculate salescost for each stock item.
        public double ItemCost
        {
            get;
            private set;
        }
        
        //enable the sales date to synchronise with the clock on the computer.
        public DateTime SalesDate
        {
            get;
            private set;
        }

        //calculate the total stock sold and profit.
        public StockSale[] Stocksold;
        { get
            {
				return _StockSold;
			}
        }

        public void UpdateStock(string StockName, int StockSold)
        {
          //just need to know what to insert here.
        }

        public void AddStockToSale(string StockName, int StockSold)
          {
          //Just need to know what to insert here.
          }
    }
}