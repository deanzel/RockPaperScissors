using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Implementations;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper, Scissors...");
            Game newGame = new Game();
            //int gameCount = 1;
            //Dictionary<int, MatchResult> gameResults = new Dictionary<int, MatchResult>();

            string input = "";

            do
            {
                //newGame.PlayRound(new HumanPlayer("Player 1"), new ComputerPlayer("Player 2"));

                newGame.PlayLizardSpock(new HumanSpock("Spock 1"), new ComputerSpock("Computer Spock"));
                //gameCount++;

                Console.Write("Would you like to play again? (enter \"Q\" to Quit): ");
                input = Console.ReadLine();

            } while (input.ToUpper() != "Q");




        }
    }
}
