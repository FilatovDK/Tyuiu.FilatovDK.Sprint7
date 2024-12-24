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
        public string openFilePath;
        DataService ds = new DataService();
        public string FolderContr = @"C:\Users\fiirv\source\repos\Tyuiu.FilatovDK.Sprint7\Tyuiu.FilatovDK.Sprint7.Project.V13\bin\Debug";
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

        private void buttonEnter_FDK_Click(object sender, EventArgs e)
        {
            chartDiag_FDK.Series[0].Points.AddXY(Convert.ToDouble(textBoxSquare_FDK.Text), Convert.ToDouble(textBoxPopulation_FDK.Text));
        }
    }
}

