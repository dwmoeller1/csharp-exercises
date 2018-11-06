using System;
using System.Collections.Generic;

namespace Class2PracticeProblems
{
    public class ExerciseFour
    {
        public static Dictionary<int, string> students = new Dictionary<int, string>();

        public static void Run()
        {
            GetUserInput();
            PrintStudents();

        }

        private static void GetUserInput()
        {
            int studentId = GetStudentId();
            string studentName = GetStudentName();

            students.Add(studentId, studentName);

            if (DoAnotherStudent())
                GetUserInput();
        }

        private static int GetStudentId()
        {
            Console.WriteLine("Enter a student ID:");
            string studentIdString = Console.ReadLine();
            int studentId = int.Parse(studentIdString);
            return studentId;
        }

        private static string GetStudentName()
        {
            Console.WriteLine("Enter student name:");
            string studentName = Console.ReadLine();
            return studentName;
        }

        private static bool DoAnotherStudent()
        {
            Console.WriteLine("Enter another student (y/n)?:");
            string doAnother = Console.ReadLine();
            return doAnother == "y";
        }

        private static void PrintStudents()
        {
            Console.WriteLine("Do you wish to print the student list (y/n)?");
            if(Console.ReadLine().ToLower() == "y")
            {
                foreach (KeyValuePair<int, string> student in students)
                    Console.WriteLine($"Student id = {student.Key}; Student Name = {student.Value}");
            }
        }

    }
}