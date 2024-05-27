using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sklad_Predpriyatiya
{
    public partial class Form1 : Form
    {
        DataBaseOperations DBOperations = new DataBaseOperations("Data Source=C:\\Users\\D3MCHIK\\Desktop\\organizationStorage.db");
        FormElementsOperations FEOperations = new FormElementsOperations();
        string sqlQuery = "SELECT * FROM @";
        string[] adminTables = new string[8]
        {
            "category",
            "status",
            "customer",
            "provider",
            "worker",
            "product",
            "input_invoice",
            "output_invoice"
        }; // ПОМЕНЯТЬ НА НАЗВАНИЯ ВАШИХ ТАБЛИЦ БД ДЛЯ АДМИНА
        string[] managerTables = new string[5]
        {
            "customer",
            "provider",
            "product",
            "input_invoice",
            "output_invoice"
        }; // // ПОМЕНЯТЬ НА НАЗВАНИЯ ВАШИХ ТАБЛИЦ БД ДЛЯ МЕНЕДЖЕРА
        string currentTable = "";
        DataGridView currentGridView = null;
        List<DataGridView> dataGridViews = new List<DataGridView>();
        List<TabPage> _AllPages = new List<TabPage>();
        bool isAdmin;
        List<string> _AdminLogins = new List<string>() { "usyalAdmin" };
        List<string> _AdminPasswords = new List<string>() { "strongPassword" };
        List<string> _ManagerLogins = new List<string>() { "currManager" };
        List<string> _ManagerPasswords = new List<string>() { "currManPass" };
        List<string> _ManagerPages = new List<string>() { "customers", "providers", "products", "inputInvoices", "outputInvoices" }; // ПОМЕНЯТЬ НА НАЗВАНИЯ ВАШИХ ТАБЛИЦ БД ДЛЯ МЕНЕДЖЕРА

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViews.Add(CategoriesGridView);
            dataGridViews.Add(StatusesGridView);
            dataGridViews.Add(CustomersGridView);
            dataGridViews.Add(ProvidersGridView);
            dataGridViews.Add(WorkersGridView);
            dataGridViews.Add(ProductsGridView);
            dataGridViews.Add(InpInvGridView);
            dataGridViews.Add(OutInvGridView);

            DBTabs.Selected += DBTabs_Selected;
            currentGridView = CategoriesGridView;

            foreach (TabPage tabPage in DBTabs.TabPages)
            {
                if (!tabPage.Name.Contains("login"))
                {
                    Button AddRow = FEOperations.AddButton(
                        "Добавить...", new Point(686, 370), new Size(0, 0), tabPage.Name + "AddRow"
                    );
                    AddRow.Click += AddRow_Click;
                    tabPage.Controls.Add(AddRow);
                    Button DelRow = FEOperations.AddButton(
                        "Удалить...", new Point(605, 370), new Size(0, 0), tabPage.Name + "DelRow"
                    );
                    DelRow.Click += DelRow_Click;
                    tabPage.Controls.Add(DelRow);

                    _AllPages.Add(tabPage);
                    DBTabs.TabPages.RemoveAt(0);
                }
                else
                {
                    loginPage_ErrorLabel.Text = string.Empty;
                    submit.Click += Submit_Click;
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(_AdminLogins.Contains(loginPage_LoginInput.Text))
            {
                if (_AdminPasswords.Contains(loginPage_PasswordInput.Text))
                {
                    DBTabs.TabPages.RemoveAt(0);

                    foreach (TabPage tabPage in _AllPages)
                    {
                        DBTabs.TabPages.Add(tabPage);
                    }

                    isAdmin = true;
                    currentTable = adminTables[0];
                    UpdateDataGridViews();
                }
                else
                {
                    loginPage_ErrorLabel.Text = "Неправильный пароль!";
                }
            }
            else if (_ManagerLogins.Contains(loginPage_LoginInput.Text))
            {
                if (_ManagerPasswords.Contains(loginPage_PasswordInput.Text))
                {
                    DBTabs.TabPages.RemoveAt(0);

                    foreach (TabPage tabPage in _AllPages)
                    {
                        if (_ManagerPages.Contains(tabPage.Name))
                        {
                            DBTabs.TabPages.Add(tabPage);
                        }
                    }

                    dataGridViews.Remove(CategoriesGridView);
                    dataGridViews.Remove(StatusesGridView);
                    dataGridViews.Remove(WorkersGridView);

                    isAdmin = false;
                    currentTable = managerTables[0];
                    UpdateDataGridViews();
                }
                else
                {
                    loginPage_ErrorLabel.Text = "Неправильный пароль!";
                }
            }
            else
            {
                loginPage_ErrorLabel.Text = "Пользователь не найден!";
            }
        }

        private void DBTabs_Selected(object sender, TabControlEventArgs e)
        {
            if (DBTabs.SelectedIndex <= DBTabs.TabPages.Count - 1 && DBTabs.SelectedIndex >= 0) {
                if (isAdmin)
                {
                    currentGridView = dataGridViews[DBTabs.SelectedIndex];
                    currentTable = adminTables[DBTabs.SelectedIndex];
                }
                else
                {
                    currentGridView = dataGridViews[DBTabs.SelectedIndex];
                    currentTable = managerTables[DBTabs.SelectedIndex];
                }
            }
        }

        public void UpdateDataGridViews()
        {
            if(isAdmin)
                for(int i = 0; i < adminTables.Length; i++)
                {
                    dataGridViews[i].DataSource = DBOperations.LoadTable(sqlQuery.Replace("@", adminTables[i]));
                }
            else
                for (int i = 0; i < managerTables.Length; i++)
                {
                    dataGridViews[i].DataSource = DBOperations.LoadTable(sqlQuery.Replace("@", managerTables[i]));
                }
        }

        private void DelRow_Click(object sender, EventArgs e)
        {
            if (currentGridView.SelectedRows.Count >= 1)
            {
                string sqlQuery = DBOperations.GenerateDeleteRequest(currentTable, currentGridView);
                DBOperations.ExecuteOperation(sqlQuery);
                UpdateDataGridViews();
            }
            else
            {
                MessageBox.Show("Выберите 1 или более строк\nдля удаления!", "Внимание!");
            }
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            AddRowForm _AddRowForm = new AddRowForm();
            _AddRowForm.mainForm = this;
            _AddRowForm._ConnectionString = DBOperations.GetConnectionString();
            _AddRowForm.tableName = currentTable;
            foreach (DataGridViewColumn column in currentGridView.Columns)
            {
                _AddRowForm.columns.Add(column.Name);
            }
            _AddRowForm.Init();
            _AddRowForm.Show();
            Hide();
        }
    }
}