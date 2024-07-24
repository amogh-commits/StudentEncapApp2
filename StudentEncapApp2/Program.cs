using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapApp2
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "John", 8.5);
            Student student2 = new Student(2, "Jane", 11);
            Student student3 = new Student(3,"Ramesh", -10);

            
            Console.WriteLine("Student 1 details:");
            student1.PrintDetails();


            Console.WriteLine("Student 2 details:");
            student2.PrintDetails();


            Console.WriteLine("Student 3 details:");
            student3.PrintDetails();
        }
    }
}
