using System;

namespace Gamestm_php_solution
{
	public class StockClass
	{
		private string _Name;
		private string _Desc;
		private int _Id;
		private double _Price;

		public StockClass (string Name, string Desc, int Id, double Price)
		{
			_Name = Name;
			_Desc = Desc;
			_Id = Id;
			_Price = Price;
		}
			
		public string GetName {
			get {
				return _Name;
			}
		}

		public double GetPrice {
			get {
				return _Price;
			}
			set {
				_Price = value;
			}
		}

		public int GetId {
			get {
				return _Id;
			}
		}

		public string GetDesc {
			get {
				return _Desc;
			}
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

