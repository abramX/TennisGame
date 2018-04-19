using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame
{
    public class Score
    {
        public Dictionary<int, string> pointText = new Dictionary<int, string>
        {
            {0,"Love" }, {1,"Fifteen" },{2,"Thirty" },{3,"Forty" }
        };

        public Tuple<string, string> GetResult(Player player1, Player player2)
        {
            if (player1.GetPoints() >= 4 && player1.GetPoints() >= (player2.GetPoints() + 2))
            {
                return new Tuple<string, string>(player1.getName() + " Win", player2.getName() + " Lose");
            }
            else if (player2.GetPoints() >= 4 && player2.GetPoints() >= (player1.GetPoints() + 2))
            {
                return new Tuple<string, string>(player1.getName() + " Lose", player2.getName() + " Win");
            }
            else
            {
                if (player1.GetPoints() >= 3 & player2.GetPoints() >= 3)
                {
                    if (player1.GetPoints() == player2.GetPoints())
                    {
                        return new Tuple<string, string>("Deuce", "Deuce");
                    }
                    else if (player1.GetPoints() > player2.GetPoints())
                    {
                        return new Tuple<string, string>("Advantage", pointText[player2.GetPoints()]);
                    }
                    else
                    {
                        return new Tuple<string, string>(pointText[player1.GetPoints()], "Advantage");
                    }
                }
                else
                {
                    return new Tuple<string, string>(pointText[player1.GetPoints()], pointText[player2.GetPoints()]);
                }
            }
        }
    }
}
