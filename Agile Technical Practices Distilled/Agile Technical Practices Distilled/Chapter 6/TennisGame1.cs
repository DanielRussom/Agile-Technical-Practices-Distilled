namespace Agile_Technical_Practices_Distilled.Chapter_6
{
    public class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
            {
                m_score1 += 1;
            }
            else
            {
                m_score2 += 1;
            }
        }

        public string GetScore()
        {
            string score = String.Empty;
            if (IsScoreTied())
            {
                return GetTiedScore();
            }
            else if (m_score1 >= 4 || m_score2 >= 4)
            {
                var minusResult = m_score1 - m_score2;

                if (minusResult == 1)
                {
                    score = "Advantage player1";
                }
                else if (minusResult == -1)
                {
                    score = "Advantage player2";
                }
                else if (minusResult >= 2)
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
                    var tempScore = m_score1;

                    if (i != 1)
                    {
                        score += "-";
                        tempScore = m_score2;
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

        private bool IsScoreTied()
        {
            return m_score1 == m_score2;
        }

        private string GetTiedScore()
        {
            switch (m_score1)
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

