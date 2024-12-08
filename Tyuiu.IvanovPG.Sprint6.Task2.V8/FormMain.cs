
using Tyuiu.IvanovPG.Sprint6.Task2.V8.Lib;
namespace Tyuiu.IvanovPG.Sprint6.Task2.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonReference_IPG_Clic(object sender, EventArgs e)
        {
            MessageBox.Show("���� 2 �������� ������� ������ �����-24-1 ������ ������ �����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_IPG_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_IPG.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_IPG.Text);



                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_IPG.Titles.Add("������ �������");
                this.chartFunction_IPG.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_IPG.ChartAreas[0].AxisY.Title = "��� Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_IPG.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_IPG.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_IPG_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_IPG.BackColor = Color.Red;
        }

        private void buttonDone_IPG_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_IPG.BackColor = Color.Green;
        }

        private void buttonDone_IPG_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_IPG.BackColor = Color.Blue;
        }
        private void buttonReference_IPG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 1 �������� ������� ������ �����-24-1 ������ ������ �����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartFunction_IPG_Click(object sender, EventArgs e)
        {

        }
    }
}
