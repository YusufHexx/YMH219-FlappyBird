namespace _1_Flappy_Bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Skor: " + score;

            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 730;
                score++;
            }
            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 850;
                score++;

            }
            //Çarpışma denetleme,oyunu bitir, hile önleme(en üste çıkarsa oyunu bitir)
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 15;
            }
            
                
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Oyun Bitti!";
        }
    }
}
