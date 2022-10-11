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

        public Turn (TurnCounter turnCounter)
        {
            this.turnCounter = turnCounter;
        }

        public void DoTurn(IList<PlayerScope> playerScopes)
        {
            foreach(var playerScope in playerScopes)
            {
                var playerTurn = playerScope.Scope.ServiceProvider.GetRequiredService<IPlayerTurn>();

                playerTurn.DoTurn();
            }

            turnCounter.Turn += 1;
        }
    }
}
