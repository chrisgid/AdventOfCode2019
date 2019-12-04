using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2019.Day1
{
    public class Day1 : BaseDay
    {
        public override string GetAnswer(int part)
        {
            var fuelCounterUpper = new FuelCounterUpper();
            var fuelCount = fuelCounterUpper.GetFuelCount(ReadInput());

            if (part == 1)
            {
                return fuelCount.ToString();
            }

            return base.GetAnswer(part);
        }

        private static IEnumerable<Module> ReadInput()
        {
            using (var stream = InputHelper.GetInputStream("Day1.input.txt"))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var mass = int.Parse(reader.ReadLine());

                    yield return new Module(mass);
                }
            }
        }
    }
}
