using System;

namespace StudentEncapApp2
{
    internal class Student
    {
        private uint _studentRollNo;
        private string _studentName;
        private double _cgpa;

        public uint StudentRollNo
        {
            get { return _studentRollNo; }
            set
            {
                if (value > 0)
                    _studentRollNo = value;
                else
                    _studentRollNo = 0;
            }
        }

        public string StudentName
        {
            get { return _studentName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 5)
                    _studentName = value;
                else
                    _studentName = "";
            }
        }

        public double CGPA
        {
            get { return _cgpa; }
            set
            {
                if (value < 1)
                    _cgpa = 1;
                else if (value > 10)
                    _cgpa = 10;
                else
                    _cgpa = value;
            }
        }

        public Student(uint rollNo, string name, double cgpa)
        {
            StudentRollNo = rollNo;   
            StudentName = name;       
            CGPA = cgpa;              
        }

        public double CalculatePercentage()
        {
            return CGPA * 10;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Roll No: {StudentRollNo}");
            Console.WriteLine($"Name: {StudentName}");
            Console.WriteLine($"CGPA: {CGPA}");
            Console.WriteLine($"Percentage: {CalculatePercentage()}%");
            Console.WriteLine();
        }
    }
}
