namespace DesktopDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {fName.Text} {lName.Text}");
            textBox3.Text = $"{fName.Text} {lName.Text}";
            label3.Text = "Full Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About clicked");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New about");
        }

        private async void getAllBtn_Click(object sender, EventArgs e)
        {
            var result = RestfulHelper.GetAll();
            OutputBox.Text = await result;
        }
    }
}