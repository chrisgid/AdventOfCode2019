﻿using System;
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

            var wire1Coordinates = CoordinateHelper.GenerateFrom(wires.Item1);
            var wire2Coordinates = CoordinateHelper.GenerateFrom(wires.Item2);

            var intersections = CoordinateHelper.IntersectAndAddSteps(wire1Coordinates, wire2Coordinates);

            var smallestManhattan = CoordinateHelper.GetSmallestManhattan(intersections);

            return smallestManhattan.ToString();
        }

        public override string GetPartTwoAnswer()
        {
            var wires = ReadInput();

            var wire1Coordinates = CoordinateHelper.GenerateFrom(wires.Item1);
            var wire2Coordinates = CoordinateHelper.GenerateFrom(wires.Item2);

            var intersections = CoordinateHelper.IntersectAndAddSteps(wire1Coordinates, wire2Coordinates);

            var smallestSteps = CoordinateHelper.GetSmallestSteps(intersections);

            return smallestSteps.ToString();
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
                wires.Item1.Path.Add(new WireSection(direction, distance));
            }

            foreach (var s in lines[1])
            {
                var split = Regex.Split(s, @"(?<=[UDLR])");
                var direction = char.Parse(split[0]);
                var distance = int.Parse(split[1]);
                wires.Item2.Path.Add(new WireSection(direction, distance));
            }

            return wires;
        }
    }
}
