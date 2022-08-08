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

            if (playerOneScore == playerTwoScore)
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

        private string GetLateGameScore()
        {
            if (playerOneScore == playerTwoScore)
            {
                return "Deuce";
            }

            var leadingPlayer = playerOneScore > playerTwoScore ? playerOneName : playerTwoName;

            if (Math.Abs(playerOneScore - playerTwoScore) == 1)
            {
                return "Advantage " + leadingPlayer;
            }

            return "Win for " + leadingPlayer;
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

