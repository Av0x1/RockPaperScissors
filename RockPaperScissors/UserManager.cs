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

		public void CheckWinner(String userValue, String botValue, ref Int32 userScore, ref Int32 botScore)
		{
			if (this.CheckForTie(userValue, botValue))
			{
				Console.WriteLine("Das Spiel endet in einem unentschieden.");
				;
			}
			else if (userValue.Equals("s"))
			{
				if (botValue.Equals("r"))
				{
					Console.WriteLine("Der Computer gewinnt.");
					botScore++;
				}
				else
				{
					Console.WriteLine("Du gewinnst.");
					userScore++;
				}
			}
			else if (userValue.Equals("r"))
			{
				if (botValue.Equals("p"))
				{
					Console.WriteLine("Der Computer gewinnt.");
					botScore++;
				}
				else
				{
					Console.WriteLine("Du gewinnst.");
					userScore++;
				}
			}
			else
			{
				if (botValue.Equals("s"))
				{
					Console.WriteLine("Der Computer gewinnt.");
					botScore++;
				}
				else
				{
					Console.WriteLine("Du gewinnst.");
					userScore++;
				}
			}
		}

		public Boolean HasOnePlayerWon(Int32 userScore, Int32 botScore)
		{
			if (userScore == 2 | botScore == 2)
			{
				return true;
			}

			return false;
		}

		public void CheckFinalWinner(Int32 userScore, Int32 botScore)
		{
			if (userScore > botScore)
			{
				Console.WriteLine("Du hast gewonnen.");
			}
			else if (userScore < botScore)
			{
				Console.WriteLine("Der Computer hat gewonnen.");
			}
			else
			{
				Console.WriteLine("Das Spiel endete in einem Unterschied");
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
