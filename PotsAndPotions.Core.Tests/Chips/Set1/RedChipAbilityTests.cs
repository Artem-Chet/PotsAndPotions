using PotsAndPotions.Core.Chips.Set1;
using PotsAndPotions.Core.Color;
using PotsAndPotions.Core.Effects;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Tests.Chips.Set1
{
    public class RedChipAbilityTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 2)]
        public void GetEffects_OrangeCount_ValueAdded(int orangeCount, int expectedValueAdded)
        {
            var orangeChips = Enumerable.Range(0, orangeCount).Select(x => 1).ToList();
            var orangeChipsSnapshot = new ChipInPotSnapshot<Orange>(orangeChips);

            var ability = new RedChipAbility(orangeChipsSnapshot);
            var effects = ability.GetEffects();

            Assert.Single(effects);

            var effect = effects[0] as ValueAdditionEffect;
           
            Assert.NotNull(effect);

            var value = effect.AddValue(4);

            Assert.Equal(expectedValueAdded, value);
        }
    }
}
