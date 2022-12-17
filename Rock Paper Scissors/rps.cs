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
            string InputPlayer, inputCPU;
            int randomInt;

            Console.WriteLine("Choose between ROCK, PAPER and SCISSORS:  ");
            inputPlayer = Console.ReadLine();

            Random r = new Random();

            randomInt = r.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("DRAW!! \n\n");
                    } 
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("WIN!! \n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("LOSE!! \n\n");
                        scoreCPU++;
                    }
                    break;

                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose PAPER");
                    if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW!! \n\n");
                    } 
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("WIN!! \n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("LOSE!! \n\n");
                        scoreCPU++;
                    }
                    break;
                
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose SCISSORS");
                    if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("DRAW!! \n\n");
                    } 
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("WIN!! \n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("LOSE!! \n\n");
                        scoreCPU++;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}