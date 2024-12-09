
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

        private void buttonFile_IPG_Click(object sender, EventArgs e)
        {
            textBoxOutput_IPG.Text = dataService.CollectTextFromFile(openFilePath);
        }
        private void buttonQuestion_IPG_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonFile_IPG_Click(object sender, EventArgs e)
        {
            object value = buttonFile_IPG.ShowDialog();
            openFilePath = buttonFile_IPG.FileName;
            try
            {
                textBoxInput_IPG.Text = File.ReadAllText(openFilePath);
                groupBoxInput_IPG.Text = groupBoxInput_IPG.Text + " " + buttonFile_IPG.FileName;
                buttonCursor_IPG.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ôàéë íå íàéäåí", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
