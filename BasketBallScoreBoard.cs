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

  

        private void BasketBallScoreBoard_Load(object sender, EventArgs e)
        {
            ScoreBoard scoreboard = new ScoreBoard(aTeamScore, bTeamScore);
            scoreboard.Show();
        }
    }
}
