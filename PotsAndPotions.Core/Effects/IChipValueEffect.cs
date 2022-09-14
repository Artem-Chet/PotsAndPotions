using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Effects
{
    public interface IChipValueEffect : IEffect
    {
        int AddValue(int chipValue);
    }
}
