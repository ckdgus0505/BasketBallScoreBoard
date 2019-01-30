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
    public partial class ScoreBoard : Form
    {
        public ScoreBoard(int aTeamScore, int bTeamScore)
        {
            InitializeComponent();
            txtAscore.Text = aTeamScore.ToString();
            txtBscore.Text = bTeamScore.ToString();
        }
    }
}
