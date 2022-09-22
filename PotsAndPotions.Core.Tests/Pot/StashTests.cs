using NuGet.Frameworks;
using PotsAndPotions.Core.Chips;
using PotsAndPotions.Core.Color;
using PotsAndPotions.Core.Pot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Tests.Pot
{
    public class StashTests
    {
        [Fact]
        public void AddChip_NoChips_HasAChipInAllChips()
        {
            var stash = new Stash();

            Assert.Empty(stash.AllChips);

            stash.AddChip(new Chip(1, Colors.Orange, 1));

            Assert.Single(stash.AllChips);
        }

        [Fact]
        public void DrawSingle_NoChipsRemaing_OneChipRemaining()
        {
            var stash = new Stash();

            stash.AddChip(new Chip(1, Colors.Orange, 1));

            stash.DrawSingle();            

            Assert.Empty(stash.RemainingChips);

            stash.AddChip(new Chip(1, Colors.Orange, 1));

            Assert.Single(stash.RemainingChips);
        }

        [Fact]
        public void Reset_OneChipDrawn_CanDrawAgain()
        {
            var stash = new Stash();

            stash.AddChip(new Chip(1, Colors.Orange, 1));

            stash.DrawSingle();

            Assert.Empty(stash.RemainingChips);

            stash.Reset();

            Assert.Single(stash.RemainingChips);
        }

        [Fact]
        public void DrawSingle_TwoChipsRemaining_OneChipRemaining()
        {
            var stash = new Stash();

            stash.AddChip(new Chip(1, Colors.Orange, 1));
            stash.AddChip(new Chip(1, Colors.Orange, 1));

            Assert.Equal(2, stash.RemainingChips.Count);

            stash.DrawSingle();

            Assert.Single(stash.RemainingChips);
        }

        [Fact]
        public void DrawSingle_NoChipsRemaining_NoChipReturned()
        {
            var stash = new Stash();

            Assert.Empty(stash.RemainingChips);

            var drawnChip = stash.DrawSingle();

            Assert.Null(drawnChip);
        }

        [Fact]
        public void ReturnDrawn_NoChipsRemaining_1ChipRemaining()
        {
            var stash = new Stash();

            stash.AddChip(new Chip(1, Colors.Orange, 1));

            var drawnChip = stash.DrawSingle();

            Assert.NotNull(drawnChip);
            Assert.Empty(stash.RemainingChips);

            stash.ReturnDrawn(drawnChip);

            Assert.Single(stash.RemainingChips);
            Assert.Single(stash.AllChips);
        }
    }
}
