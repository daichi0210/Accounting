namespace Accounting
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void �ݒ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings s = new();
            s.ShowDialog();
        }
    }
}
