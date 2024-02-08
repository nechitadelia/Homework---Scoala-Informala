namespace Homework_10___Class_Stud
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //crearea celor 5 obiecte de tip Student
            Student[] students = new Student[5];

            for (byte i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"________STUDENT NUMBER {i+1}________");
                Console.Write("Write a name: ");
                string userName = Console.ReadLine();

                do
                {
                    Console.Write("Write an age: ");
                    bool success = byte.TryParse(Console.ReadLine(), out byte userAge);
                    students[i] = new Student(userAge, userName);
                } 
                while (students[i].Age == 0);
            }

            //afisarea informatiilor studentilor la consola
            Console.WriteLine("________STUDENTS INFO________");
            foreach (Student student in students)
            {
                Console.WriteLine(student.Info);
            }

            //citirea de la tastatura a notelor
            Console.WriteLine("________STUDENT MARKS________");
            Console.WriteLine($"Give marks for students. If not, press Enter.");

            for (byte i = 0; i < students.Length; i++)
            {
                Console.Write($"Student number {i+1}: ");
                string mark = Console.ReadLine();
                if (mark != "")
                {
                    students[i].Mark = Convert.ToByte(mark);
                }
                else
                {
                    students[i].Mark = null;
                }
            }

            //calcularea si afisarea la consola a mediei studentilor cu nota
            double sum = 0;
            byte counter = 0;

            for (byte i = 0; i < students.Length; i++)
            {
                if (students[i].Mark != null)
                {
                    sum += (double)students[i].Mark;
                    counter++;
                }
            }

            Console.WriteLine($"The average mark for all students is: {sum / counter}");
        }
    }
}
