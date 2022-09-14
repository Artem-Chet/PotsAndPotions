using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Status
{
    public class SpoiledStatus
    {
        public bool IsSpoiled { get; private set; }

        public SpoiledChosenPhase ChosenPhase { get; private set; }

        public void Spoil(SpoiledChosenPhase chosenPhase)
        {
            IsSpoiled = true;
            ChosenPhase = chosenPhase;
        }
    }

    public enum SpoiledChosenPhase
    {
        Score,
        Purchase,
    }
}
