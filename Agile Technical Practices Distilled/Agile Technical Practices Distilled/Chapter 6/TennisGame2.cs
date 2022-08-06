namespace Agile_Technical_Practices_Distilled.Chapter_6
{
    public class TennisGame2 : ITennisGame
    {
        private int playerOnePoints = 0;
        private int playerTwoPoints = 0;

        private const string PlayerOne = "player1";
        private const string PlayerTwo = "player2";

        public string GetScore()
        {
            if (PlayerScoresMatch())
            {
                return GetMatchingScoreText();
            }

            if (BothPlayerScoresAreUnderFour())
            {
                var playerOneScoreText = GetScoreText(playerOnePoints);
                var playerTwoScoreText = GetScoreText(playerTwoPoints);

                return $"{playerOneScoreText}-{playerTwoScoreText}";
            }

            if (PlayerScoresAreOnePointApart())
            {
                return GetAdvantageScoreText();
            }

            return GetWinScoreText();
        }

        private bool BothPlayerScoresAreUnderFour()
        {
            return playerOnePoints < 4 && playerTwoPoints < 4;
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

        private bool PlayerScoresAreOnePointApart()
        {
            var scoreDifference = Math.Abs(playerOnePoints - playerTwoPoints);
            return scoreDifference == 1;
        }

        private string GetAdvantageScoreText()
        {
            var player = GetLeadingPlayerName();

            return $"Advantage {player}";
        }

        private string GetLeadingPlayerName()
        {
            if (playerOnePoints > playerTwoPoints)
            {
                return PlayerOne;
            }

            return PlayerTwo;
        }

        private string GetWinScoreText()
        {
            var player = GetLeadingPlayerName();

            return $"Win for {player}";
        }

        public void WonPoint(string player)
        {
            if (player == PlayerOne)
            {
                IncrementPlayerOneScore();
            }
            else
            {
                IncrementPlayerTwoScore();
            }
        }

        private void IncrementPlayerOneScore()
        {
            playerOnePoints++;
        }

        private void IncrementPlayerTwoScore()
        {
            playerTwoPoints++;
        }
    }
}

