using KataTenis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTest
{
    [TestClass]
    public class TestGame
    {

        private void CheckScores(int player1, int player2, Game game)
        {
            Assert.AreEqual(player1, game.player1score);
            Assert.AreEqual(player2, game.player2score);
        }

        [TestMethod]
        public void AGameShouldStartWithZero()
        {
            Game game = new Game();
            CheckScores(0, 0, game);
        }

        [TestMethod]
        public void WhenAPlayerScoresPlayerScoreShouldBeIncreased()
        {
            Game game = new Game();
            game.Score(Game.PLAYER1);
            CheckScores(15, 0, game);
        }

        [TestMethod]
        public void WhenTwoPlayersScoreTheyShouldBothHave15()
        {
            Game game = new Game();
            game.Score(Game.PLAYER1, Game.PLAYER2);
            CheckScores(15, 15, game);
        }

        [TestMethod]
        public void WhenAPlayerScoresTwiceItGets30()
        {
            Game game = new Game();
            game.Score( Game.PLAYER1, Game.PLAYER1 );
            CheckScores(30, 0, game);
        }

        [TestMethod]
        public void WhenTheOtherPlayerScoresTwiceItGets30()
        {
            Game game = new Game();
            game.Score(Game.PLAYER2, Game.PLAYER2);
            CheckScores(0, 30, game);
        }

        [TestMethod]
        public void WhenAPlayerScores3TimesHeWouldGet40()
        {
            Game game = new Game();
            game.Score(Game.PLAYER1, Game.PLAYER1, Game.PLAYER1);
            CheckScores(40, 0, game);
        }

        [TestMethod]
        public void WhenAPlayerScores4TimesHeWillWin()
        {
            Game game = new Game();
            game.Score(Game.PLAYER1, Game.PLAYER1, Game.PLAYER1, Game.PLAYER1);
            Assert.AreEqual(Game.PLAYER1, game.GetWinner());
        }

        [TestMethod]
        public void WhenTheOtherPlayerScores4TimesHeWillWin()
        {
            Game game = new Game();
            game.Score(Game.PLAYER2, Game.PLAYER2, Game.PLAYER2, Game.PLAYER2);
            Assert.AreEqual(Game.PLAYER2, game.GetWinner());
        }

        //[TestMethod]
        //public void WhenBothPlayersScore3TimesTheyWillBeDeuce()
        //{
        //    Game game = new Game();
        //    game.Score(
        //        Game.PLAYER1,
        //        Game.PLAYER2,
        //        Game.PLAYER1,
        //        Game.PLAYER2,
        //        Game.PLAYER1,
        //        Game.PLAYER2);
        //}
    }
}
