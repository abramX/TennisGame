using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame
{
    public class Player
    {
        private string _playerName;
        private int _points;
        public Player(string playerName)
        {
            _playerName = playerName;
            _points = 0;
        }

        internal string getName()
        {
            return _playerName;
        }

        public void addPoint()
        {
            _points = _points + 1;
        }
        public int GetPoints()
        {
            return _points;
        }
    }
}
