using System;
namespace Gamestm_php_solution
{
	public class Message
	{
		private string text;
		public Message(string txt)
		{
			text = txt;
		}
		public void Print()
		{
			Console.WriteLine(text);
		}
	}
}