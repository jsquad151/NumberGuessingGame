using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer; //create player input string
            string inputCPU;    //create CPU choice string
            int randomInt;  //create variable to hold CPU choice as an integer

            bool playAgain = true;  //boolean variable to track if the player will play again

            while (playAgain)   //start while loop to track if player is playing again
            {

                int scorePlayer = 0;    //if player is playing again then player and CPU scores are set to 0
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)     //if player and CPU scores are less than 3 then loop the game until one of them reaches 3 points (in other words, the game is first to 3 wins)
                {


                    Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");  //give player the starting message to make their choice
                    inputPlayer = Console.ReadLine();   //read player choice
                    inputPlayer = inputPlayer.ToUpper();    //convert player choice to all uppercase

                    Random rnd = new Random();  //call Random class

                    randomInt = rnd.Next(1, 4); //generate random number from 1 to 3

                    switch (randomInt)  //insert randomly generated number into a switch statement
                    {
                        case 1:
                            inputCPU = "ROCK";  //if random number = 1 then assign CPU choice to ROCK
                            Console.WriteLine("Computer chose ROCK");   //tell player the CPU choice
                            if (inputPlayer == "ROCK")      //if player choice matches CPU choice then say DRAW
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")    //if player choice wins over CPU choice then say PLAYER WINS and increment the playerscore
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")     //if player choice loses to CPU choice then say CPU WINS and increment the CPUscore
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer != "ROCK" || inputPlayer != "PAPER" || inputPlayer != "SCISSORS")  //if player chose something other than rock, paper or scissors then tell them to try again
                            {
                                Console.WriteLine("You did not choose Rock, Paper or Scissors! \n Try Again!");
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER"; //if random number = 2 then assign CPU choice to PAPER
                            Console.WriteLine("Computer chose PAPER");  //tell player the CPU choice
                            if (inputPlayer == "PAPER")     //if player choice matches CPU choice then say DRAW
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");    //if player choice loses to CPU choice then say CPU WINS and increment the CPUscore
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");     //if player choice wins over CPU choice then say PLAYER WINS and increment the playerscore
                                scorePlayer++;
                            }
                            else if (inputPlayer != "ROCK" || inputPlayer != "PAPER" || inputPlayer != "SCISSORS")  //if player chose something other than rock, paper or scissors then tell them to try again
                            {
                                Console.WriteLine("You did not choose Rock, Paper or Scissors! \n Try Again!");
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";  //if random number = 3 then assign CPU choice to SCISSORS
                            Console.WriteLine("Computer chose SCISSORS");   //tell player the CPU choice
                            if (inputPlayer == "SCISSORS")      //if player choice matches CPU choice then say DRAW
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");     //if player choice wins over CPU choice then say PLAYER WINS and increment the playerscore
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");    //if player choice loses to CPU choice then say CPU WINS and increment the CPUscore
                                scoreCPU++;
                            }
                            else if (inputPlayer != "ROCK" || inputPlayer != "PAPER" || inputPlayer != "SCISSORS")  //if player chose something other than rock, paper or scissors then tell them to try again
                            {
                                Console.WriteLine("You did not choose Rock, Paper or Scissors! \n Try Again!");
                            }
                            break;
                        default:        //if the CPU for some reason chose a number outside of the boundary of the game then say invalid entry
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);   //show current player and CPU scores after every round

                }

                if (scorePlayer == 3)   //if playerscore hits 3 before the CPU then announce the player as the winner
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreCPU == 3)     //if CPUscore hits 3 before the player then announce the CPU as the winner
                {
                    Console.WriteLine("CPU WON!");
                }

                Console.WriteLine("Do you want to play again?(y/n)");   //ask the player if they would like to play again
                string loop = Console.ReadLine();   //fetch the player's response to the previous question
                if (loop == "y")    //if player indicated yes then restart the game and all scores
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")   //if player indicated no then say goodbye and close the program at the player's behest
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing!");
                    Console.Write("Press any key to finish");
                    Console.ReadKey(true);
                }

            }
        }
    }
}
