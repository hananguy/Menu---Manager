using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class MenuInterfaceRun
	{
		private Menu m_MainMenu;
		public void InterfaceMenuRun()
		{
			MenuItem showVersionItem = new MenuItem("Show Version", null, new ShowVersionAction());
			MenuItem countLettersItem = new MenuItem("Count Lowercase Letters", null, new CountLettersAction());
			MenuItem lettersAndVersionBranch = new MenuItem("Letters and Version", new List<MenuItem> { showVersionItem, countLettersItem }, null);
			MenuItem showDateItem = new MenuItem("Show Current Date", null, new ShowDateAction());
			MenuItem showTimeItem = new MenuItem("Show Current Time", null, new ShowTimeAction());
			MenuItem dateTimeBranch = new MenuItem("Show Current Date/Time", new List<MenuItem> { showDateItem, showTimeItem }, null);
			Menu mainMenu = new Menu("Interfaces Main Menu", new List<MenuItem> { lettersAndVersionBranch, dateTimeBranch });
			mainMenu.Show();
		}
	}
}
