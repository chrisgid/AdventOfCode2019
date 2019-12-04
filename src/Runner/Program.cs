using System;
using AdventOfCode2019.Day1;
using AdventOfCode2019.Day2;

namespace Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Day 1:");
            Console.WriteLine(new Day1().GetPartOneAnswer());
            Console.WriteLine(new Day1().GetPartTwoAnswer());

            Console.WriteLine("Day 2:");
            Console.WriteLine(new Day2().GetPartOneAnswer());
            Console.WriteLine(new Day2().GetPartTwoAnswer());

            Console.ReadKey();
        }
    }
}
