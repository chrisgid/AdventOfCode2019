using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2019.Day1
{
    public class Day1 : BaseDay
    {
        public override string GetPartOneAnswer()
        {
            var fuelCounterUpper = new FuelCounterUpper();
            var fuelCount = fuelCounterUpper.GetFuelCount(ReadInput());

            return fuelCount.ToString();
        }

        public override string GetPartTwoAnswer()
        {
            var fuelCounterUpper = new FuelCounterUpper();
            var fuelCount = fuelCounterUpper.GetActualFuelCount(ReadInput());

            return fuelCount.ToString();
        }

        private static IEnumerable<Module> ReadInput()
        {
            using (var stream = InputHelper.GetInputTxtStream())
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
