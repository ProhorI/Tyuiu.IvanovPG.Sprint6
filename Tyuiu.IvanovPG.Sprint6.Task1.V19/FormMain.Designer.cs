namespace Tyuiu.IvanovPG.Sprint6.Task1.V19
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
            groupBoxTask_IPG = new GroupBox();
            textBoxOutput2_IPG = new TextBox();
            textBoxOutput1_IPG = new TextBox();
            groupBoxResult_IPG = new GroupBox();
            textBoxOutput3_IPG = new TextBox();
            textBoxResult_IPG = new TextBox();
            groupBox1 = new GroupBox();
            textBoxStop_IPG = new TextBox();
            textBoxStart_IPG = new TextBox();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            buttonReference_IPG = new Button();
            buttonDone_IPG = new Button();
            groupBoxTask_IPG.SuspendLayout();
            groupBoxResult_IPG.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_IPG
            // 
            groupBoxTask_IPG.Controls.Add(textBoxOutput2_IPG);
            groupBoxTask_IPG.Controls.Add(textBoxOutput1_IPG);
            groupBoxTask_IPG.Location = new Point(27, 50);
            groupBoxTask_IPG.Name = "groupBoxTask_IPG";
            groupBoxTask_IPG.Size = new Size(1162, 366);
            groupBoxTask_IPG.TabIndex = 2;
            groupBoxTask_IPG.TabStop = false;
            groupBoxTask_IPG.Text = "Условие:";
            // 
            // textBoxOutput2_IPG
            // 
            textBoxOutput2_IPG.BorderStyle = BorderStyle.None;
            textBoxOutput2_IPG.Location = new Point(6, 76);
            textBoxOutput2_IPG.Name = "textBoxOutput2_IPG";
            textBoxOutput2_IPG.ReadOnly = true;
            textBoxOutput2_IPG.Size = new Size(415, 32);
            textBoxOutput2_IPG.TabIndex = 1;
            textBoxOutput2_IPG.Text = "Результат вывести в виде таблицы";
            // 
            // textBoxOutput1_IPG
            // 
            textBoxOutput1_IPG.BorderStyle = BorderStyle.None;
            textBoxOutput1_IPG.Location = new Point(6, 38);
            textBoxOutput1_IPG.Name = "textBoxOutput1_IPG";
            textBoxOutput1_IPG.ReadOnly = true;
            textBoxOutput1_IPG.Size = new Size(1064, 32);
            textBoxOutput1_IPG.TabIndex = 0;
            textBoxOutput1_IPG.Text = "Протабулировать функцию (Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x) на заданном диапозоне.";
            // 
            // groupBoxResult_IPG
            // 
            groupBoxResult_IPG.Controls.Add(textBoxOutput3_IPG);
            groupBoxResult_IPG.Controls.Add(textBoxResult_IPG);
            groupBoxResult_IPG.Location = new Point(1260, 50);
            groupBoxResult_IPG.Name = "groupBoxResult_IPG";
            groupBoxResult_IPG.Size = new Size(423, 608);
            groupBoxResult_IPG.TabIndex = 3;
            groupBoxResult_IPG.TabStop = false;
            groupBoxResult_IPG.Text = "Вывод данных";
            // 
            // textBoxOutput3_IPG
            // 
            textBoxOutput3_IPG.BorderStyle = BorderStyle.None;
            textBoxOutput3_IPG.Location = new Point(11, 38);
            textBoxOutput3_IPG.Name = "textBoxOutput3_IPG";
            textBoxOutput3_IPG.ReadOnly = true;
            textBoxOutput3_IPG.Size = new Size(200, 32);
            textBoxOutput3_IPG.TabIndex = 4;
            textBoxOutput3_IPG.Text = "Результат:";
            // 
            // textBoxResult_IPG
            // 
            textBoxResult_IPG.Font = new Font("Consolas", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_IPG.Location = new Point(26, 76);
            textBoxResult_IPG.Multiline = true;
            textBoxResult_IPG.Name = "textBoxResult_IPG";
            textBoxResult_IPG.ReadOnly = true;
            textBoxResult_IPG.ScrollBars = ScrollBars.Vertical;
            textBoxResult_IPG.Size = new Size(391, 526);
            textBoxResult_IPG.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxStop_IPG);
            groupBox1.Controls.Add(textBoxStart_IPG);
            groupBox1.Controls.Add(textBoxStop);
            groupBox1.Controls.Add(textBoxStart);
            groupBox1.Location = new Point(27, 441);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(686, 189);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // textBoxStop_IPG
            // 
            textBoxStop_IPG.Location = new Point(243, 87);
            textBoxStop_IPG.Name = "textBoxStop_IPG";
            textBoxStop_IPG.Size = new Size(200, 39);
            textBoxStop_IPG.TabIndex = 7;
            // 
            // textBoxStart_IPG
            // 
            textBoxStart_IPG.Location = new Point(6, 85);
            textBoxStart_IPG.Name = "textBoxStart_IPG";
            textBoxStart_IPG.Size = new Size(171, 39);
            textBoxStart_IPG.TabIndex = 6;
            // 
            // textBoxStop
            // 
            textBoxStop.BorderStyle = BorderStyle.None;
            textBoxStop.Location = new Point(248, 38);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.ReadOnly = true;
            textBoxStop.Size = new Size(200, 32);
            textBoxStop.TabIndex = 5;
            textBoxStop.Text = "Конец шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.BorderStyle = BorderStyle.None;
            textBoxStart.Location = new Point(15, 37);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.ReadOnly = true;
            textBoxStart.Size = new Size(200, 32);
            textBoxStart.TabIndex = 5;
            textBoxStart.Text = "Старт шага:";
            // 
            // buttonReference_IPG
            // 
            buttonReference_IPG.BackColor = SystemColors.MenuHighlight;
            buttonReference_IPG.Location = new Point(732, 465);
            buttonReference_IPG.Name = "buttonReference_IPG";
            buttonReference_IPG.Size = new Size(215, 165);
            buttonReference_IPG.TabIndex = 5;
            buttonReference_IPG.Text = "Справка";
            buttonReference_IPG.UseVisualStyleBackColor = false;
            buttonReference_IPG.Click += buttonReference_IPG_Click;
            // 
            // buttonDone_IPG
            // 
            buttonDone_IPG.BackColor = Color.Green;
            buttonDone_IPG.Location = new Point(973, 465);
            buttonDone_IPG.Name = "buttonDone_IPG";
            buttonDone_IPG.Size = new Size(240, 165);
            buttonDone_IPG.TabIndex = 6;
            buttonDone_IPG.Text = "Выполнить";
            buttonDone_IPG.UseVisualStyleBackColor = false;
            buttonDone_IPG.Click += buttonDone_IPG_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1695, 670);
            Controls.Add(buttonDone_IPG);
            Controls.Add(buttonReference_IPG);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxResult_IPG);
            Controls.Add(groupBoxTask_IPG);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "спринт 6 | Таск 1| Вариант 19| Иванов П. Г.";
            groupBoxTask_IPG.ResumeLayout(false);
            groupBoxTask_IPG.PerformLayout();
            groupBoxResult_IPG.ResumeLayout(false);
            groupBoxResult_IPG.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxTask_IPG;
        private GroupBox groupBoxResult_IPG;
        private TextBox textBoxOutput1_IPG;
        private TextBox textBoxOutput2_IPG;
        private TextBox textBoxResult_IPG;
        private TextBox textBoxOutput3_IPG;
        private GroupBox groupBox1;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private TextBox textBoxStop_IPG;
        private TextBox textBoxStart_IPG;
        private Button buttonReference_IPG;
        private Button buttonDone_IPG;
    }
}
