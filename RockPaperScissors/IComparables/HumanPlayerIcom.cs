using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;

namespace RockPaperScissors.IComparables
{
    public class HumanPlayerICom : PlayerICom
    {
        public HumanPlayerICom(string Name) : base(Name)
        { }

        public override ThrowChoice GetChoice()
        {
            ThrowChoice playerChoice = new ThrowChoice();
            playerChoice.throwChoice = Choice.Unknown;

            while (playerChoice.throwChoice == Choice.Unknown)
            {
                Console.WriteLine("{0}: Enter a choice (R)ock, (P)aper, (S)cissors, (L)izard, (SP)ock: ", Name);
                string input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "R":
                        playerChoice.throwChoice = Choice.Rock;
                        break;
                    case "P":
                        playerChoice.throwChoice = Choice.Paper;
                        break;
                    case "S":
                        playerChoice.throwChoice = Choice.Scissors;
                        break;
                    case "L":
                        playerChoice.throwChoice = Choice.Lizard;
                        break;
                    case "SP":
                        playerChoice.throwChoice = Choice.Spock;
                        break;
                    default:
                        Console.WriteLine("Invalid entry! Please try again!");
                        playerChoice.throwChoice = Choice.Unknown;
                        break;
                }
            }

            return playerChoice;
        }
    }
}
