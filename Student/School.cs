using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class School: ISchool 
    {

        
        
        static int count = -1;

        Student[] newstudent = new Student[2];
        public bool Add(string id, string name)
        {

            bool k = true;
            int i = ++count;
            newstudent[i] = new Student(id, name, 0);

            

            Console.WriteLine("New Student Added to School");
            return k;
        }

        public bool Remove(string id)
        {
            bool k = true;
            for(int i=0;i<newstudent.Length;i++)
            {
                if (newstudent[i].ID == id)
                {
                    newstudent[i] = null;
                    k = true;
                    break;
                }
                else
                {
                    k = false;
                    continue;
                    
                }
            }
            if(k == true)
            {
                Console.WriteLine("Student Found And Removed");

            }
            else
            {
                Console.WriteLine("Student Not Found");
            }

            return k;
        }


        public bool Update(string id, double cgpa)
        {
            bool k = true;
            for (int i = 0; i < newstudent.Length; i++)
            { if (newstudent[i].ID == id)
                {
                    newstudent[i].cgpa = cgpa;
                    k = true;
                    break;
                }
                else
                {
                    k = false;
                    continue;

                }

            }

            if (k == true)
            {
                Console.WriteLine("Student Found and CGPA Updated");

            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
            return k;
        }

        //public bool Add(string id, string name)
        //{
        //    bool k = true;
        //    for (int i=0;i<Student.slist.Length;i++)
        //    {
                
                
        //        if(slist[i] == null)
        //        {
        //            continue;
        //        }
        //        if (slist[i].ID == id && slist[i].Name == name)
        //        {

        //            students[++count] = (School)slist[i];
        //            k = true;
        //            break;
        //        }

        //        else
        //        {
        //            k = false;
        //        }
        //    }
            
        //    if(k == true)
        //    {
        //        Console.WriteLine("Student Added to School");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student Not Found");
        //    }

            

        //    return k;
        //}

        

        //public bool Remove(string id)
        //{
        //    bool k = true;
        //    for(int i =0;i<slist.Length;i++)
        //    {
        //        if (Check(students[i], id) == true)
        //        {
        //            students[i] = null;
        //            k = true;
        //        }
        //        else if(students[i] == null)
        //        {
        //            k = false;
        //            continue;
        //        }
        //        else
        //        {
        //            k = false;
        //        }
        //    }

        //    if (k == true)
        //    {
        //        Console.WriteLine("Student Removed from School");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student Not Found");
        //    }

        //    return k;
        //}

        //public static bool Check(School c, string id)
        //{
        //    bool k;
        //    if (c.ID == id)
        //    {
        //        k = true;
        //    }
        //    else
        //    {
        //        k = false;
        //    }
        //    return k;
        //}

        //public bool Update(string id, double cgpa)
        //{
        //    bool k = true;
        //    for(int i=0; i<students.Length;i++)
        //    {
        //        if(students[i].ID == id)
        //        {
        //            students[i].cgpa = cgpa;
        //            k = true;
        //        }
        //        else if(students[i] == null)
        //        {
        //            k = false;
        //            continue;
        //        }
        //        else
        //        {
        //            k = false;
        //        }
        //    }

        //    if (k == true)
        //    {
        //        Console.WriteLine("Student CGPA Updated");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student Not Found");
        //    }

        //    return k;
        //}

    }
}
