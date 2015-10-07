using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.IComparables;
using RockPaperScissors.Implementations;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper, Scissors...");
            Game newGame = new Game();
            

            string input = "";

            do
            {
                //newGame.PlayRound(new HumanPlayer("Player 1"), new ComputerPlayer("Player 2"));

                //newGame.PlayLizardSpock(new HumanSpock("Spock 1"), new ComputerSpock("Computer Spock"));

                newGame.PlayLizardSpockICom(new HumanPlayerICom("Player 1"), new ComputerPlayerICom("Computa Playa 2")); 

                Console.Write("Would you like to play again? (enter \"Q\" to Quit): ");
                input = Console.ReadLine();

            } while (input.ToUpper() != "Q");




        }
    }
}
