using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core
{
    public class Pot
    {
        public static ReadOnlyCollection<PotSlot> PotSlots { get; } = Array.AsReadOnly(new PotSlot[54]
        {
            new PotSlot{Coins = 0, Points = 0, HasCrystal = false},
            new PotSlot{Coins = 1, Points = 0, HasCrystal = false},
            new PotSlot{Coins = 2, Points = 0, HasCrystal = false},
            new PotSlot{Coins = 3, Points = 0, HasCrystal = false},
            new PotSlot{Coins = 4, Points = 0, HasCrystal = false},
            new PotSlot{Coins = 5, Points = 0, HasCrystal = true},            
            new PotSlot{Coins = 6, Points = 1, HasCrystal = false},
            new PotSlot{Coins = 7, Points = 1, HasCrystal = false},
            new PotSlot{Coins = 8, Points = 1, HasCrystal = false},
            new PotSlot{Coins = 9, Points = 1, HasCrystal = false},
            new PotSlot{Coins = 10, Points = 2, HasCrystal = false},
            new PotSlot{Coins = 11, Points = 2, HasCrystal = false},            
            new PotSlot{Coins = 12, Points = 2, HasCrystal = false},
            new PotSlot{Coins = 13, Points = 2, HasCrystal = true},
            new PotSlot{Coins = 14, Points = 3, HasCrystal = false},
            new PotSlot{Coins = 15, Points = 3, HasCrystal = false},
            new PotSlot{Coins = 15, Points = 3, HasCrystal = true},
            new PotSlot{Coins = 16, Points = 3, HasCrystal = false},            
            new PotSlot{Coins = 16, Points = 4, HasCrystal = false},
            new PotSlot{Coins = 17, Points = 4, HasCrystal = false},
            new PotSlot{Coins = 17, Points = 4, HasCrystal = true},
            new PotSlot{Coins = 18, Points = 4, HasCrystal = false},
            new PotSlot{Coins = 18, Points = 5, HasCrystal = false},
            new PotSlot{Coins = 19, Points = 5, HasCrystal = false},            
            new PotSlot{Coins = 19, Points = 5, HasCrystal = true},
            new PotSlot{Coins = 20, Points = 5, HasCrystal = false},
            new PotSlot{Coins = 20, Points = 6, HasCrystal = false},
            new PotSlot{Coins = 21, Points = 6, HasCrystal = false},            
            new PotSlot{Coins = 21, Points = 6, HasCrystal = true},
            new PotSlot{Coins = 22, Points = 7, HasCrystal = false},
            new PotSlot{Coins = 22, Points = 7, HasCrystal = true},
            new PotSlot{Coins = 23, Points = 7, HasCrystal = false},
            new PotSlot{Coins = 23, Points = 8, HasCrystal = false},
            new PotSlot{Coins = 24, Points = 8, HasCrystal = false},            
            new PotSlot{Coins = 24, Points = 8, HasCrystal = true},
            new PotSlot{Coins = 25, Points = 9, HasCrystal = false},
            new PotSlot{Coins = 25, Points = 9, HasCrystal = true},
            new PotSlot{Coins = 26, Points = 9, HasCrystal = false},            
            new PotSlot{Coins = 26, Points = 10, HasCrystal = false},
            new PotSlot{Coins = 27, Points = 10, HasCrystal = false},
            new PotSlot{Coins = 27, Points = 10, HasCrystal = true},
            new PotSlot{Coins = 28, Points = 11, HasCrystal = false},
            new PotSlot{Coins = 28, Points = 11, HasCrystal = true},
            new PotSlot{Coins = 29, Points = 11, HasCrystal = false},
            new PotSlot{Coins = 29, Points = 12, HasCrystal = false},
            new PotSlot{Coins = 30, Points = 12, HasCrystal = false},
            new PotSlot{Coins = 30, Points = 12, HasCrystal = true},
            new PotSlot{Coins = 31, Points = 12, HasCrystal = false},
            new PotSlot{Coins = 31, Points = 13, HasCrystal = false},
            new PotSlot{Coins = 32, Points = 13, HasCrystal = false},
            new PotSlot{Coins = 32, Points = 13, HasCrystal = true},
            new PotSlot{Coins = 33, Points = 14, HasCrystal = false},
            new PotSlot{Coins = 33, Points = 14, HasCrystal = true},
            new PotSlot{Coins = 35, Points = 15, HasCrystal = false},
        });


        public int BaseFirstChipSlot { get; private set; }
        public int BonusFirstChipSlot { get; private set; }
        public int TotalFirstChipSlot => 0;
    }
}
