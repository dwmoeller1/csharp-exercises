using System;
using System.Collections.Generic;

namespace Class2PracticeProblems
{
    public class ExerciseFour
    {
        public static void Run()
        {
            Dictionary<int, string> studentNameDictionary = GetUserInput();
        }

        private static Dictionary<int, string> GetUserInput()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string studentIdString = Console.ReadLine();
            int studentId = int.Parse(studentIdString);
            string studentName = Console.ReadLine();

            students.Add(studentId, studentName);

            return students;
        }
    }
}