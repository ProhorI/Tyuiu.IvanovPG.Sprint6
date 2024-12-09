namespace Tyuiu.IvanovPG.Sprint6.Task7.V29
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
            buttonOpenFile_IPG = new Button();
            buttonDone_IPG = new Button();
            buttonSaveFile_IPG = new Button();
            buttonHelp_IPG = new Button();
            groupBoxInput_IPG = new GroupBox();
            dataGridViewInput_IPG = new DataGridView();
            groupBoxOtput_IPG = new GroupBox();
            dataGridViewOutput_IPG = new DataGridView();
            groupBoxTask_IPG = new GroupBox();
            openFileDialogTask_IPG = new OpenFileDialog();
            toolTipButton_IPG = new ToolTip(components);
            saveFileDialogMatrix_IPG = new SaveFileDialog();
            groupBoxCondition_IPG.SuspendLayout();
            groupBoxInput_IPG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_IPG).BeginInit();
            groupBoxOtput_IPG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_IPG).BeginInit();
            groupBoxTask_IPG.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_IPG
            // 
            groupBoxCondition_IPG.Controls.Add(textBoxCondition_IPG);
            groupBoxCondition_IPG.Location = new Point(32, 179);
            groupBoxCondition_IPG.Name = "groupBoxCondition_IPG";
            groupBoxCondition_IPG.Size = new Size(1722, 183);
            groupBoxCondition_IPG.TabIndex = 0;
            groupBoxCondition_IPG.TabStop = false;
            groupBoxCondition_IPG.Text = "Условие:";
            // 
            // textBoxCondition_IPG
            // 
            textBoxCondition_IPG.BorderStyle = BorderStyle.None;
            textBoxCondition_IPG.Location = new Point(11, 38);
            textBoxCondition_IPG.Multiline = true;
            textBoxCondition_IPG.Name = "textBoxCondition_IPG";
            textBoxCondition_IPG.ReadOnly = true;
            textBoxCondition_IPG.Size = new Size(1550, 131);
            textBoxCondition_IPG.TabIndex = 0;
            textBoxCondition_IPG.Text = resources.GetString("textBoxCondition_IPG.Text");
            // 
            // buttonOpenFile_IPG
            // 
            buttonOpenFile_IPG.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_IPG.BackgroundImage");
            buttonOpenFile_IPG.Location = new Point(82, 36);
            buttonOpenFile_IPG.Name = "buttonOpenFile_IPG";
            buttonOpenFile_IPG.Size = new Size(145, 109);
            buttonOpenFile_IPG.TabIndex = 1;
            buttonOpenFile_IPG.UseVisualStyleBackColor = true;
            buttonOpenFile_IPG.Click += buttonOpenFile_IPG_Click;
            buttonOpenFile_IPG.MouseEnter += buttonOpenFile_IPG_MouseEnter;
            // 
            // buttonDone_IPG
            // 
            buttonDone_IPG.BackgroundImage = (Image)resources.GetObject("buttonDone_IPG.BackgroundImage");
            buttonDone_IPG.FlatStyle = FlatStyle.Flat;
            buttonDone_IPG.Location = new Point(329, 44);
            buttonDone_IPG.Name = "buttonDone_IPG";
            buttonDone_IPG.Size = new Size(147, 101);
            buttonDone_IPG.TabIndex = 2;
            buttonDone_IPG.UseVisualStyleBackColor = true;
            buttonDone_IPG.Click += buttonDone_IPG_Click;
            buttonDone_IPG.MouseEnter += buttonDone_IPG_MouseEnter;
            // 
            // buttonSaveFile_IPG
            // 
            buttonSaveFile_IPG.BackgroundImage = (Image)resources.GetObject("buttonSaveFile_IPG.BackgroundImage");
            buttonSaveFile_IPG.Location = new Point(569, 42);
            buttonSaveFile_IPG.Name = "buttonSaveFile_IPG";
            buttonSaveFile_IPG.Size = new Size(150, 103);
            buttonSaveFile_IPG.TabIndex = 3;
            buttonSaveFile_IPG.UseVisualStyleBackColor = true;
            buttonSaveFile_IPG.Click += buttonSaveFile_IPG_Click;
            buttonSaveFile_IPG.MouseEnter += buttonSaveFile_IPG_MouseEnter;
            // 
            // buttonHelp_IPG
            // 
            buttonHelp_IPG.BackgroundImage = (Image)resources.GetObject("buttonHelp_IPG.BackgroundImage");
            buttonHelp_IPG.Location = new Point(1552, 26);
            buttonHelp_IPG.Name = "buttonHelp_IPG";
            buttonHelp_IPG.Size = new Size(164, 109);
            buttonHelp_IPG.TabIndex = 4;
            buttonHelp_IPG.UseVisualStyleBackColor = true;
            buttonHelp_IPG.Click += buttonHelp_IPG_Click;
            buttonHelp_IPG.MouseEnter += buttonHelp_IPG_MouseEnter;
            // 
            // groupBoxInput_IPG
            // 
            groupBoxInput_IPG.Controls.Add(dataGridViewInput_IPG);
            groupBoxInput_IPG.Location = new Point(12, 368);
            groupBoxInput_IPG.Name = "groupBoxInput_IPG";
            groupBoxInput_IPG.Size = new Size(935, 694);
            groupBoxInput_IPG.TabIndex = 5;
            groupBoxInput_IPG.TabStop = false;
            groupBoxInput_IPG.Text = "Ввод:";
            // 
            // dataGridViewInput_IPG
            // 
            dataGridViewInput_IPG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_IPG.Location = new Point(20, 38);
            dataGridViewInput_IPG.Name = "dataGridViewInput_IPG";
            dataGridViewInput_IPG.RowHeadersWidth = 82;
            dataGridViewInput_IPG.Size = new Size(894, 650);
            dataGridViewInput_IPG.TabIndex = 0;
            // 
            // groupBoxOtput_IPG
            // 
            groupBoxOtput_IPG.Controls.Add(dataGridViewOutput_IPG);
            groupBoxOtput_IPG.Location = new Point(967, 381);
            groupBoxOtput_IPG.Name = "groupBoxOtput_IPG";
            groupBoxOtput_IPG.Size = new Size(828, 675);
            groupBoxOtput_IPG.TabIndex = 5;
            groupBoxOtput_IPG.TabStop = false;
            groupBoxOtput_IPG.Text = "Вывод:";
            // 
            // dataGridViewOutput_IPG
            // 
            dataGridViewOutput_IPG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_IPG.Location = new Point(36, 38);
            dataGridViewOutput_IPG.Name = "dataGridViewOutput_IPG";
            dataGridViewOutput_IPG.RowHeadersWidth = 82;
            dataGridViewOutput_IPG.Size = new Size(765, 631);
            dataGridViewOutput_IPG.TabIndex = 0;
            // 
            // groupBoxTask_IPG
            // 
            groupBoxTask_IPG.Controls.Add(buttonDone_IPG);
            groupBoxTask_IPG.Controls.Add(buttonOpenFile_IPG);
            groupBoxTask_IPG.Controls.Add(buttonSaveFile_IPG);
            groupBoxTask_IPG.Controls.Add(buttonHelp_IPG);
            groupBoxTask_IPG.Location = new Point(32, 12);
            groupBoxTask_IPG.Name = "groupBoxTask_IPG";
            groupBoxTask_IPG.Size = new Size(1722, 161);
            groupBoxTask_IPG.TabIndex = 6;
            groupBoxTask_IPG.TabStop = false;
            // 
            // openFileDialogTask_IPG
            // 
            openFileDialogTask_IPG.FileName = "openFileDialog1";
            // 
            // toolTipButton_IPG
            // 
            toolTipButton_IPG.IsBalloon = true;
            toolTipButton_IPG.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1804, 1068);
            Controls.Add(groupBoxTask_IPG);
            Controls.Add(groupBoxInput_IPG);
            Controls.Add(groupBoxOtput_IPG);
            Controls.Add(groupBoxCondition_IPG);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7| Вариант 29| Иванов П. Г.";
            Load += FormMain_Load;
            groupBoxCondition_IPG.ResumeLayout(false);
            groupBoxCondition_IPG.PerformLayout();
            groupBoxInput_IPG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_IPG).EndInit();
            groupBoxOtput_IPG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_IPG).EndInit();
            groupBoxTask_IPG.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_IPG;
        private TextBox textBoxCondition_IPG;
        private Button buttonOpenFile_IPG;
        private Button buttonDone_IPG;
        private Button buttonSaveFile_IPG;
        private Button buttonHelp_IPG;
        private GroupBox groupBoxInput_IPG;
        private GroupBox groupBoxOtput_IPG;
        private DataGridView dataGridViewInput_IPG;
        private DataGridView dataGridViewOutput_IPG;
        private GroupBox groupBoxTask_IPG;
        private OpenFileDialog openFileDialogTask_IPG;
        private ToolTip toolTipButton_IPG;
        private SaveFileDialog saveFileDialogMatrix_IPG;
    }
}
