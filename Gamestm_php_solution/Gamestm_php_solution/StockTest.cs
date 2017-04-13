using NUnit.Framework;
using System;

namespace Gamestm_php_solution
{
	[TestFixture ()]
	public class SalesTest
	{
		[Test ()]
		public void StockNameTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			//Sets the test value to actual
			string actual = StockItem.GetName;

			//Sets the value of the expected result
			string expected = "Sleepu";

			Assert.AreEqual(expected, actual, "Name does not match anything in the database");
		}

		[Test ()]
		public void StockNotNameTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			//Sets the test value to actual
			string actual = StockItem.GetName;

			//Sets the value of the expected result
			string expected = "Sleep";

			Assert.AreNotEqual(expected, actual, "Name does not match");
		}

		[Test ()]
		public void StockDescTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			//Sets the test value to actual
			string actual = StockItem.GetDesc;

			//Sets the value of the expected result
			string expected = "Sleeping Pill";

			Assert.AreEqual(expected, actual, "Description does not match");
		}

		[Test ()]
		public void StockNotDescTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			//Sets the test value to actual
			string actual = StockItem.GetName;

			//Sets the value of the expected result
			string expected = "Sleep Pill";

			Assert.AreNotEqual(expected, actual, "Description does not match");
		}

		[Test ()]
		public void StockIDTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			//Sets the test value to actual
			int actual = StockItem.GetId;

			//Sets the value of the expected result
			int expected = 121212;

			Assert.AreEqual(expected, actual, "ID does not match");
		}

		[Test ()]
		public void StockNotIDTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			//Sets the test value to actual
			int actual = StockItem.GetId;

			//Sets the value of the expected result
			int expected = 121213;

			Assert.AreNotEqual(expected, actual, "ID does not match");
		}

		[Test ()]
		public void StockPriceCheckTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			//Sets the test value to actual
			double actual = StockItem.GetPrice;

			//Sets the value of the expected result
			double expected = 5;

			Assert.AreEqual(expected, actual, "Price does not match");
		}

		[Test ()]
		public void StockPriceNotCheckTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			//Sets the test value to actual
			double actual = StockItem.GetPrice;

			//Sets the value of the expected result
			double expected = 10;

			Assert.AreNotEqual(expected, actual, "Price does not match");
		}

		[Test ()]
		public void StockPriceChangeTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			StockItem.GetPrice = 10;

			//Sets the test value to actual
			double actual = StockItem.GetPrice;

			//Sets the value of the expected result
			double expected = 10;

			Assert.AreEqual(expected, actual, "Price does not match");
		}

		[Test ()]
		public void StockPriceNotChangeTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			StockItem.GetPrice = 10;

			//Sets the test value to actual
			double actual = StockItem.GetPrice;

			//Sets the value of the expected result
			double expected = 5;

			Assert.AreNotEqual(expected, actual, "Price does not match");
		}

		[Test ()]
		public void StockStockTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			//Sets the test value to actual
			int actual = StockItem.InStock;

			//Sets the value of the expected result
			int expected = 120;

			Assert.AreEqual(expected, actual, "Stock does not match");
		}

		[Test ()]
		public void StockNotStockTest ()
		{
			//Creating an Object
			StockClass StockItem = new StockClass ("Sleepu", "Sleeping Pill", 121212, 5, 120);

			//Sets the test value to actual
			int actual = StockItem.InStock;

			//Sets the value of the expected result
			int expected = 100;

			Assert.AreNotEqual(expected, actual, "Stock does not match");
		}
	}
}

