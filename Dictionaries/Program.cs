using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.Write("id: ");
                    int id = int.Parse(Console.ReadLine());

                    students.Add(id, newStudent);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, String> student in students)
            {
                Console.WriteLine("Student ID: " + student.Key + " / Student Name: " + student.Value);
            }
            Console.ReadLine();
        }
    }
}