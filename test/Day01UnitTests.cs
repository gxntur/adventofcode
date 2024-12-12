using adventofcode.Helpers;
using adventofcode.Interfaces;

namespace AdventOfCode.Tests
{
    public class Day01UnitTests
    {
        private IDay _day1 = new DayFactory().CreateDay(1);

        [Fact]
        public void Day1Part1Test()
        {
            var answer = _day1.SolvePart1();

            Assert.Equal(3569916, answer);
        }

        [Fact]
        public void Day1Part2Test()
        {
            var answer = _day1.SolvePart2();

            Assert.Equal(26407426, answer);
        }
    }
}
