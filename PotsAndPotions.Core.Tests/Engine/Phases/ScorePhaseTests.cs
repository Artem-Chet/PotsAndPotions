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
    public class ScorePhaseTests
    {
        [Fact]
        public void IsPlayerEligible_NotSpoiled_True()
        {
            var mocker = new AutoMocker();

            var spoiledState = new SpoiledStatus();

            mocker.Use(spoiledState);

            var phase = mocker.CreateInstance<ScorePhase>();

            var result = phase.IsPlayerEligible();

            Assert.True(result);
        }

        [Fact]
        public void IsPlayerEligible_SpoiledScoreChosen_True()
        {
            var mocker = new AutoMocker();

            var spoiledState = new SpoiledStatus();

            mocker.Use(spoiledState);
            spoiledState.Spoil(SpoiledChosenPhase.Score);

            var phase = mocker.CreateInstance<ScorePhase>();

            var result = phase.IsPlayerEligible();

            Assert.True(result);
        }

        [Fact]
        public void IsPlayerEligible_SpoiledPurchaseChosen_False()
        {
            var mocker = new AutoMocker();

            var spoiledState = new SpoiledStatus();

            mocker.Use(spoiledState);
            spoiledState.Spoil(SpoiledChosenPhase.Purchase);

            var phase = mocker.CreateInstance<ScorePhase>();

            var result = phase.IsPlayerEligible();

            Assert.False(result);
        }

        [Fact]
        public void RunPhase_Scored_ScoreMatchesSpot()
        {
            var mocker = new AutoMocker();

            var expectedScore = 5;
            var score = new PlayerScore();
            mocker.Use(score);

            mocker.Use(new PotStatus { ScoringSlot = new PotSlot { Points = expectedScore } });

            var phase = mocker.CreateInstance<ScorePhase>();

            phase.RunPhase();

            Assert.Equal(expectedScore, score.Score);
        }
    }
}
