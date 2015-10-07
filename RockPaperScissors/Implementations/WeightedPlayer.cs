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

            if (i >= 1 && i <= 7)
            {
                return Choice.Rock;
            }
            else if (i == 8 || i == 9)
            {
                return Choice.Scissors;
            }
            else
            {
                return Choice.Paper;
            }
           
        }
    }
}
