namespace Anton2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            AddButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            OpenButton = new Button();
            helpButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDate, colTime, colName });
            dataGridView1.Location = new Point(14, 15);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(887, 479);
            dataGridView1.TabIndex = 0;
            // 
            // colDate
            // 
            colDate.HeaderText = "Дата";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 120;
            // 
            // colTime
            // 
            colTime.HeaderText = "Время";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            colTime.Width = 120;
            // 
            // colName
            // 
            colName.HeaderText = "Имя";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 120;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(15, 519);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(159, 29);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(206, 519);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(171, 29);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(419, 519);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(154, 29);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(594, 519);
            OpenButton.Margin = new Padding(3, 4, 3, 4);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(159, 29);
            OpenButton.TabIndex = 4;
            OpenButton.Text = "Открыть";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // helpButton
            // 
            helpButton.Location = new Point(775, 519);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(126, 29);
            helpButton.TabIndex = 5;
            helpButton.Text = "Справка";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += HelpButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(DeleteButton);
            Controls.Add(OpenButton);
            Controls.Add(helpButton);
            Controls.Add(SaveButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colName;
        private Button AddButton;
        private Button SaveButton;
        private Button DeleteButton;
        private Button OpenButton;
        private Button helpButton;
    }
}
