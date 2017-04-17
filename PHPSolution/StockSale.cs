using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSolution
{
    class StockSale
    {
        private string _StockName;
        private int _StockSold;

        public StockSale(String StockName, int StockSold)
        {
            _StockName = StockName;
            _StockSold = StockSold;
        }

        //Get the name of the stock.	
        public string GetStockName
        {
            get
            {
                return _StockName;
            }
        }

        //Get the amount of stock sold.	
        public int UpdateStockSold
        {
            set
            {
                _StockSold -= value;
            }
        }
    }
}
