namespace Tyuiu.IvanovPG.Sprint6.Task5.V28
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_IPG = new GroupBox();
            textBoxCondition_IPG = new TextBox();
            buttonReference_IPG = new Button();
            buttonDone_IPG = new Button();
            buttonOpenFile_IPG = new Button();
            groupBox2 = new GroupBox();
            dataGridViewResult_IPG = new DataGridView();
            chartFunction_IPG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_IPG.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_IPG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_IPG).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_IPG
            // 
            groupBoxCondition_IPG.Controls.Add(textBoxCondition_IPG);
            groupBoxCondition_IPG.Location = new Point(12, 21);
            groupBoxCondition_IPG.Name = "groupBoxCondition_IPG";
            groupBoxCondition_IPG.Size = new Size(972, 230);
            groupBoxCondition_IPG.TabIndex = 0;
            groupBoxCondition_IPG.TabStop = false;
            groupBoxCondition_IPG.Text = "Условие:";
            // 
            // textBoxCondition_IPG
            // 
            textBoxCondition_IPG.BorderStyle = BorderStyle.None;
            textBoxCondition_IPG.Location = new Point(0, 45);
            textBoxCondition_IPG.Multiline = true;
            textBoxCondition_IPG.Name = "textBoxCondition_IPG";
            textBoxCondition_IPG.ReadOnly = true;
            textBoxCondition_IPG.Size = new Size(903, 102);
            textBoxCondition_IPG.TabIndex = 0;
            textBoxCondition_IPG.Text = "Прочитать данные из файлы InPutDataFileTask5V28.txt. Вывести в dataGridView\r\nВывести все числа, меньше 10. Построить диаграмму по этим значениям.";
            // 
            // buttonReference_IPG
            // 
            buttonReference_IPG.BackColor = Color.FromArgb(255, 128, 255);
            buttonReference_IPG.Location = new Point(1357, 39);
            buttonReference_IPG.Name = "buttonReference_IPG";
            buttonReference_IPG.Size = new Size(150, 212);
            buttonReference_IPG.TabIndex = 1;
            buttonReference_IPG.Text = "Справка";
            buttonReference_IPG.UseVisualStyleBackColor = false;
            buttonReference_IPG.Click += buttonReference_IPG_Click;
            // 
            // buttonDone_IPG
            // 
            buttonDone_IPG.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_IPG.Location = new Point(1005, 39);
            buttonDone_IPG.Name = "buttonDone_IPG";
            buttonDone_IPG.Size = new Size(151, 212);
            buttonDone_IPG.TabIndex = 2;
            buttonDone_IPG.Text = "Выполнить ";
            buttonDone_IPG.UseVisualStyleBackColor = false;
            buttonDone_IPG.Click += buttonDone_IPG_Click;
            // 
            // buttonOpenFile_IPG
            // 
            buttonOpenFile_IPG.BackColor = Color.FromArgb(255, 128, 0);
            buttonOpenFile_IPG.Location = new Point(1171, 39);
            buttonOpenFile_IPG.Name = "buttonOpenFile_IPG";
            buttonOpenFile_IPG.Size = new Size(170, 212);
            buttonOpenFile_IPG.TabIndex = 3;
            buttonOpenFile_IPG.Text = "Открыть файл ";
            buttonOpenFile_IPG.UseVisualStyleBackColor = false;
            buttonOpenFile_IPG.Click += buttonOpenFile_IPG_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewResult_IPG);
            groupBox2.Location = new Point(12, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 742);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных:";
            // 
            // dataGridViewResult_IPG
            // 
            dataGridViewResult_IPG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_IPG.Location = new Point(0, 38);
            dataGridViewResult_IPG.Name = "dataGridViewResult_IPG";
            dataGridViewResult_IPG.RowHeadersWidth = 82;
            dataGridViewResult_IPG.Size = new Size(413, 698);
            dataGridViewResult_IPG.TabIndex = 6;
            // 
            // chartFunction_IPG
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_IPG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_IPG.Legends.Add(legend1);
            chartFunction_IPG.Location = new Point(437, 273);
            chartFunction_IPG.Name = "chartFunction_IPG";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_IPG.Series.Add(series1);
            chartFunction_IPG.Size = new Size(1186, 736);
            chartFunction_IPG.TabIndex = 5;
            chartFunction_IPG.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 1011);
            Controls.Add(chartFunction_IPG);
            Controls.Add(groupBox2);
            Controls.Add(buttonOpenFile_IPG);
            Controls.Add(buttonDone_IPG);
            Controls.Add(buttonReference_IPG);
            Controls.Add(groupBoxCondition_IPG);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5| Вариант 28| Иванов П. Г.";
            groupBoxCondition_IPG.ResumeLayout(false);
            groupBoxCondition_IPG.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_IPG).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_IPG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_IPG;
        private TextBox textBoxCondition_IPG;
        private Button buttonReference_IPG;
        private Button buttonDone_IPG;
        private Button buttonOpenFile_IPG;
        private GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_IPG;
        private DataGridView dataGridViewResult_IPG;
    }
}
