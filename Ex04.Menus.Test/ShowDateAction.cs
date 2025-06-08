using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
	public class ShowDateAction : IMenuAction
	{
		public void Execute()
		{
			Console.WriteLine($"Current Date is {DateTime.Now:dd/MM/yyyy}");
		}
	}
}
