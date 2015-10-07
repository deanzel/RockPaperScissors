using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.IComparables;
using RockPaperScissors.Implementations;

namespace RockPaperScissors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors...(Lizard, Spock)\n");
            Game newGame = new Game();
            string input = "";

            string gameChoice = "";
            do
            {
                Console.WriteLine("Which version do you want to play? (1) Rock, Paper, Scissors or (2) Rock, Paper, Scissors, Lizard, Spock. Enter 1 or 2.");
                gameChoice = Console.ReadLine();
                if (gameChoice != "1" && gameChoice != "2")
                {
                    Console.WriteLine("That is not a valid choice.");
                }
            } while (gameChoice != "1" && gameChoice != "2");


            if (gameChoice == "1")
            {
                string numberOfPlayers = "";
                Console.Clear();
                Console.WriteLine("OK. We will play the regular version of Rock, Paper, Scissors.");

                do
                {
                    Console.WriteLine(
                        "Do you want to play (1) against the computer or (2) against another human player? Enter 1 or 2.");
                    numberOfPlayers = Console.ReadLine();
                    if (numberOfPlayers != "1" && numberOfPlayers != "2")
                    {
                        Console.WriteLine("That is not a valid choice.");
                    }
                } while (numberOfPlayers != "1" && numberOfPlayers != "2");

                if (numberOfPlayers == "1")
                {
                    do
                    {
                        newGame.PlayRound(new HumanPlayer("Player 1"), new ComputerPlayer("Computa Playa 2"));

                        Console.Write("Would you like to play again? (enter \"Q\" to Quit): ");
                        input = Console.ReadLine();
                    } while (input.ToUpper() != "Q");
                }
                else
                {
                    do
                    {
                        newGame.PlayRound(new HumanPlayer("Player 1"), new HumanPlayer("Human Playa 2"));

                        Console.Write("Would you like to play again? (enter \"Q\" to Quit): ");
                        input = Console.ReadLine();
                    } while (input.ToUpper() != "Q");
                }
            }

            else
            {
                string numberOfPlayers = "";
                Console.Clear();
                Console.WriteLine("OK. We will play Rock, Paper, Scissors, Lizard, Spock ( ͡° ͜ʖ ͡°)");

                do
                {
                    Console.WriteLine(
                        "Do you want to play (1) against the computer or (2) against another human player? Enter 1 or 2.");
                    numberOfPlayers = Console.ReadLine();
                    if (numberOfPlayers != "1" && numberOfPlayers != "2")
                    {
                        Console.WriteLine("That is not a valid choice.");
                    }
                } while (numberOfPlayers != "1" && numberOfPlayers != "2");

                if (numberOfPlayers == "1")
                {
                    do
                    {
                        newGame.PlayLizardSpock(new HumanSpock("Player 1"), new ComputerSpock("Computa Spock 2"));

                        Console.Write("Would you like to play again? (enter \"Q\" to Quit): ");
                        input = Console.ReadLine();
                    } while (input.ToUpper() != "Q");
                }
                else
                {
                    do
                    {
                        newGame.PlayRound(new HumanSpock("Player 1"), new HumanSpock("Human Spock 2"));

                        Console.Write("Would you like to play again? (enter \"Q\" to Quit): ");
                        input = Console.ReadLine();
                    } while (input.ToUpper() != "Q");

                }











                //do
                //{
                //    //newGame.PlayRound(new HumanPlayer("Player 1"), new ComputerPlayer("Player 2"));

                //    //newGame.PlayLizardSpock(new HumanSpock("Spock 1"), new ComputerSpock("Computer Spock"));

                //    //newGame.PlayLizardSpockICom(new HumanPlayerICom("Player 1"), new ComputerPlayerICom("Computa Playa 2")); 

                //    Console.Write("Would you like to play again? (enter \"Q\" to Quit): ");
                //    input = Console.ReadLine();

                //} while (input.ToUpper() != "Q");




            }
        }
    }
}
