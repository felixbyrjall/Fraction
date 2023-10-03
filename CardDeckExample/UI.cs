using System;
using System.Xml.Linq;

namespace CardDeckExample
{
	public class UI {
		public static void NameInput() {
			string name;

			Console.WriteLine("What is your name?");
			name = Console.ReadLine();
			Console.WriteLine($"\r\nHello {name}");
		}

		public static void Welcome() {
			Console.WriteLine("Welcome to BlackJack \r\n");
		}

	}
}

