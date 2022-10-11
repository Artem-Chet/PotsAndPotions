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

        public PlayerTurn(IEnumerable<IResettablePerTurn> resettablePerTurns)
        {
            this.resettablePerTurns = resettablePerTurns;
        }

        public void DoTurn()
        {


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
