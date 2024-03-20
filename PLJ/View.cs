using System.Drawing;

namespace PLJ
{
    public partial class View : Form
    {
        private List<PictureX> _pboxes = new();
        private Controller _myController;
       
        public View(String headerText)
        {
            InitializeComponent();

            this.SuspendLayout();
            this.Text = headerText;
            this.ResumeLayout(false);
        }

        public void SetController(Controller myController)
        {
            _myController = myController;
            _myController.Init();
        }

        public void ShowModel(bool[,] matrix, bool win, int steps)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i,j])
                        _pboxes[i * 5 + j].Image = Properties.Resources.red_tile_smashed;
                    else
                        _pboxes[i * 5 + j].Image = Properties.Resources.black_tile_smashed;
                }
            }

            if (win)
                MessageBox.Show("Nyertel, " + steps + " lépésből");
        }
        
        public void SetUp(bool[,] matrix)
        {

            int x_layout = 30;
            int y_layout = 30;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    PictureX pBox = new(new Point(i, j));
                    
                    pBox.Location = new Point(x_layout, y_layout);

                    pBox.Click += HandleClick; 

                    Controls.Add(pBox);
                    _pboxes.Add(pBox);
                    x_layout += 85;
                }

                x_layout = 30;
                y_layout += 85;
            }
        }

        private void HandleClick(object? sender, EventArgs e)
        {
            Point coordinates = ((PictureX)sender).coordinates;
            _myController.RedirectClickToModel(coordinates);
        }

   



    }

}
