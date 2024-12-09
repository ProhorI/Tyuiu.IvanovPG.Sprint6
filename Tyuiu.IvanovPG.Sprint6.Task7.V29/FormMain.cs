

using Tyuiu.IvanovPG.Sprint6.Task7.V29.Lib;
namespace Tyuiu.IvanovPG.Sprint6.Task7.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_IPG.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_IPG.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static string openFilePath;
        static int rows;
        static int colums;
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }


        DataService ds = new DataService();
        private void buttonOpenFile_IPG_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IPG.ShowDialog();
            openFilePath = openFileDialogTask_IPG.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_IPG.ColumnCount = colums;
            dataGridViewInput_IPG.RowCount = rows;
            dataGridViewOutput_IPG.ColumnCount = colums;
            dataGridViewOutput_IPG.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInput_IPG.Columns[i].Width = 100;
                dataGridViewOutput_IPG.Columns[i].Width = 100;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInput_IPG.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_IPG.Enabled = true;
        }

        private void buttonDone_IPG_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutput_IPG.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_IPG.Enabled = true;
        }

        private void buttonHelp_IPG_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSaveFile_IPG_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_IPG.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_IPG.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_IPG.ShowDialog();

            string path = saveFileDialogMatrix_IPG.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_IPG.RowCount;
            int columns = dataGridViewOutput_IPG.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_IPG.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_IPG.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_IPG.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_IPG.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_IPG_MouseEnter(object sender, EventArgs e)
        {
            
            toolTipButton_IPG.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_IPG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_IPG.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_IPG.ColumnCount = 100;
            dataGridViewOutput_IPG.ColumnCount = 100;

            dataGridViewInput_IPG.RowCount = 100;
            dataGridViewOutput_IPG.RowCount = 100;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_IPG.Columns[i].Width = 50;
                dataGridViewOutput_IPG.Columns[i].Width = 50;
            }
        }
    }
}
