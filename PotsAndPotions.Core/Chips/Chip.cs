using PotsAndPotions.Core.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Chips
{
    public record Chip(int InitialValue, IColor Color, int Cost) : IChip
    {
        public Type AbilityType => typeof(NoOpAbility);
    }
}
