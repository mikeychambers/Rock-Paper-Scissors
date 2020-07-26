using RockPaperScissors.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly static Random numberGen = new Random();
        public int score = 0;
        public int computerScore = 0;
       
         void PlayerRock_Click(object sender, EventArgs e)
         {
            int computerChoice = numberGen.Next(1, 4);
            switch (computerChoice)
            {
                case 1:
                    pictureBox1.Image = new Bitmap(Resources.Rock);
                    label1.Text = "Draw";
                    break;
                case 2:
                    pictureBox1.Image = new Bitmap(Resources.Paper);
                    label1.Text = "You Lose";
                    computerScore++;
                    break;
                case 3:
                    pictureBox1.Image = new Bitmap(Resources.Scissors);
                    label1.Text = "You Win!";
                    score++;
                    break;
            }
            ScoreToString();

        }

        void PlayerPaper_Click(object sender, EventArgs e)
         {
            int computerChoice = numberGen.Next(1, 4);
            switch (computerChoice)
            {
                case 1:
                    pictureBox1.Image = new Bitmap(Resources.Rock);
                    label1.Text = "You Win!";
                    score++;
                    break;
                case 2:
                    pictureBox1.Image = new Bitmap(Resources.Paper);
                    label1.Text = "Draw";
                    break;
                case 3:
                    pictureBox1.Image = new Bitmap(Resources.Scissors);
                    label1.Text = "You Lose";
                    computerScore++;
                    break;
            }
            ScoreToString();


        }

        void PlayerScissors_Click(object sender, EventArgs e)
         {
            int computerChoice = numberGen.Next(1, 4);
            switch (computerChoice)
            {
                case 1:
                    pictureBox1.Image = new Bitmap(Resources.Rock);
                    label1.Text = "You Lose";
                    computerScore++;
                    break;
                case 2:
                    pictureBox1.Image = new Bitmap(Resources.Paper);
                    label1.Text = "You Win!";
                    score++;
                    break;
                case 3:
                    pictureBox1.Image = new Bitmap(Resources.Scissors);
                    label1.Text = "Draw";
                    break;
            }
            ScoreToString();
        }

        void ScoreToString()
        {
            PlayerScore.Text = "Player Score: " + score.ToString();
            PCScore.Text = "Computer Score: " + computerScore.ToString();
        }

    }
}
