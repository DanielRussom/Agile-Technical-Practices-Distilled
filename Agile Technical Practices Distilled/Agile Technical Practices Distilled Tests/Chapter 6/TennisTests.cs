using Agile_Technical_Practices_Distilled.Chapter_6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_6
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {0, 0, "Love-All"},
            new object[] {1, 1, "Fifteen-All"},
            new object[] {2, 2, "Thirty-All"},
            new object[] {3, 3, "Deuce"},
            new object[] {4, 4, "Deuce"},
            new object[] {1, 0, "Fifteen-Love"},
            new object[] {0, 1, "Love-Fifteen"},
            new object[] {2, 0, "Thirty-Love"},
            new object[] {0, 2, "Love-Thirty"},
            new object[] {3, 0, "Forty-Love"},
            new object[] {0, 3, "Love-Forty"},
            new object[] {4, 0, "Win for player1"},
            new object[] {0, 4, "Win for player2"},
            new object[] {2, 1, "Thirty-Fifteen"},
            new object[] {1, 2, "Fifteen-Thirty"},
            new object[] {3, 1, "Forty-Fifteen"},
            new object[] {1, 3, "Fifteen-Forty"},
            new object[] {4, 1, "Win for player1"},
            new object[] {1, 4, "Win for player2"},
            new object[] {3, 2, "Forty-Thirty"},
            new object[] {2, 3, "Thirty-Forty"},
            new object[] {4, 2, "Win for player1"},
            new object[] {2, 4, "Win for player2"},
            new object[] {4, 3, "Advantage player1"},
            new object[] {3, 4, "Advantage player2"},
            new object[] {5, 4, "Advantage player1"},
            new object[] {4, 5, "Advantage player2"},
            new object[] {15, 14, "Advantage player1"},
            new object[] {14, 15, "Advantage player2"},
            new object[] {6, 4, "Win for player1"},
            new object[] {4, 6, "Win for player2"},
            new object[] {16, 14, "Win for player1"},
            new object[] {14, 16, "Win for player2"},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [TestClass]
    public class TennisTests
    {

        [TestMethod]
        [DataRow(0, 0, "Love-All")]
        [DataRow(1, 1, "Fifteen-All")]
        [DataRow(2, 2, "Thirty-All")]
        [DataRow(3, 3, "Deuce")]
        [DataRow(4, 4, "Deuce")]
        [DataRow(1, 0, "Fifteen-Love")]
        [DataRow(0, 1, "Love-Fifteen")]
        [DataRow(2, 0, "Thirty-Love")]
        [DataRow(0, 2, "Love-Thirty")]
        [DataRow(3, 0, "Forty-Love")]
        [DataRow(0, 3, "Love-Forty")]
        [DataRow(4, 0, "Win for player1")]
        [DataRow(0, 4, "Win for player2")]
        [DataRow(2, 1, "Thirty-Fifteen")]
        [DataRow(1, 2, "Fifteen-Thirty")]
        [DataRow(3, 1, "Forty-Fifteen")]
        [DataRow(1, 3, "Fifteen-Forty")]
        [DataRow(4, 1, "Win for player1")]
        [DataRow(1, 4, "Win for player2")]
        [DataRow(3, 2, "Forty-Thirty")]
        [DataRow(2, 3, "Thirty-Forty")]
        [DataRow(4, 2, "Win for player1")]
        [DataRow(2, 4, "Win for player2")]
        [DataRow(4, 3, "Advantage player1")]
        [DataRow(3, 4, "Advantage player2")]
        [DataRow(5, 4, "Advantage player1")]
        [DataRow(4, 5, "Advantage player2")]
        [DataRow(15, 14, "Advantage player1")]
        [DataRow(14, 15, "Advantage player2")]
        [DataRow(6, 4, "Win for player1")]
        [DataRow(4, 6, "Win for player2")]
        [DataRow(16, 14, "Win for player1")]
        [DataRow(14, 16, "Win for player2")]
        public void Tennis1Test(int p1, int p2, string expected)
        {
            var game = new TennisGame1();
            CheckAllScores(game, p1, p2, expected);
        }

        [TestMethod]
        [DataRow(0, 0, "Love-All")]
        [DataRow(1, 1, "Fifteen-All")]
        [DataRow(2, 2, "Thirty-All")]
        [DataRow(3, 3, "Deuce")]
        [DataRow(4, 4, "Deuce")]
        [DataRow(1, 0, "Fifteen-Love")]
        [DataRow(0, 1, "Love-Fifteen")]
        [DataRow(2, 0, "Thirty-Love")]
        [DataRow(0, 2, "Love-Thirty")]
        [DataRow(3, 0, "Forty-Love")]
        [DataRow(0, 3, "Love-Forty")]
        [DataRow(4, 0, "Win for player1")]
        [DataRow(0, 4, "Win for player2")]
        [DataRow(2, 1, "Thirty-Fifteen")]
        [DataRow(1, 2, "Fifteen-Thirty")]
        [DataRow(3, 1, "Forty-Fifteen")]
        [DataRow(1, 3, "Fifteen-Forty")]
        [DataRow(4, 1, "Win for player1")]
        [DataRow(1, 4, "Win for player2")]
        [DataRow(3, 2, "Forty-Thirty")]
        [DataRow(2, 3, "Thirty-Forty")]
        [DataRow(4, 2, "Win for player1")]
        [DataRow(2, 4, "Win for player2")]
        [DataRow(4, 3, "Advantage player1")]
        [DataRow(3, 4, "Advantage player2")]
        [DataRow(5, 4, "Advantage player1")]
        [DataRow(4, 5, "Advantage player2")]
        [DataRow(15, 14, "Advantage player1")]
        [DataRow(14, 15, "Advantage player2")]
        [DataRow(6, 4, "Win for player1")]
        [DataRow(4, 6, "Win for player2")]
        [DataRow(16, 14, "Win for player1")]
        [DataRow(14, 16, "Win for player2")]
        public void Tennis2Test(int p1, int p2, string expected)
        {
            var game = new TennisGame2();
            CheckAllScores(game, p1, p2, expected);
        }

        [TestMethod]
        [DataRow(0, 0, "Love-All")]
        [DataRow(1, 1, "Fifteen-All")]
        [DataRow(2, 2, "Thirty-All")]
        [DataRow(3, 3, "Deuce")]
        [DataRow(4, 4, "Deuce")]
        [DataRow(1, 0, "Fifteen-Love")]
        [DataRow(0, 1, "Love-Fifteen")]
        [DataRow(2, 0, "Thirty-Love")]
        [DataRow(0, 2, "Love-Thirty")]
        [DataRow(3, 0, "Forty-Love")]
        [DataRow(0, 3, "Love-Forty")]
        [DataRow(4, 0, "Win for player1")]
        [DataRow(0, 4, "Win for player2")]
        [DataRow(2, 1, "Thirty-Fifteen")]
        [DataRow(1, 2, "Fifteen-Thirty")]
        [DataRow(3, 1, "Forty-Fifteen")]
        [DataRow(1, 3, "Fifteen-Forty")]
        [DataRow(4, 1, "Win for player1")]
        [DataRow(1, 4, "Win for player2")]
        [DataRow(3, 2, "Forty-Thirty")]
        [DataRow(2, 3, "Thirty-Forty")]
        [DataRow(4, 2, "Win for player1")]
        [DataRow(2, 4, "Win for player2")]
        [DataRow(4, 3, "Advantage player1")]
        [DataRow(3, 4, "Advantage player2")]
        [DataRow(5, 4, "Advantage player1")]
        [DataRow(4, 5, "Advantage player2")]
        [DataRow(15, 14, "Advantage player1")]
        [DataRow(14, 15, "Advantage player2")]
        [DataRow(6, 4, "Win for player1")]
        [DataRow(4, 6, "Win for player2")]
        [DataRow(16, 14, "Win for player1")]
        [DataRow(14, 16, "Win for player2")]
        public void Tennis3Test(int p1, int p2, string expected)
        {
            var game = new TennisGame3("player1", "player2");
            CheckAllScores(game, p1, p2, expected);
        }

        private void CheckAllScores(ITennisGame game, int player1Score, int player2Score, string expectedScore)
        {
            var highestScore = Math.Max(player1Score, player2Score);
            for (var i = 0; i < highestScore; i++)
            {
                if (i < player1Score)
                    game.WonPoint("player1");
                if (i < player2Score)
                    game.WonPoint("player2");
            }

            Assert.AreEqual(expectedScore, game.GetScore());
        }
    }
}