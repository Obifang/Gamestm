using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSolution
{
    //private variables.
    public class StockClass
    {
        //name of product.
        private string _Name;
        //product description.
        private string _Desc;
        //product ID.
        private int _Id;
        //cost of item.
        private decimal _Price;
        //find out what stock is available.
        private int _InStock;
        private string _Type;
        private int _Quantity;


        //maybe have "Quantity" as a private variable if need be.
        public StockClass(string Name, string Desc, int Id, int InStock, string Type, int Quantity, decimal Price)
        {
            //Provide a value for the variables.
            _Name = Name;
            _Desc = Desc;
            _Id = Id;
            _Price = Price;
            _InStock = InStock;
            _Type = Type;
            _Quantity = Quantity;
        }

        //Get the name of the product inserted.
        public string GetName
        {//^[A-Za-z]\S*$
            get
            {
                return _Name;
            }
        }

        //Get the price of the product.	
        public decimal GetPrice
        {//[0-9]
            //^[0-9]([.,][0-9]{1,3})?$
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }

        //Get the ID of a product.	
        public int GetId
        {
            get
            {
                return _Id;
            }
        }

        //Get the description of the product.
        public string GetDesc
        {//^[A-Za-z]\S*$
            get
            {
                return _Desc;
            }
            //Add limitations and if statements if necessary.
        }

        public string GetStockType
        {//^[A-Za-z]\S*$
            get
            {
                return _Type;
            }
        }

        public int GetQuantity
        {//[0-9]
            //^(?:\d|[1-3]\d|4[0-5])$
            get
            {
                return _Quantity;
            }
            set
            {
                _Quantity = value;
            }
        }

        //get and find out if there is stock available or not.
        public int InStock
        {
            get
            {
                return _InStock;
            }
        }

        //search for entry of typed sales item.
        public void edit(string newName, string newDesc, string newType, int newId, int newQuantity, decimal newPrice)
        {
            //just need to know what to insert here.
            _Id = newId;
            _Name = newName;
            _Desc = newDesc;
            _Desc = newType;
            _Quantity = newQuantity;
            _Price = newPrice;
            //Edit database.
        }

    }
}