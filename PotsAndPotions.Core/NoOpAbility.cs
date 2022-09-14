using PotsAndPotions.Core.Chips;
using PotsAndPotions.Core.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core
{
    public class NoOpAbility : IChipAbility
    {
        public IList<IEffect> GetEffects()
        {
            return new List<IEffect>();
        }
    }
}
