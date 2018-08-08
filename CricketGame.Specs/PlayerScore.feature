Feature: PlayerScore
	In order to enjoy a game
	As a player
	I want to be told my score

@mytag
Scenario: Player 1 score is zero when game starts
	Given Game of cricket has started
	When Player 1 starts a game of cricket
	Then the player 1 score should be 0

Scenario: Player 1 Should be able to score runs
	Given Game of cricket has started
	And Player 1 has started a game of cricket
	When Player 1 scores 4 runs
	Then the player 1 score should be 4

Scenario: Player 1 should be able to score runs multiple times
	Given Game of cricket has started
	And Player 1 has started a game of cricket
	And Player 1 has scored 4 runs
	When Player 1 scores 3 runs
	Then the player 1 score should be 7

Scenario: Player 1 should not be able to score runs after getting out
	Given Game of cricket has started
	And Player 1 has started a game of cricket
	And Player 1 has scored 4 runs
	And Player 1 got out
	When Player 1 scores 3 runs
	Then the player 1 score should be 4