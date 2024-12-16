using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string Replay = "yes";
                     
            Player player = new Player("PlayerName");
            Player computer = new Player("ComputerName");

            Game game = new Game();
            do
            {
                Console.WriteLine("Please enter your choice: Rock, Paper, or Scissors");
                string MyChoice = Console.ReadLine();

                while (MyChoice != "Rock" && MyChoice != "Paper" && MyChoice != "Scissors")
                {
                   Console.WriteLine("Invalid choice. Please enter Rock, Paper, or Scissors.");
                   MyChoice = Console.ReadLine();
                }

                //string result = game.RPS(MyChoice);
                player.SetChoice(MyChoice);

 
                computer.SetChoice(game.GetComputerChoice());


                string result = game.RPS(player, computer);

                if (result == "tie")
                {
                    Console.WriteLine("Do you want to play again? (yes/no)");
                    Replay = Console.ReadLine().Trim().ToLower();
                }
                else
                {
                    Replay = "no";
                }
            } while (Replay == "yes");

            Console.WriteLine("Thanks for playing Rock, Paper, Scissors!");
        }
    }
}
