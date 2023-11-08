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
                }
            }

            // Отображаем результаты на форме
            labelTotalStudents.Text = $"Всего студентов: {totalStudents}";
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
                           $"Всего студентов: {totalStudents}\n";

            // Добавьте заголовок для ФИО и информации о паре
            report += "ФИО студентов, отсутствующих или отпущенных, и информация о паре:\n";

            // Создайте словарь для хранения информации о парах и именах студентов
            Dictionary<string, List<string>> pairInfoDict = new Dictionary<string, List<string>>();

            // Переберите строки в dataGridView1
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Получите ФИО студента из соответствующей ячейки (предположим, что ФИО находится во второй ячейке - Column2)
                    string fullName = row.Cells["Column2"].Value as string;

                    // Проверьте статусы студента на каждой паре и добавьте информацию о парах
                    if (row.Cells["Column3"].Value as string == "Отсутствует")
                    {
                        string pair = "0 Пара";
                        if (!pairInfoDict.ContainsKey(pair))
                        {
                            pairInfoDict[pair] = new List<string>();
                        }
                        pairInfoDict[pair].Add(fullName);
                    }
                    if (row.Cells["Column4"].Value as string == "Отсутствует")
                    {
                        string pair = "1 Пара";
                        if (!pairInfoDict.ContainsKey(pair))
                        {
                            pairInfoDict[pair] = new List<string>();
                        }
                        pairInfoDict[pair].Add(fullName);
                    }
                    if (row.Cells["Column5"].Value as string == "Отсутствует")
                    {
                        string pair = "2 Пара";
                        if (!pairInfoDict.ContainsKey(pair))
                        {
                            pairInfoDict[pair] = new List<string>();
                        }
                        pairInfoDict[pair].Add(fullName);
                    }
                    if (row.Cells["Column6"].Value as string == "Отсутствует")
                    {
                        string pair = "3 Пара";
                        if (!pairInfoDict.ContainsKey(pair))
                        {
                            pairInfoDict[pair] = new List<string>();
                        }
                        pairInfoDict[pair].Add(fullName);
                    }
                    if (row.Cells["Column7"].Value as string == "Отсутствует")
                    {
                        string pair = "4 Пара";
                        if (!pairInfoDict.ContainsKey(pair))
                        {
                            pairInfoDict[pair] = new List<string>();
                        }
                        pairInfoDict[pair].Add(fullName);
                    }
                }
            }

            // Добавьте информацию о парам и именах студентов в отчет
            foreach (var pairInfo in pairInfoDict)
            {
                report += "\n" + pairInfo.Key + ":\n";
                foreach (var studentName in pairInfo.Value)
                {
                    string status = "Отсутствует";
                    string modifiedStudentName = studentName;
                    if (studentName.EndsWith("Отпущен(а)"))
                    {
                        status = "Отпущен(а)";
                        modifiedStudentName = studentName.Substring(0, studentName.Length - 11).Trim();
                    }
                    report += status + " " + modifiedStudentName + "\n";
                }
            }

            // Добавьте комментарии
            report += "\nКомментарии:";

            // Вставьте созданную строку в richTextBox1
            richTextBox1.Text = report;
        }

        public void CopyDataFromForm1(DataGridView sourceDataGridView)
        {
            // Очистите dataGridView1 в reportstudents, если там уже есть данные.
            dataGridView1.Rows.Clear();

            // Скопируйте данные из sourceDataGridView в dataGridView1 в reportstudents.
            foreach (DataGridViewRow row in sourceDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    int rowIndex = dataGridView1.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
                }
            }
        }

        private void reportstudents_Load(object sender, EventArgs e)
        {
            // Получите доступ к форме form1 (предположим, что она называется form1) и скопируйте данные.
            Form1 form1 = Application.OpenForms["form1"] as Form1;

            if (form1 != null)
            {
                // Передайте данные из dataGridView1 в reportstudents.
                CopyDataFromForm1(form1.dataGridView1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получите выбранную дату из monthCalendar1
            DateTime selectedDate = monthCalendar1.SelectionStart;

            // Преобразуйте выбранную дату в строку с определенным форматом
            string selectedDateStr = selectedDate.ToString("dd/MM/yyyy"); // Вы можете выбрать любой желаемый формат

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
            string currentDateStr = currentDate.ToString("dd/MM/yyyy"); // Вы можете выбрать любой желаемый формат

            // Получите текущую позицию курсора
            int cursorPosition = richTextBox1.SelectionStart;

            // Вставьте строку с текущей датой в текущую позицию курсора
            richTextBox1.Text = richTextBox1.Text.Insert(cursorPosition, currentDateStr);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string report = $"Всего студентов: {totalStudents}\n";

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
