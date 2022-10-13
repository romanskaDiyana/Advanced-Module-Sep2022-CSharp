using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Average Student Grades
            //Create a program, which reads a name of a student and his/her grades and adds them to the student record, then prints the students' names with their grades and their average grade.

            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            StudentsGradesInformation(numberOfStudents, studentsGrades);

            PrintStudentGrades(studentsGrades);

        }

        static void StudentsGradesInformation(int numberOfStudents, Dictionary<string, List<decimal>> studentsGrades)
        {
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split();
                string currStudentName = studentsInfo[0];
                decimal currStudentGrade = decimal.Parse(studentsInfo[1]);

                if (!studentsGrades.ContainsKey(currStudentName))
                {
                    studentsGrades.Add(currStudentName, new List<decimal>());
                }

                studentsGrades[currStudentName].Add(currStudentGrade);
            }
        }

        static void PrintStudentGrades(Dictionary<string, List<decimal>> studentsGrades)
        {
            foreach (var student in studentsGrades)
            {
                var averageGrade = student.Value.Average();

                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value)} (avg: {averageGrade:f2})");
            }
        }
    }
}
