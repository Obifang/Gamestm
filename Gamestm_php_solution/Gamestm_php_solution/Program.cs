using System;
//PHP solution
namespace Gamestm_php_solution
{
	class MainClass
	{
		public static void Main()
		{
			StockClass testStock = new StockClass ("stock name", "a type of stock", 1, 23);
			Console.WriteLine (testStock.GetName);
			Console.WriteLine (testStock.GetDesc);
			Console.WriteLine (testStock.GetId);
			Console.WriteLine (testStock.GetPrice);
		}
	}
}
