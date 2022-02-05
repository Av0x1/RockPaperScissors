using System;

namespace RockPaperScissors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UserManager userManager = new UserManager();
			Random random = new Random();

			Console.WriteLine("Guten Tag, dies ist ein Schere-Stein-Papier Spiel. Bitte wählen Sie Ihren Gegenstand:\nFür Schere bitte 'S' drücken.\nFür Stein bitte 'R' drücken.\nFür Papier bitte 'R' drücken.");

			String tool = userManager.ReadInput();

			String[] botTools = new String[3] { "s", "r", "p" };

			Int32 bot = random.Next(0, 3);

			//Schere
			if(tool == "s")
			{
				userManager.DrawChecker(tool, botTools[bot]);

				if()
			}
			//Stein
			else if(tool == "r")
			{
				userManager.DrawChecker(tool, botTools[bot]);

			}
			//Papier
			else
			{
				userManager.DrawChecker(tool, botTools[bot]);

			}
		}
	}
}
