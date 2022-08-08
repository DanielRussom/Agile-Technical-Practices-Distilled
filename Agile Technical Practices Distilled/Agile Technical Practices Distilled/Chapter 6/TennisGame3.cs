namespace Agile_Technical_Practices_Distilled.Chapter_6
{
    public class TennisGame3 : ITennisGame
    {
        private int playerOneScore;
        private int playerTwoScore;
        private string playerOneName;
        private string playerTwoName;

        public TennisGame3(string player1Name, string player2Name)
        {
            playerOneName = player1Name;
            playerTwoName = player2Name;
        }

        public string GetScore()
        {
            if (PlayersAreNotInAdvantageOrWinStates())
            {
                return GetNormalGameScore();
            }

            return GetLateGameScore();
        }

        private bool PlayersAreNotInAdvantageOrWinStates()
        {
            return playerOneScore < 4 && playerTwoScore < 4 && (playerOneScore + playerTwoScore < 6);
        }

        private string GetNormalGameScore()
        {
            var playerOneScoreValue = GetScoreValue(playerOneScore);

            if (PlayerScoresAreEqual())
            {
                return $"{playerOneScoreValue}-All";
            }

            var playerTwoScoreValue = GetScoreValue(playerTwoScore);

            return $"{playerOneScoreValue}-{playerTwoScoreValue}";
        }

        private string GetScoreValue(int score)
        {
            string[] scoreValues = { "Love", "Fifteen", "Thirty", "Forty" };

            return scoreValues[score];
        }

        private bool PlayerScoresAreEqual()
        {
            return playerOneScore == playerTwoScore;
        }

        private string GetLateGameScore()
        {
            if (PlayerScoresAreEqual())
            {
                return "Deuce";
            }
            string leadingPlayer = GetPlayerInTheLead();

            if (PlayerScoresAreOnePointApart())
            {
                return $"Advantage {leadingPlayer}";
            }

            return $"Win for {leadingPlayer}";
        }

        private bool PlayerScoresAreOnePointApart()
        {
            return Math.Abs(playerOneScore - playerTwoScore) == 1;
        }

        private string GetPlayerInTheLead()
        {
            if (playerOneScore > playerTwoScore)
            {
                return playerOneName;
            }

            return playerTwoName;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == playerOneName)
            {
                playerOneScore += 1;
            }
            else
            { 
                playerTwoScore += 1;
            }
        }
    }
}

