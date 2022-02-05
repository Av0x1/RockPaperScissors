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
			while(true)
			{
				String input = Console.ReadLine();

				if(!input.ToLower().Equals("s") && !input.ToLower().Equals("r") && !input.ToLower().Equals("p"))
				{
					Console.WriteLine("Ungültige Eingabe!");
				}
				else
				{
					return input;
				}
			}
		}

		public void DrawChecker(String user, String bot)
		{
			if(user.Equals(bot))
			{
				Console.WriteLine("Spiel ist unentschieden.");
			}
		}
	}
}
