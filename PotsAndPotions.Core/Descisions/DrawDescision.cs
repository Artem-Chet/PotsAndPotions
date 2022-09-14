using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Descisions
{
    public class DrawDescision : IDescision<DrawDescisionOptions>
    {
        public void Descide(DrawDescisionOptions descision)
        {
            throw new NotImplementedException();
        }
    }

    public enum DrawDescisionOptions
    {
        Draw,
        Stop
    }
}
