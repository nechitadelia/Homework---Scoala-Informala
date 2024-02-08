using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11___Classes_Light
{
    static class Afisare
    {
        public static void StareCandelabre(Candelabru[] cand)
        {
            foreach (Candelabru c in cand)
            {
                c.AfiseazaStare();
            }
            Console.WriteLine();
        }

        public static void PutereCurenta(Candelabru[] cand)
        {
            foreach (Candelabru c in cand)
            {
                Console.WriteLine($"Candelabrul {c.Id} are puterea curenta: {c.PutereCurenta}.");
            }
            Console.WriteLine();
        }

        public static void PutereMaxima(Candelabru[] cand)
        {
            foreach (Candelabru c in cand)
            {
                Console.WriteLine($"Candelabrul {c.Id} are puterea maxima: {c.PutereMaxima}.");
            }
            Console.WriteLine();
        }
    }
}
