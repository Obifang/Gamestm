using System;
using System.Collections.Generic;

namespace Gamestm_php_solution
{
    class StockSale
    {
        private string _StockName;
        private int _StockSold;
    }
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
    public string GetStockSold
    {
        get
        {
            return _StockSold;
        }
    }
}