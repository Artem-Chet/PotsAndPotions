using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Pot
{
    public class PotStatus
    {
        public PotSlot ScoringSlot { get; set; } = new PotSlot { Coins = 1, Points = 0, HasCrystal = false };
    }
}

