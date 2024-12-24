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
using Tyuiu.FilatovDK.Sprint7.Project.V13.Lib;
namespace Tyuiu.FilatovDK.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_FDK.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_FDK.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        public string openFilePath;
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCountry_FDK_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_FDK.FileName = "Инфа о стране.csv";//как зовут файл

                if (saveFileDialog_FDK.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog_FDK.FileName;

                    // Проверка существования файла и его удаление, если требуется  
                    if (File.Exists(savePath))
                    {
                        File.Delete(savePath);
                    }

                    int rows = dataGridViewInfo_FDK.RowCount;
                    int columns = dataGridViewInfo_FDK.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            // Проверка на null значение ячейки  
                            string cellValue = dataGridViewInfo_FDK.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;

                            // Замена кавычек внутри значения на две кавычки для CSV  
                            cellValue = cellValue.Replace("\"", "\"\"");

                            // Оборачиваем значение в кавычки  
                            strBuilder.Append($"\"{cellValue}\"");

                            // Добавляем разделитель только если это не последний элемент в строке  
                            if (j != columns - 1)
                            {
                                strBuilder.Append(","); // Разделяем значения запятой  
                            }
                        }
                        strBuilder.AppendLine(); // Конец строки  
                    }

                    // Запись данных в файл с кодировкой UTF-8  
                    File.WriteAllText(savePath, strBuilder.ToString(), Encoding.UTF8);

                    MessageBox.Show("Файл успешно сохранен на ваш компьютер", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) // Добавление информации об ошибке  
            {
                MessageBox.Show($"Ошибка: {ex.Message}\nФайл не был сохранен на ваш компьютер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonDeleteCountry_FDK_Click(object sender, EventArgs e)
        {
            openFileDialog_FDK.ShowDialog();
            openFilePath = openFileDialog_FDK.FileName;
            if (File.Exists(openFilePath))
            {
                File.Delete(openFilePath);
                MessageBox.Show("Файл удален", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSquare_FDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonSearch_FDK_Click(object sender, EventArgs e)
        {
            openFileDialog_FDK.ShowDialog();
            openFilePath = openFileDialog_FDK.FileName;
            textBoxWriteCountry_FDK.Text = Path.GetFileNameWithoutExtension(openFileDialog_FDK.FileName);
            string[,] matrix = ds.GetMatrix(openFilePath);
            int rows = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            dataGridViewInfo_FDK.RowCount = rows;
            dataGridViewInfo_FDK.ColumnCount = column;
            for (int i = 0; i < column; i++)
            {
                dataGridViewInfo_FDK.Columns[i].Width = 130;
            }
            dataGridViewInfo_FDK.RowHeadersWidth = 250;
            dataGridViewInfo_FDK.Rows[0].HeaderCell.Value = "Название страны";
            dataGridViewInfo_FDK.Rows[1].HeaderCell.Value = "Столица";
            dataGridViewInfo_FDK.Rows[2].HeaderCell.Value = "Площадь страны";
            dataGridViewInfo_FDK.Rows[3].HeaderCell.Value = "Экономика";
            dataGridViewInfo_FDK.Rows[4].HeaderCell.Value = "Валюта:";
            dataGridViewInfo_FDK.Rows[5].HeaderCell.Value = "Население :";
            dataGridViewInfo_FDK.Rows[6].HeaderCell.Value = "Национальность:";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewInfo_FDK.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonUpdate_FDK_Click(object sender, EventArgs e)
        {
            textBoxCountryName_FDK.Clear();
            textBoxCapital_FDK.Clear();
            textBoxSquare_FDK.Clear();
            textBoxEconomic_FDK.Clear();
            textBoxPopulation_FDK.Clear();
            textBoxNations_FDK.Clear();
            textBoxCurrency_FDK.Clear();
        }

        private void buttonInformation_FDK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonStatistics_FDK_Click(object sender, EventArgs e)
        {
            FormStatic formStatic = new FormStatic();
            formStatic.ShowDialog();
        }
    }
}