namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---- FIRST ARRAY ----
            string[] firstArray = new string[] { "math", "physics", "chemistry", "gym", "biology" };
            string minFirstArray = firstArray[0];
            string maxFirstArray = firstArray[0];
            
            for (int i = 1; i < firstArray.Length; i++)
            {
                if (minFirstArray.Length > firstArray[i].Length)
                {
                    minFirstArray = firstArray[i];
                }
                if (maxFirstArray.Length < firstArray[i].Length)
                {
                    maxFirstArray = firstArray[i];
                }
            }

            Console.WriteLine("FIRST ARRAY");
            Console.WriteLine($"The element with the minimum length in First Array is: {minFirstArray};");
            Console.WriteLine($"The element with the maximum length in First Array is: {maxFirstArray}.");
            Console.WriteLine("");

            //---- SECOND ARRAY - with additional code ----
            string[] secondArray = new string[] { "dog", "cat", "penguin", "horse", "pidgeon", "kangaroo", "crocodile", "raccoon", "fox", "squirrel" };
            string minSecondArray = secondArray[0];
            string maxSecondArray = secondArray[0];
            //variables for counting how many words there are with min/max length
            int minCount = 1;
            int maxCount = 1;

            for (int i = 1; i < secondArray.Length; i++)
            {
                if (minSecondArray.Length == secondArray[i].Length)
                {
                    minCount++;
                }
                if (maxSecondArray.Length == secondArray[i].Length)
                {
                    maxCount++;
                }
                if (minSecondArray.Length > secondArray[i].Length)
                {
                    minSecondArray = secondArray[i];
                    minCount = 1;
                } 
                if (maxSecondArray.Length < secondArray[i].Length)
                {
                    maxSecondArray = secondArray[i];
                    maxCount = 1;
                }
            }

            Console.WriteLine("SECOND ARRAY");

            //check if there is more than one word with min length
            if (minCount > 1)
            {   
                //create the array of words with min length
                string[] minWords = new string[minCount];
                int j = 0;
                for (int i = 0; i < secondArray.Length; i++)
                {   
                    if (minSecondArray.Length == secondArray[i].Length)
                    {
                        minWords[j] = secondArray[i];
                        j++;
                    }
                }
                //log on screen the array of words with min length
                Console.Write("The elements with the minimum length in Second Array are: ");
                for (int i = 0; i < minCount; i++)
                {
                    Console.Write(minWords[i] + " ");
                }
            }
            else
            {
                {
                    Console.WriteLine($"The element with the minimum length in Second Array is: {minSecondArray};");
                }
            }

            Console.WriteLine();

            //check if there is more than one word with max length
            if (maxCount > 1)
            {
                //create the array of words with max length
                string[] maxWords = new string[maxCount];
                int j = 0;
                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (maxSecondArray.Length == secondArray[i].Length)
                    {
                        maxWords[j] = secondArray[i];
                        j++;
                    }
                }
                //log on screen the array of words with max length
                Console.Write("The elements with the maximum length in Second Array are: ");
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write(maxWords[i] + " ");
                }
            }
            else
            {
                {
                    Console.WriteLine($"The element with the maximum length in Second Array is: {maxSecondArray};");
                }
            }

        }
    }
}