using adventofcode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode.Days
{
    internal class Day1 : IDay
    {
        public int SolvePart1()
        {
            var sortedList1 = new List<int>();
            var sortedList2 = new List<int>();
            var distance = 0;
            var lineNumber = 0;

            var text = File.ReadLines($"Inputs/input1.txt");

            foreach (var line in text)
            {
                var lineParts = line.Split("   ");
                Console.WriteLine($"Current Line Number {lineNumber} and inputs {lineParts[0]} {lineParts[1]}");

                var int1 = int.Parse(lineParts[0]);
                var int2 = int.Parse(lineParts[1]);

                var index1 = sortedList1.BinarySearch(int1);
                if (index1 < 0) index1 = ~index1;
                sortedList1.Insert(index1, int1);

                var index2 = sortedList2.BinarySearch(int2);
                if (index2 < 0) index2 = ~index2;
                sortedList2.Insert(index2, int2);

                lineNumber++;
            }

            var currentDistance = 0;

            for (var i = 0; i < sortedList1.Count; i++)
            {
                currentDistance = Math.Abs(sortedList1[i] - sortedList2[i]);
                distance += currentDistance;
            }

            return distance;
        }

        public int SolvePart2()
        {
            var text = File.ReadLines("Inputs/input1.txt");

            return 1;
        }
    }
}
