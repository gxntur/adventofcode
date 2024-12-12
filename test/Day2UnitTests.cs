using adventofcode.Helpers;
using adventofcode.Interfaces;

namespace AdventOfCode.Tests
{
    public class Day2UnitTests
    {
        private IDay _day2 = new DayFactory().CreateDay(2);

        [Fact]
        public void Day2Part1Test()
        {
            var answer = _day2.SolvePart1();

            Assert.Equal(585, answer);
        }

        [Fact]
        public void Day2Part2Test()
        {
            var answer = _day2.SolvePart2();

            Assert.Equal(626, answer);
        }
    }
}
