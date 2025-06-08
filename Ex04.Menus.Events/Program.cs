using System;
using System.Collections.Generic;
using System.Linq;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
	public class ShowVersionAction
	{
		public void Execute()
		{
			Console.WriteLine("App Version: 25.2.4.4480");
		}
	}

	public class CountLettersAction
	{
		public void Execute()
		{
			Console.Write("Enter text: ");
			string input = Console.ReadLine();
			int count = input.Count(char.IsLower);
			Console.WriteLine($"> There are {count} lowercase letters in your text");
		}
	}

	public class ShowDateAction 
	{
		public void Execute()
		{
			Console.WriteLine($"Current Date is {DateTime.Now:dd/MM/yyyy}");
		}
	}

	public class ShowTimeAction 
	{
		public void Execute()
		{
			Console.WriteLine($"Current Time is {DateTime.Now:HH:mm}");
		}
	}

	public class Program
	{
		public static void Main()
		{
			ShowVersionAction showVersion = new ShowVersionAction();
			MenuItem showVersionItem = new MenuItem("Show Version", null);
			showVersionItem.m_Actions += showVersion.Execute;
			MenuItem countLettersItem = new MenuItem("Count Lowercase Letters", null);

			MenuItem lettersAndVersionBranch = new MenuItem("Letters and Version", new List<MenuItem> { showVersionItem, countLettersItem });

			MenuItem showDateItem = new MenuItem("Show Current Date", null);

			MenuItem showTimeItem = new MenuItem("Show Current Time", null);

			MenuItem dateTimeBranch = new MenuItem("Show Current Date/Time", new List<MenuItem> { showDateItem, showTimeItem });

			Menu mainMenu = new Menu("Interfaces Main Menu",new List<MenuItem> { lettersAndVersionBranch, dateTimeBranch });

			mainMenu.Show();
		}
	}
}
