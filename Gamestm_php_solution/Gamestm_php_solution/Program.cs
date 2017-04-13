using System;
using System.Collections.Generic;
//PHP solution.
namespace Gamestm_php_solution
{
	class MainClass
	{
		public static void Main()
		{
            string userInput;
            StockClass[] stockArray = new StockClass[10];
            stockArray[0] = new StockClass("Pain Killers", "kill that pain dead", 1, 25);
            //Get the user to insert an item name, short description, ID for product and the price.
            Console.WriteLine(stockArray[0].GetName);
		    Console.WriteLine(stockArray[0].GetDesc);
			Console.WriteLine(stockArray[0].GetId);
			Console.WriteLine(stockArray[0].GetPrice);

            userInput = Console.ReadLine();
            while (userInput != "quit")
            {
                if (userInput == "edit")
                {
                    Console.WriteLine("Enter new name");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Enter new description");
                    string newDesc = Console.ReadLine();
                    Console.WriteLine("Enter new ID");
                    int newId = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter new price");
                    double newPrice = Convert.ToDouble(Console.ReadLine());

                    editStockRecord(stockArray[0], newName, newDesc, newId, newPrice);
                    userInput = "";
                }

                Console.WriteLine(stockArray[0].GetName);
                Console.WriteLine(stockArray[0].GetDesc);
                Console.WriteLine(stockArray[0].GetId);
                Console.WriteLine(stockArray[0].GetPrice);

                userInput = Console.ReadLine();
            }          
        }

		public static void editStockRecord(StockClass s, string newName, string newDesc, int newId, double newPrice)
		{
			s.edit(newName, newDesc, newId, newPrice);
		}
	}
}