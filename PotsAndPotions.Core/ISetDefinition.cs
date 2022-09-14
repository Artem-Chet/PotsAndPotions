using PotsAndPotions.Core.Chips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core
{
    public interface ISetDefinition
    {
        public IList<IChip> GetAvailableChips();
    }
}
