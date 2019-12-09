using System.Collections.Generic;

namespace AdventOfCode2019.Day3
{
    public class Wire
    {
        public Wire()
        {
            Path = new List<WireSection>();
        }

        public List<WireSection> Path { get; set; }
    }
}
