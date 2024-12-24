namespace Tyuiu.FilatovDK.Sprint7.Project.V13
{
    partial class FormStatic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridViewInfo_FDK = new DataGridView();
            chartDiag_FDK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonEnter_FDK = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxPopulation_FDK = new TextBox();
            textBoxSquare_FDK = new TextBox();
            textBoxWriteCountry_FDK = new TextBox();
            buttonSearch_FDK = new Button();
            openFileDialog_FDK = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_FDK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_FDK).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInfo_FDK
            // 
            dataGridViewInfo_FDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo_FDK.Location = new Point(8, 18);
            dataGridViewInfo_FDK.Name = "dataGridViewInfo_FDK";
            dataGridViewInfo_FDK.Size = new Size(362, 346);
            dataGridViewInfo_FDK.TabIndex = 0;
            // 
            // chartDiag_FDK
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_FDK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_FDK.Legends.Add(legend1);
            chartDiag_FDK.Location = new Point(380, 12);
            chartDiag_FDK.Name = "chartDiag_FDK";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_FDK.Series.Add(series1);
            chartDiag_FDK.Size = new Size(418, 346);
            chartDiag_FDK.TabIndex = 1;
            chartDiag_FDK.Text = "chart1";
            // 
            // buttonEnter_FDK
            // 
            buttonEnter_FDK.Location = new Point(696, 396);
            buttonEnter_FDK.Name = "buttonEnter_FDK";
            buttonEnter_FDK.Size = new Size(92, 42);
            buttonEnter_FDK.TabIndex = 2;
            buttonEnter_FDK.Text = "Выполнить";
            buttonEnter_FDK.UseVisualStyleBackColor = true;
            buttonEnter_FDK.Click += buttonEnter_FDK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(561, 378);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Население";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 378);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 4;
            label2.Text = "Площадь страны";
            // 
            // textBoxPopulation_FDK
            // 
            textBoxPopulation_FDK.Location = new Point(561, 396);
            textBoxPopulation_FDK.Name = "textBoxPopulation_FDK";
            textBoxPopulation_FDK.Size = new Size(100, 23);
            textBoxPopulation_FDK.TabIndex = 5;
            // 
            // textBoxSquare_FDK
            // 
            textBoxSquare_FDK.Location = new Point(424, 396);
            textBoxSquare_FDK.Name = "textBoxSquare_FDK";
            textBoxSquare_FDK.Size = new Size(100, 23);
            textBoxSquare_FDK.TabIndex = 6;
            // 
            // textBoxWriteCountry_FDK
            // 
            textBoxWriteCountry_FDK.Location = new Point(104, 415);
            textBoxWriteCountry_FDK.Name = "textBoxWriteCountry_FDK";
            textBoxWriteCountry_FDK.Size = new Size(100, 23);
            textBoxWriteCountry_FDK.TabIndex = 7;
            // 
            // buttonSearch_FDK
            // 
            buttonSearch_FDK.Location = new Point(12, 396);
            buttonSearch_FDK.Name = "buttonSearch_FDK";
            buttonSearch_FDK.Size = new Size(86, 42);
            buttonSearch_FDK.TabIndex = 8;
            buttonSearch_FDK.Text = "Найти";
            buttonSearch_FDK.UseVisualStyleBackColor = true;
            buttonSearch_FDK.Click += buttonSearch_FDK_Click;
            // 
            // openFileDialog_FDK
            // 
            openFileDialog_FDK.FileName = "openFileDialog1";
            // 
            // FormStatic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSearch_FDK);
            Controls.Add(textBoxWriteCountry_FDK);
            Controls.Add(textBoxSquare_FDK);
            Controls.Add(textBoxPopulation_FDK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEnter_FDK);
            Controls.Add(chartDiag_FDK);
            Controls.Add(dataGridViewInfo_FDK);
            Name = "FormStatic";
            Text = "FormStatic";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_FDK).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_FDK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewInfo_FDK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_FDK;
        private Button buttonEnter_FDK;
        private Label label1;
        private Label label2;
        private TextBox textBoxPopulation_FDK;
        private TextBox textBoxSquare_FDK;
        private TextBox textBoxWriteCountry_FDK;
        private Button buttonSearch_FDK;
        private OpenFileDialog openFileDialog_FDK;
    }
}