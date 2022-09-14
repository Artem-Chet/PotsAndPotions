using PotsAndPotions.Core.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Chips
{
    public record AbilityChip<T>(int InitialValue, IColor Color, int Cost) : IChip where T : IChipAbility
    {
        public Type AbilityType => typeof(T);
    }
}
