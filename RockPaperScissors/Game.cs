using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;

namespace RockPaperScissors
{
    public class Game
    {
        public int gameCount;
        public Dictionary<int, Result> GameResults = new Dictionary<int, Result>();

        //Regular Rock, Paper, Scissors
        public MatchResult PlayRound(Player p1, Player p2)
        {
            MatchResult result = new MatchResult();
            result.Player1_Choice = p1.GetChoice();
            result.Player2_Choice = p2.GetChoice();
            


            if (result.Player1_Choice == result.Player2_Choice)
            {
                result.Match_Result = Result.Tie;
                GameResults.Add(gameCount, result.Match_Result);
            }
            else if ((result.Player1_Choice == Choice.Rock && result.Player2_Choice == Choice.Scissors) ||
                     (result.Player1_Choice == Choice.Paper && result.Player2_Choice == Choice.Rock) ||
                     (result.Player1_Choice == Choice.Scissors && result.Player2_Choice == Choice.Paper))
                     
            {
                result.Match_Result = Result.Win;
                GameResults.Add(gameCount, result.Match_Result);
            }
            else
            {
                result.Match_Result = Result.Loss;
                GameResults.Add(gameCount, result.Match_Result);
            }

            ProcessResult(p1, p2, result);
            MatchHistory(GameResults, p1, p2);
            gameCount++;

            return result;

        }


        //Rock, Paper, Scissors, Lizard, Spock
        public MatchResult PlayLizardSpock(Player p1, Player p2)
        {
            MatchResult result = new MatchResult();
            result.Player1_Choice = p1.GetChoice();
            result.Player2_Choice = p2.GetChoice();

            if (result.Player1_Choice == result.Player2_Choice)
            {
                result.Match_Result = Result.Tie;
                GameResults.Add(gameCount, result.Match_Result);

            }
            else if ((result.Player1_Choice == Choice.Rock && result.Player2_Choice == Choice.Scissors) ||
                     (result.Player1_Choice == Choice.Rock && result.Player2_Choice == Choice.Lizard) ||
                     (result.Player1_Choice == Choice.Paper && result.Player2_Choice == Choice.Rock) ||
                     (result.Player1_Choice == Choice.Paper && result.Player2_Choice == Choice.Spock) ||
                     (result.Player1_Choice == Choice.Scissors && result.Player2_Choice == Choice.Paper) ||
                     (result.Player1_Choice == Choice.Scissors && result.Player2_Choice == Choice.Lizard) ||
                     (result.Player1_Choice == Choice.Lizard && result.Player2_Choice == Choice.Spock) ||
                     (result.Player1_Choice == Choice.Lizard && result.Player2_Choice == Choice.Paper) ||
                     (result.Player1_Choice == Choice.Spock && result.Player2_Choice == Choice.Scissors) ||
                     (result.Player1_Choice == Choice.Spock && result.Player2_Choice == Choice.Scissors))

            {
                result.Match_Result = Result.Win;
                GameResults.Add(gameCount, result.Match_Result);

            }
            else
            {
                result.Match_Result = Result.Loss;
                GameResults.Add(gameCount, result.Match_Result);

            }

            ProcessResult(p1, p2, result);
            MatchHistory(GameResults, p1, p2);
            gameCount++;

            return result;
        }


        public void ProcessResult(Player Player1, Player Player2, MatchResult Result)
        {
            Console.WriteLine("{0} picked {1}, {2} picked {3}", Player1.Name, 
            Enum.GetName(typeof(Choice), Result.Player1_Choice), Player2.Name, 
            Enum.GetName(typeof(Choice), Result.Player2_Choice));

            switch (Result.Match_Result)
            {
                case Enums.Result.Win:
                    Console.WriteLine("{0} Wins!", Player1.Name);
                    
                    break;
                case Enums.Result.Loss:
                    Console.WriteLine("{0} Wins!", Player2.Name);
                    break;
                case Enums.Result.Tie:
                    Console.WriteLine("You both Tie!");
                    break;
            }
        }


        //Shows wins, losses and ties of Player 1 vs Player 2
        public void MatchHistory(Dictionary<int, Result> results, Player Player1, Player Player2)
        {
            int wins = 0;
            int losses = 0;
            int ties = 0;

            foreach (KeyValuePair<int, Result> result in results)
            {
                switch (result.Value)
                {
                    case Result.Win:
                        wins++;
                        break;
                    case Result.Loss:
                        losses++;
                        break;
                    default:
                        ties++;
                        break;
                }
            }
            
            Console.WriteLine("{0} has {1} wins, {2} losses and {3} ties against {4}.", Player1.Name, wins, losses, ties, Player2.Name);
            
        }
    }
}
