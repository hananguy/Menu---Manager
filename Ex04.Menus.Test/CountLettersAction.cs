using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
	public class CountLettersAction : IMenuAction
	{
		public void Execute()
		{
			Console.Write("Enter text: ");
			string input = Console.ReadLine();
			int count = input.Count(char.IsLower);
			Console.WriteLine($"> There are {count} lowercase letters in your text");
		}
	}
}
