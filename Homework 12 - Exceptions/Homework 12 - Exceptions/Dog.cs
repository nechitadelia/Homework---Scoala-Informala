using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12___Exceptions
{
    public class Dog
    {
        //campuri
        private int _age;
        private string _name;

        //proprietati
        public int Age
        {
            get { return _age; }
            set
            {
                try
                {
                    AgeChecking(value);
                    _age = value;
                    Console.WriteLine("The age is valid.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                try
                {
                    NameChecking(value);
                    _name = value;
                    Console.WriteLine("The name is valid.");
                }
                catch(ApplicationException e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        //metode
        static void AgeChecking(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative. Choose a positive number for age!");
            }
            if (age > 100)
            {
                throw new ApplicationException("Write an age less than or equal to 100!");
            }
        }

        static void NameChecking(string name)
        {
            if (name.Length < 2)
            {
                throw new ApplicationException($"{name} is not a valid name!");
            }
        }
    }
}
