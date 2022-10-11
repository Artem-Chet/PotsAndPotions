using Autofac;
using Microsoft.Extensions.DependencyInjection;
using PotsAndPotions.Core.Engine.Phases;
using PotsAndPotions.Core.Players;
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
            builder.AddSingleton<IPlayerTurn, PlayerTurn>();

            builder.AddPotModule();
            builder.AddPhases();

            builder.AddScoped<CrystalStash>();
            builder.AddScoped<PlayerScore>();

            serviceProvider = builder.BuildServiceProvider();
        }

        public int Run()
        {
            var players = InitializePlayers();

            for (int i = 0; i < 9; i++)
            {
                var turn = serviceProvider.GetRequiredService<ITurn>();

                turn.DoTurn(players);
            }

            return 0;
        }

        public IList<PlayerScope> InitializePlayers()
        {
            return new List<PlayerScope>
            {
                new PlayerScope(new AllDefaultChoicesPlayer(), serviceProvider.CreateScope())
            };
        }
    }
}
