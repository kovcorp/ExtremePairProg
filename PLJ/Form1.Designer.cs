namespace PLJ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            btn_startSideGame = new Button();
            btn_startChessGame = new Button();
            btn_Info = new Button();
            SuspendLayout();
            // 
            // btn_startSideGame
            // 
            btn_startSideGame.Location = new Point(12, 12);
            btn_startSideGame.Name = "btn_startSideGame";
            btn_startSideGame.Size = new Size(120, 25);
            btn_startSideGame.TabIndex = 0;
            btn_startSideGame.UseVisualStyleBackColor = true;
            btn_startSideGame.Click += btn_startSideGame_Click;
            // 
            // btn_startChessGame
            // 
            btn_startChessGame.Location = new Point(12, 41);
            btn_startChessGame.Name = "btn_startChessGame";
            btn_startChessGame.Size = new Size(120, 25);
            btn_startChessGame.TabIndex = 1;
            btn_startChessGame.UseVisualStyleBackColor = true;
            btn_startChessGame.Click += btn_startChessGame_Click;
            // 
            // btn_Info
            // 
            btn_Info.Location = new Point(172, 14);
            btn_Info.Name = "btn_Info";
            btn_Info.Size = new Size(75, 52);
            btn_Info.TabIndex = 2;
            btn_Info.Text = "Info";
            btn_Info.UseVisualStyleBackColor = true;
            btn_Info.Click += btn_Info_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 78);
            Controls.Add(btn_Info);
            Controls.Add(btn_startChessGame);
            Controls.Add(btn_startSideGame);
            Name = "Form1";
            Text = "PLJ";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_startSideGame;
        private Button btn_startChessGame;
        private Button btn_Info;
    }
}