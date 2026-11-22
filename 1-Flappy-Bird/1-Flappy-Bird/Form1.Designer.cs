namespace _1_Flappy_Bird
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            pipeTop = new PictureBox();
            flappyBird = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            SuspendLayout();
            // 
            // pipeBottom
            // 
            pipeBottom.Image = (Image)resources.GetObject("pipeBottom.Image");
            pipeBottom.Location = new Point(299, 348);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(120, 243);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-35, 545);
            ground.Name = "ground";
            ground.Size = new Size(560, 184);
            ground.SizeMode = PictureBoxSizeMode.CenterImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Transparent;
            scoreText.Font = new Font("Georgia", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            scoreText.Location = new Point(12, 9);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(150, 41);
            scoreText.TabIndex = 4;
            scoreText.Text = "Skor: 0";
            // 
            // pipeTop
            // 
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(364, -42);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(107, 221);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(60, 289);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(58, 52);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(519, 635);
            Controls.Add(scoreText);
            Controls.Add(flappyBird);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Name = "Form1";
            Text = "Flappy Bird Oyunu";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
        private PictureBox pipeTop;
        private PictureBox flappyBird;
        private System.Windows.Forms.Timer gameTimer;
    }
}
