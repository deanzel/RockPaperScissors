using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.IComparables
{
    public class ComputerPlayerICom : PlayerICom
    {
        private static Random _randomGenerator = new Random();

        public ComputerPlayerICom(string Name) : base(Name) { }

        public override ThrowChoice GetChoice()
        {
            ThrowChoice computerChoice = new ThrowChoice();

            int i = _randomGenerator.Next(1, 6);

            switch (i)
            {
                case 1:
                    computerChoice.throwChoice = Choice.Rock;
                    break;
                case 2:
                    computerChoice.throwChoice = Choice.Paper;
                    break;
                case 3:
                    computerChoice.throwChoice = Choice.Scissors;
                    break;
                case 4:
                    computerChoice.throwChoice = Choice.Lizard;
                    break;
                default:
                    computerChoice.throwChoice = Choice.Spock;
                    break;
            }

            return computerChoice;
        }
    }
}
