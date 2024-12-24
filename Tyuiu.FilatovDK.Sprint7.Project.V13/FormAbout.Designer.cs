namespace Tyuiu.FilatovDK.Sprint7.Project.V13
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_FDK = new Button();
            label_FDK = new Label();
            SuspendLayout();
            // 
            // buttonOK_FDK
            // 
            buttonOK_FDK.Location = new Point(12, 166);
            buttonOK_FDK.Name = "buttonOK_FDK";
            buttonOK_FDK.Size = new Size(75, 23);
            buttonOK_FDK.TabIndex = 0;
            buttonOK_FDK.Text = "Ok";
            buttonOK_FDK.UseVisualStyleBackColor = true;
            buttonOK_FDK.Click += buttonOK_FDK_Click;
            // 
            // label_FDK
            // 
            label_FDK.AutoSize = true;
            label_FDK.Location = new Point(12, 9);
            label_FDK.Name = "label_FDK";
            label_FDK.Size = new Size(303, 150);
            label_FDK.TabIndex = 1;
            label_FDK.Text = resources.GetString("label_FDK.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 193);
            Controls.Add(label_FDK);
            Controls.Add(buttonOK_FDK);
            Name = "FormAbout";
            Text = "Form1";
///            Load += FormAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_FDK;
        private Label label_FDK;
    }
}