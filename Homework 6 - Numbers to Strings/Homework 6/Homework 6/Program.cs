namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //citirea unui numar de la tastatura
            Console.Write("Write a number from 0 to 9999: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int copyNumber = number;
            string numberText = "";

            //declararea array-urilor cu numere
            string[] arrayOneDigit = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string[] arrayTens = {"", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] arrayTwoDigits = {"", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};

            //conversia numarului in text

            //conversia pentru mii
            if (copyNumber / 1000 > 0) 
            {   
                byte digit = (byte)(copyNumber / 1000);
                
                numberText = arrayOneDigit[digit] + " thousand ";

                copyNumber %= 1000;
            }

            //conversia pentru sute
            if (copyNumber / 100 > 0) 
            {
                byte digit = (byte)(copyNumber / 100);
                
                numberText += arrayOneDigit[digit] + " hundred ";

                copyNumber %= 100;
            }

            //conversia pentru zeci (numere cuprinse intre 20 - 99)
            if (copyNumber / 10 > 0 && copyNumber >= 20) 
            {
                byte digit = (byte)(copyNumber / 10);

                numberText += arrayTwoDigits[digit] + " ";

                copyNumber %= 10;
            }

            //conversia pentru zeci (numere cuprinse intre 10 - 19)
            if (copyNumber / 10 > 0 && copyNumber < 20) 
            {
                byte digit = (byte)(copyNumber % 10);

                numberText += arrayTens[digit + 1];

                copyNumber = 0;
            }

            //conversia pentru numerele cu o singura cifra
            if (copyNumber > 0) 
            {
                byte digit = (byte)(copyNumber);

                if (digit != 0)
                {
                    numberText += arrayOneDigit[digit];
                }        
            }

            //conversia pentru un numar egal cu zero
            if (number == 0) 
            {
                numberText = "zero";
            }

            //afisarea rezultatului
            Console.WriteLine($"The number {number} in words is written as: {numberText}");
        }
    }
}