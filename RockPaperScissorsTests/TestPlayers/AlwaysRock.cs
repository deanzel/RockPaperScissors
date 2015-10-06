using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsTests.TestPlayers
{
    class AlwaysRock : Player
    {
        public AlwaysRock() : base("Rock Player")
        {
        }

        public override Choice GetChoice()
        {
            return Choice.Rock;


        }
    
    }
}
