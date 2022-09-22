using PotsAndPotions.Core.Chips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Pot
{
    public class Stash
    {
        private Random random = new Random();

        public List<IChip> AllChips { get; } = new List<IChip>();

        public List<IChip> RemainingChips { get; private set; } = new List<IChip>();
        
        public void Reset()
        {
            RemainingChips = AllChips.ToList();
        }

        public IChip? DrawSingle()
        {
            if(RemainingChips.Count == 0)
            {
                return null;
            }

            var chipIndex = random.Next(0, RemainingChips.Count - 1);
            var chip = RemainingChips[chipIndex];
            RemainingChips.RemoveAt(chipIndex);
            return chip;
        }

        public void ReturnDrawn(IChip chip)
        {
            RemainingChips.Add(chip);
        }

        public void AddChip(IChip chip)
        {
            AllChips.Add(chip);
            RemainingChips.Add(chip);
        }
    }
}
