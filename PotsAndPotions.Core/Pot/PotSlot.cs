using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Pot
{
    public record PotSlot
    {
        public int Coins { get; init; }
        public int Points { get; init; }
        public bool HasCrystal { get; init; }
    }
}
