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

namespace dtbasestudents
{
    public partial class loginseb : Form
    {
        public loginseb()
        {
            InitializeComponent();
        }

        private bool IsUserCredentialsValid(string usernameOrEmail, string password)
        {
            string fileName = "accounts.SEbase";
            string[] lines = File.ReadAllLines(fileName);

            bool isAccountSection = false;
            string storedUsernameOrEmail = null;
            string storedPassword = null;

            foreach (string line in lines)
            {
                if (line.StartsWith("[Account]"))
                {
                    if (isAccountSection)
                    {
                        // Если уже нашли секцию аккаунта, проверяем данные
                        if (storedUsernameOrEmail == usernameOrEmail && storedPassword == password)
                        {
                            return true;
                        }
                    }

                    isAccountSection = true;
                    storedUsernameOrEmail = null;
                    storedPassword = null;
                }
                else if (line.StartsWith("Имя пользователя: "))
                {
                    storedUsernameOrEmail = line.Substring("Имя пользователя: ".Length);
                }
                else if (line.StartsWith("Пароль: "))
                {
                    storedPassword = line.Substring("Пароль: ".Length);
                }
            }

            // Проверка последней записи (если она есть)
            if (isAccountSection && storedUsernameOrEmail == usernameOrEmail && storedPassword == password)
            {
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
            string usernameOrEmail = comboBox1.Text;
            string password = textBox2.Text;

            if (IsUserCredentialsValid(usernameOrEmail, password))
            {
                // Вход выполнен успешно
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }

            if (checkBox1.Checked)
            {
                // Если флажок checkBox1 отмечен, сохраните содержимое ComboBox
                Properties.Settings.Default.ComboBoxItems = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.ComboBoxItems.AddRange(comboBox1.Items.OfType<string>().ToArray());
            }
            else
            {
                //Ничего не делать
            }
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regestrationseb regestration = new regestrationseb();
            regestration.ShowDialog();
        }

        private void loginseb_Load(object sender, EventArgs e)
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

            // Восстановление содержимого ComboBox
            if (Properties.Settings.Default.ComboBoxItems != null)
            {
                comboBox1.Items.AddRange(Properties.Settings.Default.ComboBoxItems.Cast<string>().ToArray());
            }
        }
    }
}
