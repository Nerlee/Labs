using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Anton2
{
    public partial class Form1 : Form
    {
        public ObservableCollection<Lesson> Lessons = new();
        private string? currentFilePath = null;
        private bool isOpened = false;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            RefreshGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using var dialog = new AddLessonForm();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Lessons.Add(new Lesson(dialog.LessonDate, dialog.LessonTime, dialog.LessonName));
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var l in Lessons)
            {
                dataGridView1.Rows.Add(l.Date.ToString("dd-MM-yyyy"), l.Time.ToString("hh\\:mm\\:ss"), l.Name);
            }
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            if (currentFilePath is null)
            {
                currentFilePath = LessonParser.SaveDialog();
                isOpened = true;
                using var sw = new StreamWriter(currentFilePath, false, Encoding.UTF8);
                foreach (var l in Lessons)
                {
                    sw.WriteLine(l.ToString());
                }
            }
        }

        private void OpenButton_Click(object? sender, EventArgs e)
        {

            string path = LessonParser.OpenDialog();
            if (path != string.Empty)
            {
                if (isOpened)
                    Lessons.Clear();
                isOpened = true;
                List<Lesson> tmpLessons = LessonParser.LoadFromFile(path);
                foreach (var l in tmpLessons)
                {
                    Lessons.Add(l);
                }
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Файл не выбран.");
            }
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var idx = dataGridView1.SelectedRows[0].Index;
            if (idx >= 0 && idx < Lessons.Count)
            {
                Lessons.RemoveAt(idx);
                RefreshGrid();
            }
        }
        private void HelpButton_Click(object? sender, EventArgs e)
        {
            string helpPath = Path.Combine(Application.StartupPath, "help.html");

            // Если файла нет в output, ищем в папке проекта
            if (!File.Exists(helpPath))
            {
                helpPath = Path.Combine(Application.StartupPath, "..", "..", "..", "help.html");
                helpPath = Path.GetFullPath(helpPath);
            }

            var helpForm = new HelpForm(helpPath);
            helpForm.ShowDialog();  // ← Открываем как модальное ок
        }
    }
}
