namespace Tyuiu.IvanovPG.Sprint6.Task0.V20
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            colorDialog1 = new ColorDialog();
            pictureBoxFormula = new PictureBox();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            textBoxVarX_IPG = new TextBox();
            textBoxResult_IPG = new TextBox();
            buttonDone = new Button();
            buttonHint_IPG = new Button();
            groupBoxTask_IPG = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxInput_IPG = new GroupBox();
            textBoxVarX = new TextBox();
            groupBoxOutput_IPG = new GroupBox();
            textBoxResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBoxTask_IPG.SuspendLayout();
            groupBoxInput_IPG.SuspendLayout();
            groupBoxOutput_IPG.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.ErrorImage = null;
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(438, 31);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(259, 130);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormula.TabIndex = 3;
            pictureBoxFormula.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 4;
            // 
            // textBoxVarX_IPG
            // 
            textBoxVarX_IPG.Location = new Point(12, 80);
            textBoxVarX_IPG.Name = "textBoxVarX_IPG";
            textBoxVarX_IPG.Size = new Size(131, 32);
            textBoxVarX_IPG.TabIndex = 5;
            textBoxVarX_IPG.KeyPress += textBoxVarX_IPG_KeyPress;
            // 
            // textBoxResult_IPG
            // 
            textBoxResult_IPG.Location = new Point(17, 74);
            textBoxResult_IPG.Name = "textBoxResult_IPG";
            textBoxResult_IPG.ReadOnly = true;
            textBoxResult_IPG.Size = new Size(200, 32);
            textBoxResult_IPG.TabIndex = 6;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(115, 125);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(150, 46);
            buttonDone.TabIndex = 7;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHint_IPG
            // 
            buttonHint_IPG.FlatStyle = FlatStyle.Flat;
            buttonHint_IPG.Location = new Point(17, 125);
            buttonHint_IPG.Name = "buttonHint_IPG";
            buttonHint_IPG.Size = new Size(58, 46);
            buttonHint_IPG.TabIndex = 8;
            buttonHint_IPG.Text = "?";
            buttonHint_IPG.UseVisualStyleBackColor = true;
            buttonHint_IPG.Click += buttonHint_IPG_Click;
            // 
            // groupBoxTask_IPG
            // 
            groupBoxTask_IPG.Controls.Add(textBoxTask);
            groupBoxTask_IPG.Controls.Add(pictureBoxFormula);
            groupBoxTask_IPG.Location = new Point(22, 15);
            groupBoxTask_IPG.Name = "groupBoxTask_IPG";
            groupBoxTask_IPG.Size = new Size(730, 200);
            groupBoxTask_IPG.TabIndex = 9;
            groupBoxTask_IPG.TabStop = false;
            groupBoxTask_IPG.Text = "Условие";
            groupBoxTask_IPG.Enter += groupBoxTask_IPG_Enter;
            // 
            // textBoxTask
            // 
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(9, 31);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(341, 25);
            textBoxTask.TabIndex = 5;
            textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_IPG
            // 
            groupBoxInput_IPG.Controls.Add(textBoxVarX);
            groupBoxInput_IPG.Controls.Add(label1);
            groupBoxInput_IPG.Controls.Add(textBoxVarX_IPG);
            groupBoxInput_IPG.Location = new Point(22, 244);
            groupBoxInput_IPG.Name = "groupBoxInput_IPG";
            groupBoxInput_IPG.Size = new Size(350, 194);
            groupBoxInput_IPG.TabIndex = 10;
            groupBoxInput_IPG.TabStop = false;
            groupBoxInput_IPG.Text = "Ввод данных";
            // 
            // textBoxVarX
            // 
            textBoxVarX.BorderStyle = BorderStyle.None;
            textBoxVarX.Location = new Point(12, 39);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.ReadOnly = true;
            textBoxVarX.Size = new Size(200, 25);
            textBoxVarX.TabIndex = 6;
            textBoxVarX.Text = "Переменная X";
            // 
            // groupBoxOutput_IPG
            // 
            groupBoxOutput_IPG.Controls.Add(textBoxResult);
            groupBoxOutput_IPG.Controls.Add(buttonDone);
            groupBoxOutput_IPG.Controls.Add(textBoxResult_IPG);
            groupBoxOutput_IPG.Controls.Add(buttonHint_IPG);
            groupBoxOutput_IPG.Location = new Point(443, 250);
            groupBoxOutput_IPG.Name = "groupBoxOutput_IPG";
            groupBoxOutput_IPG.Size = new Size(354, 188);
            groupBoxOutput_IPG.TabIndex = 11;
            groupBoxOutput_IPG.TabStop = false;
            groupBoxOutput_IPG.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.Location = new Point(17, 33);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(200, 25);
            textBoxResult.TabIndex = 9;
            textBoxResult.Text = "Результат";
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(809, 467);
            Controls.Add(groupBoxOutput_IPG);
            Controls.Add(groupBoxInput_IPG);
            Controls.Add(groupBoxTask_IPG);
            Font = new Font("Arial Narrow", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(11, 19);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "спринт 6 | Таск 0| Вариант 20| Иванов П. Г.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBoxTask_IPG.ResumeLayout(false);
            groupBoxTask_IPG.PerformLayout();
            groupBoxInput_IPG.ResumeLayout(false);
            groupBoxInput_IPG.PerformLayout();
            groupBoxOutput_IPG.ResumeLayout(false);
            groupBoxOutput_IPG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private PictureBox pictureBoxFormula;
        private BindingSource bindingSource1;
        private Label label1;
        private TextBox textBoxVarX_IPG;
        private TextBox textBoxResult_IPG;
        private Button buttonDone;
        private Button buttonHint_IPG;
        private GroupBox groupBoxTask_IPG;
        private Label label2;
        private GroupBox groupBoxOutput_IPG;
        private GroupBox groupBoxInput_IPG;
        private TextBox textBoxTask;
        private TextBox textBoxResult;
        private TextBox textBoxVarX;
        private Label labelResult_IPG;
    }
}
