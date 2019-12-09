using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2019.Day3
{
    public static class CoordinateHelper
    {
        public static Dictionary<Coordinate, int> GenerateFrom(Wire wire)
        {
            var currentX = 0;
            var currentY = 0;
            var steps = 0;

            var coordinates = new Dictionary<Coordinate, int>();

            foreach (var section in wire.Path)
            {
                var xModifier = 0;
                var yModifier = 0;

                switch (section.Direction)
                {
                    case WireSection.UP:
                        yModifier = 1;
                        break;
                    case WireSection.DOWN:
                        yModifier = -1;
                        break;
                    case WireSection.LEFT:
                        xModifier = -1;
                        break;
                    case WireSection.RIGHT:
                        xModifier = 1;
                        break;
                }

                for (var i = 0; i < section.Distance; i++)
                {
                    steps++;
                    currentY += yModifier;
                    currentX += xModifier;

                    var newCoordinate = new Coordinate(currentX, currentY);

                    if (!coordinates.ContainsKey(newCoordinate))
                    {
                        coordinates.Add(new Coordinate(currentX, currentY), steps);
                    }
                }
            }

            return coordinates;
        }

        public static Dictionary<Coordinate, int> IntersectAndAddSteps(Dictionary<Coordinate, int> first, Dictionary<Coordinate, int> second)
        {
            return first.Where(x => second.ContainsKey(x.Key)).ToDictionary(x => x.Key, x => x.Value + second[x.Key]);
        }

        public static int GetSmallestManhattan(Dictionary<Coordinate, int> intersections)
        {
            return intersections.Keys.Min(i => Math.Abs(i.X) + Math.Abs(i.Y));
        }

        public static int GetSmallestSteps(Dictionary<Coordinate, int> intersections)
        {
            return intersections.Values.Min();
        }
    }
}
