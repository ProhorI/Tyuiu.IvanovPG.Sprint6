
using Tyuiu.IvanovPG.Sprint6.Task0.V20.Lib;

namespace Tyuiu.IvanovPG.Sprint6.Task0.V20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_IPG.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_IPG.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_IPG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHint_IPG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСТНБ-24-1 Иванов Прохор Геннадьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxTask_IPG_Enter(object sender, EventArgs e)
        {

        }
    }
}
