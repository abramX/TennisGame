using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame
{
    public class Match
    {
        public Player _player1;
        public Player _player2;
        Score _score;
        public Match(string playerName1, string playerName2)
        {
            _player1 = new Player(playerName1);
            _player2 = new Player(playerName2);
            _score = new Score();
        }


        public Tuple<string, string> GetScore()
        {
            return _score.GetResult(_player1, _player2);
        }
    }
}
