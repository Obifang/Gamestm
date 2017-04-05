using System;
//A Hello World! program in C#.
namespace Gamestm_php_solution
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Message myMessage = new Message("This is the PHP_Inc Program:");
			myMessage.Print();

			Message[] messages = new Message[4];
			messages[0] = new Message(" Hello World ");
			messages[1] = new Message(" My name is Tom Latimer");
			messages[2] = new Message(" Nice to meet you ");
			messages[3] = new Message(" This is my first time doing object oriented programming ");

			Console.WriteLine("Insert Item Name:");
			string name = Console.ReadLine();
			//MITCH = mitch
			if (name.ToLower() == "andrew")
			{
				messages[0].Print();
			}
			else if (name.ToLower() == "wilma")
			{
				messages[1].Print();
			}
			else if (name.ToLower() == "fred")
			{
				messages[2].Print();
			}
			else
			{
				messages[3].Print();
			}
		}
	}
}
/*int num;
			Console.WriteLine("Enter a number:");
			num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("you have inserted a number");
			Console.ReadLine();*/