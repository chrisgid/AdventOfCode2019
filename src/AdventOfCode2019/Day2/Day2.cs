using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Day2
{
    public class Day2 : BaseDay
    {
        public override string GetPartOneAnswer()
        {
            var program = ReadInput();
            program[1] = 12;
            program[2] = 2;

            var computer = new Computer();
            var outputState = computer.Run(program);

            return outputState[0].ToString();
        }

        public override string GetPartTwoAnswer()
        {
            return base.GetPartTwoAnswer();
        }

        public int[] ReadInput()
        {
            string input;

            using (var stream = InputHelper.GetInputTxtStream())
            using (var reader = new StreamReader(stream))
            {
                input = reader.ReadToEnd();
            }

            var strings = input.Split(',');

            return strings.Select(int.Parse).ToArray();
        }
    }
}
