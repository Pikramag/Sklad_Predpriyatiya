using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sklad_Predpriyatiya
{
    public partial class AddRowForm : Form
    {
        private DataBaseOperations DBOperations;
        private FormElementsOperations FEOperations = new FormElementsOperations();
        public string tableName;
        public string _ConnectionString;
        public List<string> columns = new List<string>();
        public Form1 mainForm;
        private List<TextBox> textBoxes = new List<TextBox>();
        private Point startPoint = new Point(13, 13);

        public AddRowForm()
        {
            InitializeComponent();
        }

        public void Init()
        {
            DBOperations = new DataBaseOperations(_ConnectionString);

            AddTextBoxes();
            Size = new Size(200, startPoint.Y + 63 * textBoxes.Count);
            Button addRow = FEOperations.AddButton(
                "Добавить строку",
                new Point(startPoint.X, textBoxes[textBoxes.Count - 1].Location.Y + 35),
                new Size(150, 25)
            );
            addRow.Click += AddRow_Click;
            Controls.Add(addRow);
            Button cancel = FEOperations.AddButton(
                "Отменить добавление",
                new Point(startPoint.X, addRow.Location.Y + 35),
                new Size(150, 25)
            );
            cancel.Click += Cancel_Click;
            Controls.Add(cancel);
            Size = new Size(200, Size.Height + addRow.Height + cancel.Height + 45);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            foreach (TextBox box in textBoxes)
            {
                if (box.Text.Length < 1)
                {
                    MessageBox.Show("Все поля должны\nбыть заполнены!");
                    return;
                }
            }
            string sqlQuery = DBOperations.GenerateInsertRequest(tableName, columns, textBoxes);
            DBOperations.ExecuteOperation(sqlQuery);

            Controls.Clear();
            Close();
        }

        private void AddTextBoxes()
        {
            for (int i = 0; i < columns.Count; i++)
            {
                textBoxes.Add(
                    FEOperations.AddTextBoxToForm(
                        columns[i], new Point(startPoint.X, startPoint.Y + 50 * i),
                        new Size(150, 20), this, columns[i]
                    )
                );
            }
        }

        private void AddRowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.UpdateDataGridViews();
            mainForm.Show();
        }
    }
}