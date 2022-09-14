using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Effects
{
    public record ValueAdditionEffect(int Value) : IChipValueEffect
    {
        public int AddValue(int chipValue)
        {
            return Value;
        }
    }
}
