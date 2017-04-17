using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSolution
{
    public class StockClass
    {
        //Private variables.
        private string _Name;
        private string _Desc;
        private string _Type;
        private int _Quantity;
        private decimal _Price;
       
        public StockClass(string Name, string Desc, string Type, int Quantity, decimal Price)
        {
            //Provide a value for the variables.
            _Name = Name;
            _Desc = Desc;
            _Type = Type;
            _Quantity = Quantity;
            _Price = Price;
        }

        public void edit(string newName, string newDesc, string newType, int newQuantity, decimal newPrice)
        {
            _Name = newName;
            _Desc = newDesc;
            _Desc = newType;
            _Quantity = newQuantity;
            _Price = newPrice;

            //Edit database
        }

        public string GetName
        {
            get
            {
                return _Name;
            }
        }

        public string GetDesc
        {
            get
            {
                return _Desc;
            }
        }

        public string GetStockType
        {
            get
            {
                return _Type;
            }
        }

        public int GetQuantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                _Quantity = value;
            }
        }

        public decimal GetPrice
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }
    }
}
