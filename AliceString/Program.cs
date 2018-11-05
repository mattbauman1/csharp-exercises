using System;

namespace AliceString
{
    class Program
    {
        static void Main(string[] args)
        {
            String alicePassage = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Please enter the string you would like to search for: ");
            String searchQuery = Console.ReadLine();
            bool containsQuery = alicePassage.Contains(searchQuery, System.StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(containsQuery);
            Console.ReadLine();
        }
    }
}
