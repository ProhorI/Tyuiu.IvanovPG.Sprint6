namespace Tyuiu.IvanovPG.Sprint6.Task2.V8
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBoxOutput_IPG = new GroupBox();
            chartFunction_IPG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_IPG = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            textBoxResult_IPG = new TextBox();
            groupBoxInput_IPG = new GroupBox();
            textBoxEnd_IPG = new TextBox();
            textBoxStart_IPG = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            buttonReference_IPG = new Button();
            buttonDone_IPG = new Button();
            groupBoxCondition_IPG.SuspendLayout();
            groupBoxOutput_IPG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_IPG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_IPG).BeginInit();
            groupBoxInput_IPG.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_IPG
            // 
            groupBoxCondition_IPG.Controls.Add(textBox2);
            groupBoxCondition_IPG.Controls.Add(textBox1);
            groupBoxCondition_IPG.Location = new Point(38, 22);
            groupBoxCondition_IPG.Name = "groupBoxCondition_IPG";
            groupBoxCondition_IPG.Size = new Size(1048, 507);
            groupBoxCondition_IPG.TabIndex = 0;
            groupBoxCondition_IPG.TabStop = false;
            groupBoxCondition_IPG.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(14, 83);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(897, 32);
            textBox2.TabIndex = 1;
            textBox2.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(15, 43);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1044, 32);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию Math.Cos(2 * x) + Math.Sin(x) / del + 2 * x на заданом диапозоне. ";
            // 
            // groupBoxOutput_IPG
            // 
            groupBoxOutput_IPG.Controls.Add(chartFunction_IPG);
            groupBoxOutput_IPG.Controls.Add(dataGridViewFunction_IPG);
            groupBoxOutput_IPG.Controls.Add(textBoxResult_IPG);
            groupBoxOutput_IPG.Location = new Point(1119, 22);
            groupBoxOutput_IPG.Name = "groupBoxOutput_IPG";
            groupBoxOutput_IPG.Size = new Size(959, 713);
            groupBoxOutput_IPG.TabIndex = 1;
            groupBoxOutput_IPG.TabStop = false;
            groupBoxOutput_IPG.Text = "Вывол данных";
            // 
            // chartFunction_IPG
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_IPG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_IPG.Legends.Add(legend1);
            chartFunction_IPG.Location = new Point(172, 83);
            chartFunction_IPG.Name = "chartFunction_IPG";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_IPG.Series.Add(series1);
            chartFunction_IPG.Size = new Size(862, 618);
            chartFunction_IPG.TabIndex = 2;
            chartFunction_IPG.Text = "chart1";
            chartFunction_IPG.Click += chartFunction_IPG_Click;
            // 
            // dataGridViewFunction_IPG
            // 
            dataGridViewFunction_IPG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_IPG.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_IPG.Location = new Point(6, 83);
            dataGridViewFunction_IPG.Name = "dataGridViewFunction_IPG";
            dataGridViewFunction_IPG.RowHeadersVisible = false;
            dataGridViewFunction_IPG.RowHeadersWidth = 82;
            dataGridViewFunction_IPG.Size = new Size(171, 618);
            dataGridViewFunction_IPG.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 10;
            X.Name = "X";
            X.Width = 200;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 10;
            Y.Name = "Y";
            Y.Width = 200;
            // 
            // textBoxResult_IPG
            // 
            textBoxResult_IPG.BorderStyle = BorderStyle.None;
            textBoxResult_IPG.Location = new Point(15, 43);
            textBoxResult_IPG.Name = "textBoxResult_IPG";
            textBoxResult_IPG.ReadOnly = true;
            textBoxResult_IPG.Size = new Size(200, 32);
            textBoxResult_IPG.TabIndex = 0;
            textBoxResult_IPG.Text = "Результат:";
            // 
            // groupBoxInput_IPG
            // 
            groupBoxInput_IPG.Controls.Add(textBoxEnd_IPG);
            groupBoxInput_IPG.Controls.Add(textBoxStart_IPG);
            groupBoxInput_IPG.Controls.Add(textBox4);
            groupBoxInput_IPG.Controls.Add(textBox3);
            groupBoxInput_IPG.Location = new Point(38, 535);
            groupBoxInput_IPG.Name = "groupBoxInput_IPG";
            groupBoxInput_IPG.Size = new Size(527, 200);
            groupBoxInput_IPG.TabIndex = 2;
            groupBoxInput_IPG.TabStop = false;
            groupBoxInput_IPG.Text = "Ввод данных";
            // 
            // textBoxEnd_IPG
            // 
            textBoxEnd_IPG.Location = new Point(244, 93);
            textBoxEnd_IPG.Name = "textBoxEnd_IPG";
            textBoxEnd_IPG.Size = new Size(213, 39);
            textBoxEnd_IPG.TabIndex = 3;
            // 
            // textBoxStart_IPG
            // 
            textBoxStart_IPG.Location = new Point(7, 93);
            textBoxStart_IPG.Name = "textBoxStart_IPG";
            textBoxStart_IPG.Size = new Size(200, 39);
            textBoxStart_IPG.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(244, 38);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(200, 32);
            textBox4.TabIndex = 1;
            textBox4.Text = "Конец шага:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(11, 38);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(200, 32);
            textBox3.TabIndex = 0;
            textBox3.Text = "Старт шага:";
            // 
            // buttonReference_IPG
            // 
            buttonReference_IPG.BackColor = Color.RoyalBlue;
            buttonReference_IPG.Location = new Point(614, 551);
            buttonReference_IPG.Name = "buttonReference_IPG";
            buttonReference_IPG.Size = new Size(204, 172);
            buttonReference_IPG.TabIndex = 4;
            buttonReference_IPG.Text = "Справка";
            buttonReference_IPG.UseVisualStyleBackColor = false;
            buttonReference_IPG.Click += buttonReference_IPG_Click;
            // 
            // buttonDone_IPG
            // 
            buttonDone_IPG.BackColor = Color.ForestGreen;
            buttonDone_IPG.Location = new Point(854, 551);
            buttonDone_IPG.Name = "buttonDone_IPG";
            buttonDone_IPG.Size = new Size(221, 172);
            buttonDone_IPG.TabIndex = 5;
            buttonDone_IPG.Text = "Выполнить ";
            buttonDone_IPG.UseVisualStyleBackColor = false;
            buttonDone_IPG.Click += buttonDone_IPG_Click;
            buttonDone_IPG.MouseDown += buttonDone_IPG_MouseDown;
            buttonDone_IPG.MouseEnter += buttonDone_IPG_MouseEnter;
            buttonDone_IPG.MouseLeave += buttonDone_IPG_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2146, 742);
            Controls.Add(buttonReference_IPG);
            Controls.Add(buttonDone_IPG);
            Controls.Add(groupBoxInput_IPG);
            Controls.Add(groupBoxOutput_IPG);
            Controls.Add(groupBoxCondition_IPG);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2| Вариант 8| Иванов П. Г.";
            groupBoxCondition_IPG.ResumeLayout(false);
            groupBoxCondition_IPG.PerformLayout();
            groupBoxOutput_IPG.ResumeLayout(false);
            groupBoxOutput_IPG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_IPG).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_IPG).EndInit();
            groupBoxInput_IPG.ResumeLayout(false);
            groupBoxInput_IPG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_IPG;
        private GroupBox groupBoxOutput_IPG;
        private GroupBox groupBoxInput_IPG;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBoxEnd_IPG;
        private TextBox textBoxStart_IPG;
        private Button buttonReference_IPG;
        private Button buttonDone_IPG;
        private TextBox textBoxResult_IPG;
        private DataGridView dataGridViewFunction_IPG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_IPG;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
