using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTenis
{
    public class Player
    {
        public string Points { get; set; }
        public Game Game { get; set; }

        public Player()
        {
            Points = "0";
        }

        public object GetScore()
        {
            return Points;
        }

        public void Score()
        {
            Game.Score(this);
        }
    }
}
