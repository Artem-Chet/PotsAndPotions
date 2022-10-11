using Autofac;
using Microsoft.Extensions.DependencyInjection;
using PotsAndPotions.Core.Pot;
using PotsAndPotions.Core.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine
{
    public class Game
    {
        private readonly ServiceProvider serviceProvider;

        public Game()
        {
            var builder = new ServiceCollection();

            // Scope is per player for the entire game. It is up to the turn to reset state per turn.

            builder.AddSingleton<TurnCounter>();
            builder.AddSingleton<ITurn, Turn>();

            builder.AddPotModule();

            serviceProvider = builder.BuildServiceProvider();
        }

        public int Run()
        {
            for (int i = 0; i < 9; i++)
            {
                var turn = serviceProvider.GetRequiredService<ITurn>();

                turn.DoTurn();
            }

            return 0;
        }
    }
}
