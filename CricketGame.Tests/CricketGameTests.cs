using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Tests
{
    [TestClass]
    public class CricketGameTests
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShoulbeZero()
        {
            var game = new Cricket();
            game.PlayerStartsToPlay(0);
            Assert.IsTrue(game.GetPlayerScore(0) == 0);
        }

        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.PlayerStartsToPlay(0);
            game.Score(0, 4);
            Assert.IsTrue(game.GetPlayerScore(0) == 4);
        }

        [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.PlayerStartsToPlay(0);
            game.Score(0, 7);
            Assert.IsTrue(game.GetPlayerScore(0) == 0);
        }

        [TestMethod]
        public void Score_ValidRuns_MultipleTimes__ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.PlayerStartsToPlay(0);
            game.Score(0, 4);
            game.Score(0, 3);
            Assert.IsTrue(game.GetPlayerScore(0) == 7);
        }

        [TestMethod]
        public void Score__AfterGettingOut_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.PlayerStartsToPlay(0);
            game.Score(0, 2);
            game.Score(0, 3);
            game.Wicket(0);
            game.Score(0, 6);
            Assert.IsTrue(game.GetPlayerScore(0) == 5);
        }

        [TestMethod]
        public void WinnerOfGame_PlayerOneScoresMoreThanPlayerTwo__ShouldDeclaredPlayerOneAsWinner()
        {
            var game = new Cricket();
            game.PlayerStartsToPlay(0);
            game.Score(0, 4);
            game.Score(0, 3);
            game.Score(0, 6);
            game.Score(0, 4);
            game.Score(0, 4);
            game.Wicket(0);
            game.PlayerStartsToPlay(1);
            game.Score(1, 4);
            game.Score(1, 4);
            game.Score(1, 4);
            game.Score(1, 1);
            game.Wicket(1);
            Assert.IsTrue(game.WinnerOfGame().Equals("Player 1"));
        }

        [TestMethod]
        public void WinnerOfGame_BothPlayersHaveSameTotal__ShouldDeclaredGameTie()
        {
            var game = new Cricket();
            game.PlayerStartsToPlay(0);
            game.Score(0, 4);
            game.Score(0, 3);
            game.Score(0, 6);
            game.Score(0, 4);
            game.Score(0, 4);
            game.Wicket(0);
            game.PlayerStartsToPlay(1);
            game.Score(1, 4);
            game.Score(1, 4);
            game.Score(1, 4);
            game.Score(1, 1);
            game.Score(1, 6);
            game.Score(1, 2);
            game.Wicket(1);
            Assert.IsTrue(game.WinnerOfGame().Equals("Tie"));
        }
    }
}
