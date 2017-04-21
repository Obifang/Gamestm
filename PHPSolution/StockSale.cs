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
        {//^[A-Za-z]\S*$
            get
            {
                return _StockName;
            }
        }

        //Get the amount of stock sold.	
        public int UpdateStockSold
        {//[0-9]
            //^(?:\d|[1-3]\d|4[0-5])$
            set
            {
                _StockSold -= value;
            }
        }
    }
}