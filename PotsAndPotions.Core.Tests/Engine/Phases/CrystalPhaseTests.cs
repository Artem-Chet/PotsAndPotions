using Moq.AutoMock;
using PotsAndPotions.Core.Engine;
using PotsAndPotions.Core.Engine.Phases;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Tests.Engine.Phases
{
    public class CrystalPhaseTests
    {
        [Fact]
        public void RunPhase_CrystalScoring_CrystalAdded()
        {
            var mocker = new AutoMocker();

            mocker.Use(new PotStatus { ScoringSlot = new PotSlot { HasCrystal = true } });

            var crystalStash = new CrystalStash() { CrystalCount = 5 };
            mocker.Use(crystalStash);

            var phase = mocker.CreateInstance<CrystalPhase>();

            phase.RunPhase();

            Assert.Equal(6, crystalStash.CrystalCount);
        }
    }
}
