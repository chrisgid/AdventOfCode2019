using System;

namespace AdventOfCode2019.Day3
{
    public class WireSection
    {
        public const char UP = 'U';
        public const char DOWN = 'D';
        public const char LEFT = 'L';
        public const char RIGHT = 'R';

        private readonly Tuple<char, int> _section;

        public WireSection(char direction, int distance)
        {
            _section = new Tuple<char, int>(direction, distance);
        }

        public char Direction => _section.Item1;

        public int Distance => _section.Item2;
    }
}
