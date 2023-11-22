namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //declarare variabile
            Console.Write("Declara valoarea lui a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Declara valoarea lui b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Declara valoarea lui c: ");
            int c = int.Parse(Console.ReadLine());
            double x1;
            double x2;
            int delta = b * b - 4 * a * c;

            //calculare si afisare rezultate
            if (delta < 0)
            {
                Console.WriteLine("Ecuatia nu are solutii reale.");
            } else if (delta == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine($"Ecuatia are doua solutii egale: x1 = x2 = {x1}");
            } else
            {
                x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine($"Ecuatia are doua solutii distincte: x1 = {x1} si x2 = {x2}");
            }
        }
    }
}