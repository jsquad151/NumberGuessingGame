using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
			Random r = new Random();	//call Random method and assign it "r"
			int winNum = r.Next(0, 100);	//create winNum as an integer and assign it to random number between 0 and 100 by calling r.Next
			bool win = false;	//create a boolean value to control our loop and manage the win condition of the game

			do		//begin a "do-while" loop that does X things WHILE Y conditions are active
			{
				Console.Write("Guess a number between 0 and 100 \n");	//entry statement for the user
				string s = Console.ReadLine();		//collects the user's response and assigns it to the variable s which is a string

				int i = int.Parse(s);	//converts our string variable s into an integer so that we can compare it with other numbers (in this case, the random number we generated earlier)

				if (i > winNum)		//if i (the user number) is bigger than winNum (our randomly generated number) then deliver following message to the user
				{
					Console.WriteLine("Too high. Guess Lower...");
				}
				else if (i < winNum)	//if i is lower than winNum then deliver following message to the user
				{
					Console.WriteLine("Too low. Guess higher...");
				}
				else if (i == winNum)	//if i and winNum are identical then show user that they have won and set the win condition to true
				{
					Console.WriteLine("YOU WIN!!");
					win = true;
				}

				Console.WriteLine();	//skip a line after each iteration of the loop
			} while (win == false);		//list our conditions for the loop. In this case, the only condition is that we do X things WHILE our win condition if set to false

			Console.WriteLine("Thanks for playing!");
			Console.Write("Press any key to finish.");
			Console.ReadKey(true);
		}
    }
}
