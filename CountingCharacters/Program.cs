using System;
using System.Collections.Generic;
using System.IO;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            while (option != 1 && option != 2)
            {
                Console.WriteLine("Please '1' to input a search passage manually or '2' to enter file containing search passage: ");
                option = int.Parse(Console.ReadLine());
            }
            switch (option) {
                case 1:
                    Console.Write("Please enter a passage to count characters on: ");
                    String passage = Console.ReadLine();
                    Dictionary<char, int> returnDictionary = CountCharacters(passage);
                    foreach (KeyValuePair<char, int> character in returnDictionary)
                    {
                        Console.WriteLine(character.Key + ": " + character.Value);
                    }
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Please enter the file path for the file to count characters on: ");
                    String filePath = Console.ReadLine();
                    String inputLine;
                    String pass = "";
                    try
                    {
                        StreamReader reader = new StreamReader(filePath);
                        inputLine = reader.ReadLine();
                        while(inputLine != null)
                        {
                            pass += (" " + inputLine);
                            inputLine = reader.ReadLine();
                        }
                        reader.Close();
                        Dictionary<char, int> returnDict = CountCharacters(pass);
                        foreach (KeyValuePair<char, int> character in returnDict)
                        {
                            Console.WriteLine(character.Key + ": " + character.Value);
                        }
                        Console.ReadLine();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                        Console.ReadLine();
                    }
                    break;
            }
        }

        static Dictionary<char, int> CountCharacters(String passage)
        {
            passage = passage.ToUpper();
            Dictionary<char, int> characterCounts = new Dictionary<char, int>();
            for(int i = 0; i < passage.Length; i++)
            {
                if(passage[i] != ' ')
                {
                    if(characterCounts.ContainsKey(passage[i]) == true)
                    {
                        characterCounts[passage[i]] ++; 
                    }
                    else
                    {
                        characterCounts.Add(passage[i], 1);
                    }
                }
                else
                {
                    continue;
                }
            }
            return characterCounts;
        }
    }
}
