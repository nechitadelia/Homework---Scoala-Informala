using System.Text;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //citirea emailului de la tastatura
            Console.Write("Write the email adress you want to obfuscate: ");
            string userEmail = Console.ReadLine();

            //folosirea metodei Obfuscate si afisarea emailului
            string hiddenUserEmail = Obfuscate(userEmail);
            Console.WriteLine($"The obfuscated email is: {hiddenUserEmail}");
        }

        static string Obfuscate(string email)
        {
            StringBuilder hiddenEmail = new StringBuilder();
            bool check = false;

            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    check = true;
                }

                if (check == false)
                {
                    hiddenEmail.Append('*');
                } 
                else
                {
                    hiddenEmail.Append(email[i]);
                }
            }

            return hiddenEmail.ToString();
        }
    }
}