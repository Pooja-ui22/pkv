using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    public class Game
    {
        private string[] Moves = { "Rock", "Paper", "Scissors" };

        public string RPS(Player player, Player computer)
        {
            // Random random = new Random();

            // int computerChoiceIndex = random.Next(Moves.Length);
            //string ComputerChoice = Moves[computerChoiceIndex];

            Console.WriteLine("Pooja chose: " + player.Choice);
            // Console.WriteLine("Computer chose: " + ComputerChoice);
            Console.WriteLine("Computer chose: " + computer.Choice);

            // if (MyChoice == ComputerChoice)
            if (player.Choice == computer.Choice)
            {
                Console.WriteLine("It's a tie!");
                return "tie";
            }
            /* else if (
                 (MyChoice == "Rock" && ComputerChoice == "Scissors") ||
                 (MyChoice == "Paper" && ComputerChoice == "Rock") ||
                 (MyChoice == "Scissors" && ComputerChoice == "Paper")
             )*/
            else if (
               (player.Choice == "Rock" && computer.Choice == "Scissors") ||
               (player.Choice == "Paper" && computer.Choice == "Rock") ||
               (player.Choice == "Scissors" && computer.Choice == "Paper")
           )
            {
                Console.WriteLine("Pooja wins!");
                return "win";
            }
            else
            {
                Console.WriteLine("Computer wins!");
                return "Computer wins";
            }
        }

        public string GetComputerChoice()
        {
            Random random = new Random();
            int Index = random.Next(Moves.Length);
            return Moves[Index];
        }
    }
}

