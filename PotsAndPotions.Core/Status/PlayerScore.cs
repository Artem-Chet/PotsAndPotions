using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Status
{
    public class PlayerScore
    {
        public int Score { get; private set; }

        public void AddScore (int scoreToAdd)
        {
            Score += scoreToAdd;
        }
    }
}
