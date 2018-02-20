using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Average_Grades
{
    class Student
    {
        public string name;
        public List<double> grades = new List<double>();
        public double average;
    }

    class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List<Student> excellentStudents = new List<Student>();


            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentData = Console.ReadLine().Split().ToArray();

                Student next = new Student();

                next.name = studentData[0];

                for (int j = 1; j < studentData.Length; j++)
                {
                    next.grades.Add(Convert.ToDouble(studentData[j]));
                }

                next.average = next.grades.Average();

                if (next.average >= 5.00)
                {
                    excellentStudents.Add(next);
                }
            }
            excellentStudents = excellentStudents.OrderBy(x => x.name).ThenByDescending(x => x.average).ToList();

            foreach (var baba in excellentStudents)
            {
                Console.WriteLine("{0} -> {1:f2}", baba.name, baba.average);
            }
        }
    }
}
