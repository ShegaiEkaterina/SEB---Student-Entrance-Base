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

namespace dtbasestudents
{
    public partial class studentlistsadd : Form
    {
        public studentlistsadd()
        {
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
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

        private void menuItem2_Click(object sender, EventArgs e)
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
    }
}
