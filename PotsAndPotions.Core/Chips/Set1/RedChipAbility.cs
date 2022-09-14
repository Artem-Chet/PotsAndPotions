using PotsAndPotions.Core.Color;
using PotsAndPotions.Core.Effects;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Chips.Set1
{
    public class RedChipAbility : IImmediateAbility
    {
        private readonly ChipInPotSnapshot<Orange> orangeChips;

        public RedChipAbility(ChipInPotSnapshot<Orange> orangeChips)
        {
            this.orangeChips = orangeChips;
        }
        public IList<IEffect> GetEffects()
        {
            var effects = new List<IEffect>();

            if (orangeChips.Values.Count == 0)
            {
                return effects;
            }

            if (orangeChips.Values.Count < 3)
            {
                effects.Add(new ValueAdditionEffect(1));
                return effects;
            }

            effects.Add(new ValueAdditionEffect(2));
            return effects;
        }
    }
}
