using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataTenis;

namespace KataTest
{

    [TestClass]
    public class TestGame
    {
        Player p1;
        Player p2;
        Game g;
        [TestInitialize]
        public void InitializeTest()
        {
            p1 = new Player();
            p2 = new Player();
            g = new Game(p1, p2);
        }

        [TestMethod]
        public void TestInitialGame()
        {
            Assert.AreEqual("0", p1.GetScore());
            Assert.AreEqual("0", p2.GetScore());
        }

        [TestMethod]
        public void FirstPlay()
        {
            p1.Score();
            Assert.AreEqual("15", p1.GetScore());
        }

        [TestMethod]
        public void TwoPlays()
        {
            p1.Score();
            p2.Score();
            p1.Score();
            Assert.AreEqual("30", p1.GetScore());
            Assert.AreEqual("15", p2.GetScore());
        }

        [TestMethod]
        public void WinnerPlayer()
        {
            p1.Score();
            p1.Score();
            p1.Score();
            p1.Score();
            Assert.AreEqual(p1, g.GetWinner());
        }

        [TestMethod]
        public void Equals()
        {
            p1.Score();
            p1.Score();
            p1.Score();
            p2.Score();
            p2.Score();
            p2.Score();
            Assert.AreEqual("Deuce", p1.GetScore());
            Assert.AreEqual("Deuce", p2.GetScore());
        }

        [TestMethod]
        public void Advantage()
        {
            p1.Score();
            p1.Score();
            p1.Score();
            p2.Score();
            p2.Score();
            p2.Score();
            p1.Score();
            Assert.AreEqual("Advantage", p1.GetScore());
            Assert.AreEqual("40", p2.GetScore()); 
        }

        [TestMethod]
        public void WinFromAdvantage()
        {
            p1.Score();
            p1.Score();
            p1.Score();
            p2.Score();
            p2.Score();
            p2.Score();
            p1.Score();
            p1.Score();
            Assert.AreEqual(p1, g.GetWinner());
        }

        [TestMethod]
        public void DeuceFromAdvantage()
        {
            p1.Score();
            p1.Score();
            p1.Score();
            p2.Score();
            p2.Score();
            p2.Score();
            p1.Score();
            p2.Score();
            Assert.AreEqual("Deuce", p1.GetScore());
            Assert.AreEqual("Deuce", p2.GetScore());
        }
    }
}
