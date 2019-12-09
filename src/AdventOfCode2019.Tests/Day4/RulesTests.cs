using AdventOfCode2019.Day4;
using NUnit.Framework;

namespace AdventOfCode2019.Tests.Day4
{
    [TestFixture]
    public class RulesTests
    {
        [TestCase(111111, true)]
        [TestCase(223450, false)]
        [TestCase(123789, true)]
        [TestCase(211111, false)]
        [TestCase(124321, false)]
        public void HasIncreasingDigitsTests(int password, bool expected)
        {
            var actual = Rules.HasIncreasingDigits(password);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(111111, true)]
        [TestCase(223450, true)]
        [TestCase(123789, false)]
        [TestCase(211111, true)]
        [TestCase(124321, false)]
        public void HasAdjacentDigitsTests(int password, bool expected)
        {
            var actual = Rules.HasAdjacentDigits(password);

            Assert.AreEqual(expected, actual);
        }
    }
}
