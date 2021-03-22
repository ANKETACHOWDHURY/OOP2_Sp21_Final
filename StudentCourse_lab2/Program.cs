using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student s1 = new Student("Anketa", "111", 3.0F);
            Student s2 = new Student("Anketa Chowdhury", "201", 3.5F);
            Student s3 = new Student("Anketa Chowdhury", "202", 3.25F);
            Student s4 = new Student("Anketa Chowdhury", "203", 3.15F);
            Student s5 = new Student("Anketa Chowdhury", "204", 3.85F);
            Student s6 = new Student("Anketa Chowdhury", "205", 3.24F);
            Student s7 = new Student("Anketa Chowdhury", "206", 3.68F);


            

            Course c1 = new Course("CSC201", "OOP 2");
            Course c2 = new Course("CSC202", "Algorithm");
            Course c3 = new Course("CSC203", "OOAD");


           
            c1.AddStudent(s3, s5, s6, s7);

            c1.PrintStudent();

            c1.RemoveStudent(s4);

            Console.WriteLine("\nAfter Remove Student..................\n");

            s5.PrintCourse();
            c1.PrintStudent();

            Console.WriteLine("\n.............................\n");

            s2.AddCourse(c1, c2, c3);
            s2.PrintCourse();

            s2.RemoveCourse(c3);
            Console.WriteLine("\nAfter Remove Course..................\n");
            s2.PrintCourse();
            c2.PrintStudent();
        }
    }
}
