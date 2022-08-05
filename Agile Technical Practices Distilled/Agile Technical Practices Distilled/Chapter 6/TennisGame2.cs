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
            if (playerOnePoints == playerTwoPoints && playerOnePoints < 3)
            {
                var playerScoreText = GetScoreText(playerOnePoints);

                return $"{playerScoreText}-All";
            }

            if (playerOnePoints == playerTwoPoints && playerOnePoints > 2)
            {
                return "Deuce";
            }

            if (playerOnePoints < 4 && playerTwoPoints < 4)
            {
                playerOneScoreText = GetScoreText(playerOnePoints);
                playerTwoScoreText = GetScoreText(playerTwoPoints);

                return $"{playerOneScoreText}-{playerTwoScoreText}";
            }

            var score = string.Empty;

            if (playerOnePoints > playerTwoPoints && playerTwoPoints >= 3)
            {
                score = "Advantage player1";
            }

            if (playerTwoPoints > playerOnePoints && playerOnePoints >= 3)
            {
                score = "Advantage player2";
            }

            if (playerOnePoints >= 4 && playerTwoPoints >= 0 && (playerOnePoints - playerTwoPoints) >= 2)
            {
                score = "Win for player1";
            }

            if (playerTwoPoints >= 4 && playerOnePoints >= 0 && (playerTwoPoints - playerOnePoints) >= 2)
            {
                score = "Win for player2";
            }

            return score;
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

        public void SetP1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P1Score();
            }
        }

        public void SetP2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                P2Score();
            }
        }

        private void P1Score()
        {
            playerOnePoints++;
        }

        private void P2Score()
        {
            playerTwoPoints++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
            {
                P1Score();
            }
            else
            {
                P2Score();
            }
        }

    }
}

