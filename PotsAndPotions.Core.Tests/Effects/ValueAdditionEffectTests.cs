using PotsAndPotions.Core.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Tests.Effects
{
    public class ValueAdditionEffectTests
    {
        [Fact]
        public void AddValue_ValuePassed_ValueAdded()
        {
            var effect = new ValueAdditionEffect(2);

            var valueAdded = effect.AddValue(4);

            Assert.Equal(2, valueAdded);
        }
    }
}
