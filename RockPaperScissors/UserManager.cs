using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	public class UserManager
	{
		public String ReadInput()
		{
			String input = Console.ReadLine();

			while (!input.ToLower().Equals("s") && !input.ToLower().Equals("r") && !input.ToLower().Equals("p"))
			{
				Console.WriteLine("Ungültige Eingabe! Bitte eine der oben genannten Tasten drücken.");
				input = Console.ReadLine();
			}
			return input;
		}

		public void PrintUserValue(String userValue)
		{
			if (userValue.Equals("s"))
			{
				Console.WriteLine("Du wählst Schere.");
			}
			else if (userValue.Equals("r"))
			{
				Console.WriteLine("Du wählst Stein.");
			}
			else
			{
				Console.WriteLine("Du wählst Papier.");
			}
		}

		public void PrintBotValue(Int32 botValue)
		{
			if (botValue == 0)
			{
				Console.WriteLine("Der Computer wählt Schere.");
			}
			else if (botValue == 1)
			{
				Console.WriteLine("Der Computer wählt Stein.");
			}
			else
			{
				Console.WriteLine("Der Computer wählt Papier.");
			}
		}

		public void CheckWinner(String userValue, String botValue)
		{
			if (this.CheckForTie(userValue, botValue))
			{
				Console.WriteLine("Das Spiel endet in einem unentschieden.");
			}
			//Schere
			//0 > 2 (Schere schlägt Papier)
			//0 < 1 (Stein schlägt Schere)
			else if (userValue.Equals("s"))
			{


				if (botValue.Equals("r"))
				{
					Console.WriteLine("Der Computer gewinnt.");
				}
				else
				{
					Console.WriteLine("Du gewinnst.");
				}
			}
			//Stein
			//1 > 0 (Stein schlägt Schere)
			//1 < 2 (Papier schlägt Stein)
			else if (userValue.Equals("r"))
			{
				this.CheckForTie(userValue, botValue);

				if (botValue.Equals("p"))
				{
					Console.WriteLine("Der Computer gewinnt.");
				}
				else
				{
					Console.WriteLine("Du gewinnst.");
				}
			}
			//Papier
			//2 < 0 (Schere schlägt Papier)
			//2 > 1 (Papier schlägt Stein)
			else
			{
				this.CheckForTie(userValue, botValue);

				if (botValue.Equals("s"))
				{
					Console.WriteLine("Der Computer gewinnt.");
				}
				else
				{
					Console.WriteLine("Du gewinnst.");
				}
			}
		}

		private Boolean CheckForTie(String userValue, String botValue)
		{
			if (userValue.Equals(botValue))
			{
				return true;
			}

			return false;
		}
	}
}
