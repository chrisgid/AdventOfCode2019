using System.Collections.Generic;
using AdventOfCode2019.Day3;
using NUnit.Framework;

namespace AdventOfCode2019.Tests.Day3
{
    [TestFixture]
    public class CoordinateHelperTests
    {
        [Test]
        public void GenerateTest()
        {
            var wire = new Wire();
            wire.Path.Add(new WireSection('U', 3));
            wire.Path.Add(new WireSection('R', 3));
            wire.Path.Add(new WireSection('D', 2));
            wire.Path.Add(new WireSection('L', 1));

            var expected = new Dictionary<Coordinate, int>()
            {
                { new Coordinate(0, 1), 1 },
                { new Coordinate(0, 2), 2 },
                { new Coordinate(0, 3), 3 },
                { new Coordinate(1, 3), 4 },
                { new Coordinate(2, 3), 5 },
                { new Coordinate(3, 3), 6 },
                { new Coordinate(3, 2), 7 },
                { new Coordinate(3, 1), 8 },
                { new Coordinate(2, 1), 9 }
            };

            var result = CoordinateHelper.GenerateFrom(wire);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ManhattanDistanceTest1()
        {
            var wire1Sections = new List<WireSection>()
            {
                new WireSection('R', 8),
                new WireSection('U', 5),
                new WireSection('L', 5),
                new WireSection('D', 3)
            };

            var wire2Sections = new List<WireSection>()
            {
                new WireSection('U', 7),
                new WireSection('R', 6),
                new WireSection('D', 4),
                new WireSection('L', 4)
            };

            var wire1 = new Wire();
            var wire2 = new Wire();
            wire1.Path.AddRange(wire1Sections);
            wire2.Path.AddRange(wire2Sections);

            var wire1Coordinates = CoordinateHelper.GenerateFrom(wire1);
            var wire2Coordinates = CoordinateHelper.GenerateFrom(wire2);
            var intersections = CoordinateHelper.IntersectAndAddSteps(wire1Coordinates, wire2Coordinates);

            const int expected = 6;
            var actual = CoordinateHelper.GetSmallestManhattan(intersections);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ManhattanDistanceTest2()
        {
            var wire1Sections = new List<WireSection>()
            {
                new WireSection('R', 75),
                new WireSection('D', 30),
                new WireSection('R', 83),
                new WireSection('U', 83),
                new WireSection('L', 12),
                new WireSection('D', 49),
                new WireSection('R', 71),
                new WireSection('U', 7),
                new WireSection('L', 72)
            };

            var wire2Sections = new List<WireSection>()
            {
                new WireSection('U', 62),
                new WireSection('R', 66),
                new WireSection('U', 55),
                new WireSection('R', 34),
                new WireSection('D', 71),
                new WireSection('R', 55),
                new WireSection('D', 58),
                new WireSection('R', 83)
            };

            var wire1 = new Wire();
            var wire2 = new Wire();
            wire1.Path.AddRange(wire1Sections);
            wire2.Path.AddRange(wire2Sections);

            var wire1Coordinates = CoordinateHelper.GenerateFrom(wire1);
            var wire2Coordinates = CoordinateHelper.GenerateFrom(wire2);
            var intersections = CoordinateHelper.IntersectAndAddSteps(wire1Coordinates, wire2Coordinates);

            const int expected = 159;
            var actual = CoordinateHelper.GetSmallestManhattan(intersections);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ManhattanDistanceTest3()
        {
            var wire1Sections = new List<WireSection>()
            {
                new WireSection('R', 98),
                new WireSection('U', 47),
                new WireSection('R', 26),
                new WireSection('D', 63),
                new WireSection('R', 33),
                new WireSection('U', 87),
                new WireSection('L', 62),
                new WireSection('D', 20),
                new WireSection('R', 33),
                new WireSection('U', 53),
                new WireSection('R', 51)
            };

            var wire2Sections = new List<WireSection>()
            {
                new WireSection('U', 98),
                new WireSection('R', 91),
                new WireSection('D', 20),
                new WireSection('R', 16),
                new WireSection('D', 67),
                new WireSection('R', 40),
                new WireSection('U', 7),
                new WireSection('R', 15),
                new WireSection('U', 6),
                new WireSection('R', 7)
            };

            var wire1 = new Wire();
            var wire2 = new Wire();
            wire1.Path.AddRange(wire1Sections);
            wire2.Path.AddRange(wire2Sections);

            var wire1Coordinates = CoordinateHelper.GenerateFrom(wire1);
            var wire2Coordinates = CoordinateHelper.GenerateFrom(wire2);
            var intersections = CoordinateHelper.IntersectAndAddSteps(wire1Coordinates, wire2Coordinates);

            const int expected = 135;
            var actual = CoordinateHelper.GetSmallestManhattan(intersections);

            Assert.AreEqual(expected, actual);
        }
    }
}
