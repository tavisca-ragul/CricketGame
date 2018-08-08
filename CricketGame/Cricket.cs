using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        private PlayerScoreCard[] _playerScoreCards = new PlayerScoreCard[2];

        public void Score(int player, int runs)
        {
            if ((_playerScoreCards[player].Out == false) && (runs <= 6))
                _playerScoreCards[player].PlayerScore += runs;
        }

        public void PlayerStartsToPlay(int player)
        {
            _playerScoreCards[player] = new PlayerScoreCard();
        }

        public void Wicket(int player)
        {
            _playerScoreCards[player].Out = true;
        }

        public int GetPlayerScore(int player)
        {
            return _playerScoreCards[player].PlayerScore;
        }

        public String WinnerOfGame()
        {
            return (_playerScoreCards[0].PlayerScore > _playerScoreCards[1].PlayerScore) ? "Player 1" : (_playerScoreCards[0].PlayerScore == _playerScoreCards[1].PlayerScore) ? "Tie" : "Player 2";
        }
    }
}