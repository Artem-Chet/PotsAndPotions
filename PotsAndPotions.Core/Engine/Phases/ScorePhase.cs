using PotsAndPotions.Core.Pot;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine.Phases
{
    public class ScorePhase : IPhase
    {
        private readonly SpoiledStatus spoiledStatus;
        private readonly PlayerScore playerScore;
        private readonly PotStatus potStatus;

        public ScorePhase(SpoiledStatus spoiledStatus, PlayerScore playerScore, PotStatus potStatus)
        {
            this.spoiledStatus = spoiledStatus;
            this.playerScore = playerScore;
            this.potStatus = potStatus;
        }

        public void RunPhase()
        {
            playerScore.AddScore(potStatus.ScoringSlot.Points);
        }

        public bool IsPlayerEligible()
        {
            if (!spoiledStatus.IsSpoiled)
            {
                return true;
            }

            return spoiledStatus.ChosenPhase == SpoiledChosenPhase.Score;
        }
    }
}
