using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student: AbsStudent
    {
        protected string id, name;
        internal double cgpa;

        internal static Student[] slist = new Student[2];
        static int count = 0; 
        public Student()
        {

        }

        public Student(string id, string name, double cgpa)
        {
            this.id = id;
            this.name = name;
            this.cgpa = cgpa;
        }



        public override string ID { get { return id; } }

        public override string Name { get { return name; } set { this.name = value; } }

        public override double Cgpa { get { return cgpa; }  }

        public override void print()
        {
            Console.WriteLine("Student's ID: " + this.id);
            Console.WriteLine("Student's Name: " + this.name);
            Console.WriteLine("Student's CGPA: " + this.cgpa);
            Console.WriteLine("");
        }

        public static void PrintAll()
        {
            for (int i=0 ; i< slist.Length;i++)
            {
             
                
                    slist[i].print();
                
                
            }
        }

        public static void AddStudent(Student s)
        {
            slist[count++] = s;

            Console.WriteLine("Student Added");
        }
    }
}
