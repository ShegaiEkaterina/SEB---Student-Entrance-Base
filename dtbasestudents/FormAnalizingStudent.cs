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
    public partial class FormAnalizingStudent : Form
    {

        private DataGridView dataGridView;

        public FormAnalizingStudent(DataGridView dataGridView)
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

        private void DrawPieChart(Graphics g, int centerX, int centerY, int radius, float anglePresent, float angleAbsent, float angleExcused, float angleSick, float angleFree, float angleRespectful)
        {
            using (SolidBrush brushPresent = new SolidBrush(Color.Blue))
            using (SolidBrush brushAbsent = new SolidBrush(Color.Red))
            using (SolidBrush brushExcused = new SolidBrush(Color.Green))
            using (SolidBrush brushSick = new SolidBrush(Color.Gray))
            using (SolidBrush brushFree = new SolidBrush(Color.Orange))
            using (SolidBrush brushRespectful = new SolidBrush(Color.Purple))
            {
                // Рисуем каждый сегмент
                g.FillPie(brushPresent, centerX - radius, centerY - radius, radius * 2, radius * 2, 0, anglePresent);
                g.FillPie(brushAbsent, centerX - radius, centerY - radius, radius * 2, radius * 2, anglePresent, angleAbsent);
                g.FillPie(brushExcused, centerX - radius, centerY - radius, radius * 2, radius * 2, anglePresent + angleAbsent, angleExcused);
                g.FillPie(brushSick, centerX - radius, centerY - radius, radius * 2, radius * 2, anglePresent + angleAbsent + angleExcused, angleSick);
                g.FillPie(brushFree, centerX - radius, centerY - radius, radius * 2, radius * 2, anglePresent + angleAbsent + angleExcused + angleSick, angleFree);
                g.FillPie(brushRespectful, centerX - radius, centerY - radius, radius * 2, radius * 2, anglePresent + angleAbsent + angleExcused + angleSick + angleFree, angleRespectful);
            }

            using (Pen pen = new Pen(Color.Black))
            using (Font font = new Font("Arial", 10))
            using (StringFormat sf = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center })
            {
                // Рисуем текст и числа для каждого сегмента
                DrawSegmentLabel(g, totalStudents.ToString(), anglePresent / 2, centerX, centerY, radius, font, sf, pen);
            }
        }

        private void DrawSegmentLabel(Graphics g, string text, float angle, int centerX, int centerY, int radius, Font font, StringFormat sf, Pen pen)
        {
            float x = centerX + radius * 0.7f * (float)Math.Cos(Math.PI * angle / 180.0);
            float y = centerY + radius * 0.7f * (float)Math.Sin(Math.PI * angle / 180.0);

            g.DrawLine(pen, centerX, centerY, x, y);
            g.DrawString(text, font, Brushes.White, x, y, sf);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;
            int radius = Math.Min(centerX, centerY);

            float total = totalPresent + totalAbsent + totalExcused + totalSick + totalFree + totalRespectful;

            float anglePresent = 360.0f * totalPresent / total;
            float angleAbsent = 360.0f * totalAbsent / total;
            float angleExcused = 360.0f * totalExcused / total;
            float angleSick = 360.0f * totalSick / total;
            float angleFree = 360.0f * totalFree / total;
            float angleRespectful = 360.0f * totalRespectful / total;

            DrawPieChart(g, centerX, centerY, radius, anglePresent, angleAbsent, angleExcused, angleSick, angleFree, angleRespectful);
        }

        // Метод для получения случайного цвета

        private void FormAnalizingStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем изображение пироговой диаграммы и устанавливаем его в pictureBox1
            Bitmap pieChartImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(pieChartImage))
            {
                int centerX = pieChartImage.Width / 2;
                int centerY = pieChartImage.Height / 2;
                int radius = Math.Min(centerX, centerY);

                float total = totalPresent + totalAbsent + totalExcused + totalSick + totalFree + totalRespectful;

                float anglePresent = 360.0f * totalPresent / total;
                float angleAbsent = 360.0f * totalAbsent / total;
                float angleExcused = 360.0f * totalExcused / total;
                float angleSick = 360.0f * totalSick / total;
                float angleFree = 360.0f * totalFree / total;
                float angleRespectful = 360.0f * totalRespectful / total;

                DrawPieChart(g, centerX, centerY, radius, anglePresent, angleAbsent, angleExcused, angleSick, angleFree, angleRespectful);
            }

            pictureBox1.Image = pieChartImage; // Устанавливаем изображение в pictureBox1

            if (pictureBox1.Image != null)
            {
                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.Filter = "Изображения|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Все файлы|*.*";
                    saveFileDialog1.Title = "Сохранить изображение";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        // Получите имя файла, выбранное пользователем
                        string fileName = saveFileDialog1.FileName;

                        // Используйте метод Save() для сохранения изображения
                        pictureBox1.Image.Save(fileName);

                        MessageBox.Show("Изображение сохранено успешно.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Изображение не найдено в PictureBox.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
