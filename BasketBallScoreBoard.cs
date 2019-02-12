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
        bool isGameStart = false;

        DateTime startTime;
        DateTime stopTime1;
        DateTime stopTime2;
        DateTime sec24;
        DateTime sec24stop1;
        DateTime sec24stop2;
        
        int min = 45;
        int sec = 0;

        public BasketBallScoreBoard()
        {
            InitializeComponent();
            Load += BasketBallScoreBoard_Load;
            btnScoreReset.Click += BtnScoreReset_Click;
            btnStart.Click += BtnStart_Click;
            btn24start.Click += Btn24start_Click;
            btnMup.Click += BtnMup_Click;
            btnMdown.Click += BtnMdown_Click;
            btnSup.Click += BtnSup_Click;
            btnSdown.Click += BtnSdown_Click;
            btnQuarter.Click += BtnQuarter_Click;
            btn24reset.Click += Btn24reset_Click;
        }

        private void Btn24start_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Pause")
            {
                if(btn24start.Text == "Pause")
                {
                    sec24stop1 = DateTime.Now;
                    btn24start.Text = "Start";
                    SYNC24.Stop();
                }
                else if (btn24start.Text == "Start")
                {
                    sec24stop2 = DateTime.Now;
                    sec24 += sec24stop2 - sec24stop1;
                    btn24start.Text = "Pause";
                    SYNC24.Start();
                }
            }
        }

        private void Btn24reset_Click(object sender, EventArgs e)
        {
            sec24 = DateTime.Now.Add(new TimeSpan(0, 0, 0, 24));
        }

        private void BtnQuarter_Click(object sender, EventArgs e)
        {
            if (quarter >= 1 && quarter <= 5)
            {
                quarter++;
                if (quarter == 1) rbtnQ1.Checked = true;
                if (quarter == 2)
                {
                    rbtnQ1.Checked = false;
                    rbtnQ2.Checked = true;
                }
                if (quarter == 3)
                {
                    rbtnQ2.Checked = false;
                    rbtnQ3.Checked = true;
                }
                if (quarter == 4)
                {
                    rbtnQ3.Checked = false;
                    rbtnQ4.Checked = true;
                }
                if (quarter == 5)
                {
                    rbtnQ4.Checked = false;
                    rbtnQ5.Checked = true;
                    btnQuarter.Enabled = false;
                }
            }
        }

        private void BtnSdown_Click(object sender, EventArgs e)
        {
            sec--;
            GameTime.Text = min.ToString() + ":" + sec.ToString();
        }

        private void BtnSup_Click(object sender, EventArgs e)
        {
            sec++;
            GameTime.Text = min.ToString() + ":" + sec.ToString();
        }

        private void BtnMdown_Click(object sender, EventArgs e)
        {
            min--;
            GameTime.Text = min.ToString() + ":" + sec.ToString();
        }

        private void BtnMup_Click(object sender, EventArgs e)
        {
            min++;
            GameTime.Text = min.ToString() + ":" + sec.ToString();
        }

        private void ShowTime()
        {
            if (btn24start.Text == "start")
            {

                time24.Text = "";
            }
            else
            {
                if ((startTime - DateTime.Now).Minutes == 0 && (startTime - DateTime.Now).Seconds == 0 && (startTime - DateTime.Now).Milliseconds < 1)
                {
                    isGameStart = false;
                    GameTime.Text = "00:00";
                    time24.Text = "24";
                    btnStart.Text = "Start";
                }
                if (isGameStart == true)
                {
                    if ((startTime - DateTime.Now) <= (sec24 - DateTime.Now))
                    {
                        GameTime.Text = "";
                    }
                    else
                    {
                        GameTime.Text = (startTime - DateTime.Now).Minutes.ToString() + ":" + (startTime - DateTime.Now).Seconds.ToString();
                    }
                }
            }
        }

        private void ShowTime24()
        {

            if ((startTime - DateTime.Now).Minutes == 0 && (startTime - DateTime.Now).Seconds == 0 && (startTime - DateTime.Now).Milliseconds < 1)
            {
                isGameStart = false;
                time24.Text = "24";
                btnStart.Text = "Start";
            }
            if ((sec24 - DateTime.Now).Seconds == 0 && (sec24 - DateTime.Now).Milliseconds < 1)
            {
                sec24 = sec24.Add(new TimeSpan(0, 0, 0, 24));

            }
            if (isGameStart == true)
            {
                if ((startTime - DateTime.Now) <= (sec24 - DateTime.Now))
                {
                    if ((startTime - DateTime.Now).Seconds >= 5)
                    {
                        time24.Text = (startTime - DateTime.Now).Seconds.ToString();
                    }
                    else
                    {
                        time24.Text = (startTime - DateTime.Now).Seconds.ToString() + ":" + (startTime - DateTime.Now).Milliseconds.ToString();
                    }
                }
                else
                {
                    if ((sec24 - DateTime.Now).Seconds >= 5)
                    {
                        time24.Text = (sec24 - DateTime.Now).Seconds.ToString();
                    }
                    else
                    {
                        time24.Text = (sec24 - DateTime.Now).Seconds.ToString() + ":" + (sec24 - DateTime.Now).Milliseconds.ToString();
                    }
                }
            }

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(isGameStart == false)
            {
                startTime = DateTime.Now;
                stopTime1 = stopTime2 = startTime;
                sec24 = sec24stop1 = sec24stop2 =  startTime;
                startTime = startTime.Add(new TimeSpan(0, 0, min, sec));
                sec24 = sec24.Add(new TimeSpan(0, 0, 0, 24));
                isGameStart = true;
                btn24start.Text = "Pause";
            }
            if (btnStart.Text == "Pause")
            {
                stopTime1 = DateTime.Now;
                sec24stop1 = stopTime1;
                btnStart.Text = "Start";
                btn24start.Text = "Start";

                SYNC.Stop();
                SYNC24.Stop();
            }
            else
            {
                stopTime2 = DateTime.Now;
                sec24stop2 = stopTime2;
                startTime += stopTime2 - stopTime1;
                sec24 += sec24stop2 - sec24stop1;
                btnStart.Text = "Pause";
                btn24start.Text = "Pause";

                SYNC.Start();
                SYNC24.Start();
            }
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

        private void SYNC_Tick(object sender, EventArgs e) // 시간에 지남에 따라 윈폼 최신화 가능
        {
            ShowTime();
        }

        private void SYNC24_Tick(object sender, EventArgs e)
        {
            ShowTime24();
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
            //scoreboard.Show();
        }
    }
}
