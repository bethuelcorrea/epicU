using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts.Darts
{
    public class Dart
    {
        public int Score { get; set; }
        public bool OuterBandDouble { get; set; }
        public bool innerBandTriple { get; set; }

        private Random _random;

        public Dart(Random random)
        {

            _random = random;

        }

        public void Throw()
        {
            Score = _random.Next(0, 21);
            int multiply = _random.Next(1, 101);
            if (multiply > 95) OuterBandDouble = true;
            else if (multiply > 20 && multiply < 26) innerBandTriple = true;


        }
    }
}