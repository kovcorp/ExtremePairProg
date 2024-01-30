namespace PLJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetUp();
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

        private void SetUp()
        {
            this.SuspendLayout();
            btn_startChessGame.Image = Properties.Resources.chess_mode_btn;
            btn_startSideGame.Image = Properties.Resources.side_mode_btn;
            this.ResumeLayout(false);
        }
    }
}