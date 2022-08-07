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
            string s;
            if ((playerOneScore < 4 && playerTwoScore < 4) && (playerOneScore + playerTwoScore < 6))
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                s = p[playerOneScore];
                return (playerOneScore == playerTwoScore) ? s + "-All" : s + "-" + p[playerTwoScore];
            }
            else
            {
                if (playerOneScore == playerTwoScore)
                    return "Deuce";
                s = playerOneScore > playerTwoScore ? playerOneName : playerTwoName;
                return ((playerOneScore - playerTwoScore) * (playerOneScore - playerTwoScore) == 1) ? "Advantage " + s : "Win for " + s;
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                playerOneScore += 1;
            else
                playerTwoScore += 1;
        }

    }
}

