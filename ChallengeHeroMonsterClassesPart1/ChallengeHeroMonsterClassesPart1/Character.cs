﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClassesPart1
{
    public class Character
    {
        public String Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(this.DamageMaximum);
            return damage;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }


    }
}