using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton1
{
    public class Lesson
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Name { get; set; }

        public void ShowInform()
        {
            Console.WriteLine($"Дата занятия: {Date.Day}.{Date.Month}.{Date.Year}");
            Console.WriteLine($"Время занятия: {Time.Hours}:{Time.Minutes}");
            Console.WriteLine($"Имя преподавателя: {Name}");
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
