using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Anton1
{
    internal class Program
    {
        static string trueString(string s)
        {
            string[] strings = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            for (int i = 0; i < strings.Length; i++)
            {
                result += strings[i];
                if (i != strings.Length - 1) result += " ";
            }
            return result;
        }

        static void Main(string[] args)
        {
            //string rawString = Console.ReadLine();
            string rawString = "12-12-12       23:50     \"Steve\"";
            List<string> list = new List<string>();
            string[] words = rawString.Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                string[] subword = word.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (subword.Length == 1) list.Add(word);
                else if (subword.Length == 2) list.AddRange(subword);
            }

            string workDate = trueString(list[0]);
            string timedate = trueString(list[1]);
            string name = trueString(list[2]);

            DateTime dateOfWork = DateTime.Parse(workDate);

            TimeSpan timeSpan;

            if (TimeSpan.TryParse(timedate, out timeSpan))
            {
                Lesson lesson = new Lesson(dateOfWork, timeSpan, name);
                lesson.ShowInform();
            }
            else
            {
                Console.WriteLine("Неверный формат времени.");
            }
        }
    }
}
