using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dtbasestudents
{
    public partial class regestrationseb : Form
    {
        public regestrationseb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Заполните все обязательные поля.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                string confirmPassword = textBox3.Text;
                string email = textBox4.Text;
                string roles = comboBox1.Text;
                string group = textBox5.Text;
                string school = textBox6.Text;
                string schoolyear = textBox7.Text;

                // Проверка, что пароль и подтверждение пароля совпадают
                if (password != confirmPassword)
                {
                    MessageBox.Show("Пароль и подтверждение пароля не совпадают.");
                    return;
                }

                // Файл для хранения учетных записей
                string fileName = "accounts.SEbase";

                // Запись данных аккаунта в файл
                using (StreamWriter writer = File.AppendText(fileName))
                {
                    writer.WriteLine("[Account]");
                    writer.WriteLine("Имя пользователя: " + username);
                    writer.WriteLine("Пароль: " + password);
                    writer.WriteLine("Эл.почта: " + email);
                    writer.WriteLine("Роль: " + roles);
                    writer.WriteLine("Группа: " + group);
                    writer.WriteLine("Место учебы: " + school);
                    writer.WriteLine("Учебный год: " + schoolyear);
                    writer.WriteLine();
                }

                MessageBox.Show("Учетная запись успешно сохранена.");
            } 
        }

        private void regestrationseb_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else 
            {
                button1.Enabled = false;
            }
        }
    }
}
