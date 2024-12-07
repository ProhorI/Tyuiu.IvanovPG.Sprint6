namespace Tyuiu.IvanovPG.Sprint6.Task3.V8
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
            groupBoxCondition_IPG = new GroupBox();
            dataGridViewMatrix_IPG = new DataGridView();
            textBoxData_IPG = new TextBox();
            groupBoxOutput_IPG = new GroupBox();
            textBox3 = new TextBox();
            textBoxResult_IPG = new TextBox();
            buttonHelp_IPG = new Button();
            buttonDone_IPG = new Button();
            groupBoxCondition_IPG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_IPG).BeginInit();
            groupBoxOutput_IPG.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_IPG
            // 
            groupBoxCondition_IPG.Controls.Add(dataGridViewMatrix_IPG);
            groupBoxCondition_IPG.Controls.Add(textBoxData_IPG);
            groupBoxCondition_IPG.Location = new Point(12, 12);
            groupBoxCondition_IPG.Name = "groupBoxCondition_IPG";
            groupBoxCondition_IPG.Size = new Size(1041, 526);
            groupBoxCondition_IPG.TabIndex = 0;
            groupBoxCondition_IPG.TabStop = false;
            groupBoxCondition_IPG.Text = "Условие";
            // 
            // dataGridViewMatrix_IPG
            // 
            dataGridViewMatrix_IPG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_IPG.Location = new Point(359, 14);
            dataGridViewMatrix_IPG.Name = "dataGridViewMatrix_IPG";
            dataGridViewMatrix_IPG.RowHeadersWidth = 82;
            dataGridViewMatrix_IPG.Size = new Size(667, 266);
            dataGridViewMatrix_IPG.TabIndex = 1;
            // 
            // textBoxData_IPG
            // 
            textBoxData_IPG.BorderStyle = BorderStyle.None;
            textBoxData_IPG.Location = new Point(6, 38);
            textBoxData_IPG.Multiline = true;
            textBoxData_IPG.Name = "textBoxData_IPG";
            textBoxData_IPG.ReadOnly = true;
            textBoxData_IPG.Size = new Size(387, 398);
            textBoxData_IPG.TabIndex = 0;
            textBoxData_IPG.Text = "Дана матрица 5 на 5 \r\n-10  10  -7  19   6\r\n  15 -13 -19   9   1\r\n -20 -15  -6   8  -4\r\n  10  18  -5   9  -6\r\n  16 -10   4  15  16\r\nЗаменить четные значения в четвертой строке на 0.";
            // 
            // groupBoxOutput_IPG
            // 
            groupBoxOutput_IPG.Controls.Add(textBox3);
            groupBoxOutput_IPG.Controls.Add(textBoxResult_IPG);
            groupBoxOutput_IPG.Location = new Point(1059, 26);
            groupBoxOutput_IPG.Name = "groupBoxOutput_IPG";
            groupBoxOutput_IPG.Size = new Size(272, 200);
            groupBoxOutput_IPG.TabIndex = 1;
            groupBoxOutput_IPG.TabStop = false;
            groupBoxOutput_IPG.Text = "Вывод данных:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(23, 36);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(200, 32);
            textBox3.TabIndex = 1;
            textBox3.Text = "Результат:";
            // 
            // textBoxResult_IPG
            // 
            textBoxResult_IPG.BorderStyle = BorderStyle.None;
            textBoxResult_IPG.Location = new Point(6, 96);
            textBoxResult_IPG.Name = "textBoxResult_IPG";
            textBoxResult_IPG.Size = new Size(200, 32);
            textBoxResult_IPG.TabIndex = 0;
            // 
            // buttonHelp_IPG
            // 
            buttonHelp_IPG.Location = new Point(1065, 478);
            buttonHelp_IPG.Name = "buttonHelp_IPG";
            buttonHelp_IPG.Size = new Size(67, 60);
            buttonHelp_IPG.TabIndex = 2;
            buttonHelp_IPG.Text = "?";
            buttonHelp_IPG.UseVisualStyleBackColor = true;
            buttonHelp_IPG.Click += buttonHelp_IPG_Click;
            // 
            // buttonDone_IPG
            // 
            buttonDone_IPG.Location = new Point(1181, 478);
            buttonDone_IPG.Name = "buttonDone_IPG";
            buttonDone_IPG.Size = new Size(150, 60);
            buttonDone_IPG.TabIndex = 3;
            buttonDone_IPG.Text = "Выполнить";
            buttonDone_IPG.UseVisualStyleBackColor = true;
            buttonDone_IPG.Click += buttonDone_IPG_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 545);
            Controls.Add(buttonDone_IPG);
            Controls.Add(buttonHelp_IPG);
            Controls.Add(groupBoxOutput_IPG);
            Controls.Add(groupBoxCondition_IPG);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3| Вариант 8| Иванов П. Г.";
            Load += FormMain_Load;
            groupBoxCondition_IPG.ResumeLayout(false);
            groupBoxCondition_IPG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_IPG).EndInit();
            groupBoxOutput_IPG.ResumeLayout(false);
            groupBoxOutput_IPG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_IPG;
        private GroupBox groupBoxOutput_IPG;
        private TextBox textBoxResult_IPG;
        private TextBox textBoxData_IPG;
        private TextBox textBox3;
        private DataGridView dataGridViewMatrix_IPG;
        private Button buttonHelp_IPG;
        private Button buttonDone_IPG;
    }
}
