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
            int _playerType1;
            int _playerType2;
            string _name1;
            string _name2;
            string numberOfPlayers = "";

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
                Console.Clear();
                Console.WriteLine("OK. We will play the regular version of Rock, Paper, Scissors.");
                Console.WriteLine();

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
                    _playerType1 = 1;
                    _playerType2 = 2;
                }
                else
                {
                    _playerType1 = 1;
                    _playerType2 = 1;
                }
                _name1 = PlayerNamer(1);
                _name2 = PlayerNamer(2);

                Console.Clear();

                do
                {
                    newGame.PlayRound(PlayerCreator(_playerType1, _name1), PlayerCreator(_playerType2, _name2));

                    Console.WriteLine("\nWould you like to play again? (enter \"Q\" to Quit):");
                    input = Console.ReadLine();
                } while (input.ToUpper() != "Q");
            }

            else //Run Rock, Paper, Scissors, Lizard, Spock
            {
                Console.Clear();
                Console.WriteLine("OK. We will play Rock, Paper, Scissors, Lizard, Spock ( ͡° ͜ʖ ͡°)");
                Console.WriteLine();

                do
                {
                    Console.WriteLine(
                        "Do you want to play (1) against the computer or (2) against another human player/spock? Enter 1 or 2.");
                    numberOfPlayers = Console.ReadLine();
                    if (numberOfPlayers != "1" && numberOfPlayers != "2")
                    {
                        Console.WriteLine("That is not a valid choice.");
                    }
                } while (numberOfPlayers != "1" && numberOfPlayers != "2");

                if (numberOfPlayers == "1")
                {
                    _playerType1 = 3;
                    _playerType2 = 4;
                }
                else
                {
                    _playerType1 = 3;
                    _playerType2 = 3;
                }

                _name1 = PlayerNamer(1);
                _name2 = PlayerNamer(2);

                Console.Clear();

                do
                {
                    newGame.PlayLizardSpock(PlayerCreator(_playerType1, _name1), PlayerCreator(_playerType2, _name2));

                    Console.WriteLine("\nWould you like to play again? (enter \"Q\" to Quit):");
                    input = Console.ReadLine();
                } while (input.ToUpper() != "Q");


                ////IComparables version of the Game
                //do
                //{
                //    //newGame.PlayLizardSpockICom(new HumanPlayerICom("Player 1"), new ComputerPlayerICom("Computa Playa 2")); 

                //    Console.Write("Would you like to play again? (enter \"Q\" to Quit): ");
                //    input = Console.ReadLine();

                //} while (input.ToUpper() != "Q");

            }
        }
        //Player Name Method
        public static string PlayerNamer(int PlayerNum)
        {
            string name = "";
            bool playerNameOK = false;
            string response = "";

            Console.Clear();
            Console.WriteLine("Player {0}, please enter your desired name: ", PlayerNum);
            name = Console.ReadLine();

            do
            {
                Console.WriteLine("{0} is what we will call Player {1}. Continue? (Y)es or (N)o: ", name, PlayerNum);
                response = Console.ReadLine().ToUpper();

                while (response != "N" && response != "Y")
                {
                    Console.WriteLine("I'm sorry. I didn't get that. Is {0} what we will call Player {1}? (Y)es or (N)o: ", name, PlayerNum);
                    response = Console.ReadLine().ToUpper();
                }
                if (response == "N")
                {
                    Console.WriteLine("OK, Player {0}. Please enter your new desired name: ", PlayerNum);
                    name = Console.ReadLine();
                }
                if (response == "Y")
                {
                    playerNameOK = true;
                }
            } while (!playerNameOK);
             
            return name;
        }



        //Player Creator method
        public static Player PlayerCreator(int Choice, string Name)
        {
            //1 is HumanPlayer
            //2 is ComputerPlayer
            //3 is HumanSpock
            //4 is ComputerSpock

            if (Choice == 1)
            {
                return new HumanPlayer(Name);
            }
            else if (Choice == 2)
            {
                return new ComputerPlayer(Name);
            }
            else if (Choice == 3)
            {
                return new HumanSpock(Name);
            }
            else
            {
                return new ComputerSpock(Name);
            }
        }
    }
}
