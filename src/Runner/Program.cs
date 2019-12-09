using System;
using System.Collections.Generic;
using AdventOfCode2019;
using AdventOfCode2019.Day1;
using AdventOfCode2019.Day2;
using AdventOfCode2019.Day3;
using AdventOfCode2019.Day4;

namespace Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var days = new List<BaseDay>
            {
                new Day1(),
                new Day2(),
                new Day3(),
                new Day4()
            };

            for (var i = 0; i < days.Count; i++)
            {
                var day = days[i];
                Console.WriteLine($"Day {i}:");
                Console.WriteLine("  " + day.GetPartOneAnswer());
                Console.WriteLine("  " + day.GetPartTwoAnswer());
            }

            Console.ReadKey();
        }
    }
}
