using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();


            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student: ");
                newStudent = Console.ReadLine();

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("ID: ");
                    int newID = int.Parse(Console.ReadLine());
                    students.Add(newID, newStudent);

                    // Read in the newline before looping back
                    //Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }
        }
    }
}
