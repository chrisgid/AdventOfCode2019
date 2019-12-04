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
            var totalRequiredFuel = 0;
            totalRequiredFuel += (mass / 3) - 2;

            while (true)
            {
                var requiredFuel = (totalRequiredFuel / 3) - 2;

                if (requiredFuel <= 0)
                {
                    break;
                }

                totalRequiredFuel += requiredFuel;
            }

            return totalRequiredFuel;
        }
    }
}
