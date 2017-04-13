using System;
using System.Collections.Generic;
//PHP solution.
namespace Gamestm_php_solution
{
	class MainClass
	{
		public static void Main()
		{
            //Get the user to insert an item name, short description, ID for product and the price.
			StockClass testStock = new StockClass ("Test Name", "TestType", 1, 23, 5);
			Console.WriteLine (testStock.GetName);
			Console.WriteLine (testStock.GetDesc);
			Console.WriteLine (testStock.GetId);
			Console.WriteLine (testStock.GetPrice);
		}
	}
}