using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Lists!");
            string para = "I would not, could not, in a box. I would not, could not with a fox.I will not eat them in a house. I will not eat them with a mouse.";

            List<int> intList = new List<int> { 1, 2, 3, 420, 5, 69, 777, 8, 9001, 10 };
            //List<string> strList = new List<string>
            //{
            //    "plane",
            //    "mile",
            //    "super",
            //    "Darian",
            //    "Supercalafragilisticespialadotiuous",
            //    "mouse"
            //};
            List<string> strList = para.Split(' ').ToList();

            Console.WriteLine(EvenSum(intList));
            //Modify your code to prompt the user to enter the word length for the search.
            Console.WriteLine("Enter the word length for the search.");
            int search = int.Parse(Console.ReadLine());


            PrintWords(strList, search);
        }

        static int EvenSum(List<int> list)
        {
            int sum = 0;
            foreach (int item in list)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        static void PrintWords(List<string> list, int num)
        {
            foreach (string word in list)
            {
                if (word.Length == num)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
