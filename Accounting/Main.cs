namespace Accounting
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ï¬Ç∂ÇÈToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ê›íËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings s = new();
            s.ShowDialog();
        }
    }
}
