using System.Drawing;

namespace PLJ
{
    public partial class GameForm : Form
    {
        private List<PictureX> pboxes = new();
        private double expectedNeighbourDistance;

        public static double SIDE_MODE = 1.0;
        public static double HORSEY_MODE = Math.Sqrt(5.0);
        private int stepCounter = 0;
        public GameForm(String headerText, double expectedNeighbourDistance)
        {
            InitializeComponent();
            this.expectedNeighbourDistance = expectedNeighbourDistance;

            this.SuspendLayout();
            this.Text = headerText;
            SetUp();
            this.ResumeLayout(false);
        }

        private void SetUp()
        {
            label_step.Text = stepCounter.ToString();
            int x = 30;
            int y = 30;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    PictureX pBox = new(new Point(i, j));
                    pBox.Location = new Point(x, y);

                    pBox.Click += turn_Neighbours;
                    pBox.MouseEnter += PBox_MouseEnter;
                    pBox.MouseLeave += PBox_MouseLeave;

                    Controls.Add(pBox);
                    pboxes.Add(pBox);
                    x += 85;
                }
                x = 30;
                y += 85;
            }
        }

        private void PBox_MouseLeave(object? sender, EventArgs e)
        {
            Tag = null;
            timer1.Stop();
            foreach (PictureX pBox in pboxes)
            {
                if (equalsWithTolerance(getDistance(((PictureX)sender).coordinates, pBox.coordinates), expectedNeighbourDistance, 0.001))
                    pBox.TurnPreviewBack();
            }
            ((PictureX)sender).TurnPreviewBack();
        }

        private void PBox_MouseEnter(object? sender, EventArgs e)
        {
            Tag = ((PictureX)sender);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (Tag != null)
            {
                PictureX p = (PictureX)Tag;
                foreach (PictureX pBox in pboxes)
                {
                    if (equalsWithTolerance(getDistance(p.coordinates, pBox.coordinates), expectedNeighbourDistance, 0.001))
                        pBox.TurnPreview();
                }
                p.TurnPreview();
            }
        }

        private void IncreaseStepCounter()
        {
            stepCounter++;
            label_step.Text = stepCounter.ToString();
        }

        public void turn_Neighbours(object sender, EventArgs e)
        {
            IncreaseStepCounter();
            PictureX senderX = (PictureX)sender;
            Point coordinates = senderX.coordinates;
            Boolean everythingOk = true;
            foreach (PictureX pBox in pboxes)
            {
                double distance = getDistance(coordinates, pBox.coordinates);
                if (equalsWithTolerance(distance, expectedNeighbourDistance, 0.001))
                    pBox.Turn();

                if (pBox.Tag == "black")
                    everythingOk = false;
            }
            if (everythingOk)
            {
                MessageBox.Show("Nyertel, "+ stepCounter +" lépésből");
            }
        }

        private double getDistance(Point start, Point end)
        {
            return Math.Sqrt(Math.Pow(start.X - end.X, 2) + Math.Pow(start.Y - end.Y, 2));
        }

        private bool equalsWithTolerance(double actual, double expectedDistance, double tolerance)
        {
            return Math.Abs(actual - expectedDistance) < tolerance;
        }
    }
}
