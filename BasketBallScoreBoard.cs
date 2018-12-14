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
        public BasketBallScoreBoard()
        {
            InitializeComponent();
            Load += BasketBallScoreBoard_Load;
        }

        private void BasketBallScoreBoard_Load(object sender, EventArgs e)
        {
            ScoreBoard scoreboard = new ScoreBoard();
            scoreboard.Show();
        }
    }
}
