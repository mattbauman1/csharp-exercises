using System;
using System.Collections.Generic;

namespace ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> words = new List<String>();
            String[] wrd = new String[] { "cat","mouse","house","dogs","Matts" };
            words.AddRange(wrd);
            PrintFiveLetterWords(words);
            Console.ReadLine();
        }

        static void PrintFiveLetterWords(List<String> words)
        {
            List<String> returnWords = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length == 5)
                {
                    returnWords.Add(words[i]);
                }
            }
            for(int i = 0; i < returnWords.Count; i++)
            {
                Console.WriteLine(returnWords[i]);
            }
        }
    }
}
