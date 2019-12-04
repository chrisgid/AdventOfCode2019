using System.Collections.Generic;

namespace Day1
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
    }
}
