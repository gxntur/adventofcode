using adventofcode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode.Days
{
    internal class Day02 : IDay
    {
        private readonly IEnumerable<string> _inputString;

        public Day02() {
            _inputString = File.ReadLines($"Inputs/input02.txt");
        }

        public int SolvePart1()
        {
            int totalSafeReports = 0;
            foreach (string line in _inputString)
            {
                if (IsLineSafe(line)) { 
                    totalSafeReports++;
                }
            }

            return totalSafeReports;
        }

        public int SolvePart2()
        {
            int totalSafeReports = 0;
            foreach (string line in _inputString)
            {
                if (IsDampenedLineSafe(line))
                {
                    totalSafeReports++;
                }
            }

            return totalSafeReports;
        }

        private static bool IsLineSafe(string line)
        {
            string[] numbersAsStrings = line.Split(" ");
            var pointer = 0;
            bool isSafe = true;
            bool isSeriesAscending = int.Parse(numbersAsStrings[0]) - int.Parse(numbersAsStrings[1]) < 0;

            while (isSafe && pointer < numbersAsStrings.Length - 1)
            {
                var currentInt = int.Parse(numbersAsStrings[pointer]);
                var nextInt = int.Parse(numbersAsStrings[pointer + 1]);
                var difference = nextInt - currentInt;
                var absoluteDifference = Math.Abs(nextInt - currentInt);

                if ((isSeriesAscending && difference < 0) 
                    || (!isSeriesAscending && difference > 0)
                    || (difference == 0)
                    || (absoluteDifference < 1 || absoluteDifference > 3)) isSafe = false;

                pointer++;
            }

            return isSafe;
        }

        private static bool IsDampenedLineSafe(string line)
        {
            string[] numbersAsStrings = line.Split(" ");
            var pointer = 0;
            bool isSafe = true;
            bool isSeriesAscending = int.Parse(numbersAsStrings[0]) - int.Parse(numbersAsStrings[1]) < 0;
            bool dampened = false;

            while (isSafe && pointer < numbersAsStrings.Length - 1)
            {
                var currentInt = int.Parse(numbersAsStrings[pointer]);
                var nextInt = int.Parse(numbersAsStrings[pointer + 1]);
                var difference = nextInt - currentInt;
                var absoluteDifference = Math.Abs(nextInt - currentInt);

                if ((isSeriesAscending && difference < 0)
                    || (!isSeriesAscending && difference > 0)
                    || (difference == 0)
                    || (absoluteDifference < 1 || absoluteDifference > 3)) { 
                    if (dampened)
                    {
                        isSafe = false;
                    } else
                    {
                        dampened = true;
                    }
                }

                pointer++;
            }

            return isSafe;
        }
    }
}
