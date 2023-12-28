using System.Text;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //citirea si declararea string-ului
            Console.Write("Hello! Write a word/text: ");
            string userText = Console.ReadLine().ToLower();

            //aplicarea celor doua metode: eliminarea non-caracterelor din string si inversarea stringului
            string userTextCompressed = RemoveNonLetters(userText);
            string userTextReversed = ReverseString(userText);

            //compararea stringurilor
            int result = string.Compare(userTextCompressed, userTextReversed, true);

            //afisarea rezultatului
            if (result == 0)
            {
                Console.WriteLine("Nice! The word/text is a palindrom!");
            } else
            {
                Console.WriteLine("Sorry, the word/text is not a palindrom!");
            }
        }

        //metoda care elimina spatiile si caracterele speciale dintr-un string
        public static string RemoveNonLetters(string text)
        {
            StringBuilder sb = new StringBuilder();
            string alphabet = "abcdefghijklmnopqrstuvxyz";

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (alphabet.IndexOf(letter) != -1)
                {
                    sb.Append(text[i]);
                }
            }

            return sb.ToString();
        }

        //metoda care inverseaza un string
        public static string ReverseString(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);      
            }

            string textReversed = RemoveNonLetters(sb.ToString());

            return textReversed;
        }
    }
}