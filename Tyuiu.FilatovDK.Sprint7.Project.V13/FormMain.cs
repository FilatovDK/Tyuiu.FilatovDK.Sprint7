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
                saveFileDialog_FDK.FileName = "Инфа о стране.csv";//Устанавливает имя файла по умолчанию для диалогового окна сохранения файла

                if (saveFileDialog_FDK.ShowDialog() == DialogResult.OK)//Открывает диалоговое окно для сохранения файла. Если пользователь нажимает кнопку OK, выполнение переходит внутрь блока if
                {
                    string savePath = saveFileDialog_FDK.FileName;//Сохраняет полный путь к выбранному файлу в переменной savePath. FileName возвращает путь к файлу, который выбрал пользователь.


                    if (File.Exists(savePath))//Проверяет, существует ли файл по указанному пути
                    {
                        File.Delete(savePath);//Если файл существует, эта строка удаляет его с помощью метода File.Delete()
                    }

                    int rows = dataGridViewInfo_FDK.RowCount;//Получает количество строк в элементе управления DataGridView с именем dataGridViewInfo_FDK и сохраняет это значение в переменной rows
                    int columns = dataGridViewInfo_FDK.ColumnCount;//Получает количество столбцов в dataGridViewInfo_FDK и сохраняет это значение в переменной columns

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)//Начинает цикл, который будет проходить по всем строкам DataGridView
                    {
                        for (int j = 0; j < columns; j++)//Начинает вложенный цикл, который будет проходить по всем столбцам текущей строки
                        {

                            string cellValue = dataGridViewInfo_FDK.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;//Получает значение ячейки из DataGridView. Если ячейка пустая (null), используется пустая строка


                            cellValue = cellValue.Replace("\"", "\"\"");//Заменяет все двойные кавычки в значении ячейки на две двойные кавычки. Это необходимо для корректного формирования CSV, где двойные кавычки должны быть экранированы


                            strBuilder.Append($"\"{cellValue}\"");//Добавляет значение ячейки в StringBuilder, заключая его в двойные кавычки


                            if (j != columns - 1)
                            {
                                strBuilder.Append(",");
                            }//Если текущий столбец не последний, добавляет запятую после значения ячейки для разделения значений в CSV
                        }
                        strBuilder.AppendLine();//Закрывает вложенный цикл и добавляет символ новой строки в StringBuilder, чтобы перейти к следующей строке в CSV
                    }


                    File.WriteAllText(savePath, strBuilder.ToString(), Encoding.UTF8);//Записывает содержимое StringBuilder в файл по указанному пути savePath с кодировкой UTF-8

                    MessageBox.Show("Файл успешно сохранен на ваш компьютер", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);//Показывает сообщение о том, что файл был успешно сохранен. Используется
                }
            }
            catch (Exception ex)
            {//Закрывает блок try и открывает блок catch, который будет выполнен, если в блоке try возникнет исключение
                MessageBox.Show($"Ошибка: {ex.Message}\nФайл не был сохранен на ваш компьютер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);//Показывает сообщение об ошибке, если возникло исключение
            }
        }



        private void buttonDeleteCountry_FDK_Click(object sender, EventArgs e)
        {
            openFileDialog_FDK.ShowDialog();//Открывает диалоговое окно для выбора файла. Пользователь может выбрать файл, который он хочет удалить
            openFilePath = openFileDialog_FDK.FileName;//Сохраняет путь к выбранному файлу в переменной openFilePath. FileName возвращает полный путь к файлу, который выбрал пользователь.
            if (File.Exists(openFilePath))// Проверяет, существует ли файл по указанному пути openFilePath.Если файл существует, выполнение перейдет в блок if.
            {
                File.Delete(openFilePath);//Если файл существует, эта строка удаляет файл по указанному пути с помощью метода File.Delete()
                MessageBox.Show("Файл удален", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);//Показывает сообщение пользователю о том, что файл был успешно удален.
            }
            else
            {
                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);//Показывает сообщение о том, что файл не был найден
            }
        }

        private void textBoxSquare_FDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonSearch_FDK_Click(object sender, EventArgs e) //При нажатии кнопки открывается диалоговое окно для выбора файла.
        {
            openFileDialog_FDK.ShowDialog();//Открывает диалоговое окно для выбора файла. Пользователь может выбрать файл, и после этого выполнение программы продолжится
            openFilePath = openFileDialog_FDK.FileName;//Сохраняет путь к выбранному файлу в переменной openFilePath. FileName — это свойство, которое возвращает полный путь к файлу, выбранному пользователем.
            textBoxWriteCountry_FDK.Text = Path.GetFileNameWithoutExtension(openFileDialog_FDK.FileName);//Извлекает имя файла без расширения с помощью Path.GetFileNameWithoutExtension() и устанавливает его в текстовое поле textBoxWriteCountry_FDK. Это позволяет пользователю видеть, какой файл был выбран.
            string[,] matrix = ds.GetMatrix(openFilePath);//Вызывает метод GetMatrix у объекта ds, передавая ему путь к файлу openFilePath. Метод, вероятно, считывает данные из файла и возвращает их в виде двумерного массива строк matrix
            int rows = matrix.GetLength(0);//Получает количество строк в массиве matrix с помощью метода GetLength(0) и сохраняет это значение в переменной rows
            int column = matrix.GetLength(1);//Получает количество столбцов в массиве matrix с помощью метода GetLength(1) и сохраняет это значение в переменной column
            dataGridViewInfo_FDK.RowCount = rows;//Устанавливает количество строк в элементе управления dataGridViewInfo_FDK равным количеству строк в массиве matrix
            dataGridViewInfo_FDK.ColumnCount = column;//Устанавливает количество столбцов в элементе управления dataGridViewInfo_FDK равным количеству столбцов в массиве matrix
            for (int i = 0; i < column; i++)
            {
                dataGridViewInfo_FDK.Columns[i].Width = 130;//Цикл, который проходит по всем столбцам dataGridViewInfo_FDK и устанавливает ширину каждого столбца равной 130 пикселей. Это делает таблицу более читаемой
            }
            dataGridViewInfo_FDK.RowHeadersWidth = 250;//Устанавливает ширину заголовков строк в dataGridViewInfo_FDK равной 250 пикселей. Это может быть полезно для отображения длинных названий.
            dataGridViewInfo_FDK.Rows[0].HeaderCell.Value = "Название страны";//Устанавливает текст заголовка первой строки (индекс 0) в dataGridViewInfo_FDK на "Название страны"
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
                    dataGridViewInfo_FDK.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }//Два вложенных цикла, которые проходят по всем элементам массива matrix. Внешний цикл проходит по строкам, а внутренний — по столбцам. Каждое значение из массива matrix помещается в соответствующую ячейку dataGridViewInfo_FDK.

        private void buttonInformation_FDK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();//Создает новый экземпляр формы FormAbout, которая, содержит информацию о приложении или разработчике.
            formAbout.ShowDialog();//Открывает диалоговое окно formAbout, позволяя пользователю взаимодействовать с этой формой. После закрытия этого окна выполнение вернется к текущей форме.
        }
        private void buttonStatistics_FDK_Click(object sender, EventArgs e)
        {
            FormStatic formStatic = new FormStatic();//Создает новый экземпляр формы FormStatic, которая, вероятно, отображает статистику или аналитическую информацию.
            formStatic.ShowDialog();//Открывает диалоговое окно formStatic, позволяя пользователю взаимодействовать с этой формой. После закрытия этого окна выполнение вернется к текущей форме.
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxCountryName_FDK_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRed_FDK_Click(object sender, EventArgs e)
        {
            dataGridViewInfo_FDK.ReadOnly = false;
        }
    }
}