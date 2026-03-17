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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDate, colTime, colName });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 378);
            dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            colDate.HeaderText = "Дата";
            colDate.Name = "Date";
            colDate.ReadOnly = true;
            // 
            // Time
            // 
            colTime.HeaderText = "Время";
            colTime.Name = "Time";
            colTime.ReadOnly = true;
            // 
            // Name
            // 
            colName.HeaderText = "Имя";
            colName.Name = "Name";
            colName.ReadOnly = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(13, 410);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(139, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // OpenButton
            // 
            OpenButton = new Button();
            OpenButton.Location = new Point(520, 410);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(139, 23);
            OpenButton.TabIndex = 4;
            OpenButton.Text = "Открыть";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(180, 410);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(150, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(367, 410);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(135, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteButton);
            Controls.Add(OpenButton);
            Controls.Add(SaveButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            this.Name = "Form1";
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
    }
}
