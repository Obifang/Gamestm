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

        //I think we can reference stock class here as well to check the user input.
        //reference stock class or stock.
		public SalesClass ()
		{
            _StockItems = StockItems;
            _StockCount = StockCount;
            _ItemCost = ItemCost;
            _SalesDate = SalesDate;
		}

        //Getters and setters. add fields to each item.
        //assign price to stock item.
        //bring up stock data in set messages.
        public StockClass[] StockItems
        {
            get => StockItems;
            set => StockItems = value;
        }

        //with each stock added - increase quantity of item.
        //calculate the amount of purchases of each sales item.
        public int StockCount
        {
            get => StockCount;
            set => StockCount = value;
        }

        //calculate salescost for each stock item.
        public double ItemCost
        {
            get => ItemCost;
            set => ItemCost = value;
        }

        //enable the sales date to synchronise with the clock on the computer.
        public DateTime SalesDate
        {
            get => SalesDate;
            set => SalesDate = value;
        }
        //calculate the total stock sold and profit.
    }
}