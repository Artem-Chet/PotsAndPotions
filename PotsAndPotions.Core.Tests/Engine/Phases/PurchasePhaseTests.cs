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
    public class PurchasePhaseTests
    {
        [Fact]
        public void IsPlayerEligible_NotSpoiled_True()
        {
            var mocker = new AutoMocker();

            var spoiledState = new SpoiledStatus();

            mocker.Use(spoiledState);

            var phase = mocker.CreateInstance<PurchasePhase>();

            var result = phase.IsPlayerEligible();

            Assert.True(result);
        }

        [Fact]
        public void IsPlayerEligible_SpoiledScoreChosen_True()
        {
            var mocker = new AutoMocker();

            var spoiledState = new SpoiledStatus();

            mocker.Use(spoiledState);
            spoiledState.Spoil(SpoiledChosenPhase.Purchase);

            var phase = mocker.CreateInstance<PurchasePhase>();

            var result = phase.IsPlayerEligible();

            Assert.True(result);
        }

        [Fact]
        public void IsPlayerEligible_SpoiledPurchaseChosen_False()
        {
            var mocker = new AutoMocker();

            var spoiledState = new SpoiledStatus();

            mocker.Use(spoiledState);
            spoiledState.Spoil(SpoiledChosenPhase.Score);

            var phase = mocker.CreateInstance<PurchasePhase>();

            var result = phase.IsPlayerEligible();

            Assert.False(result);
        }

        [Fact]
        public void RunPhase_LastTurn_AddsScore()
        {
            var mocker = new AutoMocker();

            var expectedScore = 5;
            var score = new PlayerScore();
            mocker.Use(score);

            mocker.Use(new PotStatus { ScoringSlot = new PotSlot { Coins = 26 } });
            mocker.Use(new TurnCounter { Turn = 8 });

            var phase = mocker.CreateInstance<PurchasePhase>();

            phase.RunPhase();

            Assert.Equal(expectedScore, score.Score);
        }
    }
}
