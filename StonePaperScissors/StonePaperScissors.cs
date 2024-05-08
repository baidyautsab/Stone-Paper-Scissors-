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
            Console.WriteLine();
        }

        static int GetAIChoice(Random random)
        {
            return random.Next(1, 4);
        }

        static int ConvertToChoice(char choice)
        {
            switch (choice)
            {
                case 'r': return 1; // Stone
                case 'p': return 2; // Paper
                case 's': return 3; // Scissors
                default: return 0; // Invalid choice
            }
        }

        static void Main(string[] args)
        {
            WelcomeMsg();
            System.Threading.Thread.Sleep(2000);

            int count = 0;
            int playerPoint = 0, AIPoint = 0;

            Random random = new Random();

            while (count < 3)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("r. Stone/rock");
                Console.WriteLine("p. Paper");
                Console.WriteLine("s. Scissors");

                char choice = char.ToLower(Console.ReadKey().KeyChar);

                Console.WriteLine(); // Move to next line

                int playerChoice = ConvertToChoice(choice);

                if (playerChoice == 0)
                {
                    Console.WriteLine("Enter a valid choice!");
                    continue; // Restart the loop
                }

                int AIChoice = GetAIChoice(random);

                switch (AIChoice)
                {
                    case 1: Console.WriteLine("AI chooses Rock"); break;
                    case 2: Console.WriteLine("AI chooses Paper"); break;
                    case 3: Console.WriteLine("AI chooses Scissors"); break;
                }

                // Calculate score
                if (playerChoice == AIChoice)
                    Console.WriteLine("Match Draw");
                else if ((playerChoice == 1 && AIChoice == 3) ||
                         (playerChoice == 2 && AIChoice == 1) ||
                         (playerChoice == 3 && AIChoice == 2))
                {
                    playerPoint++;
                    Console.WriteLine("You won the round");
                }
                else
                {
                    AIPoint++;
                    Console.WriteLine("AI won the round");
                }

                count++;
            }

            // Winner announcement
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
