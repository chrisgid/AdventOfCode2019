using System.IO;
using System.Linq;

namespace AdventOfCode2019.Day5
{
    public class Day5 : BaseDay
    {
        public override string GetPartOneAnswer()
        {
            var input = ReadInput();
            return base.GetPartOneAnswer();
        }

        public override string GetPartTwoAnswer()
        {
            return base.GetPartTwoAnswer();
        }

        private static int[] ReadInput()
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
