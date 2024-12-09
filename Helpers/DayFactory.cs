using adventofcode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode.Helpers
{
    internal class DayFactory
    {
        public List<int> CompletedDays = new()
        {
            1
        };

        public DayFactory() { }

        public IDay CreateDay(int dayNumber)
        {
            try
            {
                if (!IsComplete(dayNumber)) throw new ArgumentException("Invalid day number.");
                string className = $"adventofcode.Days.Day{dayNumber}";
                Type type = Type.GetType(className);

                if (type == null)
                {
                    throw new ArgumentException("Invalid day number.");
                }

                return (IDay)Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool IsComplete(int dayNumber)
        {
            return CompletedDays.Contains(dayNumber);
        }
    }
}
