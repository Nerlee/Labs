using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anton2
{
    public static class LessonParser
    {
        public static string OpenDialog()
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Text files|*.txt|All files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            return string.Empty;
        }

        public static string SaveDialog()
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = "Text files|*.txt|All files|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                return sfd.FileName;
            }
            return string.Empty;
        }

        public static List<Lesson> LoadFromFile(string path)
        {
            List<Lesson> lessons = new();
            foreach (var line in File.ReadAllLines(path, Encoding.UTF8))
            {
                var trimmed = line.Trim();
                if (string.IsNullOrEmpty(trimmed)) continue;
                try
                {
                    var firstSpace = trimmed.IndexOf(' ');
                    if (firstSpace < 0) continue;
                    var datePart = trimmed.Substring(0, firstSpace);
                    var rest = trimmed.Substring(firstSpace + 1).Trim();
                    var secondSpace = rest.IndexOf(' ');
                    if (secondSpace < 0) continue;
                    var timePart = rest.Substring(0, secondSpace);
                    var namePart = rest.Substring(secondSpace + 1).Trim();
                    if (namePart.StartsWith("\"") && namePart.EndsWith("\""))
                        namePart = namePart.Substring(1, namePart.Length - 2);

                    if (!DateTime.TryParse(datePart,out var date))
                        continue;

                    var timeParts = timePart.Split(':');
                    int hours = 0, minutes = 0, seconds=0;
                    if (timeParts.Length >= 1) int.TryParse(timeParts[0], out hours);
                    if (timeParts.Length >= 2) int.TryParse(timeParts[1], out minutes);
                    if (timeParts.Length >= 3) int.TryParse(timeParts[2], out seconds);
                    var timespan = new TimeSpan(hours, minutes, seconds);
                    lessons.Add(new Lesson(date, timespan, namePart));
                }
                catch { continue; }
            }
            return lessons;
        }
    }
}
