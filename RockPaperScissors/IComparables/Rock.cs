using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.IComparables
{
    public class Rock : IComparable
    {
        public int CompareTo(object obj)
        {
            Choice otherChoice = obj as Choice;

            if (otherChoice != null)
            {
                if (otherChoice == Choice.Rock)
                {
                    return 0;
                }
                else if (otherChoice == Choice.Scissors)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                throw new ArgumentException("Object is not Rock, Paper or Scissors.");
            }
        }
    }
}
