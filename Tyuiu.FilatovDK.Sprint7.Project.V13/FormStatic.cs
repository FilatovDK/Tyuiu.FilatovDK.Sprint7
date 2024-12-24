using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.FilatovDK.Sprint7.Project.V13.Lib;

namespace Tyuiu.FilatovDK.Sprint7.Project.V13
{
    public partial class FormStatic : Form
    {
        public FormStatic()
        {
            InitializeComponent();
        }
        public string openFilePath;//Эта строка объявляет публичную строковую переменную openFilePath
        DataService ds = new DataService();
        public string FolderContr = @"C:\Users\fiirv\source\repos\Tyuiu.FilatovDK.Sprint7\Tyuiu.FilatovDK.Sprint7.Project.V13\bin\Debug";
        private void buttonSearch_FDK_Click(object sender, EventArgs e)
        {
            openFileDialog_FDK.ShowDialog();//Открывает диалоговое окно для выбора файла. Метод ShowDialog() отображает диалоговое окно и ожидает, пока пользователь выберет файл или закроет диалог
            openFilePath = openFileDialog_FDK.FileName;//Сохраняет полный путь к выбранному файлу в переменной openFilePath. FileName возвращает путь к файлу, который выбрал пользователь
            textBoxWriteCountry_FDK.Text = Path.GetFileNameWithoutExtension(openFileDialog_FDK.FileName);//Устанавливает текст в текстовом поле textBoxWriteCountry_FDK. Метод Path.GetFileNameWithoutExtension() извлекает имя файла без расширения из полного пути, выбранного пользователем
            string[,] matrix = ds.GetMatrix(openFilePath);
            int rows = matrix.GetLength(0);//Получает количество строк в массиве matrix и сохраняет это значение в переменной rows. Метод GetLength(0) возвращает размер первого измерения (строки) массива
            int column = matrix.GetLength(1);//Получает количество столбцов в массиве matrix и сохраняет это значение в переменной column. Метод GetLength(1) возвращает размер второго измерения (столбцы) массива
            dataGridViewInfo_FDK.RowCount = rows;//Устанавливает количество строк в элементе управления DataGridView с именем dataGridViewInfo_FDK равным количеству строк, полученных из массива matrix
            dataGridViewInfo_FDK.ColumnCount = column;//Устанавливает количество столбцов в dataGridViewInfo_FDK равным количеству столбцов, полученных из массива matrix
            for (int i = 0; i < column; i++)
            {
                dataGridViewInfo_FDK.Columns[i].Width = 130;
            }
            dataGridViewInfo_FDK.RowHeadersWidth = 250;
            dataGridViewInfo_FDK.Rows[0].HeaderCell.Value = "Название страны";//Устанавливает текст заголовка первой строки в dataGridViewInfo_FDK на "Название страны"
            dataGridViewInfo_FDK.Rows[1].HeaderCell.Value = "Столица";
            dataGridViewInfo_FDK.Rows[2].HeaderCell.Value = "Площадь страны";
            dataGridViewInfo_FDK.Rows[3].HeaderCell.Value = "Экономика";
            dataGridViewInfo_FDK.Rows[6].HeaderCell.Value = "Валюта:";
            dataGridViewInfo_FDK.Rows[4].HeaderCell.Value = "Население :";
            dataGridViewInfo_FDK.Rows[5].HeaderCell.Value = "Национальность:";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewInfo_FDK.Rows[i].Cells[j].Value = matrix[i, j];//Устанавливает значение ячейки в dataGridViewInfo_FDK на основе данных из массива matrix. Значение ячейки в строке i и столбце j устанавливается равным соответствующему значению из массива
                }
            }
        }

        private void buttonEnter_FDK_Click(object sender, EventArgs e)
        {
            chartDiag_FDK.Series[0].Points.AddXY(Convert.ToDouble(textBoxSquare_FDK.Text), Convert.ToDouble(textBoxPopulation_FDK.Text));//Эта строка добавляет новую точку на график, который представлен в элементе управления chartDiag_FDK
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void chartDiag_FDK_Click(object sender, EventArgs e)
        {

        }
    }
}

