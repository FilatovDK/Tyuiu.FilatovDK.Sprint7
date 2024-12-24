namespace Tyuiu.FilatovDK.Sprint7.Project.V13
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            openFileDialog_FDK = new OpenFileDialog();
            saveFileDialog_FDK = new SaveFileDialog();
            toolTipButton_FDK = new ToolTip(components);
            buttonInformation_FDK = new Button();
            dataGridViewInfo_FDK = new DataGridView();
            textBoxWriteCountry_FDK = new TextBox();
            groupBoxInPut_FDK = new GroupBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxCurrency_FDK = new TextBox();
            textBoxNations_FDK = new TextBox();
            textBoxPopulation_FDK = new TextBox();
            textBoxEconomic_FDK = new TextBox();
            textBoxSquare_FDK = new TextBox();
            textBoxCapital_FDK = new TextBox();
            textBoxCountryName_FDK = new TextBox();
            buttonAddCountry_FDK = new Button();
            buttonDeleteCountry_FDK = new Button();
            buttonSearch_FDK = new Button();
            buttonUpdate_FDK = new Button();
            buttonStatistics_FDK = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_FDK).BeginInit();
            groupBoxInPut_FDK.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите страну";
            // 
            // openFileDialog_FDK
            // 
            openFileDialog_FDK.FileName = "openFileDialog1";
            // 
            // buttonInformation_FDK
            // 
            buttonInformation_FDK.Location = new Point(416, 12);
            buttonInformation_FDK.Name = "buttonInformation_FDK";
            buttonInformation_FDK.Size = new Size(67, 38);
            buttonInformation_FDK.TabIndex = 18;
            buttonInformation_FDK.Text = "Кто?";
            toolTipButton_FDK.SetToolTip(buttonInformation_FDK, "Показывает кто сделал этот шедевр");
            buttonInformation_FDK.UseVisualStyleBackColor = true;
            buttonInformation_FDK.Click += buttonInformation_FDK_Click;
            // 
            // dataGridViewInfo_FDK
            // 
            dataGridViewInfo_FDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo_FDK.Location = new Point(6, 22);
            dataGridViewInfo_FDK.Name = "dataGridViewInfo_FDK";
            dataGridViewInfo_FDK.Size = new Size(609, 284);
            dataGridViewInfo_FDK.TabIndex = 5;
            // 
            // textBoxWriteCountry_FDK
            // 
            textBoxWriteCountry_FDK.Location = new Point(289, 27);
            textBoxWriteCountry_FDK.Name = "textBoxWriteCountry_FDK";
            textBoxWriteCountry_FDK.Size = new Size(121, 23);
            textBoxWriteCountry_FDK.TabIndex = 6;
            // 
            // groupBoxInPut_FDK
            // 
            groupBoxInPut_FDK.Controls.Add(dataGridViewInfo_FDK);
            groupBoxInPut_FDK.Location = new Point(289, 56);
            groupBoxInPut_FDK.Name = "groupBoxInPut_FDK";
            groupBoxInPut_FDK.Size = new Size(626, 321);
            groupBoxInPut_FDK.TabIndex = 7;
            groupBoxInPut_FDK.TabStop = false;
            groupBoxInPut_FDK.Text = "Информация о стране";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxCurrency_FDK);
            groupBox1.Controls.Add(textBoxNations_FDK);
            groupBox1.Controls.Add(textBoxPopulation_FDK);
            groupBox1.Controls.Add(textBoxEconomic_FDK);
            groupBox1.Controls.Add(textBoxSquare_FDK);
            groupBox1.Controls.Add(textBoxCapital_FDK);
            groupBox1.Controls.Add(textBoxCountryName_FDK);
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 290);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 20);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 13;
            label8.Text = "Название страны";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 19);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 12;
            label7.Text = "Столица страны";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 64);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 11;
            label6.Text = "Площадь страны";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 64);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 10;
            label5.Text = "Экономика";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 146);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 9;
            label4.Text = "Валюта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 108);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Нация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 108);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Население";
            // 
            // textBoxCurrency_FDK
            // 
            textBoxCurrency_FDK.Location = new Point(81, 164);
            textBoxCurrency_FDK.Name = "textBoxCurrency_FDK";
            textBoxCurrency_FDK.Size = new Size(100, 23);
            textBoxCurrency_FDK.TabIndex = 6;
            // 
            // textBoxNations_FDK
            // 
            textBoxNations_FDK.Location = new Point(162, 126);
            textBoxNations_FDK.Name = "textBoxNations_FDK";
            textBoxNations_FDK.Size = new Size(100, 23);
            textBoxNations_FDK.TabIndex = 5;
            // 
            // textBoxPopulation_FDK
            // 
            textBoxPopulation_FDK.Location = new Point(6, 126);
            textBoxPopulation_FDK.Name = "textBoxPopulation_FDK";
            textBoxPopulation_FDK.Size = new Size(100, 23);
            textBoxPopulation_FDK.TabIndex = 4;
            // 
            // textBoxEconomic_FDK
            // 
            textBoxEconomic_FDK.Location = new Point(165, 82);
            textBoxEconomic_FDK.Name = "textBoxEconomic_FDK";
            textBoxEconomic_FDK.Size = new Size(100, 23);
            textBoxEconomic_FDK.TabIndex = 3;
            // 
            // textBoxSquare_FDK
            // 
            textBoxSquare_FDK.Location = new Point(6, 82);
            textBoxSquare_FDK.Name = "textBoxSquare_FDK";
            textBoxSquare_FDK.Size = new Size(100, 23);
            textBoxSquare_FDK.TabIndex = 2;
            // 
            // textBoxCapital_FDK
            // 
            textBoxCapital_FDK.Location = new Point(165, 38);
            textBoxCapital_FDK.Name = "textBoxCapital_FDK";
            textBoxCapital_FDK.Size = new Size(100, 23);
            textBoxCapital_FDK.TabIndex = 1;
            // 
            // textBoxCountryName_FDK
            // 
            textBoxCountryName_FDK.Location = new Point(6, 38);
            textBoxCountryName_FDK.Name = "textBoxCountryName_FDK";
            textBoxCountryName_FDK.Size = new Size(100, 23);
            textBoxCountryName_FDK.TabIndex = 0;
            // 
            // buttonAddCountry_FDK
            // 
            buttonAddCountry_FDK.Location = new Point(18, 12);
            buttonAddCountry_FDK.Name = "buttonAddCountry_FDK";
            buttonAddCountry_FDK.Size = new Size(53, 38);
            buttonAddCountry_FDK.TabIndex = 14;
            buttonAddCountry_FDK.Text = "Сохранить";
            buttonAddCountry_FDK.UseVisualStyleBackColor = true;
            buttonAddCountry_FDK.Click += buttonAddCountry_FDK_Click;
            // 
            // buttonDeleteCountry_FDK
            // 
            buttonDeleteCountry_FDK.Location = new Point(77, 12);
            buttonDeleteCountry_FDK.Name = "buttonDeleteCountry_FDK";
            buttonDeleteCountry_FDK.Size = new Size(55, 38);
            buttonDeleteCountry_FDK.TabIndex = 15;
            buttonDeleteCountry_FDK.Text = "Удалить";
            buttonDeleteCountry_FDK.UseVisualStyleBackColor = true;
            buttonDeleteCountry_FDK.Click += buttonDeleteCountry_FDK_Click;
            // 
            // buttonSearch_FDK
            // 
            buttonSearch_FDK.Location = new Point(138, 12);
            buttonSearch_FDK.Name = "buttonSearch_FDK";
            buttonSearch_FDK.Size = new Size(55, 38);
            buttonSearch_FDK.TabIndex = 16;
            buttonSearch_FDK.Text = "Найти";
            buttonSearch_FDK.UseVisualStyleBackColor = true;
            buttonSearch_FDK.Click += buttonSearch_FDK_Click;
            // 
            // buttonUpdate_FDK
            // 
            buttonUpdate_FDK.Location = new Point(199, 12);
            buttonUpdate_FDK.Name = "buttonUpdate_FDK";
            buttonUpdate_FDK.Size = new Size(62, 38);
            buttonUpdate_FDK.TabIndex = 17;
            buttonUpdate_FDK.Text = "Стереть всё";
            buttonUpdate_FDK.UseVisualStyleBackColor = true;
            buttonUpdate_FDK.Click += buttonUpdate_FDK_Click;
            // 
            // buttonStatistics_FDK
            // 
            buttonStatistics_FDK.Location = new Point(489, 12);
            buttonStatistics_FDK.Name = "buttonStatistics_FDK";
            buttonStatistics_FDK.Size = new Size(61, 38);
            buttonStatistics_FDK.TabIndex = 19;
            buttonStatistics_FDK.Text = "Диограмма";
            buttonStatistics_FDK.UseVisualStyleBackColor = true;
            buttonStatistics_FDK.Click += buttonStatistics_FDK_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 528);
            Controls.Add(buttonStatistics_FDK);
            Controls.Add(buttonInformation_FDK);
            Controls.Add(buttonUpdate_FDK);
            Controls.Add(buttonSearch_FDK);
            Controls.Add(buttonDeleteCountry_FDK);
            Controls.Add(buttonAddCountry_FDK);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxInPut_FDK);
            Controls.Add(textBoxWriteCountry_FDK);
            Controls.Add(label1);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_FDK).EndInit();
            groupBoxInPut_FDK.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button net;
        private TextBox textBoxSearch_FDK;
        private Label label1;
        private Button buttonSaveFile_FDK;
        private Button buttonHelp_FDK;
        private OpenFileDialog openFileDialog_FDK;
        private SaveFileDialog saveFileDialog_FDK;
        private Button buttonOpenFiles_FDK;
        private ToolTip toolTipButton_FDK;
        private DataGridView dataGridViewInfo_FDK;
        private TextBox textBoxWriteCountry_FDK;
        private GroupBox groupBoxInPut_FDK;
        private GroupBox groupBox1;
        private TextBox textBoxCurrency_FDK;
        private TextBox textBoxNations_FDK;
        private TextBox textBoxPopulation_FDK;
        private TextBox textBoxEconomic_FDK;
        private TextBox textBoxSquare_FDK;
        private TextBox textBoxCapital_FDK;
        private TextBox textBoxCountryName_FDK;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonAddCountry_FDK;
        private Button buttonDeleteCountry_FDK;
        private Button buttonSearch_FDK;
        private Button buttonUpdate_FDK;
        private Button buttonInformation_FDK;
        private Button buttonStatistics_FDK;
    }
}
