using System;
using System.Collections.Generic;
using System.Text;

namespace Class2PracticeProblems
{
    public class ExerciseOne
    {
        public static void Run()
        {
            List<int> integers = SetupIntegerList();
            int sum = GetSumOfEvenIntegers(integers);
            Console.WriteLine(sum);
        }

        private static int GetSumOfEvenIntegers(List<int> integers)
        {
            int sum = 0;
            foreach(int integer in integers)
            {
                if (integer % 2 == 0)
                    sum += integer;
            }
            return sum;
        }

        private static List<int> SetupIntegerList()
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 30; i++)
                integers.Add(i);
            return integers;
        }
    }
}
