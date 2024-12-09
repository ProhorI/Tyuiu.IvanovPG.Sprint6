
using Tyuiu.IvanovPG.Sprint6.Task5.V28.Lib;
using System.IO;
namespace Tyuiu.IvanovPG.Sprint6.Task5.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\ivano\source\repos\Tyuiu.IvanovPG.Sprint6\InPutDataFileTask5V28.txt";

        private void buttonDone_IPG_Click(object sender, EventArgs e)
        {
            dataGridViewResult_IPG.ColumnCount = 2;
            dataGridViewResult_IPG.Columns[0].Width = 50;
            dataGridViewResult_IPG.Columns[1].Width = 80;

            this.chartFunction_IPG.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_IPG.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_IPG.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_IPG.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_IPG.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenFile_IPG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;

            txt.Start();
        }

        private void buttonReference_IPG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студент группы ИСТНБ - 24 - 1 Иванов Прохор Геннадьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
