using System;
using AdventOfCode2019.Day1;

namespace Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Day 1:");
            Console.WriteLine(new Day1().GetAnswer(1));
            Console.WriteLine(new Day1().GetAnswer(2));

            Console.ReadKey();
        }
    }
}
