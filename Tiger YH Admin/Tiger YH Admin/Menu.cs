﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiger_YH_Admin.Models;

namespace Tiger_YH_Admin
{
	static class Menu
	{
		public static int MainAdminMenu()
		{
			Console.WriteLine("Tiger Board!");
			Console.WriteLine("Admin-meny");
			Console.WriteLine();
			Console.WriteLine("1. Skapa användare");
			Console.WriteLine("2. Sök efter användare");
			Console.WriteLine("3. Skapa kurs");
			Console.WriteLine("4. Skapa klass");
			Console.WriteLine();
			Console.Write("Ditt val: ");
			return UserInput.GetInput<int>();
		}

		public static User LoginMenu(UserStore userStore)
		{
			Console.WriteLine("Inloggning");

			Console.Write("Användarnamn: ");
			string userName = UserInput.LoginGetUserName();

			Console.Write("Lösenord: ");
			string password = UserInput.LoginGetPassword();

			return userStore.LoginUser(userName, password);

		}
	}
}
