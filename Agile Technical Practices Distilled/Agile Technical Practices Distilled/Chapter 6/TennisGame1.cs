namespace Agile_Technical_Practices_Distilled.Chapter_6
{
    public class TennisGame1 : ITennisGame
    {
        private int player1Score = 0;
        private int player2Score = 0;

        private const string PlayerOneName = "player1";
        private const string PlayerTwoName = "player2";

        public void WonPoint(string playerName)
        {
            if (playerName == PlayerOneName)
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

            var score = GetPlayerOneScoreMessage();

            return $"{score}-All";
        }

        private string GetPlayerOneScoreMessage()
        {
            return GetScoreMessage(player1Score);
        }

        private string GetScoreMessage(int score)
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
            return player1Score > 3 || player2Score > 3;
        }

        private string GetAdvantageScore()
        {
            var scoreDifference = Math.Abs(player1Score - player2Score);
            var playerInLead = PlayerOneName;

            if (player1Score < player2Score)
            {
                playerInLead = PlayerTwoName;
            }

            if (scoreDifference == 1)
            {
                return $"Advantage {playerInLead}";
            }

            return $"Win for {playerInLead}";
        }

        private string GetMatchScore()
        {
            var player1ScoreMessage = GetPlayerOneScoreMessage();
            var player2ScoreMessage = GetPlayerTwoScoreMessage();

            return $"{player1ScoreMessage}-{player2ScoreMessage}";
        }

        private string GetPlayerTwoScoreMessage()
        {
            return GetScoreMessage(player2Score);
        }
    }
}