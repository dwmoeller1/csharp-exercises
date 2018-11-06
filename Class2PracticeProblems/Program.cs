using System;
using System.Linq;

namespace Class2PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                if (arg == "1")
                    ExerciseOne.Run();
                else if (arg == "2")
                    ExerciseTwo.Run();
                else if (arg == "3")
                    ExerciseThree.Run();
                else if (arg == "4")
                    ExerciseFour.Run();
                else
                    RunAll();                
            }
        }

        public static void RunAll()
        {
            ExerciseOne.Run();
            ExerciseTwo.Run();
            ExerciseThree.Run();
            ExerciseFour.Run();
        }
    }
}
