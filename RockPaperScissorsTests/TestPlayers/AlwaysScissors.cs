using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;

namespace RockPaperScissorsTests.TestPlayers
{
    class AlwaysScissors : Player
    {
        public AlwaysScissors() : base("Scissors Player") { }

        public override Choice GetChoice()
        {
            return Choice.Scissors;
        }
    }
}
