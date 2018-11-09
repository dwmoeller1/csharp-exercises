using System;
using System.Collections.Generic;

namespace Studio_CountingCharacters
{
    class Program
    {
        public static string inputString = @"Lorem ipsum dolor sit amet, 
consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. 
Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. 
Donec sit amet suscipit metus, non lobortis massa. 
Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. 
Donec nec velit non ligula efficitur luctus.";

        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char letter in inputString)
            {
                if (Char.IsLetter(letter) && !charCount.ContainsKey(letter))
                {
                    charCount.Add(letter, 1);
                }
                else if(Char.IsLetter(letter))
                {
                    int currentCount = charCount[letter];
                    currentCount++;
                    charCount[letter] = currentCount;
                }
            }

            foreach(KeyValuePair<char, int> pair in charCount)
            {
                Console.WriteLine($"{pair.Key.ToString()}:{pair.Value}");
            }
            Console.ReadLine();
        }
    }
}
