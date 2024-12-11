namespace Rak
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnHello.Click += BtnHello_Click;
        }

        private void BtnHello_Click(object? sender, EventArgs e)
        {
            _ = MessageBox.Show("Hello");
        }
    }
}
