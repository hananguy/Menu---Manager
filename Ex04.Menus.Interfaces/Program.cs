using System;
using System.Collections.Generic;
using System.Linq;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class ShowVersionAction : IMenuAction
	{
		public void Execute()
		{
			Console.WriteLine("App Version: 25.2.4.4480");
		}
	}

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

	public class ShowDateAction : IMenuAction
	{
		public void Execute()
		{
			Console.WriteLine($"Current Date is {DateTime.Now:dd/MM/yyyy}");
		}
	}

	public class ShowTimeAction : IMenuAction
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
			MenuItem showVersionItem = new MenuItem(
				"Show Version",
				null,
				new ShowVersionAction()
			);

			MenuItem countLettersItem = new MenuItem(
				"Count Lowercase Letters",
				null,
				new CountLettersAction()
			);

			MenuItem lettersAndVersionBranch = new MenuItem(
				"Letters and Version",
				new List<MenuItem> { showVersionItem, countLettersItem },
				null
			);

			MenuItem showDateItem = new MenuItem(
				"Show Current Date",
				null,
				new ShowDateAction()
			);

			MenuItem showTimeItem = new MenuItem(
				"Show Current Time",
				null,
				new ShowTimeAction()
			);

			MenuItem dateTimeBranch = new MenuItem(
				"Show Current Date/Time",
				new List<MenuItem> { showDateItem, showTimeItem },
				null
			);

			Menu mainMenu = new Menu(
				"Interfaces Main Menu",
				new List<MenuItem> { lettersAndVersionBranch, dateTimeBranch }
			);

			mainMenu.Show();
		}
	}
}
