namespace Tyuiu.IvanovPG.Sprint6.Task6.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_IPG = new GroupBox();
            textBoxCondition_IPG = new TextBox();
            groupBoxInput_IPG = new GroupBox();
            textBoxInput_IPG = new TextBox();
            groupBoxOutput_IPG = new GroupBox();
            textBoxOutput_IPG = new TextBox();
            buttonOpenfile_IPG = new Button();
            buttonDone_IPG = new Button();
            buttonQuestion_IPG = new Button();
            openFileDialogTask_IPG = new OpenFileDialog();
            toolTipTask_IPG = new ToolTip(components);
            groupBoxCondition_IPG.SuspendLayout();
            groupBoxInput_IPG.SuspendLayout();
            groupBoxOutput_IPG.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_IPG
            // 
            groupBoxCondition_IPG.Controls.Add(textBoxCondition_IPG);
            groupBoxCondition_IPG.Location = new Point(12, 128);
            groupBoxCondition_IPG.Name = "groupBoxCondition_IPG";
            groupBoxCondition_IPG.Size = new Size(1480, 192);
            groupBoxCondition_IPG.TabIndex = 0;
            groupBoxCondition_IPG.TabStop = false;
            groupBoxCondition_IPG.Text = "Условие:";
            // 
            // textBoxCondition_IPG
            // 
            textBoxCondition_IPG.BorderStyle = BorderStyle.None;
            textBoxCondition_IPG.Location = new Point(19, 50);
            textBoxCondition_IPG.Multiline = true;
            textBoxCondition_IPG.Name = "textBoxCondition_IPG";
            textBoxCondition_IPG.ReadOnly = true;
            textBoxCondition_IPG.Size = new Size(1402, 130);
            textBoxCondition_IPG.TabIndex = 0;
            textBoxCondition_IPG.Text = resources.GetString("textBoxCondition_IPG.Text");
            // 
            // groupBoxInput_IPG
            // 
            groupBoxInput_IPG.Controls.Add(textBoxInput_IPG);
            groupBoxInput_IPG.Location = new Point(12, 326);
            groupBoxInput_IPG.Name = "groupBoxInput_IPG";
            groupBoxInput_IPG.Size = new Size(704, 621);
            groupBoxInput_IPG.TabIndex = 1;
            groupBoxInput_IPG.TabStop = false;
            groupBoxInput_IPG.Text = "Ввод:";
            // 
            // textBoxInput_IPG
            // 
            textBoxInput_IPG.BorderStyle = BorderStyle.None;
            textBoxInput_IPG.Location = new Point(23, 47);
            textBoxInput_IPG.Multiline = true;
            textBoxInput_IPG.Name = "textBoxInput_IPG";
            textBoxInput_IPG.Size = new Size(675, 568);
            textBoxInput_IPG.TabIndex = 0;
            // 
            // groupBoxOutput_IPG
            // 
            groupBoxOutput_IPG.Controls.Add(textBoxOutput_IPG);
            groupBoxOutput_IPG.Location = new Point(722, 344);
            groupBoxOutput_IPG.Name = "groupBoxOutput_IPG";
            groupBoxOutput_IPG.Size = new Size(770, 603);
            groupBoxOutput_IPG.TabIndex = 1;
            groupBoxOutput_IPG.TabStop = false;
            groupBoxOutput_IPG.Text = "Вывод:";
            // 
            // textBoxOutput_IPG
            // 
            textBoxOutput_IPG.BorderStyle = BorderStyle.None;
            textBoxOutput_IPG.Location = new Point(6, 38);
            textBoxOutput_IPG.Multiline = true;
            textBoxOutput_IPG.Name = "textBoxOutput_IPG";
            textBoxOutput_IPG.Size = new Size(758, 559);
            textBoxOutput_IPG.TabIndex = 0;
            // 
            // buttonOpenfile_IPG
            // 
            buttonOpenfile_IPG.Location = new Point(51, 29);
            buttonOpenfile_IPG.Name = "buttonOpenfile_IPG";
            buttonOpenfile_IPG.Size = new Size(229, 91);
            buttonOpenfile_IPG.TabIndex = 2;
            buttonOpenfile_IPG.Text = "файл";
            toolTipTask_IPG.SetToolTip(buttonOpenfile_IPG, "Открыть файл, выберите нужный файл для обработки\r\n\r\n");
            buttonOpenfile_IPG.UseVisualStyleBackColor = true;
            buttonOpenfile_IPG.Click += buttonOpenfile_IPG_Click;
            // 
            // buttonDone_IPG
            // 
            buttonDone_IPG.Location = new Point(349, 33);
            buttonDone_IPG.Name = "buttonDone_IPG";
            buttonDone_IPG.Size = new Size(252, 87);
            buttonDone_IPG.TabIndex = 2;
            buttonDone_IPG.Text = "курсор";
            toolTipTask_IPG.SetToolTip(buttonDone_IPG, "газ");
            buttonDone_IPG.UseVisualStyleBackColor = true;
            buttonDone_IPG.Click += buttonDone_IPG_Click;
            // 
            // buttonQuestion_IPG
            // 
            buttonQuestion_IPG.Location = new Point(1092, 33);
            buttonQuestion_IPG.Name = "buttonQuestion_IPG";
            buttonQuestion_IPG.Size = new Size(231, 91);
            buttonQuestion_IPG.TabIndex = 2;
            buttonQuestion_IPG.Text = "вопрос";
            toolTipTask_IPG.SetToolTip(buttonQuestion_IPG, "тормоз");
            buttonQuestion_IPG.UseVisualStyleBackColor = true;
            buttonQuestion_IPG.Click += buttonQuestion_IPG_Click;
            // 
            // openFileDialogTask_IPG
            // 
            openFileDialogTask_IPG.FileName = "openFileDialog1";
            // 
            // toolTipTask_IPG
            // 
            toolTipTask_IPG.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_IPG.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 959);
            Controls.Add(buttonQuestion_IPG);
            Controls.Add(buttonDone_IPG);
            Controls.Add(buttonOpenfile_IPG);
            Controls.Add(groupBoxOutput_IPG);
            Controls.Add(groupBoxInput_IPG);
            Controls.Add(groupBoxCondition_IPG);
            Name = "FormMain";
            Text = "Form1";
            groupBoxCondition_IPG.ResumeLayout(false);
            groupBoxCondition_IPG.PerformLayout();
            groupBoxInput_IPG.ResumeLayout(false);
            groupBoxInput_IPG.PerformLayout();
            groupBoxOutput_IPG.ResumeLayout(false);
            groupBoxOutput_IPG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_IPG;
        private TextBox textBoxCondition_IPG;
        private GroupBox groupBoxInput_IPG;
        private GroupBox groupBoxOutput_IPG;
        private Button buttonOpenfile_IPG;
        private Button buttonDone_IPG;
        private Button buttonQuestion_IPG;
        private TextBox textBoxInput_IPG;
        private TextBox textBoxOutput_IPG;
        private OpenFileDialog openFileDialogTask_IPG;
        private ToolTip toolTipTask_IPG;
    }
}
