namespace Tyuiu.IvanovPG.Sprint6.Task7.V29
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            labelInfo_IPG = new Label();
            buttonOk_IPG = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(44, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 362);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelInfo_IPG
            // 
            labelInfo_IPG.AutoSize = true;
            labelInfo_IPG.Location = new Point(302, 72);
            labelInfo_IPG.Name = "labelInfo_IPG";
            labelInfo_IPG.Size = new Size(295, 32);
            labelInfo_IPG.TabIndex = 1;
            labelInfo_IPG.Text = "Разработчик: Иванов П.Г.";
            // 
            // buttonOk_IPG
            // 
            buttonOk_IPG.Location = new Point(616, 375);
            buttonOk_IPG.Name = "buttonOk_IPG";
            buttonOk_IPG.Size = new Size(150, 46);
            buttonOk_IPG.TabIndex = 2;
            buttonOk_IPG.Text = "ОК";
            buttonOk_IPG.UseVisualStyleBackColor = true;
            buttonOk_IPG.Click += buttonOk_IPG_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOk_IPG);
            Controls.Add(labelInfo_IPG);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "О программе ";
            Load += Form2_Load;
            Click += buttonOk_IPG_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelInfo_IPG;
        private Button buttonOk_IPG;
    }
}