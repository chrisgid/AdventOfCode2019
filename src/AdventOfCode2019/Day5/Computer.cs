using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Day5
{
    public class Computer
    {
        private int[] _memory;
        private int _instructionPointer;

        public Computer(int[] program)
        {
            _memory = (int[])program.Clone();
            _instructionPointer = 0;
        }
    }

    public enum Opcode
    {
        Add = 1,
        Multiply = 2,
        Input = 3,
        Output = 4,
        Halt = 99
    }
}
