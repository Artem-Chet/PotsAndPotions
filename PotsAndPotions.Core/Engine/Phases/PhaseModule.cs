using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Engine.Phases
{
    public static class PhaseModule
    {
        public static IServiceCollection AddPhases(this IServiceCollection services)
        {            
            services.AddScoped<IPhase, AlchemyPhase>();
            services.AddScoped<IPhase, LeadBonusPhase>();
            services.AddScoped<IPhase, ChipBonusPhase>();
            services.AddScoped<IPhase, CrystalPhase>();
            services.AddScoped<IPhase, ScorePhase>();
            services.AddScoped<IPhase, PurchasePhase>();

            return services;
        }
    }
}
