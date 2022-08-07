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
            if (playerOneScore < 4 && playerTwoScore < 4 && (playerOneScore + playerTwoScore < 6))
            {
                string[] scoreValues = { "Love", "Fifteen", "Thirty", "Forty" };
                
                var playerOneScoreMessage = scoreValues[playerOneScore];

                if (playerOneScore == playerTwoScore)
                {
                    return playerOneScoreMessage + "-All";
                }

                return playerOneScoreMessage + "-" + scoreValues[playerTwoScore];
            }
         
            if (playerOneScore == playerTwoScore)
            {
                return "Deuce";
            }

            var scoreMessage = playerOneScore > playerTwoScore ? playerOneName : playerTwoName;

            if (Math.Abs(playerOneScore - playerTwoScore) == 1)
            {
                return "Advantage " + scoreMessage;
            }

            return "Win for " + scoreMessage;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
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

