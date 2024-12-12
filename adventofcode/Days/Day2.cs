using adventofcode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode.Days
{
    internal class Day2 : IDay
    {
        private readonly IEnumerable<string> _inputString;

        public Day2() {
            _inputString = File.ReadLines($"Inputs/test.txt");
        }

        public int SolvePart1()
        {
            int totalSafeReports = 0;
            foreach (string line in _inputString)
            {
                if (isLineSafe(line)) { 
                    totalSafeReports++;
                    Console.WriteLine("safe");
                } else { 
                    Console.WriteLine("unsafe"); 
                }

            }

            return totalSafeReports;
        }

        public int SolvePart2()
        {
            throw new NotImplementedException();
        }

        private bool isLineSafe(string line)
        {
            string[] numbersAsStrings = line.Split(" ");
            var pointer = 0;
            bool isSafe = true;
            bool isSeriesAscending = int.Parse(numbersAsStrings[0]) - int.Parse(numbersAsStrings[1]) < 0;

            while (isSafe && pointer < numbersAsStrings.Length - 2)
            {
                var currentInt = int.Parse(numbersAsStrings[pointer]);
                var nextInt = int.Parse(numbersAsStrings[pointer + 1]);
                var difference = Math.Abs(nextInt - currentInt);

                if (isSeriesAscending && (nextInt - currentInt) < 0) isSafe = false;

                if (!isSeriesAscending && (nextInt - currentInt) > 0) isSafe = false;

                if (nextInt - currentInt == 0) isSafe = false;

                if (difference < 1 || difference > 3)
                {
                    isSafe = false;
                }

                pointer++;
            }

            return isSafe;
        }
    }
}
