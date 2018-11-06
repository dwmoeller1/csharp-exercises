using System;
using System.Collections.Generic;
using System.Text;

namespace Class2PracticeProblems
{
    public class ExerciseTwo
    {
        public static void Run()
        {
            List<string> words = GetList();
            List<string> wordsOfExcatlyFiveLetters = GetWordsOfFiveLetter(words);
            PrintList(wordsOfExcatlyFiveLetters);
        }

        private static void PrintList(List<string> wordsOfExcatlyFiveLetters)
        {
            foreach (string word in wordsOfExcatlyFiveLetters)
                Console.WriteLine(word);
        }

        private static List<string> GetWordsOfFiveLetter(List<string> words)
        {
            List<string> fiveLetterWords = new List<string>();
            foreach(string word in words)
            {
                if (word.Length == 5)
                    fiveLetterWords.Add(word);
            }
            return fiveLetterWords;
        }

        private static List<string> GetList()
        {
            List<string> words = new List<string> { "some word",
                "another",
                "FiveL",
                "three",
                "aflakr" };

            return words;
        }
    }
}
