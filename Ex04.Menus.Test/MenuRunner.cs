﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
	public class MenuRunner
	{
		static void Main()
		{
			MenuInterfaceRun menuInterfaceRun = new MenuInterfaceRun();
			MenuDelegatesRun menuDelegatesRun = new MenuDelegatesRun();
			menuInterfaceRun.InterfaceMenuRun();
			menuDelegatesRun.DelegateMenuRun();

		}
	}
}
