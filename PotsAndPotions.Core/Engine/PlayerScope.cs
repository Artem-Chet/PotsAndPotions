using Microsoft.Extensions.DependencyInjection;
using PotsAndPotions.Core.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine
{
    public class PlayerScope
    {
        public IPlayer Player { get; }
        public IServiceScope Scope { get; }

        public PlayerScope(IPlayer player, IServiceScope scope)
        {
            Player = player;
            Scope = scope;
        }
    }
}
