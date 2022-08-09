using Agile_Technical_Practices_Distilled.Chapter_7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_7
{
    [TestClass]
    public class GameShould
    {
        private Game game;

        public GameShould()
        {
           game = new Game();
        }


        [TestMethod]
        public void NotAllowPlayerOToPlayFirst()
        {
            Action wrongPlay = () => game.Play('O', 0, 0);

            var exception = Assert.ThrowsException<Exception>(wrongPlay);
            Assert.AreEqual("Invalid first player", exception.Message);
        }


        [TestMethod]
        public void NotAllowPlayerXToPlayTwiceInARow()
        {
            game.Play('X', 0, 0);
            
            Action wrongPlay = () => game.Play('X', 1, 0);

            var exception = Assert.ThrowsException<Exception>(wrongPlay);
            Assert.AreEqual("Invalid next player", exception.Message);
        }

        [TestMethod]
        public void NotAllowPlayerToPlayInLastPlayedPosition()
        {
            game.Play('X', 0, 0);

            Action wrongPlay = () => game.Play('O', 0, 0);

            var exception = Assert.ThrowsException<Exception>(wrongPlay);
            Assert.AreEqual("Invalid position", exception.Message);
        }

        [TestMethod]
        public void NotAllowPlayerToPlayInAnyPlayedPosition()
        {
            game.Play('X', 0, 0);
            game.Play('O', 1, 0);

            Action wrongPlay = () => game.Play('X', 0, 0);

            var exception = Assert.ThrowsException<Exception>(wrongPlay);
            Assert.AreEqual("Invalid position", exception.Message);
        }

        [TestMethod]
        public void DeclarePlayerXAsAWinnerIfThreeInTopRow()
        {
            game.Play('X', 0, 0);
            game.Play('O', 1, 0);
            game.Play('X', 0, 1);
            game.Play('O', 1, 1);
            game.Play('X', 0, 2);

            var winner = game.Winner();

            Assert.AreEqual('X', winner);
        }

        [TestMethod]
        public void DeclarePlayerOAsAWinnerIfThreeInTopRow()
        {
            game.Play('X', 2, 2);
            game.Play('O', 0, 0);
            game.Play('X', 1, 0);
            game.Play('O', 0, 1);
            game.Play('X', 1, 1);
            game.Play('O', 0, 2);

            var winner = game.Winner();

            Assert.AreEqual('O', winner);
        }

        [TestMethod]
        public void DeclarePlayerXAsAWinnerIfThreeInMiddleRow()
        {
            game.Play('X', 1, 0);
            game.Play('O', 0, 0);
            game.Play('X', 1, 1);
            game.Play('O', 0, 1);
            game.Play('X', 1, 2);

            var winner = game.Winner();

            Assert.AreEqual('X', winner);
        }

        [TestMethod]
        public void DeclarePlayerOAsAWinnerIfThreeInMiddleRow()
        {
            game.Play('X', 0, 0);
            game.Play('O', 1, 0);
            game.Play('X', 2, 0);
            game.Play('O', 1, 1);
            game.Play('X', 2, 1);
            game.Play('O', 1, 2);

            var winner = game.Winner();

            Assert.AreEqual('O', winner);
        }

        [TestMethod]
        public void DeclarePlayerXAsAWinnerIfThreeInBottomRow()
        {
            game.Play('X', 2, 0);
            game.Play('O', 0, 0);
            game.Play('X', 2, 1);
            game.Play('O', 0, 1);
            game.Play('X', 2, 2);

            var winner = game.Winner();

            Assert.AreEqual('X', winner);
        }

        [TestMethod]
        public void DeclarePlayerOAsAWinnerIfThreeInBottomRow()
        {
            game.Play('X', 0, 0);
            game.Play('O', 2, 0);
            game.Play('X', 1, 0);
            game.Play('O', 2, 1);
            game.Play('X', 1, 1);
            game.Play('O', 2, 2);

            var winner = game.Winner();

            Assert.AreEqual('O', winner);
        }
    }
}
