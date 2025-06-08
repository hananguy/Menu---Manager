using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
	public class MenuItem
	{
		public delegate void ActionDelegate();

		private string m_Title;
		private List<MenuItem> m_SubItems;
		public event ActionDelegate m_Actions;

		public MenuItem(string i_Title, List<MenuItem> subItems)
		{
			m_Title = i_Title ?? throw new ArgumentNullException(nameof(i_Title));
			m_SubItems = subItems ?? new List<MenuItem>();
		}
		public string Title
		{
			get { return m_Title; }
		}
		public List<MenuItem> SubItems
		{
			get { return m_SubItems; }
		}
		public ActionDelegate Actions
		{
			get { return m_Actions; }
		}


	}
}
