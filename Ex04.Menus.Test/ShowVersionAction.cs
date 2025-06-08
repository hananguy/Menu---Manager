using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
	public class ShowVersionAction : IMenuAction
	{
		public void Execute()
		{
			Console.WriteLine("App Version: 25.2.4.4480");
		}
	}
}
