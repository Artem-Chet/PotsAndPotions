using PotsAndPotions.Core.Chips;
using PotsAndPotions.Core.Chips.Set1;
using PotsAndPotions.Core.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Sets
{
    public class Set1
    {
        public List<IChip> GetAvailableChips()
        {
            return new List<IChip>()
            {
                new Chip(1, Colors.Orange, 3),
                new AbilityChip<RedChipAbility>(1, Colors.Red, 6),
                new AbilityChip<RedChipAbility>(2, Colors.Red, 10),
                new AbilityChip<RedChipAbility>(4, Colors.Red, 16),
            };
        }
    }
}
