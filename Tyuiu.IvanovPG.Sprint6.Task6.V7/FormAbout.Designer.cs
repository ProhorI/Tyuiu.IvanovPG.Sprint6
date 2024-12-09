namespace Tyuiu.IvanovPG.Sprint6.Task6.V7
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
            pictureBoxName_IPG = new PictureBox();
            labelInfo_IPG = new Label();
            buttonOk_IPG = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxName_IPG).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxName_IPG
            // 
            pictureBoxName_IPG.Location = new Point(12, 40);
            pictureBoxName_IPG.Name = "pictureBoxName_IPG";
            pictureBoxName_IPG.Size = new Size(241, 354);
            pictureBoxName_IPG.TabIndex = 0;
            pictureBoxName_IPG.TabStop = false;
            // 
            // labelInfo_IPG
            // 
            labelInfo_IPG.AutoSize = true;
            labelInfo_IPG.Location = new Point(357, 109);
            labelInfo_IPG.Name = "labelInfo_IPG";
            labelInfo_IPG.Size = new Size(99, 32);
            labelInfo_IPG.TabIndex = 1;
            labelInfo_IPG.Text = "привет ";
            // 
            // buttonOk_IPG
            // 
            buttonOk_IPG.Location = new Point(575, 281);
            buttonOk_IPG.Name = "buttonOk_IPG";
            buttonOk_IPG.Size = new Size(150, 157);
            buttonOk_IPG.TabIndex = 2;
            buttonOk_IPG.Text = "ок";
            buttonOk_IPG.UseVisualStyleBackColor = true;
            buttonOk_IPG.Click += buttonOk_IPG_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOk_IPG);
            Controls.Add(labelInfo_IPG);
            Controls.Add(pictureBoxName_IPG);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxName_IPG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxName_IPG;
        private Label labelInfo_IPG;
        private Button buttonOk_IPG;
    }
}