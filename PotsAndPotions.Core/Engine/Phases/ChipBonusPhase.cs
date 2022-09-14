using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine.Phases
{
    public class ChipBonusPhase : IPhase
    {
        public bool IsPlayerEligible()
        {
            return true;
        }

        public void RunPhase()
        {
            throw new NotImplementedException();
        }
    }
}
