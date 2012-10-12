using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTenis
{
    public class Game
    {
        private string[] Scores = new string[] { "0", "15", "30", "40", "Deuce", "Advantage" };
        private Player p1;
        private Player p2;
        private Player winner;

        public Game(Player p1, Player p2)
        {
            if (p1 == null || p2 == null)
            {
                throw new Exception("2 player are required");
            }
            this.p1 = p1;
            p1.Game = this;
            this.p2 = p2;
            p2.Game = this;
        }

        public void Score(Player p)
        {
            int i = Array.IndexOf(Scores, p.Points);
            if (i == 2)
            {
                Player opponent = GetOpponent(p);
                if (opponent.Points == "40")
                {
                    opponent.Points = "Deuce";
                    p.Points = "Deuce";
                    return;
                }
            }
            if (i == 3 || i == 5)
            {
                Player opponent = GetOpponent(p);
                if (opponent.Points == "Advantage")
                {
                    opponent.Points = "Deuce";
                    p.Points = "Deuce";
                    return;
                }
                winner = p;
                return;
            }
            if (i == 4)
            {
                Player opponent = GetOpponent(p);
                if (opponent.Points == "Deuce")
                {
                    opponent.Points = "40";
                    p.Points = "Advantage";
                    return;
                }
            }
            p.Points = Scores[++i];
        }

        private Player GetOpponent(Player p)
        {
            if (p == p1)
            {
                return p2;
            }
            return p1;
        }

        public object GetWinner()
        {
            return winner;
        }
    }
}
