using System;
//using System.Collections.Generic;

//print out text and make sure it prints out.
namespace Gamestm_php_solution
{
	public class Message
	{
		private string text;

		public Message(string txt)
		{
			text = txt;
		}

        //once the text inserted is given a value and then printed out.
		public void Print()
		{
			Console.WriteLine(text);
		}
	}
}