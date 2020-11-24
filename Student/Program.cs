using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ob1 = new Student("123", "King", 3.25);
            Student ob2 = new Student("125", "Queen", 3.5);

            Student.AddStudent(ob1);
            Student.AddStudent(ob2);

            Student.PrintAll();

            School ob3 = new School();

            ob3.Add("123", "King");
            ob3.Add("125", "Queen");

            

            ob3.Update("129", 3.5);
            ob3.Remove("129");

            ob3.Remove("123");
            

            Console.ReadKey();


        }
    }
}
