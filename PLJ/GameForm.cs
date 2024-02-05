using System.Drawing;

namespace PLJ
{
    public partial class GameForm : Form
    {
        private List<PictureX> pboxes = new();
        private double neighbourDistance;

        public static double SIDE_MODE = 1.0;
        public static double HORSEY_MODE = Math.Sqrt(5.0);
        public GameForm(String headerText, double expectedNeighbourDistance)
        {
            InitializeComponent();
            neighbourDistance = expectedNeighbourDistance;

            this.SuspendLayout();
            this.Text = headerText;
            SetUp();
            this.ResumeLayout(false);
        }

        private void SetUp()
        {
            int x = 30;
            int y = 30;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    PictureX pBox = new(new Point(i, j));
                    pBox.Location = new Point(x, y);
                    pBox.Click += turn_Neighbours;
                    Controls.Add(pBox);
                    pboxes.Add(pBox);
                    x += 85;
                }
                x = 30;
                y += 85;
            }

        }

        public void turn_Neighbours(object sender, EventArgs e)
        {
            PictureX senderX = (PictureX)sender;
            Point coordinates = senderX.coordinates;
            Boolean everythingOk = true;
            foreach (PictureX pBox in pboxes)
            {
                double distance = getDistance(coordinates, pBox.coordinates);
                if (equalsWithTolerance(distance, neighbourDistance, 0.001))
                {
                    pBox.Turn();
                }
                if(pBox.Tag == "black")
                {
                    everythingOk = false;
                }
            }
            if(everythingOk)
            {
                MessageBox.Show("Nyertel!!!!!!");
            }
        }

        private double getDistance(Point start, Point end)
        {
            return Math.Sqrt(Math.Pow(start.X - end.X, 2) + Math.Pow(start.Y - end.Y, 2));
        }

        private bool equalsWithTolerance(double actual, double expected, double tolerance)
        {
            return Math.Abs(actual - expected) < tolerance;
        }
    }
}
