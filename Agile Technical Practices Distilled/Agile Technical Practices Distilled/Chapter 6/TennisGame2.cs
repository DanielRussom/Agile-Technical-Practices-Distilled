namespace Agile_Technical_Practices_Distilled.Chapter_6
{
    public class TennisGame2 : ITennisGame
    {
        private int playerOnePoints = 0;
        private int playerTwoPoints = 0;

        private string playerOneScoreText = string.Empty;
        private string playerTwoScoreText = string.Empty;

        public string GetScore()
        {
            if (PlayerScoresMatch())
            {
                return GetMatchingScoreText();
            }

            if (playerOnePoints < 4 && playerTwoPoints < 4)
            {
                playerOneScoreText = GetScoreText(playerOnePoints);
                playerTwoScoreText = GetScoreText(playerTwoPoints);

                return $"{playerOneScoreText}-{playerTwoScoreText}";
            }

            int playerScoreDifference = GetDifferenceInPlayerScores();

            if (playerOnePoints > playerTwoPoints && playerScoreDifference >= 2)
            {
                return "Win for player1";
            }

            if (playerTwoPoints > playerOnePoints && playerScoreDifference >= 2)
            {
                return "Win for player2";
            }

            if (playerOnePoints > playerTwoPoints && playerTwoPoints >= 3)
            {
                return "Advantage player1";
            }

            if (playerTwoPoints > playerOnePoints && playerOnePoints >= 3)
            {
                return "Advantage player2";
            }

            return string.Empty;
        }

        private bool PlayerScoresMatch()
        {
            return playerOnePoints == playerTwoPoints;
        }

        private string GetMatchingScoreText()
        {
            if (PlayerOneScoreIsOverTwo())
            {
                return "Deuce";
            }
            
            var playerScoreText = GetScoreText(playerOnePoints);

            return $"{playerScoreText}-All";
        }

        private bool PlayerOneScoreIsOverTwo()
        {
            return playerOnePoints > 2;
        }

        private string GetScoreText(int score)
        {
            if (score == 0)
            {
                return "Love";
            }

            if (score == 1)
            {
                return "Fifteen";
            }

            if (score == 2)
            {
                return "Thirty";
            }

            if (score == 3)
            {
                return "Forty";
            }

            return string.Empty;
        }

        private int GetDifferenceInPlayerScores()
        {
            return Math.Abs(playerOnePoints - playerTwoPoints);
        }

        private void IncrementPlayerOneScore()
        {
            playerOnePoints++;
        }

        private void IncrementPlayerTwoScore()
        {
            playerTwoPoints++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
            {
                IncrementPlayerOneScore();
            }
            else
            {
                IncrementPlayerTwoScore();
            }
        }

    }
}

