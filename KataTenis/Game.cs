using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTenis
{
    public class Game
    {
        public static int PLAYER1 = 0;
        public static int PLAYER2 = 1;
        public static int NOTFINISHED = 3;
        
        public int player1score;
        public int player2score;

        public void Score(params int[] plays)
        {
            for (int i = 0; i < plays.Length; i++)
            {
                if (plays[i] == 0)
                {
                    ScorePlayerOne();
                    continue;
                }
                ScorePlayerTwo();
            }
        }

        private void ScorePlayerOne()
        {
            if (player1score == 15)
            {
                player1score = 30;
                return;
            }
            if (player1score == 30)
            {
                player1score = 40;
                return;
            }
            if (player1score == 40)
            {
                player1score = 50;
                return;
            }

            player1score = 15;

        }

        private void ScorePlayerTwo()
        {
            if (player2score == 15)
            {
                player2score = 30;
                return;
            }
            if (player2score == 30)
            {
                player2score = 40;
                return;
            }
            if (player2score == 40)
            {
                player2score = 50;
                return;
            }

            player2score = 15;
        }

        public object GetWinner()
        {
            if (player1score == 50)
            {
                return PLAYER1;
            }
            if (player2score == 50)
            {
                return PLAYER2;  
            }
            return NOTFINISHED;
        }

    }
}
