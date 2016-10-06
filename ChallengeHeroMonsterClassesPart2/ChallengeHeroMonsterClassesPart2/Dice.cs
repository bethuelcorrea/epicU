using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClassesPart2
{
    public class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();
        public int rollDice()
        {
            return random.Next(this.Sides);
        }

    }
}