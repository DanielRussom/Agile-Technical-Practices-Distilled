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
                var scoreDifference = player1Score - player2Score;

                if (scoreDifference == 1)
                {
                    score = "Advantage player1";
                }
                else if (scoreDifference == -1)
                {
                    score = "Advantage player2";
                }
                else if (scoreDifference >= 2)
                {
                    score = "Win for player1";
                }
                else
                {
                    score = "Win for player2";
                }

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

