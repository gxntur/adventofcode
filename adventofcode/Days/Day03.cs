using adventofcode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace adventofcode.Days
{
    internal class Day03 : IDay
    {
        private readonly IEnumerable<string> _inputString;

        public Day03() {
            _inputString = File.ReadLines($"Inputs/input03.txt");
        }

        public int SolvePart1()
        {
            var total = 0;

            foreach (var line in _inputString)
            {

                MatchCollection instructions = SplitIntoInstructions(line);

                instructions.Select(match => match.Value).ToList().ForEach(
                    instruction =>
                    {
                        var numbers = instruction.Substring(4).Split(',');
                        var firstNumber = numbers[0];
                        var secondNumber = numbers[1].Split(')')[0];
                        var multiplicationTotal = int.Parse(firstNumber) * int.Parse(secondNumber);

                        total += multiplicationTotal;
                    });
            }

            return total;
        }

        public int SolvePart2()
        {
            throw new NotImplementedException();
        }

        private MatchCollection SplitIntoInstructions(string input)
        {
            Regex regex = new Regex(@"mul\(\d+,\d+\)");
            MatchCollection instructions = regex.Matches(input);

            return instructions;
        }
    }
}
