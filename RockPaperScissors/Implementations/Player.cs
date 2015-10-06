using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Implementations
{
    public abstract class Player : IChoiceSelector
    {
        public string Name { get; }

        public Player(string Name)
        {
            this.Name = Name;
        }

        public abstract Choice GetChoice();
    }
}
