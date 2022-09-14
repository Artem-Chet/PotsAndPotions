using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Status
{
    public class TurnCounter
    {
        public int Turn { get; set; }

        public bool IsLastTurn => Turn == 8; 
    }
}
