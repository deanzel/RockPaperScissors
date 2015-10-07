using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.IComparables
{
    public abstract class PlayerICom
    {
        public string Name { get; }

        public PlayerICom(string Name)
        {
            this.Name = Name;
        }

        public abstract ThrowChoice GetChoice();
    }


}
