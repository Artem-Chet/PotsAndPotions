using Microsoft.Extensions.DependencyInjection;
using PotsAndPotions.Core.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Pot
{
    public static class PotModule
    {
        public static IServiceCollection AddPotModule(this IServiceCollection services)
        {
            services.AddScoped<Stash>();
            services.AddScoped<IResettablePerTurn>(s => s.GetRequiredService<Stash>());

            return services;
        }
    }
}
