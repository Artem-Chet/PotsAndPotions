﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine
{
    public interface IPhase
    {
        void RunPhase();
        bool IsPlayerEligible();
    }
}
