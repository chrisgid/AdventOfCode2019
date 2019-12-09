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

            var validator = new PasswordValidator();
            validator.AddRule(Rules.HasIncreasingDigits);
            validator.AddRule(Rules.HasAdjacentDigits);

            for (var i = startRange; i <= endRange; i++)
            {
                if (validator.Validate(i))
                {
                    validCount++;
                }
            }

            return validCount.ToString();
        }

        public override string GetPartTwoAnswer()
        {
            var (startRange, endRange) = ReadInput();
            var validCount = 0;

            var validator = new PasswordValidator();
            validator.AddRule(Rules.HasIncreasingDigits);
            //validator.AddRule(Rules.HasPartTwoAdjacentDigits);

            for (var i = startRange; i <= endRange; i++)
            {
                if (validator.Validate(i))
                {
                    validCount++;
                }
            }

            return validCount.ToString();
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
