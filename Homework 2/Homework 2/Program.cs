namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read the array length and its elements
            Console.Write("Introdu un numar intreg pozitiv de la tastatura: ");
            uint arrayLength = uint.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            for(int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Introdu elementul numarul {i+1} din array: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            //calculate and display the min and the max of the array elements
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < arrayLength; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Elementul cel mai mic din array este: {min}");
            Console.WriteLine($"Elementul cel mai mare din array este: {max}");
        }
    }
}