using System;
using System.Collections.Generic;
using System.IO;
using Help;

namespace Day1
{
    public static class Answer
    {
        public static string Get()
        {
            var fuelCounterUpper = new FuelCounterUpper();
            var fuelCount = fuelCounterUpper.GetFuelCount(ReadInput());

            return fuelCount.ToString();
        }

        private static IEnumerable<Module> ReadInput()
        {
            using (var stream = InputHelper.GetInputStream())
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
