using System.Collections;

namespace PLJ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBox1;
        private Panel[,] panels = new Panel[5, 5];
        private Button button;
        int panel_x = 50;
        int panel_y = 50;

        int groupBox_x = 500;
        int groupBox_y = 500;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(140, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button
            // 
            button.Location = new Point(37, 46);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 0;
            button.Text = "Change colour";
            button.Click += button_Click;
            // 
            // Form1
            // 
            initializeBoard();
            //
            //
            //
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "PLJ";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        void initializeBoard()
        {
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    panels[i, j] = new Panel();
                    panels[i,j].Location = new Point(groupBox1.Location.X + i*60, groupBox1.Location.Y + j*60);
                    panels[i,j].Name = "panel" + index;
                    panels[i, j].Size = new Size(panel_x, panel_y);
                    panels[i, j].BackColor = Color.Black;
                    panels[i, j].TabIndex = index;
                    index++;
                    groupBox1.Controls.Add(panels[i,j]);
                }
            }
        }

        #endregion
    }
}