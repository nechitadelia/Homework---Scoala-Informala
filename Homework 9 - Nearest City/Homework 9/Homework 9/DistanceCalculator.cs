using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    static class DistanceCalculator
    {
        public static double CalculateDistance(Coordinates pct1, Coordinates pct2)
        {
            return Math.Sqrt(Math.Pow(pct1.X - pct2.X, 2) + Math.Pow(pct1.Y - pct2.Y, 2));
        }
    }
}
