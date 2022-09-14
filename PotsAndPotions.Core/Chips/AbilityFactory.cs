using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Chips
{
    public class AbilityFactory
    {
        private readonly ILifetimeScope scope;

        public AbilityFactory(ILifetimeScope scope)
        {
            this.scope = scope;
        }
        public IChipAbility BuildAbility(IChip chip)
        {
            return (IChipAbility)scope.Resolve(chip.AbilityType);
        }
    }
}
