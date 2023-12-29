using System.Text;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //citirea stringului de la tastatura
            Console.Write("Hello! Write a word / text: ");
            string text = Console.ReadLine();

            //conversia stringului
            string alphabet = "abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVXYZ"; //string creat pentru verificare
            StringBuilder sb = new StringBuilder(); //declararea noului string
            
            for (int i = 0; i < text.Length; i++)
            {   
                if (alphabet.IndexOf(text[i]) != -1)
                {
                    int letterValue = (int)text[i] + 3;
                    char letter = (char)letterValue;
                    sb.Append(letter);
                } else
                {
                    sb.Append(text[i]);
                }
            }

            //afisarea noului string
            Console.WriteLine(sb.ToString());
        }
    }
}