using System;

namespace RockPaperScissors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UserManager userManager = new UserManager();
			Random random = new Random();

			Boolean gameOver = false;
			Int32 numberOfGames = 1;
			Int32 userScore = 0;
			Int32 botScore = 0;

			Console.WriteLine("Guten Tag, dies ist ein Schere-Stein-Papier Spiel.\nGespielt werden 3 Runden.\nDer Sieger einer Runde erhält einen Punkt.\nBei einem Unentschieden erhält kein Spieler einen Punkt.\nGewonnen hat der Spieler, welcher als erster 2 Punkte erreicht.");

			while (gameOver == false && numberOfGames <= 3)
			{
				Console.WriteLine($"\nRunde {numberOfGames}:\nBitte wählen Sie Ihren Gegenstand:\nFür Schere bitte 'S' drücken.\nFür Stein bitte 'R' drücken.\nFür Papier bitte 'P' drücken.");
				String userValue = userManager.ReadInput();

				String[] botTools = new String[3] { "s", "r", "p" };
				Int32 bot = random.Next(0, 3);

				userManager.PrintUserValue(userValue);
				userManager.PrintBotValue(bot);

				userManager.CheckWinner(userValue, botTools[bot], ref userScore, ref botScore);
				Console.WriteLine($" Nutzer: {userScore} | Computer: {botScore}");

				gameOver = userManager.HasOnePlayerWon(userScore, botScore);

				numberOfGames++;
			}

			Console.WriteLine($" Nutzer: {userScore} | Computer: {botScore}");
			userManager.CheckFinalWinner(userScore, botScore);
		}
	}
}
