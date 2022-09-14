using PotsAndPotions.Core.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Status
{
    internal interface IChipInPotSnapshot<T> where T : IColor
    {
        IReadOnlyList<int> Values { get; }
    }
}
