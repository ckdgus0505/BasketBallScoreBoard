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
        int quarter = 1;
        bool isAteamOffensive = true;

        public BasketBallScoreBoard()
        {
            InitializeComponent();
            Load += BasketBallScoreBoard_Load;
            btnScoreReset.Click += BtnScoreReset_Click;

        }

        private void BtnAScore(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            aTeamScore = aTeamScore + int.Parse(a.Text);
            txtAscore.Text = aTeamScore.ToString();

        }

        private void BtnBScore(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            bTeamScore = bTeamScore + int.Parse(b.Text);
            txtBscore.Text = bTeamScore.ToString();

        }

        private void BtnScoreReset_Click(object sender, EventArgs e)
        {
            aTeamScore = 0;
            bTeamScore = 0;
            txtAscore.Text = aTeamScore.ToString();
            txtBscore.Text = bTeamScore.ToString();
        }

        private void BtnAFoul(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            aTeamFoul ++ ;
        }


        private void BtnBFoul(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            bTeamFoul++;
        }

        private void BtnATime(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (aTeamTime >= 0 && aTeamTime <= 3)
            {
                aTeamTime++;
                if (aTeamTime == 1) rbtnA1time.Checked = true;
                if (aTeamTime == 2) rbtnA2time.Checked = true;
                if (aTeamTime == 3)
                {   
                    rbtnA3time.Checked = true;
                    btnAstr.Enabled = false;
                }
            }
            
        }

        private void BtnBTime(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (bTeamTime >= 0 && bTeamTime <= 3)
            {
                bTeamTime++;
                if (bTeamTime == 1) rbtnB1time.Checked = true;
                if (bTeamTime == 2) rbtnB2time.Checked = true;
                if (bTeamTime == 3)
                {
                    rbtnB3time.Checked = true;
                    btnBstr.Enabled = false;
                }
            }

        }

        private void BasketBallScoreBoard_Load(object sender, EventArgs e)
        {
            ScoreBoard scoreboard = new ScoreBoard(aTeamScore, bTeamScore);
            scoreboard.Show();
        }
    }
}
