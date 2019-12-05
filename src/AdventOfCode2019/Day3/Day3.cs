using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace AdventOfCode2019.Day3
{
    public class Day3 : BaseDay
    {
        public override string GetPartOneAnswer()
        {
            var wires = ReadInput();


            return base.GetPartOneAnswer();
        }

        public override string GetPartTwoAnswer()
        {
            return base.GetPartTwoAnswer();
        }

        private static Tuple<Wire, Wire> ReadInput()
        {
            var lines = new List<string[]>(2);
            var wires = new Tuple<Wire, Wire>(new Wire(), new Wire());

            using (var stream = InputHelper.GetInputTxtStream())
            using (var reader = new StreamReader(stream))
            {
                for (int i = 0; i < 2; i++)
                {
                    lines.Add(reader.ReadLine().Split(','));
                }
            }

            foreach (var s in lines[0])
            {
                var split = Regex.Split(s, @"(?<=[UDLR])");
                var direction = char.Parse(split[0]);
                var distance = int.Parse(split[1]);
                wires.Item1.Path.Add(new Tuple<char, int>(direction, distance));
            }

            foreach (var s in lines[1])
            {
                var split = Regex.Split(s, @"(?<=[UDLR])");
                var direction = char.Parse(split[0]);
                var distance = int.Parse(split[1]);
                wires.Item2.Path.Add(new Tuple<char, int>(direction, distance));
            }

            return wires;
        }
    }
}
