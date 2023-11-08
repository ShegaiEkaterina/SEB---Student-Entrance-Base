using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace dtbasestudents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetEmailFromSEbase(string usernameOrEmail)
        {
            string fileName = "accounts.SEbase";
            string[] lines = File.ReadAllLines(fileName);

            bool isAccountSection = false;
            string storedUsernameOrEmail = null;
            string storedEmail = null;

            foreach (string line in lines)
            {
                if (line.StartsWith("[Account]"))
                {
                    if (isAccountSection)
                    {
                        // Если уже нашли секцию аккаунта, проверяем данные
                        if (storedUsernameOrEmail == usernameOrEmail)
                        {
                            return storedEmail;
                        }
                    }

                    isAccountSection = true;
                    storedUsernameOrEmail = null;
                    storedEmail = null;
                }
                else if (line.StartsWith("Имя пользователя: "))
                {
                    storedUsernameOrEmail = line.Substring("Имя пользователя: ".Length);
                }
                else if (line.StartsWith("Эл.почта: "))
                {
                    storedEmail = line.Substring("Эл.почта: ".Length);
                }
            }


            // Проверка последней записи (если она есть)
            if (isAccountSection && storedUsernameOrEmail == usernameOrEmail)
            {
                return storedEmail;
            }

            return "Email не найден";
        }

        private string GetRoleFromSEbase(string usernameOrEmail)
        {
            string fileName = "accounts.SEbase";
            string[] lines = File.ReadAllLines(fileName);

            bool isAccountSection = false;
            string storedUsernameOrEmail = null;
            string storedRole = null;

            foreach (string line in lines)
            {
                if (line.StartsWith("[Account]"))
                {
                    if (isAccountSection)
                    {
                        // Если уже нашли секцию аккаунта, проверяем данные
                        if (storedUsernameOrEmail == usernameOrEmail)
                        {
                            return storedRole;
                        }
                    }

                    isAccountSection = true;
                    storedUsernameOrEmail = null;
                    storedRole = null;
                }
                else if (line.StartsWith("Имя пользователя: "))
                {
                    storedUsernameOrEmail = line.Substring("Имя пользователя: ".Length);
                }
                else if (line.StartsWith("Роль: "))
                {
                    storedRole = line.Substring("Роль: ".Length);
                }
            }

            // Если роль не найдена, вернуть пустую строку или значение по умолчанию
            return storedRole ?? "Роль не указана";
        }

        private string GetSchoolFromSEbase(string usernameOrEmail)
        {
            string fileName = "accounts.SEbase";
            string[] lines = File.ReadAllLines(fileName);

            bool isAccountSection = false;
            string storedUsernameOrEmail = null;
            string storedSchool = null;

            foreach (string line in lines)
            {
                if (line.StartsWith("[Account]"))
                {
                    if (isAccountSection)
                    {
                        // Если уже нашли секцию аккаунта, проверяем данные
                        if (storedUsernameOrEmail == usernameOrEmail)
                        {
                            return storedSchool;
                        }
                    }

                    isAccountSection = true;
                    storedUsernameOrEmail = null;
                    storedSchool = null;
                }
                else if (line.StartsWith("Имя пользователя: "))
                {
                    storedUsernameOrEmail = line.Substring("Имя пользователя: ".Length);
                }
                else if (line.StartsWith("Место учебы: "))
                {
                    storedSchool = line.Substring("Место учебы: ".Length);
                }
            }

            // Если место учебы не найдено, вернуть пустую строку или значение по умолчанию
            return storedSchool ?? "Место учебы не указано";
        }

        private string GetSchoolYearFromSEbase(string usernameOrEmail)
        {
            string fileName = "accounts.SEbase";
            string[] lines = File.ReadAllLines(fileName);

            bool isAccountSection = false;
            string storedUsernameOrEmail = null;
            string storedSchoolYear = null;

            foreach (string line in lines)
            {
                if (line.StartsWith("[Account]"))
                {
                    if (isAccountSection)
                    {
                        // Если уже нашли секцию аккаунта, проверяем данные
                        if (storedUsernameOrEmail == usernameOrEmail)
                        {
                            return storedSchoolYear;
                        }
                    }

                    isAccountSection = true;
                    storedUsernameOrEmail = null;
                    storedSchoolYear = null;
                }
                else if (line.StartsWith("Имя пользователя: "))
                {
                    storedUsernameOrEmail = line.Substring("Имя пользователя: ".Length);
                }
                else if (line.StartsWith("Учебный год: "))
                {
                    storedSchoolYear = line.Substring("Учебный год: ".Length);
                }
            }

            // Если учебный год не найден, вернуть пустую строку или значение по умолчанию
            return storedSchoolYear ?? "Учебный год не указан";
        }

        private string GetGroupFromSEbase(string usernameOrEmail)
        {
            string fileName = "accounts.SEbase";
            string[] lines = File.ReadAllLines(fileName);

            bool isAccountSection = false;
            string storedUsernameOrEmail = null;
            string storedGroup = null;

            foreach (string line in lines)
            {
                if (line.StartsWith("[Account]"))
                {
                    if (isAccountSection)
                    {
                        // Если уже нашли секцию аккаунта, проверяем данные
                        if (storedUsernameOrEmail == usernameOrEmail)
                        {
                            return storedGroup;
                        }
                    }

                    isAccountSection = true;
                    storedUsernameOrEmail = null;
                    storedGroup = null;
                }
                else if (line.StartsWith("Имя пользователя: "))
                {
                    storedUsernameOrEmail = line.Substring("Имя пользователя: ".Length);
                }
                else if (line.StartsWith("Группа: "))
                {
                    storedGroup = line.Substring("Группа: ".Length);
                }
            }

            // Если группа не найдена, вернуть пустую строку или значение по умолчанию
            return storedGroup ?? "Группа не указана";
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            // Вход в систему
            loginseb autorization = new loginseb();
            var result = autorization.ShowDialog();

            if (result == DialogResult.OK)
            {
                string usernameOrEmail = autorization.comboBox1.Text;
                string email = GetEmailFromSEbase(usernameOrEmail);
                string role = GetRoleFromSEbase(usernameOrEmail);
                string group = GetGroupFromSEbase(usernameOrEmail);
                string school = GetSchoolFromSEbase(usernameOrEmail);
                string schoolyear = GetSchoolYearFromSEbase(usernameOrEmail);

                label1.Text = usernameOrEmail;
                label2.Text = email;
                label3.Text = "Роль: " + role;
                label4.Text = "Группа: " + group;
                label5.Text = "Место учебы: " + school;
                label6.Text = "Учебный год: " + schoolyear;

                tabControl1.Visible = true;
                menuItem2.Enabled = true;
                menuItem12.Enabled = true;

                menuItem8.Text = usernameOrEmail;
                menuItem9.Text = email;

                this.Text = "[SEB] Student Entrance Base" + " - " + usernameOrEmail + " - " + email + " - " + role + " - " + group + " - " + school + " - " + schoolyear;

                menuItem3.Visible = false;
                menuItem4.Visible = false;
                menuItem10.Visible = false;
                statusBar1.Text = "Вы вошли как " + role;
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            regestrationseb regestration = new regestrationseb();
            regestration.ShowDialog();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Журнал|*.sbm";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDialog.FileName;

                // Получите данные из dataGridView1 и сохраните их в выбранном файле
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            writer.Write(cell.Value);
                            writer.Write("\t"); // Разделитель между значениями (может быть изменен)
                        }
                        writer.WriteLine(); // Переход на следующую строку
                    }
                }
            }
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Журнал|*.sbm";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openDialog.FileName;

                // Подписываемся на событие DataError
                dataGridView1.DataError += DataGridView1_DataError;

                try
                {
                    // Загрузите данные из выбранного файла и отобразите их в dataGridView1
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        dataGridView1.Rows.Clear(); // Очищаем существующие данные

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();

                            if (!string.IsNullOrEmpty(line))
                            {
                                string[] values = line.Split('\t'); // Разделяем строку на значения
                                dataGridView1.Rows.Add(values);
                            }
                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Произошла ошибка при чтении файла: " + ex.Message);
                }
            }
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Обработка ошибок данных
            if (e.Context == DataGridViewDataErrorContexts.Parsing || e.Context == DataGridViewDataErrorContexts.Formatting)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
                {
                    // Очистите содержимое ячейки, если она пуста
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                }
                else
                {
                    // Если возникает ошибка при преобразовании, вы можете игнорировать ее или предпринять другие действия
                    // Например, просто очистите значение ячейки
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                }
            }
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            // Очистить данные в dataGridView1
            dataGridView1.Rows.Clear();
        }

        private void AddColumnToSeries(Series series, DataGridView dataGridView, string checkBoxName, int columnIndex, string columnName)
        {
            CheckBox checkBox = FindCheckBoxInDataGridView(dataGridView, checkBoxName);

            if (checkBox != null && checkBox.Checked)
            {
                // Проверьте, что столбец с данными существует и не пуст
                if (dataGridView.Columns.Contains(columnName))
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells[columnName].Value != null && row.Cells[columnName].Value != DBNull.Value)
                        {
                            double value;
                            if (double.TryParse(row.Cells[columnName].Value.ToString(), out value))
                            {
                                series.Points.AddY(value);
                            }
                        }
                    }
                }
            }
        }

        private CheckBox FindCheckBoxInDataGridView(DataGridView dataGridView, string checkBoxName)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column is DataGridViewCheckBoxColumn && column.Name == checkBoxName)
                {
                    int rowIndex = dataGridView.Rows.Add();
                    return (CheckBox)dataGridView.Rows[rowIndex].Cells[column.Index].FormattedValue;
                }
            }

            return null;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Путь к файлу "accounts.SEbase"
            string fileName = "accounts.SEbase";

            // Проверяем, существует ли файл "accounts.SEbase"
            if (!File.Exists(fileName))
            {
                // Если файл не существует, создаем его и записываем заголовок
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine("[Accounts]");
                }
            }

            // Вход в систему
            loginseb autorization = new loginseb();
            var result = autorization.ShowDialog();

            if (result == DialogResult.OK)
            {
                string usernameOrEmail = autorization.comboBox1.Text;
                string email = GetEmailFromSEbase(usernameOrEmail);
                string role = GetRoleFromSEbase(usernameOrEmail);
                string group = GetGroupFromSEbase(usernameOrEmail);
                string school = GetSchoolFromSEbase(usernameOrEmail);
                string schoolyear = GetSchoolYearFromSEbase(usernameOrEmail);

                label1.Text = usernameOrEmail;
                label2.Text = email;
                label3.Text = "Роль: " + role;
                label4.Text = "Группа: " + group;
                label5.Text = "Место учебы: " + school;
                label6.Text = "Учебный год: " + schoolyear;

                tabControl1.Visible = true;
                menuItem2.Enabled = true;
                menuItem12.Enabled = true;

                menuItem8.Text = usernameOrEmail;
                menuItem9.Text = email;

                menuItem3.Visible = false;
                menuItem4.Visible = false;
                menuItem10.Visible = false;
                statusBar1.Text = "Вы вошли как " + role;
                this.Text = "[SEB] Student Entrance Base" + " - " + usernameOrEmail + " - " + email + " - " + role + " - " + group + " - " + school + " - " + schoolyear;
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            FormAnalizingStudent analizing = new FormAnalizingStudent(dataGridView1);
            analizing.ShowDialog();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            studentlistsadd liststudent = new studentlistsadd();
            liststudent.ShowDialog();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            reportstudents report = new reportstudents(dataGridView1);
            report.ShowDialog();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            aboutSEB about = new aboutSEB();
            about.ShowDialog();
        }
    }
}
