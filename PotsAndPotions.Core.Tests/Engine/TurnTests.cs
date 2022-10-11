﻿using Moq;
using Moq.AutoMock;
using PotsAndPotions.Core.Engine;
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

            turn.DoTurn();

            Assert.Equal(currentTurn + 1, turnCounter.Turn);
        }

        [Fact]
        public void DoTurn_EndOfTurn_ResetsResettables()
        {
            var currentTurn = 3;

            var mock1 = new Mock<IResettablePerTurn>();                 
            var mock2 = new Mock<IResettablePerTurn>();                 

            var turnCounter = new TurnCounter { Turn = currentTurn };

            var mocker = new AutoMocker();
            mocker.Use<IEnumerable<IResettablePerTurn>>(new List<IResettablePerTurn> { mock1.Object, mock2.Object});

            var turn = mocker.CreateInstance<Turn>();

            turn.DoTurn();

            mock1.Verify(x => x.ResetAfterTurn(), Times.Once());
            mock2.Verify(x => x.ResetAfterTurn(), Times.Once());
        }
    }
}
