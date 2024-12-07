
using Tyuiu.IvanovPG.Sprint6.Task3.V8.Lib;
namespace Tyuiu.IvanovPG.Sprint6.Task3.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -10, 10, -7, 19, 6 },
                                      { 15, -13, -19, 9, 1 },
                                     { -20, -15, -6, 8, -4 },
                                       { 10, 18, -5, 9, -6 },
                                   { 16, -10, 4, 15, 16 }, };


        private void buttonHelp_IPG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНБ-24-1 Иванов Прохор Геннадьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxResult_IPG_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewMatrix_IPG.ColumnCount = columns;
            dataGridViewMatrix_IPG.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_IPG.Columns[i].Width = 100;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_IPG.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_IPG_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;
            dataGridViewMatrix_IPG.ColumnCount = columns;
            dataGridViewMatrix_IPG.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_IPG.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_IPG.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
    }
}
