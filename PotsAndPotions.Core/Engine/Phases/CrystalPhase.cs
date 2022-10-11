using PotsAndPotions.Core.Pot;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine.Phases
{
    public class CrystalPhase : IPhase
    {
        private readonly PotStatus potStatus;
        private readonly CrystalStash crystalStash;

        public CrystalPhase(PotStatus potStatus, CrystalStash crystalStash)
        {
            this.potStatus = potStatus;
            this.crystalStash = crystalStash;
        }

        public bool IsPlayerEligible()
        {
            return true;
        }

        public void RunPhase()
        {
            if (potStatus.ScoringSlot.HasCrystal)
            {
                crystalStash.CrystalCount += 1;
            }
        }
    }
}
