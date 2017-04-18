using System;
using System.Collections.Generic;

namespace Gamestm_php_solution
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
            _StockItems = StockItems;
            _StockCount = StockCount;
			_SalesDate = SalesDate;
			_StockSold = new List<StockSale> ();
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
			get{
				return _StockItems;
			}
        }

        //with each stock added - increase quantity of item.
        //calculate the amount of purchases of each sales item.
        public int StockCount
        {
			get{
				return _StockCount;
			}
        }
        
        //enable the sales date to synchronise with the clock on the computer.
        public DateTime SalesDate
        {
            get {
				return _SalesDate;
			}
        }

		//calculate the total stock sold and profit.
		public List<StockSale> StockSold {
			get {
				return _StockSold;
			}
		}

        public void UpdateStock(string StockName, int StockSold)
        {
            //just need to know what to insert here.
            StockSold++;
            //might increase stock sold with each item added to the database.
        }

        public void AddStockToSale(string StockName, int StockSold)
          {
            //Just need to know what to insert here.
            StockSold++;
          }
    }
}