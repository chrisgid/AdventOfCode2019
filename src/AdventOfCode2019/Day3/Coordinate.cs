using System;

namespace AdventOfCode2019.Day3
{
    public struct Coordinate : IEquatable<Coordinate>
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public bool Equals(Coordinate other)
        {
            return other.X == X && other.Y == Y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 37;
                hash = hash * 397 + X.GetHashCode();
                hash = hash * 397 + Y.GetHashCode();
                return hash;
            }
        }
    }
}
