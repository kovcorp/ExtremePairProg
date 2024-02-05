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
            GameForm gForm = new("PLJ - Side mode", GameForm.SIDE_MODE);
            gForm.ShowDialog();
        }

        private void btn_startChessGame_Click(object sender, EventArgs e)
        {
            GameForm gForm = new("PLJ - Chess mode", GameForm.HORSEY_MODE);
            gForm.ShowDialog();
        }

        private void SetUp()
        {
            this.SuspendLayout();
            btn_startChessGame.Image = Properties.Resources.chess_mode_btn;
            btn_startSideGame.Image = Properties.Resources.side_mode_btn;
            this.ResumeLayout(false);
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            Form InfoForm = new();
            InfoForm.SuspendLayout();

            
            PictureBox pBox = new();
            pBox.Image = Properties.Resources.PLJ_Form_side_mode;
            pBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pBox.Location = new Point(10, 10);


            InfoForm.Controls.Add(pBox);

            InfoForm.Size = new Size(550, 550);
            InfoForm.ResumeLayout(false);
            InfoForm.ShowDialog();

        }
    }
}