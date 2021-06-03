using System;
using System.Windows.Forms;

namespace RockPaperScissorsGame
{

    public partial class MainFrm : Form
    {

        public MainFrm()
        {

            InitializeComponent();

        }

        int playerScore = 0;

        int computerScore = 0;

        int draw = 0;

        readonly Random rnd = new Random();

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void BtnR_Click(object sender, EventArgs e)
        {

            int computerSelect = rnd.Next(1, 4);

            if (computerSelect == 1)
            {

                LCC.Text = "Computer Chosed Rock!!";

                draw++;

                LD.Text = "Draw : " + draw;

            }

            else if (computerSelect == 2)
            {

                LCC.Text = "Computer Chosed Paper!!";

                computerScore++;

                LCS.Text = "Computer Score : " + computerScore;

            }

            else
            {

                LCC.Text = "Computer Chosed Scissors!!";

                playerScore++;

                LYS.Text = "Your Score : " + playerScore;

            }

            WhoWon();

        }

        private void BtnP_Click(object sender, EventArgs e)
        {

            int computerSelect = rnd.Next(1, 4);

            if (computerSelect == 1)
            {

                LCC.Text = "Computer Chosed Rock!!";

                playerScore++;

                LYS.Text = "Your Score : " + playerScore;

            }

            else if (computerSelect == 2)
            {

                LCC.Text = "Computer Chosed Paper!!";

                draw++;

                LD.Text = "Draw : " + draw;

            }

            else
            {

                LCC.Text = "Computer Chosed Scissors!!";

                computerScore++;

                LCS.Text = "Computer Score : " + computerScore;

            }

            WhoWon();

        }

        private void BtnS_Click(object sender, EventArgs e)
        {

            int computerSelect = rnd.Next(1, 4);

            if (computerSelect == 1)
            {

                LCC.Text = "Computer Chosed Rock!!";

                computerScore++;

                LCS.Text = "Computer Score : " + computerScore;

            }

            else if (computerSelect == 2)
            {

                LCC.Text = "Computer Chosed Paper!!";

                playerScore++;

                LYS.Text = "Your Score : " + playerScore;

            }

            else
            {

                LCC.Text = "Computer Chosed Scissors!!";

                draw++;

                LD.Text = "Draw : " + draw;

            }

            WhoWon();

        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewGame();

        }

        private void AboutGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("This is my first game. It is working in windows system. \ne-mail : ahmetbakirci30@gmail.com");

        }

        private void WhoWon()
        {

            if (computerScore == 10)
            {

                MessageBox.Show("Computer Won!");

                NewGame();

            }

            else if (playerScore == 10)
            {

                MessageBox.Show("Player Won!");

                NewGame();

            }

            else if (draw == 10)
            {

                MessageBox.Show("Draw!");

                NewGame();

            }

        }

        private void NewGame()
        {

            playerScore = 0;

            computerScore = 0;

            draw = 0;

            LCS.Text = "Computer Score : " + computerScore;

            LYS.Text = "Your Score : " + playerScore;

            LD.Text = "Draw : " + draw;

            LCC.Text = string.Empty;

        }

    }

}