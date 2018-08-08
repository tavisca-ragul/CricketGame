using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;

        [Given(@"Game of cricket has started")]
        public void GivenGameOfCricketHasStarted()
        {
            _game = new Cricket();
        }


        [Given(@"Player (.*) has started a game of cricket")]
        [When(@"Player (.*) starts a game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket(int player)
        {
            _game.PlayerStartsToPlay(player-1);
        }

        [Given(@"Player (.*) has scored (.*) runs")]
        [When(@"Player (.*) scores (.*) runs")]
        public void WhenPlayerScoresRuns(int player, int runs)
        {
            _game.Score(player - 1, runs);
        }

        [Given(@"Player (.*) got out")]
        [When(@"Player (.*) gets out")]
        public void GivenPlayerGetsOut(int player)
        {
            _game.Wicket(player - 1);
        }


        [Then(@"the player (.*) score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int player, int runs)
        {
            _game.GetPlayerScore(player-1).Should().Be(runs);
        }

        [Then(@"the winner of the game should be (.*)")]
        public void ThenTheWinnerShouldOfTheGameShouldBePlayer(String resultOfGame)
        {
            _game.WinnerOfGame().Should().Be(resultOfGame);
        }

    }
}
