using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dtbasestudents
{
    public partial class reportstudents : Form
    {
        private DataGridView dataGridView;
        public reportstudents(DataGridView dataGridView)
        {
            InitializeComponent();

            this.dataGridView = dataGridView;
            AnalyzeData(dataGridView);
        }

        public int totalStudents = 0;
        public int totalPresent = 0;
        public int totalAbsent = 0;
        public int totalExcused = 0;
        public int totalSick = 0;
        public int totalFree = 0;
        public int totalRespectful = 0;

        private void AnalyzeData(DataGridView dataGridView)
        {


            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    totalStudents++;

                    // Получаем значение чекбоксов для разных статусов
                    bool isPresent = false;
                    bool isAbsent = false;
                    bool isExcused = false;
                    bool isSick = false;
                    bool isFree = false;
                    bool isRespectful = false;

                    if (row.Cells[2].Value != null)
                    {
                        bool.TryParse(row.Cells[2].Value.ToString(), out isPresent);
                    }

                    if (row.Cells[3].Value != null)
                    {
                        bool.TryParse(row.Cells[3].Value.ToString(), out isAbsent);
                    }

                    if (row.Cells[4].Value != null)
                    {
                        bool.TryParse(row.Cells[4].Value.ToString(), out isExcused);
                    }

                    if (row.Cells[5].Value != null)
                    {
                        bool.TryParse(row.Cells[5].Value.ToString(), out isSick);
                    }

                    if (row.Cells[6].Value != null)
                    {
                        bool.TryParse(row.Cells[6].Value.ToString(), out isFree);
                    }

                    if (row.Cells[7].Value != null)
                    {
                        bool.TryParse(row.Cells[7].Value.ToString(), out isRespectful);
                    }


                    // Подсчитываем статистику
                    if (isPresent)
                    {
                        totalPresent++;
                    }
                    if (isAbsent)
                    {
                        totalAbsent++;
                    }
                    if (isExcused)
                    {
                        totalExcused++;
                    }
                    if (isSick)
                    {
                        totalSick++;
                    }
                    if (isFree)
                    {
                        totalFree++;
                    }
                    if (isRespectful)
                    {
                        totalRespectful++;
                    }
                }
            }

            // Отображаем результаты на форме
            labelTotalStudents.Text = $"Всего студентов: {totalStudents}";
            labelTotalPresent.Text = $"Присутствует: {totalPresent}";
            labelTotalAbsent.Text = $"Отсутствует: {totalAbsent}";
            labelTotalExcused.Text = $"Отпущен: {totalExcused}";
            labelTotalSick.Text = $"По болезни: {totalSick}";
            labelTotalFree.Text = $"Свободное посещение: {totalFree}";
            labelTotalRespectful.Text = $"По уважительной причине: {totalRespectful}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Создайте строку с отчетом о посещаемости студентов
            string report = "Отчет о посещаемости студентов:\n\n" +
                           "Колледж/Институт/Организация:\n" +
                           "Курс/Мероприятие:\n" +
                           "Период:\n" +
                           "Преподаватель/Организатор:\n" +
                           "Группа/Мероприятие:\n\n" +
                           "Общая посещаемость группы/мероприятия:\n" +
                           $"Всего студентов: {totalStudents}\n" +
                           $"Присутствует: {totalPresent}\n" +
                           $"Отсутствует: {totalAbsent}\n" +
                           $"Отпущен: {totalExcused}\n" +
                           $"По болезни: {totalSick}\n" +
                           $"Свободное посещение: {totalFree}\n" +
                           $"По уважительной причине: {totalRespectful}\n\n" +
                           "Комментарии:";

            // Вставьте созданную строку в richTextBox1
            richTextBox1.Text = report;
        }

        private void reportstudents_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получите выбранную дату из monthCalendar1
            DateTime selectedDate = monthCalendar1.SelectionStart;

            // Преобразуйте выбранную дату в строку с определенным форматом
            string selectedDateStr = selectedDate.ToString("yyyy-MM-dd"); // Вы можете выбрать любой желаемый формат

            // Получите текущую позицию курсора
            int cursorPosition = richTextBox1.SelectionStart;

            // Вставьте строку с выбранной датой в текущую позицию курсора
            richTextBox1.Text = richTextBox1.Text.Insert(cursorPosition, selectedDateStr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получите текущую дату
            DateTime currentDate = DateTime.Now;

            // Преобразуйте текущую дату в строку с определенным форматом
            string currentDateStr = currentDate.ToString("yyyy-MM-dd"); // Вы можете выбрать любой желаемый формат

            // Получите текущую позицию курсора
            int cursorPosition = richTextBox1.SelectionStart;

            // Вставьте строку с текущей датой в текущую позицию курсора
            richTextBox1.Text = richTextBox1.Text.Insert(cursorPosition, currentDateStr);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string report = $"Всего студентов: {totalStudents}\n" +
                           $"Присутствует: {totalPresent}\n" +
                           $"Отсутствует: {totalAbsent}\n" +
                           $"Отпущен: {totalExcused}\n" +
                           $"По болезни: {totalSick}\n" +
                           $"Свободное посещение: {totalFree}\n" +
                           $"По уважительной причине: {totalRespectful}\n\n";

            // Получите текущую позицию курсора
            int cursorPosition = richTextBox1.SelectionStart;

            // Вставьте отчет в текущую позицию курсора
            richTextBox1.Text = richTextBox1.Text.Insert(cursorPosition, report);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка, если текст в richTextBox1 пустой, то нечего сохранять
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Нечего сохранять, так как текст пуст.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Откройте диалоговое окно сохранения файла
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Получите имя файла, выбранное пользователем
                    string fileName = saveFileDialog1.FileName;

                    // Сохраните текст из richTextBox1 в файл в формате RTF
                    richTextBox1.SaveFile(fileName, RichTextBoxStreamType.RichText);

                    MessageBox.Show("Отчет успешно сохранен.", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
