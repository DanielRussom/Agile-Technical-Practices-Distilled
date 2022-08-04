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
            if (IsScoreTied())
            {
                return GetTiedScore();
            }

            if (EitherScoreIsAboveThree())
            {
                return GetAdvantageScore();
            }

            return GetMatchScore();
        }

        private bool IsScoreTied()
        {
            return player1Score == player2Score;
        }

        private string GetTiedScore()
        {
            if (player1Score > 2)
            {
                return "Deuce";
            }

            var score = GetSinglePlayerScore(player1Score);

            return $"{score}-All";
        }

        private string GetSinglePlayerScore(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
                default:
                    return string.Empty;
            }
        }

        private bool EitherScoreIsAboveThree()
        {
            return player1Score >= 4 || player2Score >= 4;
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

        private string GetMatchScore()
        {
            var score = String.Empty;
            for (var i = 1; i < 3; i++)
            {
                var tempScore = player1Score;

                if (i != 1)
                {
                    score += "-";
                    tempScore = player2Score;
                }

                score += GetSinglePlayerScore(tempScore);
            }

            return score;
        }
    }
}

