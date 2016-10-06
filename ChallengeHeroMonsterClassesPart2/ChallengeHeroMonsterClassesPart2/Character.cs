using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClassesPart2
{
    public class Character
    {
        public String Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            // Random random = new Random();
            // int damage = random.Next(this.DamageMaximum);
            // return damage;
            dice.Sides = this.DamageMaximum;
            return dice.rollDice();

        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }


    }
}