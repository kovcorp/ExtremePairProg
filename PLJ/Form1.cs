namespace PLJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_startSideGame_Click(object sender, EventArgs e)
        {
            GameForm gForm = new("PLJ - Side mode");
            gForm.ShowDialog();
        }

        private void btn_startChessGame_Click(object sender, EventArgs e)
        {
            GameForm gForm = new("PLJ - Chess mode");
            gForm.ShowDialog();
        }
    }
}