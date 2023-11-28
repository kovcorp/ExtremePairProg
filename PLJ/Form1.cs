namespace PLJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Panel> panels = new List<Panel>();
        private void Form1_Load(object sender, EventArgs e)
        {
            panels.Add(p00);
            panels.Add(p01);
            panels.Add(p02);
            panels.Add(p03);
            panels.Add(p04);

            panels.Add(p10);
            panels.Add(p11);
            panels.Add(p12);
            panels.Add(p13);
            panels.Add(p14);

            panels.Add(p20);
            panels.Add(p21);
            panels.Add(p22);
            panels.Add(p23);
            panels.Add(p24);

            panels.Add(p30);
            panels.Add(p31);
            panels.Add(p32);
            panels.Add(p33);
            panels.Add(p34);

            panels.Add(p40);
            panels.Add(p41);
            panels.Add(p42);
            panels.Add(p43);
            panels.Add(p44);

            foreach (var item in panels)
            {
                item.BackColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            foreach (var item in groupBox1.Controls)
            {
                ((Panel)item).BackColor = Color.Red;
            }
        }
    }

}