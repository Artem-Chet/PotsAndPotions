using Autofac.Core;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.AutoMock;
using PotsAndPotions.Core.Engine;
using PotsAndPotions.Core.Players;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Tests.Engine
{
    public class TurnTests
    {
        [Fact]
        public void DoTurn_EndOfTurn_TurnCounterIncremented()
        {
            var currentTurn = 3;
            var turnCounter = new TurnCounter { Turn = currentTurn };

            var mocker = new AutoMocker();
            mocker.Use(turnCounter);

            var turn = mocker.CreateInstance<Turn>();

            turn.DoTurn(new List<PlayerScope>());

            Assert.Equal(currentTurn + 1, turnCounter.Turn);
        }

        [Fact]
        public void DoTurn_MultiplePlayers_PlayerTurnPerPlayer()
        {
            var mocker = new AutoMocker();

            var playerTurn1 = new Mock<IPlayerTurn>();
            var playerTurn2 = new Mock<IPlayerTurn>();

            var services1 = new ServiceCollection();
            services1.AddScoped(x => playerTurn1.Object);

            var services2 = new ServiceCollection();
            services2.AddScoped(x => playerTurn2.Object);

            var scope1 = services1.BuildServiceProvider().CreateScope();
            var scope2 = services2.BuildServiceProvider().CreateScope();

            var playerScopes = new List<PlayerScope>
            {
                 new PlayerScope(new Mock<IPlayer>().Object, scope1),
                 new PlayerScope(new Mock<IPlayer>().Object, scope2)
            };

            var turn = mocker.CreateInstance<Turn>();

            turn.DoTurn(playerScopes);

            playerTurn1.Verify(x => x.DoTurn());
            playerTurn2.Verify(x => x.DoTurn());
        }
    }
}
