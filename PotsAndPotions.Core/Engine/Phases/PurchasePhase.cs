using PotsAndPotions.Core.Pot;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine.Phases
{
    public class PurchasePhase : IPhase
    {
        private readonly SpoiledStatus spoiledStatus;
        private readonly TurnCounter turnCounter;
        private readonly PotStatus potStatus;
        private readonly PlayerScore playerScore;

        public PurchasePhase(SpoiledStatus spoiledStatus, TurnCounter turnCounter, PotStatus potStatus, PlayerScore playerScore)
        {
            this.spoiledStatus = spoiledStatus;
            this.turnCounter = turnCounter;
            this.potStatus = potStatus;
            this.playerScore = playerScore;
        }

        public void RunPhase()
        {
            if (turnCounter.IsLastTurn)
            {
                playerScore.AddScore(potStatus.ScoringSlot.Coins / 5);
                return;
            }
        }

        public bool IsPlayerEligible()
        {
            if (!spoiledStatus.IsSpoiled)
            {
                return true;
            }

            return spoiledStatus.ChosenPhase == SpoiledChosenPhase.Purchase;
        }
    }
}
