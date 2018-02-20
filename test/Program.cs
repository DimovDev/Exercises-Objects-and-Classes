using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                string name = input[0];
                input.Remove(input[0]);
                List<double> grades = input.Select(double.Parse).ToList();
                Student student = new Student()
                {
                    Name = name,
                    Grades = grades 
                };
                students.Add(student);

            }
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].AverageGrade < 5.00)
                {
                    students.Remove(students[i]);
                }
            }

            var newList = students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();
            foreach (Student student in newList)
            {
                Console.WriteLine($"{student.Name} -> {Math.Round(student.AverageGrade, 2):0.00}");
            }
        }
    }

     class Student
    {
        public string Name { get; set; }
       
        public double AverageGrade { get; set; }
        public List<double> Grades = new List<double>();
    }
}
