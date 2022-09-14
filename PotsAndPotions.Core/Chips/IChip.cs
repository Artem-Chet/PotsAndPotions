using PotsAndPotions.Core.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Chips
{
    public interface IChip
    {
        int Cost { get; }
        IColor Color { get; }
        int InitialValue { get; }
        
        Type AbilityType { get; }
    }
}
