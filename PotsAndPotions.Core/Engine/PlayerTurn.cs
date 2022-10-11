using Microsoft.Extensions.DependencyInjection;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine
{
    public class PlayerTurn : IPlayerTurn
    {
        private readonly IEnumerable<IResettablePerTurn> resettablePerTurns;
        private readonly IEnumerable<IPhase> phases;

        public PlayerTurn(IEnumerable<IResettablePerTurn> resettablePerTurns, IEnumerable<IPhase> phases)
        {
            this.resettablePerTurns = resettablePerTurns;
            this.phases = phases;
        }

        public void DoTurn()
        {
            foreach(var phase in phases)
            {
                if (phase.IsPlayerEligible())
                {
                    phase.RunPhase();
                }
            }

            ResetResettables();
        }

        private void ResetResettables()
        {
            foreach(var resettable in resettablePerTurns)
            {
                resettable.ResetAfterTurn();
            }
        }
    }
}
