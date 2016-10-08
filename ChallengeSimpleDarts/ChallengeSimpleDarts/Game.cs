using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChallengeSimpleDarts;
using ChallengeSimpleDarts.Darts;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        private Player player1;
        private Player player2;

        private Random random;

        public Game()
        {
            random = new Random();

            player1 = new Player();
            player1.Name = "Rangers";

            player2 = new Player();
            player2.Name = "Blue Jays";
        }

        public string Play()
        {
            while (player1.Score < 300 && player2.Score < 300)
            {
                threeRound(player1);
                threeRound(player2);
            }

            return PlayersScore();
        }

        private string PlayersScore()
        {
            string result = string.Format("{0}--Score-->{1}<br/>{2}--Score-->{3}", player1.Name, player1.Score, player2.Name, player2.Score);
            if (player1.Score > player2.Score) return result + "<br/>" + player1.Name + "You Win";
            if (player1.Score < player2.Score) return result + "<br/>" + player2.Name + "You win";

            return result;
        }

        private void threeRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                var dart = new Dart(random);
                dart.Throw();
                Score.ScoreDart(player, dart);
            }
        }



    }
}