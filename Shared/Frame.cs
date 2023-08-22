using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingChallenge.Shared
{
    public class Frame
    {
        public bool isLast { get; set; }

        public int bonusRolls { get; set; }

        public int currentRoll { get; set; }

        public int frameScore { get; set; }
    }
}
