using System.IO;
using System.Linq;

namespace AdventOfCode2019.Day2
{
    public class Day2 : BaseDay
    {
        public override string GetPartOneAnswer()
        {
            var program = ReadInput();

            var computer = new Computer();
            var output = computer.Run(program, 12, 2);

            return output.ToString();
        }

        public override string GetPartTwoAnswer()
        {
            const int wantedOutput = 19690720;
            var program = ReadInput();

            var computer = new Computer();
            var input1 = 0;
            var input2 = 0;

            for (; input1 < 100; input1++)
            {
                for (input2 = 0; input2 < 100; input2++)
                {
                    var output = computer.Run(program, input1, input2);

                    if (output == wantedOutput)
                    {
                        goto end;
                    }
                }
            }
            end:

            return $"{input1:00}{input2:00}";
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
