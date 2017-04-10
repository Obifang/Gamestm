using System;
using System.Collections.Generic;

namespace Gamestm_php_solution
{
	public class SalesClass
	{
		private StockClass[] _StockItems;
		private int _StockCount;
        private double _ItemCost;
        private DateTime _SalesDate;

        //reference stock class or stock.
		public SalesClass ()
		{

		}

        public StockClass[] StockItems
        {
            get => _StockItems;
            set => _StockItems = value;
        }

        public int StockCount
        {
            get => _StockCount;
            set => _StockCount = value;
        }
        public double ItemCost
        {
            get => _ItemCost;
            set => _ItemCost = value;
        }
        public DateTime SalesDate
        {
            get => _SalesDate;
            set => _SalesDate = value;
        }
    }
}