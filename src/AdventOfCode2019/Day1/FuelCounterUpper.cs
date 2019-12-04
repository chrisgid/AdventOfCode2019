using System.Collections.Generic;

namespace AdventOfCode2019.Day1
{
    public class FuelCounterUpper
    {
        public int GetFuelCount(IEnumerable<Module> modules)
        {
            var requiredFuel = 0;

            foreach (var module in modules)
            {
                requiredFuel += (module.Mass / 3) - 2;
            }

            return requiredFuel;
        }

        public int GetActualFuelCount(IEnumerable<Module> modules)
        {
            var requiredFuel = 0;

            foreach (var module in modules)
            {
                requiredFuel += CalculateFuelCountFor(module.Mass);
            }

            return requiredFuel;
        }

        public int CalculateFuelCountFor(int mass)
        {
            var fuelCount = (mass / 3) - 2;

            if (fuelCount <= 0)
            {
                return 0;
            }

            return fuelCount + CalculateFuelCountFor(fuelCount);
        }
    }
}
