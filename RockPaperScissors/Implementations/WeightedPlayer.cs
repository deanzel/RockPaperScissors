using RockPaperScissors.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Implementations
{
    public class WeightedPlayer : Player
    {
        private static Random _randomGenerator = new Random();

        public WeightedPlayer(string Name) : base (Name)
        {
        }

        public override Choice GetChoice()
        {
            int i = _randomGenerator.Next(1, 11);

            switch (i)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    return Choice.Rock;
                    break;
                case 8:
                case 9:
                    return Choice.Scissors;
                    break;
                default:
                    return Choice.Paper;
                    break;
            }


        }
    }
}
