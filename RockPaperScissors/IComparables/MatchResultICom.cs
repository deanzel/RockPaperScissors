using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.IComparables
{
    public class MatchResultICom
    {
        public ThrowChoice Player1_Choice { get; set; }
        public ThrowChoice Player2_Choice { get; set; }
        public Result Match_Result { get; set; }
    }
}
