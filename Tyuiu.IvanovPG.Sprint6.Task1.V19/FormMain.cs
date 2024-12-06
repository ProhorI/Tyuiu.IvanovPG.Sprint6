using Tyuiu.IvanovPG.Sprint6.Task1.V19.Lib;
namespace Tyuiu.IvanovPG.Sprint6.Task1.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_IPG_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_IPG.Text);
                int stopStep = Convert.ToInt32(textBoxStop_IPG.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_IPG.Text = "";
                textBoxResult_IPG.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_IPG.AppendText("|    X     |    F(x)    |" + Environment.NewLine);
                textBoxResult_IPG.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}    | ", startStep, valueArray[i]);
                    textBoxResult_IPG.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_IPG.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReference_IPG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-24-1 Иванов Прохор Геннадьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
