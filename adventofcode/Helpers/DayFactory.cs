using adventofcode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode.Helpers
{
    public class DayFactory
    {
        public List<int> CompletedDays = new()
        {
            1,
            2,
            3
        };

        public DayFactory() { }

        public IDay CreateDay(int dayNumber)
        {
            try
            {
                if (!IsComplete(dayNumber)) throw new ArgumentException("Invalid day number.");

                string dayName = dayNumber.ToString();

                if (dayName.Length == 1) dayName = '0' + dayName; 

                string className = $"adventofcode.Days.Day{dayName}";
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
