using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine
{
    public class Game
    {
        public Game()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Turn>().As<ITurn>();
        }

        public int Run()
        {
            for(int i = 0; i < 9; i++)
            {
                var turn = new Turn();
                
            }

            return 0;
        }
    }
}
