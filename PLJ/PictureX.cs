using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLJ
{
    internal class PictureX : PictureBox
    {
        public Point coordinates;
        public PictureX(Point coordinates) : base()
        {
            Image = Properties.Resources.black_tile_smashed;
            Tag = "black";
            Click += BindTurn;
            SizeMode = PictureBoxSizeMode.AutoSize;
            this.coordinates = coordinates;
        }

        public void BindTurn(object sender, EventArgs e)
        {
            Turn();
        }

        public void Turn()
        {
            if (Tag == "black")
            {
                Image = Properties.Resources.red_tile_smashed;
                Tag = "red";
            } else
            {
                Image = Properties.Resources.black_tile_smashed;
                Tag = "black";
            }
        }
    }
}
