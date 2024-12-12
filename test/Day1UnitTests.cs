using adventofcode.Helpers;
using adventofcode.Interfaces;

namespace AdventOfCode.Tests
{
    public class Day1UnitTests
    {
        private IDay _day1 = new DayFactory().CreateDay(1);

        [Fact]
        public void Day1Part1Test()
        {
            var answer = _day1.SolvePart1();

            Console.WriteLine(answer);
            Assert.Equal(3569916, answer);
        }

        [Fact]
        public void Day1Part2Test()
        {
            var answer = _day1.SolvePart2();

            Console.WriteLine(answer);
            Assert.Equal(26407426, answer);
        }
    }
}
