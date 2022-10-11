using Moq.AutoMock;
using Moq;
using PotsAndPotions.Core.Engine;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Tests.Engine
{
    public class PlayerTurnTests
    {
        [Fact]
        public void DoTurn_EndOfTurn_ResetsResettables()
        {
            var currentTurn = 3;

            var mock1 = new Mock<IResettablePerTurn>();
            var mock2 = new Mock<IResettablePerTurn>();

            var turnCounter = new TurnCounter { Turn = currentTurn };

            var mocker = new AutoMocker();
            mocker.Use<IEnumerable<IResettablePerTurn>>(new List<IResettablePerTurn> { mock1.Object, mock2.Object });

            var turn = mocker.CreateInstance<PlayerTurn>();

            turn.DoTurn();

            mock1.Verify(x => x.ResetAfterTurn(), Times.Once());
            mock2.Verify(x => x.ResetAfterTurn(), Times.Once());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoTurn_StartOfPhase_ChecksIfPhaseIsEligible(bool eligible)
        {
            var mocker = new AutoMocker();

            var phase = new Mock<IPhase>();
            phase.Setup(x => x.IsPlayerEligible())
                .Returns(eligible);

            mocker.Use<IEnumerable<IPhase>>(new List<IPhase> { phase.Object });

            var turn = mocker.CreateInstance<PlayerTurn>();

            turn.DoTurn();

            phase.Verify(x => x.IsPlayerEligible(), Times.Once());
            phase.Verify(x => x.RunPhase(), eligible ? Times.Once() : Times.Never());
        }
    }
}
