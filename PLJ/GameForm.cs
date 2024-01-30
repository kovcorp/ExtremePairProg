namespace PLJ
{
    public partial class GameForm : Form
    {
        public GameForm(String headerText)
        {
            InitializeComponent();
            this.SuspendLayout();
            this.Text = headerText;
            this.ResumeLayout(false);
        }
    }
}
