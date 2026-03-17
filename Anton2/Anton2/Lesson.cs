using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton2
{
    public class Lesson
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Name { get; set; }

        public string ToString()
        {
            return $"{Date.Day}.{Date.Month}.{Date.Year} {Time.Hours}:{Time.Minutes}:{Time.Seconds} \"{Name}\"";
        }

        public Lesson(DateTime date, TimeSpan time, string name)
        {
            Date = date;
            Time = time;
            Name = name;
        }
        ~Lesson() { }
    }
}
