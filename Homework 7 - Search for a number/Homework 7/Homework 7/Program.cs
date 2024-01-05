namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //citirea unui numar de la tastatura
            Console.Write("Hello! Write a number: ");
            int number = int.Parse(Console.ReadLine());

            //declararea array-ului de numere
            int[] numberArray = new int[10] { 34, 643, -521, 76, 12, 0, 782, 97, 51, 74 };

            //cautarea numarului in array
            int result = SearchNumber(number, numberArray);

            //afisarea rezultatului
            if (result == -1)
            {
                Console.WriteLine("Sorry, the number was not found in the array.");
            } else
            {
                Console.WriteLine($"The number was found in the array at index: {result}");
            }

        }

        static int SearchNumber(int num, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}