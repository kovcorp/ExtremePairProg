namespace PLJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            int cells = 5;

            int topCorner = 100;

            int panelSize = 50;
            int panelOffset = 10;

            int groupSize = topCorner + cells * (panelSize + panelOffset);
            groupBox1.Size = new Size(groupSize, groupSize);    

            panelMatrix = new List<List<Panel>>();
            for (int i = 0; i < cells; i++)
            {
                List<Panel> row = new List<Panel>();
                for (int j = 0; j < cells; j++)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(panelSize, panelSize);
                    int xCoord = topCorner + i * (panelSize + panelOffset);
                    int yCoord = topCorner + j * (panelSize + panelOffset);
                    panel.Location = new Point(xCoord, yCoord);
                    panel.Name = "panel" + i + ";" + j;
                    panel.TabIndex = i + j;
                    panel.BackColor = SystemColors.ActiveCaptionText;
                    row.Add(panel);
                    groupBox1.Controls.Add(panel);
                }
                panelMatrix.Add(row);
            }
            Button button = new Button();
            button.Text = "Színezz!";
            button.Click += buttonClick;
            button.Location = new Point(panelSize, panelSize);
            button.Size = new Size(panelSize, panelSize);
            groupBox1.Controls.Add(button);
            
        }

        private void buttonClick(object sender, EventArgs e)
        {
            foreach(List<Panel> panelList in panelMatrix)
            {
                foreach (Panel panel in panelList)
                {
                    panel.BackColor = Color.Red;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}