using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Implementations
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string Name) : base(Name)
        { }

        public override Choice GetChoice()
        {
            Choice choice = Choice.Unknown;

            while (choice == Choice.Unknown)
            {
                Console.WriteLine("{0}: Enter a choice (R)ock, (P)aper, (S)cissors: ", Name);
                string input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "R":
                        choice = Choice.Rock;
                        break;
                    case "P":
                        choice = Choice.Paper;
                        break;
                    case "S":
                        choice = Choice.Scissors;
                        break;
                    default:
                        Console.WriteLine("Invalid entry! Please try again!");
                        choice = Choice.Unknown;
                        break;
                }

            }

            return choice;
        }
    }
}
