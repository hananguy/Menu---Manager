using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
	public class MenuDelegatesRun 
	{
		private Events.Menu m_MainMenu;
		public void DelegateMenuRun()
		{
			MenuItem showVersionItem = new MenuItem("Show Version", null);
			showVersionItem.m_Actions += new ShowVersionAction().Execute;
			MenuItem countLettersItem = new MenuItem("Count Lowercase Letters", null);
			countLettersItem.m_Actions += new CountLettersAction().Execute;
			MenuItem lettersAndVersionBranch = new MenuItem("Letters and Version", new List<MenuItem> { showVersionItem, countLettersItem });
			MenuItem showDateItem = new MenuItem("Show Current Date", null);
			showDateItem.m_Actions += new ShowDateAction().Execute;
			MenuItem showTimeItem = new MenuItem("Show Current Time", null);
			showTimeItem.m_Actions += new ShowTimeAction().Execute;
			MenuItem dateTimeBranch = new MenuItem("Show Current Date/Time", new List<MenuItem> { showDateItem, showTimeItem });
			Menu mainMenu = new Menu("Delegates Main Menu", new List<MenuItem> { lettersAndVersionBranch, dateTimeBranch });
			mainMenu.Show();
		}


	}
}
