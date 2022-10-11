using Microsoft.Extensions.DependencyInjection;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine
{
    public class Turn : ITurn
    {
        private readonly TurnCounter turnCounter;
        private readonly IEnumerable<IResettablePerTurn> resettablePerTurns;

        public Turn (TurnCounter turnCounter, IEnumerable<IResettablePerTurn> resettablePerTurns)
        {
            this.turnCounter = turnCounter;
            this.resettablePerTurns = resettablePerTurns;
        }

        public void DoTurn()
        {


            ResetResettables();

            turnCounter.Turn += 1;
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
