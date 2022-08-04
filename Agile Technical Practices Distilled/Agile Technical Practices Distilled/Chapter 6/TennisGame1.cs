namespace Agile_Technical_Practices_Distilled.Chapter_6
{
    public class TennisGame1 : ITennisGame
    {
        private int player1Score = 0;
        private int player2Score = 0;

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
            {
                player1Score += 1;
            }
            else
            {
                player2Score += 1;
            }
        }

        public string GetScore()
        {
            string score = String.Empty;
            if (IsScoreTied())
            {
                return GetTiedScore();
            }
            else if (EitherScoreIsAboveThree())
            {
                return GetAdvantageScore();
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    var tempScore = player1Score;

                    if (i != 1)
                    {
                        score += "-";
                        tempScore = player2Score;
                    }

                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }

        private string GetAdvantageScore()
        {
            var scoreDifference = Math.Abs(player1Score - player2Score);
            var playerInLead = "player1";

            if (player1Score < player2Score)
            {
                playerInLead = "player2";
            }

            if (scoreDifference == 1)
            {
                return $"Advantage {playerInLead}";
            }

            return $"Win for {playerInLead}";
        }

        private bool EitherScoreIsAboveThree()
        {
            return player1Score >= 4 || player2Score >= 4;
        }

        private bool IsScoreTied()
        {
            return player1Score == player2Score;
        }

        private string GetTiedScore()
        {
            switch (player1Score)
            {
                case 0:
                    return "Love-All";
                case 1:
                    return "Fifteen-All";
                case 2:
                    return "Thirty-All";
                default:
                    return "Deuce";
            }
        }
    }
}

