using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RockPaperScissors.Implementations;
using RockPaperScissors;
using RockPaperScissors.Interfaces;
using RockPaperScissors.Enums;
using RockPaperScissorsTests.TestPlayers;


namespace RockPaperScissorsTests
{
    [TestFixture]
    public class RockPaperScissorsTests
    {
        
        [TestCase(Choice.Paper, Result.Tie)]
        [TestCase(Choice.Rock, Result.Win)]
        [TestCase(Choice.Scissors, Result.Loss)]
        public void TestPaperMethod(Choice choice, Result expected)
        {
            MatchResult result = null;
            Game testGame = new Game();

            switch (choice)
            {
                case Choice.Paper:
                result = testGame.PlayRound(new AlwaysPaper(), new AlwaysPaper());
                    break;
                case Choice.Rock:
                    result = testGame.PlayRound(new AlwaysPaper(), new AlwaysRock());
                    break;
                default:
                    result = testGame.PlayRound(new AlwaysPaper(), new AlwaysScissors());
                    break;
            }

            Assert.AreEqual(expected, result.Match_Result);
        }

      

    }
}
