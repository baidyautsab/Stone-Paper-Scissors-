using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StonePaperScissors
{
    internal class StonePaperScissors
    {
        static void WelcomeMsg()
        {
            Console.WriteLine("Welcome to Stone Paper Scissors Game");
            Console.WriteLine();
            Console.WriteLine("Rules: Combination - Winner");
            Console.WriteLine("       Stone-Paper => Paper");
            Console.WriteLine("       Stone-Scissors => Stone");
            Console.WriteLine("       Paper-Scissors => Scissors");
            Console.WriteLine();
            Console.WriteLine("Winner will get 1 point");
            Console.WriteLine();
            Console.WriteLine();

            int count = 0;

            Console.Write("Starting the match");

            // for animation
            while (count < 3)
            {
                Console.Write(".");
                Thread.Sleep(500);
                count++;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            WelcomeMsg();

            int count = 0;
            int r = 1, p = 2, s = 3;

            int playerChoice;
            int AIChoice;

            int playerPoint = 0, AIPoint = 0;

            Random random = new Random();

            while (count < 3)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("r. Stone/rock");
                Console.WriteLine("p. Paper");
                Console.WriteLine("s. Scissors");

                string choice = Console.ReadLine();

                // convert choice(string) to point
                if (choice == "r")
                    playerChoice = r;
                else if (choice == "p")
                    playerChoice = p;
                else if (choice == "s")
                    playerChoice = s;
                else
                {
                    Console.WriteLine("Enter a valid choice!");
                    break;
                }

                AIChoice = random.Next(1, 4);

                if (AIChoice == 1)
                    Console.WriteLine("AI chooses Rock");
                if (AIChoice == 2)
                    Console.WriteLine("AI chooses Paper");
                if (AIChoice == 3)
                    Console.WriteLine("AI chooses Scissors");

                // calculate score
                if (playerChoice == AIChoice)
                    Console.WriteLine("Match Draw");
                else if (playerChoice == r && AIChoice == 2)
                {
                    AIPoint++;
                    Console.WriteLine("AI won the round");
                }
                else if (playerChoice == r && AIChoice == 3)
                {
                    playerPoint++;
                    Console.WriteLine("You won the round");
                }
                else if (playerChoice == p && AIChoice == 1)
                {
                    playerPoint++;
                    Console.WriteLine("You won the round");
                }
                else if (playerChoice == p && AIChoice == 3)
                {
                    AIPoint++;
                    Console.WriteLine("AI won the round");
                }
                else if (playerChoice == s && AIChoice == 1)
                {
                    AIPoint++;
                    Console.WriteLine("AI Won the Round");
                }
                else if (playerChoice == s && AIChoice == 2)
                {
                    playerPoint++;
                    Console.WriteLine("You won the round");
                }
                count++;
            }

            // winner announcing
            Console.WriteLine("Player Score: " + playerPoint + " AI Score: " + AIPoint);

            if (playerPoint < AIPoint)
                Console.WriteLine("AI won the game");
            else if (playerPoint > AIPoint)
                Console.WriteLine("You won the game");
            else
                Console.WriteLine("Match draw!");
        }
    }
}
