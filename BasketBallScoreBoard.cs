using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketBallScoreBoard
{
    public partial class BasketBallScoreBoard : Form
    {
        int aTeamScore = 0, aTeamFoul = 0, aTeamTime = 0;
        int bTeamScore = 0, bTeamFoul = 0, bTeamTime = 0;
        bool isAteamOffensive = true;

        public BasketBallScoreBoard()
        {
            InitializeComponent();
            Load += BasketBallScoreBoard_Load;
            btnA1.Click += BtnA1_Click;
            btnA2.Click += BtnA2_Click;
            btnA3.Click += BtnA3_Click;
            btnB1.Click += BtnB1_Click;
            btnB2.Click += BtnB2_Click;
            btnB3.Click += BtnB3_Click;
            btnAcut.Click += BtnAcut_Click;
            btnBcut.Click += BtnBcut_Click;
            btnScoreReset.Click += BtnScoreReset_Click;

        }

        private void BtnScoreReset_Click(object sender, EventArgs e)
        {
            aTeamScore = 0;
            bTeamScore = 0;
        }

        private void BtnBcut_Click(object sender, EventArgs e)
        {
            bTeamScore -= 1;
            txtBscore.Text = bTeamScore.ToString();
        }

        private void BtnAcut_Click(object sender, EventArgs e)
        {
            aTeamScore -= 1;
            txtAscore.Text = aTeamScore.ToString();
        }

        private void BtnB3_Click(object sender, EventArgs e)
        {
            bTeamScore += 3;
            txtBscore.Text = bTeamScore.ToString();
        }

        private void BtnB2_Click(object sender, EventArgs e)
        {
            bTeamScore += 2;
            txtBscore.Text = bTeamScore.ToString();
        }

        private void BtnB1_Click(object sender, EventArgs e)
        {
            bTeamScore += 1;
            txtBscore.Text = bTeamScore.ToString();
        }

        private void BtnA3_Click(object sender, EventArgs e)
        {
            aTeamScore += 3;
            txtAscore.Text = aTeamScore.ToString();
        }

        private void BtnA2_Click(object sender, EventArgs e)
        {
            aTeamScore += 2;
            txtAscore.Text = aTeamScore.ToString();
        }

        private void BtnA1_Click(object sender, EventArgs e)
        {
            aTeamScore += 1;
            txtAscore.Text = aTeamScore.ToString();
        }

        private void BasketBallScoreBoard_Load(object sender, EventArgs e)
        {
            ScoreBoard scoreboard = new ScoreBoard(aTeamScore, bTeamScore);
            scoreboard.Show();
        }
    }
}
