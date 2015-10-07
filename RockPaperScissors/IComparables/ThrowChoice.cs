using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.IComparables
{
    public class ThrowChoice : IComparable
    {
        public Choice throwChoice { get; set; }

        public int CompareTo(object obj)
        {
            ThrowChoice opponentChoice = obj as ThrowChoice;
            if (opponentChoice != null)
            {
                if (this.throwChoice == Choice.Rock)
                {
                    switch (opponentChoice.throwChoice)
                    {
                        case Choice.Rock:
                            return 0;
                        case Choice.Scissors:
                        case Choice.Lizard:
                            return 1;
                        default:
                            return -1;
                    }
                }
                else if (this.throwChoice == Choice.Paper)
                {
                    switch (opponentChoice.throwChoice)
                    {
                        case Choice.Paper:
                            return 0;
                        case Choice.Rock:
                        case Choice.Spock:
                            return 1;
                        default:
                            return -1;
                    }
                }
                else if (this.throwChoice == Choice.Scissors)
                {
                    switch (opponentChoice.throwChoice)
                    {
                        case Choice.Scissors:
                            return 0;
                        case Choice.Paper:
                        case Choice.Lizard:
                            return 1;
                        default:
                            return -1;
                    }
                }
                else if (this.throwChoice == Choice.Lizard)
                {
                    switch (opponentChoice.throwChoice)
                    {
                        case Choice.Lizard:
                            return 0;
                        case Choice.Paper:
                        case Choice.Spock:
                            return 1;
                        default:
                            return -1;
                    }
                }
                else if (this.throwChoice == Choice.Spock)
                {
                    switch (opponentChoice.throwChoice)
                    {
                        case Choice.Spock:
                            return 0;
                        case Choice.Rock:
                        case Choice.Scissors:
                            return 1;
                        default:
                            return -1;
                    }
                }
                else
                {
                    throw new ArgumentException("Object is Unknown.");
                }
            }
            else
            {
                throw new ArgumentException("Object is not a valid Throw Choice.");
            }
        
        }
    }
}
