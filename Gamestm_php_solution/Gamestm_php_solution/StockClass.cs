using System;
using System.Collections.Generic;

namespace Gamestm_php_solution
{
	public class StockClass
	{
        //private variables.
        //name of product.
		private string _Name;
        //product description.
		private string _Desc;
        //product ID.
		private int _Id;
        //cost of item.
		private double _Price;
        //find out what stock is available.
        private int _InStock;
        //maybe have "Quantity" as a private variable if need be.
		public StockClass (string Name, string Desc, int Id, double Price)
		{
            //Provide a value for the variables.
			_Name = Name;
			_Desc = Desc;
			_Id = Id;
			_Price = Price;
        }

		//Get the name of the product inserted.	
		public string GetName {
			get {
				return _Name;
			}
		}

        //Get the price of the product.	
        public double GetPrice {
			get {
				return _Price;
			}
			set {
				_Price = value;
			}
		}

        //Get the ID of a product.	
        public int GetId {
			get {
				return _Id;
			}
		}

        //Get the description of the product.	
        public string GetDesc {
			get {
				return _Desc;
			}
        //Add limitations and if statements if necessary.
		}
    
		public void edit(string newName, string newDesc, int newId, double newPrice)
		{
			_Name = newName;
			_Desc = newDesc;
			_Id = newId;
			_Price = newPrice;
		}
	}
}