﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.FilatovDK.Sprint7.Project.V13
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }
        private void buttonOK_FDK_Click(object sender, EventArgs e)
        {
            this.Close();//Вызывает метод Close() для текущего окна или формы, в которой находится данный метод это приводит к закрытию формы и завершению её работы
        }
    }
}
