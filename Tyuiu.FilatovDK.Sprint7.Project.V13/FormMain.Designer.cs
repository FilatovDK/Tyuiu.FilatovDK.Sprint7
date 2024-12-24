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
            buttonAddCountry_FDK = new Button();
            buttonDeleteCountry_FDK = new Button();
            buttonSearch_FDK = new Button();
            buttonStatistics_FDK = new Button();
            dataGridViewInfo_FDK = new DataGridView();
            textBoxWriteCountry_FDK = new TextBox();
            groupBoxInPut_FDK = new GroupBox();
            buttonRed_FDK = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_FDK).BeginInit();
            groupBoxInPut_FDK.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите что хотите найти";
            label1.Click += label1_Click_1;
            // 
            // openFileDialog_FDK
            // 
            openFileDialog_FDK.FileName = "openFileDialog1";
            // 
            // buttonInformation_FDK
            // 
            buttonInformation_FDK.Location = new Point(505, 12);
            buttonInformation_FDK.Name = "buttonInformation_FDK";
            buttonInformation_FDK.Size = new Size(79, 38);
            buttonInformation_FDK.TabIndex = 18;
            buttonInformation_FDK.Text = "Кто создал";
            toolTipButton_FDK.SetToolTip(buttonInformation_FDK, "Показывает кто сделал этот шедевр");
            buttonInformation_FDK.UseVisualStyleBackColor = true;
            buttonInformation_FDK.Click += buttonInformation_FDK_Click;
            // 
            // buttonAddCountry_FDK
            // 
            buttonAddCountry_FDK.Location = new Point(8, 12);
            buttonAddCountry_FDK.Name = "buttonAddCountry_FDK";
            buttonAddCountry_FDK.Size = new Size(79, 38);
            buttonAddCountry_FDK.TabIndex = 14;
            buttonAddCountry_FDK.Text = "Сохранить";
            toolTipButton_FDK.SetToolTip(buttonAddCountry_FDK, "Сохраняет новую таблицу");
            buttonAddCountry_FDK.UseVisualStyleBackColor = true;
            buttonAddCountry_FDK.Click += buttonAddCountry_FDK_Click;
            // 
            // buttonDeleteCountry_FDK
            // 
            buttonDeleteCountry_FDK.Location = new Point(93, 12);
            buttonDeleteCountry_FDK.Name = "buttonDeleteCountry_FDK";
            buttonDeleteCountry_FDK.Size = new Size(61, 38);
            buttonDeleteCountry_FDK.TabIndex = 15;
            buttonDeleteCountry_FDK.Text = "Удалить";
            toolTipButton_FDK.SetToolTip(buttonDeleteCountry_FDK, "Удаляет созданный файл");
            buttonDeleteCountry_FDK.UseVisualStyleBackColor = true;
            buttonDeleteCountry_FDK.Click += buttonDeleteCountry_FDK_Click;
            // 
            // buttonSearch_FDK
            // 
            buttonSearch_FDK.Location = new Point(160, 12);
            buttonSearch_FDK.Name = "buttonSearch_FDK";
            buttonSearch_FDK.Size = new Size(55, 38);
            buttonSearch_FDK.TabIndex = 16;
            buttonSearch_FDK.Text = "Найти";
            toolTipButton_FDK.SetToolTip(buttonSearch_FDK, "Находит фаил с exel ");
            buttonSearch_FDK.UseVisualStyleBackColor = true;
            buttonSearch_FDK.Click += buttonSearch_FDK_Click;
            // 
            // buttonStatistics_FDK
            // 
            buttonStatistics_FDK.Location = new Point(590, 12);
            buttonStatistics_FDK.Name = "buttonStatistics_FDK";
            buttonStatistics_FDK.Size = new Size(82, 38);
            buttonStatistics_FDK.TabIndex = 19;
            buttonStatistics_FDK.Text = "Диограмма";
            toolTipButton_FDK.SetToolTip(buttonStatistics_FDK, "Перейти к созданию диограммы");
            buttonStatistics_FDK.UseVisualStyleBackColor = true;
            buttonStatistics_FDK.Click += buttonStatistics_FDK_Click;
            // 
            // dataGridViewInfo_FDK
            // 
            dataGridViewInfo_FDK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo_FDK.Location = new Point(6, 22);
            dataGridViewInfo_FDK.Name = "dataGridViewInfo_FDK";
            dataGridViewInfo_FDK.ReadOnly = true;
            dataGridViewInfo_FDK.Size = new Size(890, 284);
            dataGridViewInfo_FDK.TabIndex = 5;
            // 
            // textBoxWriteCountry_FDK
            // 
            textBoxWriteCountry_FDK.Location = new Point(337, 27);
            textBoxWriteCountry_FDK.Name = "textBoxWriteCountry_FDK";
            textBoxWriteCountry_FDK.Size = new Size(146, 23);
            textBoxWriteCountry_FDK.TabIndex = 6;
            // 
            // groupBoxInPut_FDK
            // 
            groupBoxInPut_FDK.Controls.Add(dataGridViewInfo_FDK);
            groupBoxInPut_FDK.Location = new Point(8, 56);
            groupBoxInPut_FDK.Name = "groupBoxInPut_FDK";
            groupBoxInPut_FDK.Size = new Size(907, 321);
            groupBoxInPut_FDK.TabIndex = 7;
            groupBoxInPut_FDK.TabStop = false;
            groupBoxInPut_FDK.Text = "Информация о стране";
            // 
            // buttonRed_FDK
            // 
            buttonRed_FDK.Location = new Point(221, 12);
            buttonRed_FDK.Name = "buttonRed_FDK";
            buttonRed_FDK.Size = new Size(99, 38);
            buttonRed_FDK.TabIndex = 17;
            buttonRed_FDK.Text = "Редактировать";
            toolTipButton_FDK.SetToolTip(buttonRed_FDK, "Редактировать таблицу");
            buttonRed_FDK.UseVisualStyleBackColor = true;
            buttonRed_FDK.Click += buttonRed_FDK_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 376);
            Controls.Add(buttonStatistics_FDK);
            Controls.Add(buttonInformation_FDK);
            Controls.Add(buttonRed_FDK);
            Controls.Add(buttonSearch_FDK);
            Controls.Add(buttonDeleteCountry_FDK);
            Controls.Add(buttonAddCountry_FDK);
            Controls.Add(groupBoxInPut_FDK);
            Controls.Add(textBoxWriteCountry_FDK);
            Controls.Add(label1);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_FDK).EndInit();
            groupBoxInPut_FDK.ResumeLayout(false);
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
        private Button buttonAddCountry_FDK;
        private Button buttonDeleteCountry_FDK;
        private Button buttonSearch_FDK;
        private Button buttonRed_FDK;
        private Button buttonInformation_FDK;
        private Button buttonStatistics_FDK;
    }
}
