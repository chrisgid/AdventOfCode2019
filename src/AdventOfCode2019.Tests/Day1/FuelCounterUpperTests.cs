using AdventOfCode2019.Day1;
using NUnit.Framework;

namespace AdventOfCode2019.Tests.Day1
{
    [TestFixture]
    public class FuelCounterUpperTests
    {
        [TestCase(100756, 50346)]
        [TestCase(1969, 966)]
        [TestCase(14, 2)]
        public void CalculateFuelForTest(int moduleMass, int fuelRequired)
        {
            var fuelCounterUpper = new FuelCounterUpper();

            var result = fuelCounterUpper.CalculateFuelCountFor(moduleMass);

            Assert.AreEqual(fuelRequired, result);
        }
    }
}
