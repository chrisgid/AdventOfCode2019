using System;
using System.IO;

namespace AdventOfCode2019.Day4
{
    public class Day4 : BaseDay
    {
        public override string GetPartOneAnswer()
        {
            var (startRange, endRange) = ReadInput();
            var validCount = 0;

            for (var i = startRange; i <= endRange; i++)
            {
                if (PasswordValidator.IsValid(i))
                {
                    validCount++;
                }
            }

            return validCount.ToString();
        }

        public override string GetPartTwoAnswer()
        {
            return base.GetPartTwoAnswer();
        }

        private static Tuple<int, int> ReadInput()
        {
            string inputString;

            using (var stream = InputHelper.GetInputTxtStream())
            using (var reader = new StreamReader(stream))
            {
                inputString = reader.ReadLine();
            }

            var inputs = inputString.Split('-');

            return new Tuple<int, int>
            (
                int.Parse(inputs[0]),
                int.Parse(inputs[1])
            );
        }
    }
}
