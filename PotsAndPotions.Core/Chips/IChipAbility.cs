using PotsAndPotions.Core.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Chips
{
    public interface IChipAbility
    {
        IList<IEffect> GetEffects();
    }
}
