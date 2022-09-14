using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotsAndPotions.Core.Color
{
    public static class Colors
    {
        public static IColor Orange { get; } = new Orange();
        public static IColor Red { get; } = new Red();
        public static IColor Blue { get; } = new Blue();
        public static IColor Green { get; } = new Green();
        public static IColor White { get; } = new White();
        public static IColor Purple { get; } = new Purple();
        public static IColor Black { get; } = new Black();
        public static IColor Yellow { get; } = new Yellow();
    }
}
