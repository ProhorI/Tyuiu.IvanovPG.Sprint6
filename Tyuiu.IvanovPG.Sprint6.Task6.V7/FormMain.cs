
using Tyuiu.IvanovPG.Sprint6.Task6.V7.Lib;
namespace Tyuiu.IvanovPG.Sprint6.Task6.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxOutput_IPG.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_IPG.ScrollBars = ScrollBars.Vertical;
        }
        string openFilePath;
        DataService dataService = new DataService();

        private void buttonDone_IPG_Click(object sender, EventArgs e)
        {
            textBoxOutput_IPG.Text = dataService.CollectTextFromFile(openFilePath);
        }
        private void buttonQuestion_IPG_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenfile_IPG_Click(object sender, EventArgs e)
        {


            openFileDialogTask_IPG.ShowDialog();
            openFilePath = openFileDialogTask_IPG.FileName;
            try
            {
                textBoxInput_IPG.Text = File.ReadAllText(openFilePath);
                textBoxInput_IPG.Text = groupBoxInput_IPG.Text + " " + openFileDialogTask_IPG.FileName;
                buttonDone_IPG.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ôàéë íå íàéäåí", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
