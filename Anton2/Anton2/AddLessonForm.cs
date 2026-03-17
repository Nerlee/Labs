using System;
using System.Windows.Forms;

namespace Anton2
{
    public class AddLessonForm : Form
    {
        private DateTimePicker datePicker;
        private DateTimePicker timePicker;
        private TextBox nameBox;
        private Button okButton;
        private Button cancelButton;

        public DateTime LessonDate => datePicker.Value.Date;
        public TimeSpan LessonTime => timePicker.Value.TimeOfDay;
        public string LessonName => nameBox.Text;

        public AddLessonForm()
        {
            Text = "Добавить запись";
            Width = 300;
            Height = 200;

            datePicker = new DateTimePicker { Location = new System.Drawing.Point(10, 10), Width = 250, Format = DateTimePickerFormat.Short };
            timePicker = new DateTimePicker { Location = new System.Drawing.Point(10, 40), Width = 250, Format = DateTimePickerFormat.Time, ShowUpDown = true };
            nameBox = new TextBox { Location = new System.Drawing.Point(10, 70), Width = 250 };

            okButton = new Button { Text = "OK", Location = new System.Drawing.Point(10, 110), DialogResult = DialogResult.OK };
            cancelButton = new Button { Text = "Отмена", Location = new System.Drawing.Point(100, 110), DialogResult = DialogResult.Cancel };

            Controls.Add(datePicker);
            Controls.Add(timePicker);
            Controls.Add(nameBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);

            AcceptButton = okButton;
            CancelButton = cancelButton;
        }
    }
}
