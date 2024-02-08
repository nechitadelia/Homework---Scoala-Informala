using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10___Class_Stud
{
    public class Student
    {
        //campuri
        private byte _age;
        private string _name;
        private const byte MIN_AGE = 18;
        private const byte MAX_AGE = 99;


        //proprietati
        public byte Age
        {
            get { return _age; }
            set
            {   
                if (value >= MIN_AGE && value <= MAX_AGE)
                {
                    _age = value;
                } 
                else
                {
                    Console.WriteLine("Incorrect input! Write an age between 18-99!");
                }
            }
        }
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public byte? Mark { get; set; }
        public dynamic Info
        {
            get { return $"Name: {Name};\n Age: {Age}."; }
        }

        //constructor
        public Student(byte age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
