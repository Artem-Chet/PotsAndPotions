using PotsAndPotions.Core.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Status
{
    public record ChipInPotSnapshot<T>(IReadOnlyList<int> Values) where T : IColor
    {
    }
}
