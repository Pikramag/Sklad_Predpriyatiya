namespace Sklad_Predpriyatiya
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DBTabs = new System.Windows.Forms.TabControl();
            this.categories = new System.Windows.Forms.TabPage();
            this.CategoriesGridView = new System.Windows.Forms.DataGridView();
            this.statuses = new System.Windows.Forms.TabPage();
            this.StatusesGridView = new System.Windows.Forms.DataGridView();
            this.customers = new System.Windows.Forms.TabPage();
            this.CustomersGridView = new System.Windows.Forms.DataGridView();
            this.providers = new System.Windows.Forms.TabPage();
            this.ProvidersGridView = new System.Windows.Forms.DataGridView();
            this.workers = new System.Windows.Forms.TabPage();
            this.WorkersGridView = new System.Windows.Forms.DataGridView();
            this.products = new System.Windows.Forms.TabPage();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.inputInvoices = new System.Windows.Forms.TabPage();
            this.InpInvGridView = new System.Windows.Forms.DataGridView();
            this.outputInvoices = new System.Windows.Forms.TabPage();
            this.OutInvGridView = new System.Windows.Forms.DataGridView();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.loginPage_ErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.loginPage_PasswordInput = new System.Windows.Forms.TextBox();
            this.loginPage_LoginInput = new System.Windows.Forms.TextBox();
            this.DBTabs.SuspendLayout();
            this.categories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView)).BeginInit();
            this.statuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusesGridView)).BeginInit();
            this.customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).BeginInit();
            this.providers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProvidersGridView)).BeginInit();
            this.workers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersGridView)).BeginInit();
            this.products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.inputInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InpInvGridView)).BeginInit();
            this.outputInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutInvGridView)).BeginInit();
            this.loginPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // DBTabs
            // 
            this.DBTabs.Controls.Add(this.categories);
            this.DBTabs.Controls.Add(this.statuses);
            this.DBTabs.Controls.Add(this.customers);
            this.DBTabs.Controls.Add(this.providers);
            this.DBTabs.Controls.Add(this.workers);
            this.DBTabs.Controls.Add(this.products);
            this.DBTabs.Controls.Add(this.inputInvoices);
            this.DBTabs.Controls.Add(this.outputInvoices);
            this.DBTabs.Controls.Add(this.loginPage);
            this.DBTabs.Location = new System.Drawing.Point(13, 13);
            this.DBTabs.Name = "DBTabs";
            this.DBTabs.SelectedIndex = 0;
            this.DBTabs.Size = new System.Drawing.Size(775, 425);
            this.DBTabs.TabIndex = 0;
            // 
            // categories
            // 
            this.categories.Controls.Add(this.CategoriesGridView);
            this.categories.Location = new System.Drawing.Point(4, 22);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(767, 399);
            this.categories.TabIndex = 6;
            this.categories.Text = "Категории";
            this.categories.UseVisualStyleBackColor = true;
            // 
            // CategoriesGridView
            // 
            this.CategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesGridView.Location = new System.Drawing.Point(7, 7);
            this.CategoriesGridView.Name = "CategoriesGridView";
            this.CategoriesGridView.Size = new System.Drawing.Size(754, 357);
            this.CategoriesGridView.TabIndex = 2;
            // 
            // statuses
            // 
            this.statuses.Controls.Add(this.StatusesGridView);
            this.statuses.Location = new System.Drawing.Point(4, 22);
            this.statuses.Name = "statuses";
            this.statuses.Size = new System.Drawing.Size(767, 399);
            this.statuses.TabIndex = 7;
            this.statuses.Text = "Статусы";
            this.statuses.UseVisualStyleBackColor = true;
            // 
            // StatusesGridView
            // 
            this.StatusesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatusesGridView.Location = new System.Drawing.Point(7, 7);
            this.StatusesGridView.Name = "StatusesGridView";
            this.StatusesGridView.Size = new System.Drawing.Size(754, 357);
            this.StatusesGridView.TabIndex = 2;
            // 
            // customers
            // 
            this.customers.Controls.Add(this.CustomersGridView);
            this.customers.Location = new System.Drawing.Point(4, 22);
            this.customers.Name = "customers";
            this.customers.Padding = new System.Windows.Forms.Padding(3);
            this.customers.Size = new System.Drawing.Size(767, 399);
            this.customers.TabIndex = 0;
            this.customers.Text = "Покупатели";
            this.customers.UseVisualStyleBackColor = true;
            // 
            // CustomersGridView
            // 
            this.CustomersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGridView.Location = new System.Drawing.Point(7, 7);
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.Size = new System.Drawing.Size(754, 357);
            this.CustomersGridView.TabIndex = 0;
            // 
            // providers
            // 
            this.providers.Controls.Add(this.ProvidersGridView);
            this.providers.Location = new System.Drawing.Point(4, 22);
            this.providers.Name = "providers";
            this.providers.Padding = new System.Windows.Forms.Padding(3);
            this.providers.Size = new System.Drawing.Size(767, 399);
            this.providers.TabIndex = 1;
            this.providers.Text = "Поставщики";
            this.providers.UseVisualStyleBackColor = true;
            // 
            // ProvidersGridView
            // 
            this.ProvidersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProvidersGridView.Location = new System.Drawing.Point(7, 7);
            this.ProvidersGridView.Name = "ProvidersGridView";
            this.ProvidersGridView.Size = new System.Drawing.Size(754, 357);
            this.ProvidersGridView.TabIndex = 1;
            // 
            // workers
            // 
            this.workers.Controls.Add(this.WorkersGridView);
            this.workers.Location = new System.Drawing.Point(4, 22);
            this.workers.Name = "workers";
            this.workers.Size = new System.Drawing.Size(767, 399);
            this.workers.TabIndex = 2;
            this.workers.Text = "Сотрудники";
            this.workers.UseVisualStyleBackColor = true;
            // 
            // WorkersGridView
            // 
            this.WorkersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkersGridView.Location = new System.Drawing.Point(7, 7);
            this.WorkersGridView.Name = "WorkersGridView";
            this.WorkersGridView.Size = new System.Drawing.Size(754, 357);
            this.WorkersGridView.TabIndex = 1;
            // 
            // products
            // 
            this.products.Controls.Add(this.ProductsGridView);
            this.products.Location = new System.Drawing.Point(4, 22);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(767, 399);
            this.products.TabIndex = 3;
            this.products.Text = "Товары";
            this.products.UseVisualStyleBackColor = true;
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Location = new System.Drawing.Point(7, 7);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(754, 357);
            this.ProductsGridView.TabIndex = 1;
            // 
            // inputInvoices
            // 
            this.inputInvoices.Controls.Add(this.InpInvGridView);
            this.inputInvoices.Location = new System.Drawing.Point(4, 22);
            this.inputInvoices.Name = "inputInvoices";
            this.inputInvoices.Size = new System.Drawing.Size(767, 399);
            this.inputInvoices.TabIndex = 4;
            this.inputInvoices.Text = "Приходные накладные";
            this.inputInvoices.UseVisualStyleBackColor = true;
            // 
            // InpInvGridView
            // 
            this.InpInvGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InpInvGridView.Location = new System.Drawing.Point(7, 7);
            this.InpInvGridView.Name = "InpInvGridView";
            this.InpInvGridView.Size = new System.Drawing.Size(754, 357);
            this.InpInvGridView.TabIndex = 2;
            // 
            // outputInvoices
            // 
            this.outputInvoices.Controls.Add(this.OutInvGridView);
            this.outputInvoices.Location = new System.Drawing.Point(4, 22);
            this.outputInvoices.Name = "outputInvoices";
            this.outputInvoices.Size = new System.Drawing.Size(767, 399);
            this.outputInvoices.TabIndex = 5;
            this.outputInvoices.Text = "Расходные накладные";
            this.outputInvoices.UseVisualStyleBackColor = true;
            // 
            // OutInvGridView
            // 
            this.OutInvGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutInvGridView.Location = new System.Drawing.Point(7, 7);
            this.OutInvGridView.Name = "OutInvGridView";
            this.OutInvGridView.Size = new System.Drawing.Size(754, 357);
            this.OutInvGridView.TabIndex = 2;
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.loginPage_ErrorLabel);
            this.loginPage.Controls.Add(this.label2);
            this.loginPage.Controls.Add(this.label1);
            this.loginPage.Controls.Add(this.submit);
            this.loginPage.Controls.Add(this.loginPage_PasswordInput);
            this.loginPage.Controls.Add(this.loginPage_LoginInput);
            this.loginPage.Location = new System.Drawing.Point(4, 22);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(767, 399);
            this.loginPage.TabIndex = 8;
            this.loginPage.Text = "Вход";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // loginPage_ErrorLabel
            // 
            this.loginPage_ErrorLabel.AutoSize = true;
            this.loginPage_ErrorLabel.Location = new System.Drawing.Point(11, 373);
            this.loginPage_ErrorLabel.Name = "loginPage_ErrorLabel";
            this.loginPage_ErrorLabel.Size = new System.Drawing.Size(46, 13);
            this.loginPage_ErrorLabel.TabIndex = 2;
            this.loginPage_ErrorLabel.Text = "ERROR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пароль";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(345, 218);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 1;
            this.submit.Text = "Войти";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // loginPage_PasswordInput
            // 
            this.loginPage_PasswordInput.Location = new System.Drawing.Point(333, 192);
            this.loginPage_PasswordInput.Name = "loginPage_PasswordInput";
            this.loginPage_PasswordInput.PasswordChar = '*';
            this.loginPage_PasswordInput.Size = new System.Drawing.Size(100, 20);
            this.loginPage_PasswordInput.TabIndex = 0;
            // 
            // loginPage_LoginInput
            // 
            this.loginPage_LoginInput.Location = new System.Drawing.Point(333, 166);
            this.loginPage_LoginInput.Name = "loginPage_LoginInput";
            this.loginPage_LoginInput.Size = new System.Drawing.Size(100, 20);
            this.loginPage_LoginInput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DBTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Склад предприятия";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DBTabs.ResumeLayout(false);
            this.categories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView)).EndInit();
            this.statuses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatusesGridView)).EndInit();
            this.customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).EndInit();
            this.providers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProvidersGridView)).EndInit();
            this.workers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkersGridView)).EndInit();
            this.products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.inputInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InpInvGridView)).EndInit();
            this.outputInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutInvGridView)).EndInit();
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DBTabs;
        private System.Windows.Forms.TabPage customers;
        private System.Windows.Forms.TabPage providers;
        private System.Windows.Forms.TabPage workers;
        private System.Windows.Forms.TabPage products;
        private System.Windows.Forms.TabPage categories;
        private System.Windows.Forms.TabPage statuses;
        private System.Windows.Forms.TabPage inputInvoices;
        private System.Windows.Forms.TabPage outputInvoices;
        private System.Windows.Forms.DataGridView CustomersGridView;
        private System.Windows.Forms.DataGridView ProvidersGridView;
        private System.Windows.Forms.DataGridView WorkersGridView;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.DataGridView CategoriesGridView;
        private System.Windows.Forms.DataGridView StatusesGridView;
        private System.Windows.Forms.DataGridView InpInvGridView;
        private System.Windows.Forms.DataGridView OutInvGridView;
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.Label loginPage_ErrorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox loginPage_PasswordInput;
        private System.Windows.Forms.TextBox loginPage_LoginInput;
    }
}

