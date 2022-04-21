using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string para = "I would not, could not, in a box. I would not, could not with a fox.I will not eat them in a house. I will not eat them with a mouse.";

            string[] paraArray = para.Split(" ");
            Console.WriteLine(string.Join(" ", paraArray));
            //Console.WriteLine("Hello Strings!");
            foreach (string str in paraArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}
