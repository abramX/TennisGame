using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisGame;

namespace TennisTest
{
    [TestFixture]
    class ScoreTest
    {
        Match match;
        [SetUp]
        ///On Init create the Match Object
        public void Init()
        { 
             match = new Match("p1", "p2");
        }

        [TestCase(4,0,"p1 Win", "p2 Lose")]
        [TestCase(0, 4, "p1 Lose", "p2 Win")]
        [TestCase(4,2, "p1 Win", "p2 Lose")]
        [TestCase(0, 0, "Love", "Love")]
        [TestCase(1, 0, "Fifteen","Love")]
        [TestCase(3, 1, "Forty", "Fifteen")]
        [TestCase(3, 2, "Forty", "Thirty")]
        [TestCase(3, 3, "Deuce", "Deuce")]
        [TestCase(4, 3, "Advantage", "Forty")]
        public void getStringScore(int pointsPlayer1, int pointsPlayer2, string expectedResult1, string expectedResult2)
        {
            for (int i = 0; i < pointsPlayer1; i++)
            {
                match._player1.addPoint();
            }
            for (int i = 0; i < pointsPlayer2; i++)
            {
                match._player2.addPoint();
            }
            var score = match.GetScore();
            Assert.AreEqual(expectedResult1, score.Item1);
            Assert.AreEqual(expectedResult2, score.Item2);
        }       

    }
}
