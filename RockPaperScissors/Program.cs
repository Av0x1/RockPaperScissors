using System;

namespace RockPaperScissors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UserManager userManager = new UserManager();
			Random random = new Random();

			Console.WriteLine("Guten Tag, dies ist ein Schere-Stein-Papier Spiel. Bitte wählen Sie Ihren Gegenstand:\nFür Schere bitte 'S' drücken.\nFür Stein bitte 'R' drücken.\nFür Papier bitte 'P' drücken.");

			String playerValue = userManager.ReadInput();

			String[] botTools = new String[3] { "s", "r", "p" }; //s = 0, r = 1, p = 2
			Int32 bot = random.Next(0, 3);

			userManager.PrintUserValue(playerValue);
			userManager.PrintBotValue(bot);

			userManager.CheckWinner(playerValue, botTools[bot]);
		}
	}
}
