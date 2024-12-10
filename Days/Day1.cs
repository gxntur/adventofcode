using adventofcode.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode.Days
{
    internal class Day1 : IDay
    {
        private readonly IEnumerable<string> _inputString;

        public Day1() { 
            _inputString = File.ReadLines($"Inputs/input1.txt");
        }

        public int SolvePart1()
        {
            var sortedList1 = new List<int>();
            var sortedList2 = new List<int>();
            var distance = 0;
            var lineNumber = 0;

            foreach (var line in _inputString)
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
            var occurrences = new Dictionary<int, int>();
            int runningTotal = 0;
            var list1 = new List<int>();

            foreach (var line in _inputString)
            {
                var lineParts = line.Split("   ");
                var linePart1 = int.Parse(lineParts[0]);
                var linePart2 = int.Parse(lineParts[1]);

                list1.Add(linePart1);

                if(!occurrences.TryAdd(linePart2, 1))
                {
                    Console.WriteLine("didnt add new");
                    occurrences[linePart2] = occurrences[linePart2] + 1;
                    Console.WriteLine(occurrences[linePart2]);
                }
            }

            foreach (var item in list1)
            {
                if (occurrences.ContainsKey(item))
                {
                    runningTotal += (item * occurrences[item]);
                }
            }

            return runningTotal;
        }
    }
}
