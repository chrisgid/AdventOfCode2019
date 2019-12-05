using System;
using System.Collections.Generic;

namespace AdventOfCode2019.Day3
{
    public class Wire
    {
        public Wire()
        {
            Path = new List<Tuple<char,int>>();
        }

        public List<Tuple<char,int>> Path { get; set; }
    }
}
