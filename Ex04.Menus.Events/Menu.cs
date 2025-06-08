using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
	public class Menu
	{

		private readonly string m_Title;
		private readonly List<MenuItem> m_Items;
		private readonly Menu m_ParentMenu;

		public string Title
		{
			get { return m_Title; }
		}
		public List<MenuItem> Items
		{
			get { return m_Items; }
		}
		public Menu ParentMenu
		{
			get { return m_ParentMenu; }
		}

		public Menu(string title, List<MenuItem> items, Menu parentMenu = null)
		{
			m_Title = title ?? throw new ArgumentNullException(nameof(title));
			m_Items = items ?? new List<MenuItem>();
			m_ParentMenu = parentMenu;
		}

		public void Show()
		{
			Menu currentMenu = this;
			while (true)
			{
				Console.Clear();
				Console.WriteLine($"** {currentMenu.m_Title} **");
				Console.WriteLine(new string('-', currentMenu.m_Title.Length + 6));

				for (int i = 0; i < currentMenu.m_Items.Count; i++)
				{
					Console.WriteLine($"{i + 1}. {currentMenu.m_Items[i].Title}");
				}

				if (currentMenu.m_ParentMenu == null)
				{
					Console.WriteLine("0. Exit");
				}
				else
				{
					Console.WriteLine("0. Back");
				}
				Console.Write($"Please enter your choice (1–{currentMenu.m_Items.Count} or 0 to {(currentMenu.m_ParentMenu == null ? "exit" : "back")}): ");
				string input = Console.ReadLine();

				if (!int.TryParse(input, out int choice) || choice < 0 || choice > currentMenu.m_Items.Count)
				{
					Console.WriteLine("Invalid input. Press any key to retry...");
					Console.ReadKey();
					continue;
				}

				if (choice == 0)
				{
					if (currentMenu.m_ParentMenu == null)
						break;
					currentMenu = currentMenu.m_ParentMenu;
					continue;
				}

				MenuItem selected = currentMenu.m_Items[choice - 1];
				if (selected.SubItems != null && selected.SubItems.Count > 0)
				{
					currentMenu = new Menu(selected.Title, new List<MenuItem>(selected.SubItems), currentMenu);
				}
				else
				{
					Console.Clear();
					if (selected.Actions != null)
					{
						selected.Actions.Invoke();
					}
					Console.WriteLine("\nPress any key to return to the menu...");
					Console.ReadKey();
				}
			}
		}
	}
}

