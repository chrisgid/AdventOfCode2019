using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2019.Day2;
using NUnit.Framework;

namespace AdventOfCode2019.Tests.Day2
{
    [TestFixture]
    public class ComputerTests
    {
        [TestCase(new[] { 1, 0, 0, 0, 99 }, new[] { 2, 0, 0, 0, 99 })]
        [TestCase(new[] { 2, 3, 0, 3, 99 }, new[] { 2, 3, 0, 6, 99 })]
        [TestCase(new[] { 2, 4, 4, 5, 99, 0 }, new[] { 2, 4, 4, 5, 99, 9801 })]
        [TestCase(new[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 }, new[] { 30, 1, 1, 4, 2, 5, 6, 0, 99 })]
        public void RunProgram(int[] initialState, int[] finalState)
        {
            var computer = new Computer();

            computer.Run(initialState, initialState[1], initialState[2]);
            var result = computer.GetMemory();

            Assert.AreEqual(finalState, result);
        }
    }
}
