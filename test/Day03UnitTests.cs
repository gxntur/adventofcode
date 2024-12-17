using adventofcode.Helpers;
using adventofcode.Interfaces;

namespace AdventOfCode.Tests
{
    public class Day03UnitTests
    {
        private IDay _day3 = new DayFactory().CreateDay(3);

        [Fact]
        public void Day3Part1Test()
        {
            var answer = _day3.SolvePart1();

            Assert.Equal(166630675, answer);
        }

        [Fact]
        public void Day3Part2Test()
        {
            var answer = _day3.SolvePart2();

            Assert.Equal(0, answer);
        }
    }
}
