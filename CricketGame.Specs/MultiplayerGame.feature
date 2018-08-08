Feature: MultiplayerGame
	In order play a multiplier game
	As a player
	I want to be told the result of two players

@mytag
Scenario: Player 1 should be declared the winner if he scores more than Player 2
	Given Game of cricket has started
	When Player 1 starts a game of cricket
	And Player 1 scores 4 runs
	And Player 1 scores 6 runs
	And Player 1 scores 3 runs
	And Player 1 scores 1 runs
	And Player 1 scores 6 runs
	And Player 1 gets out
	And Player 2 starts a game of cricket
	And Player 2 scores 4 runs
	And Player 2 scores 1 runs
	And Player 2 scores 1 runs
	And Player 2 scores 1 runs
	And Player 2 scores 1 runs
	And Player 2 gets out
	Then the winner of the game should be Player 1

Scenario: Game should be declared a Tie if both players have the same total
	Given Game of cricket has started
	When Player 1 starts a game of cricket
	And Player 1 scores 6 runs
	And Player 1 scores 3 runs
	And Player 1 scores 6 runs
	And Player 1 scores 6 runs
	And Player 1 scores 3 runs
	And Player 1 gets out
	And Player 2 starts a game of cricket
	And Player 2 scores 4 runs
	And Player 2 scores 4 runs
	And Player 2 scores 6 runs
	And Player 2 scores 4 runs
	And Player 2 scores 6 runs
	And Player 2 gets out
	Then the winner of the game should be Tie
