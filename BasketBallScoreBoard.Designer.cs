namespace BasketBallScoreBoard
{
    partial class BasketBallScoreBoard
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketBallScoreBoard));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btn24start = new System.Windows.Forms.Button();
            this.btn24up = new System.Windows.Forms.Button();
            this.btnsettingsave = new System.Windows.Forms.Button();
            this.btnMup = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBuzzer = new System.Windows.Forms.Button();
            this.btn24reset = new System.Windows.Forms.Button();
            this.btn24down = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btnMdown = new System.Windows.Forms.Button();
            this.btnSdown = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnScoreReset = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnAcut = new System.Windows.Forms.Button();
            this.btnAfoul = new System.Windows.Forms.Button();
            this.btnAstr = new System.Windows.Forms.Button();
            this.btnQuarter = new System.Windows.Forms.Button();
            this.btnBcut = new System.Windows.Forms.Button();
            this.btnbfoul = new System.Windows.Forms.Button();
            this.btnBstr = new System.Windows.Forms.Button();
            this.txtAscore = new System.Windows.Forms.TextBox();
            this.txtBscore = new System.Windows.Forms.TextBox();
            this.TeamA = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rbtnA3time = new System.Windows.Forms.RadioButton();
            this.rbtnA2time = new System.Windows.Forms.RadioButton();
            this.rbtnA1time = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.TeamB = new System.Windows.Forms.GroupBox();
            this.rbtnB3time = new System.Windows.Forms.RadioButton();
            this.rbtnB2time = new System.Windows.Forms.RadioButton();
            this.rbtnB1time = new System.Windows.Forms.RadioButton();
            this.SYNC = new System.Windows.Forms.Timer(this.components);
            this.GameTime = new System.Windows.Forms.Label();
            this.time24 = new System.Windows.Forms.TextBox();
            this.rbtnQ1 = new System.Windows.Forms.RadioButton();
            this.rbtnQ2 = new System.Windows.Forms.RadioButton();
            this.rbtnQ3 = new System.Windows.Forms.RadioButton();
            this.rbtnQ4 = new System.Windows.Forms.RadioButton();
            this.rbtnQ5 = new System.Windows.Forms.RadioButton();
            this.SYNC24 = new System.Windows.Forms.Timer(this.components);
            this.TeamA.SuspendLayout();
            this.TeamB.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(9, 10);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(107, 60);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btn24start
            // 
            this.btn24start.BackColor = System.Drawing.Color.Firebrick;
            this.btn24start.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn24start.Location = new System.Drawing.Point(121, 10);
            this.btn24start.Margin = new System.Windows.Forms.Padding(2);
            this.btn24start.Name = "btn24start";
            this.btn24start.Size = new System.Drawing.Size(107, 60);
            this.btn24start.TabIndex = 1;
            this.btn24start.Text = "START\r\nSTOP";
            this.btn24start.UseVisualStyleBackColor = false;
            // 
            // btn24up
            // 
            this.btn24up.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn24up.Location = new System.Drawing.Point(232, 10);
            this.btn24up.Margin = new System.Windows.Forms.Padding(2);
            this.btn24up.Name = "btn24up";
            this.btn24up.Size = new System.Drawing.Size(107, 60);
            this.btn24up.TabIndex = 1;
            this.btn24up.Text = "UP";
            this.btn24up.UseVisualStyleBackColor = true;
            // 
            // btnsettingsave
            // 
            this.btnsettingsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettingsave.Location = new System.Drawing.Point(344, 10);
            this.btnsettingsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsettingsave.Name = "btnsettingsave";
            this.btnsettingsave.Size = new System.Drawing.Size(107, 60);
            this.btnsettingsave.TabIndex = 1;
            this.btnsettingsave.Text = "저장";
            this.btnsettingsave.UseVisualStyleBackColor = true;
            // 
            // btnMup
            // 
            this.btnMup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMup.Location = new System.Drawing.Point(456, 10);
            this.btnMup.Margin = new System.Windows.Forms.Padding(2);
            this.btnMup.Name = "btnMup";
            this.btnMup.Size = new System.Drawing.Size(107, 60);
            this.btnMup.TabIndex = 1;
            this.btnMup.Text = "UP";
            this.btnMup.UseVisualStyleBackColor = true;
            // 
            // btnSup
            // 
            this.btnSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.Location = new System.Drawing.Point(568, 10);
            this.btnSup.Margin = new System.Windows.Forms.Padding(2);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(107, 60);
            this.btnSup.TabIndex = 1;
            this.btnSup.Text = "UP";
            this.btnSup.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Firebrick;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(680, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 60);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnBuzzer
            // 
            this.btnBuzzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuzzer.Location = new System.Drawing.Point(9, 74);
            this.btnBuzzer.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuzzer.Name = "btnBuzzer";
            this.btnBuzzer.Size = new System.Drawing.Size(107, 60);
            this.btnBuzzer.TabIndex = 1;
            this.btnBuzzer.Text = "Buzzer";
            this.btnBuzzer.UseVisualStyleBackColor = true;
            // 
            // btn24reset
            // 
            this.btn24reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn24reset.Location = new System.Drawing.Point(121, 74);
            this.btn24reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn24reset.Name = "btn24reset";
            this.btn24reset.Size = new System.Drawing.Size(107, 60);
            this.btn24reset.TabIndex = 1;
            this.btn24reset.Text = "RESET";
            this.btn24reset.UseVisualStyleBackColor = true;
            // 
            // btn24down
            // 
            this.btn24down.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn24down.Location = new System.Drawing.Point(232, 74);
            this.btn24down.Margin = new System.Windows.Forms.Padding(2);
            this.btn24down.Name = "btn24down";
            this.btn24down.Size = new System.Drawing.Size(107, 60);
            this.btn24down.TabIndex = 1;
            this.btn24down.Text = "DOWN";
            this.btn24down.UseVisualStyleBackColor = true;
            // 
            // btn14
            // 
            this.btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14.Location = new System.Drawing.Point(344, 74);
            this.btn14.Margin = new System.Windows.Forms.Padding(2);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(107, 60);
            this.btn14.TabIndex = 1;
            this.btn14.Text = "14초";
            this.btn14.UseVisualStyleBackColor = true;
            // 
            // btnMdown
            // 
            this.btnMdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMdown.Location = new System.Drawing.Point(456, 74);
            this.btnMdown.Margin = new System.Windows.Forms.Padding(2);
            this.btnMdown.Name = "btnMdown";
            this.btnMdown.Size = new System.Drawing.Size(107, 60);
            this.btnMdown.TabIndex = 1;
            this.btnMdown.Text = "DOWN";
            this.btnMdown.UseVisualStyleBackColor = true;
            // 
            // btnSdown
            // 
            this.btnSdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSdown.Location = new System.Drawing.Point(568, 74);
            this.btnSdown.Margin = new System.Windows.Forms.Padding(2);
            this.btnSdown.Name = "btnSdown";
            this.btnSdown.Size = new System.Drawing.Size(107, 60);
            this.btnSdown.TabIndex = 1;
            this.btnSdown.Text = "DOWN";
            this.btnSdown.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(680, 74);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 60);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnA1
            // 
            this.btnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA1.Location = new System.Drawing.Point(9, 139);
            this.btnA1.Margin = new System.Windows.Forms.Padding(2);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(107, 60);
            this.btnA1.TabIndex = 1;
            this.btnA1.Text = "1";
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.Click += new System.EventHandler(this.BtnAScore);
            // 
            // btnA2
            // 
            this.btnA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA2.Location = new System.Drawing.Point(121, 139);
            this.btnA2.Margin = new System.Windows.Forms.Padding(2);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(107, 60);
            this.btnA2.TabIndex = 1;
            this.btnA2.Text = "2";
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.BtnAScore);
            // 
            // btnA3
            // 
            this.btnA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA3.Location = new System.Drawing.Point(232, 139);
            this.btnA3.Margin = new System.Windows.Forms.Padding(2);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(107, 60);
            this.btnA3.TabIndex = 1;
            this.btnA3.Text = "3";
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.BtnAScore);
            // 
            // btnScoreReset
            // 
            this.btnScoreReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreReset.Location = new System.Drawing.Point(344, 139);
            this.btnScoreReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnScoreReset.Name = "btnScoreReset";
            this.btnScoreReset.Size = new System.Drawing.Size(107, 60);
            this.btnScoreReset.TabIndex = 1;
            this.btnScoreReset.Text = "점수\r\nReset";
            this.btnScoreReset.UseVisualStyleBackColor = true;
            // 
            // btnB1
            // 
            this.btnB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB1.Location = new System.Drawing.Point(456, 139);
            this.btnB1.Margin = new System.Windows.Forms.Padding(2);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(107, 60);
            this.btnB1.TabIndex = 1;
            this.btnB1.Text = "1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.BtnBScore);
            // 
            // btnB2
            // 
            this.btnB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB2.Location = new System.Drawing.Point(568, 139);
            this.btnB2.Margin = new System.Windows.Forms.Padding(2);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(107, 60);
            this.btnB2.TabIndex = 1;
            this.btnB2.Text = "2";
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.BtnBScore);
            // 
            // btnB3
            // 
            this.btnB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB3.Location = new System.Drawing.Point(680, 139);
            this.btnB3.Margin = new System.Windows.Forms.Padding(2);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(107, 60);
            this.btnB3.TabIndex = 1;
            this.btnB3.Text = "3";
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.BtnBScore);
            // 
            // btnAcut
            // 
            this.btnAcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcut.Location = new System.Drawing.Point(9, 204);
            this.btnAcut.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcut.Name = "btnAcut";
            this.btnAcut.Size = new System.Drawing.Size(107, 60);
            this.btnAcut.TabIndex = 1;
            this.btnAcut.Text = "-1";
            this.btnAcut.UseVisualStyleBackColor = true;
            this.btnAcut.Click += new System.EventHandler(this.BtnAScore);
            // 
            // btnAfoul
            // 
            this.btnAfoul.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfoul.Location = new System.Drawing.Point(121, 204);
            this.btnAfoul.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfoul.Name = "btnAfoul";
            this.btnAfoul.Size = new System.Drawing.Size(107, 60);
            this.btnAfoul.TabIndex = 1;
            this.btnAfoul.Text = "파울\r\n세트";
            this.btnAfoul.UseVisualStyleBackColor = true;
            // 
            // btnAstr
            // 
            this.btnAstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAstr.Location = new System.Drawing.Point(232, 204);
            this.btnAstr.Margin = new System.Windows.Forms.Padding(2);
            this.btnAstr.Name = "btnAstr";
            this.btnAstr.Size = new System.Drawing.Size(107, 60);
            this.btnAstr.TabIndex = 1;
            this.btnAstr.Text = "작전\r\n타임";
            this.btnAstr.UseVisualStyleBackColor = true;
            this.btnAstr.Click += new System.EventHandler(this.BtnATime);
            // 
            // btnQuarter
            // 
            this.btnQuarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuarter.Location = new System.Drawing.Point(344, 204);
            this.btnQuarter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuarter.Name = "btnQuarter";
            this.btnQuarter.Size = new System.Drawing.Size(107, 60);
            this.btnQuarter.TabIndex = 1;
            this.btnQuarter.Text = "쿼터";
            this.btnQuarter.UseVisualStyleBackColor = true;
            // 
            // btnBcut
            // 
            this.btnBcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBcut.Location = new System.Drawing.Point(456, 204);
            this.btnBcut.Margin = new System.Windows.Forms.Padding(2);
            this.btnBcut.Name = "btnBcut";
            this.btnBcut.Size = new System.Drawing.Size(107, 60);
            this.btnBcut.TabIndex = 1;
            this.btnBcut.Text = "-1";
            this.btnBcut.UseVisualStyleBackColor = true;
            this.btnBcut.Click += new System.EventHandler(this.BtnBScore);
            // 
            // btnbfoul
            // 
            this.btnbfoul.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbfoul.Location = new System.Drawing.Point(568, 204);
            this.btnbfoul.Margin = new System.Windows.Forms.Padding(2);
            this.btnbfoul.Name = "btnbfoul";
            this.btnbfoul.Size = new System.Drawing.Size(107, 60);
            this.btnbfoul.TabIndex = 1;
            this.btnbfoul.Text = "파울\r\n세트";
            this.btnbfoul.UseVisualStyleBackColor = true;
            // 
            // btnBstr
            // 
            this.btnBstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBstr.Location = new System.Drawing.Point(680, 204);
            this.btnBstr.Margin = new System.Windows.Forms.Padding(2);
            this.btnBstr.Name = "btnBstr";
            this.btnBstr.Size = new System.Drawing.Size(107, 60);
            this.btnBstr.TabIndex = 1;
            this.btnBstr.Text = "작전\r\n타임";
            this.btnBstr.UseVisualStyleBackColor = true;
            this.btnBstr.Click += new System.EventHandler(this.BtnBTime);
            // 
            // txtAscore
            // 
            this.txtAscore.BackColor = System.Drawing.Color.Black;
            this.txtAscore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAscore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAscore.ForeColor = System.Drawing.Color.Red;
            this.txtAscore.Location = new System.Drawing.Point(121, 500);
            this.txtAscore.Margin = new System.Windows.Forms.Padding(2);
            this.txtAscore.MaxLength = 3;
            this.txtAscore.Name = "txtAscore";
            this.txtAscore.ReadOnly = true;
            this.txtAscore.Size = new System.Drawing.Size(184, 125);
            this.txtAscore.TabIndex = 3;
            this.txtAscore.Text = "0";
            this.txtAscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBscore
            // 
            this.txtBscore.BackColor = System.Drawing.Color.Black;
            this.txtBscore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBscore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBscore.ForeColor = System.Drawing.Color.Red;
            this.txtBscore.Location = new System.Drawing.Point(491, 500);
            this.txtBscore.Margin = new System.Windows.Forms.Padding(2);
            this.txtBscore.MaxLength = 3;
            this.txtBscore.Name = "txtBscore";
            this.txtBscore.ReadOnly = true;
            this.txtBscore.Size = new System.Drawing.Size(184, 125);
            this.txtBscore.TabIndex = 4;
            this.txtBscore.Text = "0";
            this.txtBscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TeamA
            // 
            this.TeamA.Controls.Add(this.radioButton7);
            this.TeamA.Controls.Add(this.rbtnA3time);
            this.TeamA.Controls.Add(this.rbtnA2time);
            this.TeamA.Controls.Add(this.rbtnA1time);
            this.TeamA.Controls.Add(this.radioButton1);
            this.TeamA.Location = new System.Drawing.Point(9, 269);
            this.TeamA.Margin = new System.Windows.Forms.Padding(2);
            this.TeamA.Name = "TeamA";
            this.TeamA.Size = new System.Drawing.Size(295, 230);
            this.TeamA.TabIndex = 6;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(646, 104);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(21, 20);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // rbtnA3time
            // 
            this.rbtnA3time.AutoCheck = false;
            this.rbtnA3time.AutoSize = true;
            this.rbtnA3time.Location = new System.Drawing.Point(112, 155);
            this.rbtnA3time.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnA3time.Name = "rbtnA3time";
            this.rbtnA3time.Size = new System.Drawing.Size(21, 20);
            this.rbtnA3time.TabIndex = 0;
            this.rbtnA3time.TabStop = true;
            this.rbtnA3time.UseVisualStyleBackColor = true;
            // 
            // rbtnA2time
            // 
            this.rbtnA2time.AutoCheck = false;
            this.rbtnA2time.AutoSize = true;
            this.rbtnA2time.Location = new System.Drawing.Point(112, 130);
            this.rbtnA2time.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnA2time.Name = "rbtnA2time";
            this.rbtnA2time.Size = new System.Drawing.Size(21, 20);
            this.rbtnA2time.TabIndex = 0;
            this.rbtnA2time.TabStop = true;
            this.rbtnA2time.UseVisualStyleBackColor = true;
            // 
            // rbtnA1time
            // 
            this.rbtnA1time.AutoCheck = false;
            this.rbtnA1time.AutoSize = true;
            this.rbtnA1time.Location = new System.Drawing.Point(112, 104);
            this.rbtnA1time.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnA1time.Name = "rbtnA1time";
            this.rbtnA1time.Size = new System.Drawing.Size(21, 20);
            this.rbtnA1time.TabIndex = 0;
            this.rbtnA1time.TabStop = true;
            this.rbtnA1time.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(112, 104);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(21, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TeamB
            // 
            this.TeamB.Controls.Add(this.rbtnB3time);
            this.TeamB.Controls.Add(this.rbtnB2time);
            this.TeamB.Controls.Add(this.rbtnB1time);
            this.TeamB.Location = new System.Drawing.Point(491, 269);
            this.TeamB.Margin = new System.Windows.Forms.Padding(2);
            this.TeamB.Name = "TeamB";
            this.TeamB.Padding = new System.Windows.Forms.Padding(2);
            this.TeamB.Size = new System.Drawing.Size(296, 230);
            this.TeamB.TabIndex = 7;
            this.TeamB.TabStop = false;
            // 
            // rbtnB3time
            // 
            this.rbtnB3time.AutoCheck = false;
            this.rbtnB3time.AutoSize = true;
            this.rbtnB3time.Location = new System.Drawing.Point(164, 155);
            this.rbtnB3time.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnB3time.Name = "rbtnB3time";
            this.rbtnB3time.Size = new System.Drawing.Size(21, 20);
            this.rbtnB3time.TabIndex = 0;
            this.rbtnB3time.TabStop = true;
            this.rbtnB3time.UseVisualStyleBackColor = true;
            // 
            // rbtnB2time
            // 
            this.rbtnB2time.AutoCheck = false;
            this.rbtnB2time.AutoSize = true;
            this.rbtnB2time.Location = new System.Drawing.Point(164, 130);
            this.rbtnB2time.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnB2time.Name = "rbtnB2time";
            this.rbtnB2time.Size = new System.Drawing.Size(21, 20);
            this.rbtnB2time.TabIndex = 0;
            this.rbtnB2time.TabStop = true;
            this.rbtnB2time.UseVisualStyleBackColor = true;
            // 
            // rbtnB1time
            // 
            this.rbtnB1time.AutoCheck = false;
            this.rbtnB1time.AutoSize = true;
            this.rbtnB1time.Location = new System.Drawing.Point(164, 104);
            this.rbtnB1time.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnB1time.Name = "rbtnB1time";
            this.rbtnB1time.Size = new System.Drawing.Size(21, 20);
            this.rbtnB1time.TabIndex = 0;
            this.rbtnB1time.TabStop = true;
            this.rbtnB1time.UseVisualStyleBackColor = true;
            // 
            // SYNC
            // 
            this.SYNC.Enabled = true;
            this.SYNC.Interval = 1;
            this.SYNC.Tick += new System.EventHandler(this.SYNC_Tick);
            // 
            // GameTime
            // 
            this.GameTime.AutoSize = true;
            this.GameTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTime.ForeColor = System.Drawing.Color.Red;
            this.GameTime.Location = new System.Drawing.Point(236, 314);
            this.GameTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameTime.Name = "GameTime";
            this.GameTime.Size = new System.Drawing.Size(327, 124);
            this.GameTime.TabIndex = 8;
            this.GameTime.Text = "45:00";
            // 
            // time24
            // 
            this.time24.BackColor = System.Drawing.Color.Black;
            this.time24.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time24.ForeColor = System.Drawing.Color.Red;
            this.time24.Location = new System.Drawing.Point(330, 496);
            this.time24.Name = "time24";
            this.time24.Size = new System.Drawing.Size(136, 132);
            this.time24.TabIndex = 9;
            this.time24.Text = "24";
            this.time24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtnQ1
            // 
            this.rbtnQ1.AutoCheck = false;
            this.rbtnQ1.AutoSize = true;
            this.rbtnQ1.Checked = true;
            this.rbtnQ1.Location = new System.Drawing.Point(309, 470);
            this.rbtnQ1.Name = "rbtnQ1";
            this.rbtnQ1.Size = new System.Drawing.Size(21, 20);
            this.rbtnQ1.TabIndex = 10;
            this.rbtnQ1.UseVisualStyleBackColor = true;
            // 
            // rbtnQ2
            // 
            this.rbtnQ2.AutoCheck = false;
            this.rbtnQ2.AutoSize = true;
            this.rbtnQ2.Location = new System.Drawing.Point(350, 470);
            this.rbtnQ2.Name = "rbtnQ2";
            this.rbtnQ2.Size = new System.Drawing.Size(21, 20);
            this.rbtnQ2.TabIndex = 10;
            this.rbtnQ2.UseVisualStyleBackColor = true;
            // 
            // rbtnQ3
            // 
            this.rbtnQ3.AutoCheck = false;
            this.rbtnQ3.AutoSize = true;
            this.rbtnQ3.Location = new System.Drawing.Point(391, 470);
            this.rbtnQ3.Name = "rbtnQ3";
            this.rbtnQ3.Size = new System.Drawing.Size(21, 20);
            this.rbtnQ3.TabIndex = 10;
            this.rbtnQ3.UseVisualStyleBackColor = true;
            // 
            // rbtnQ4
            // 
            this.rbtnQ4.AutoCheck = false;
            this.rbtnQ4.AutoSize = true;
            this.rbtnQ4.Location = new System.Drawing.Point(432, 470);
            this.rbtnQ4.Name = "rbtnQ4";
            this.rbtnQ4.Size = new System.Drawing.Size(21, 20);
            this.rbtnQ4.TabIndex = 10;
            this.rbtnQ4.UseVisualStyleBackColor = true;
            // 
            // rbtnQ5
            // 
            this.rbtnQ5.AutoCheck = false;
            this.rbtnQ5.AutoSize = true;
            this.rbtnQ5.Location = new System.Drawing.Point(473, 470);
            this.rbtnQ5.Name = "rbtnQ5";
            this.rbtnQ5.Size = new System.Drawing.Size(21, 20);
            this.rbtnQ5.TabIndex = 10;
            this.rbtnQ5.UseVisualStyleBackColor = true;
            // 
            // SYNC24
            // 
            this.SYNC24.Tick += new System.EventHandler(this.SYNC24_Tick);
            // 
            // BasketBallScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 715);
            this.Controls.Add(this.rbtnQ5);
            this.Controls.Add(this.rbtnQ4);
            this.Controls.Add(this.rbtnQ3);
            this.Controls.Add(this.rbtnQ2);
            this.Controls.Add(this.rbtnQ1);
            this.Controls.Add(this.time24);
            this.Controls.Add(this.GameTime);
            this.Controls.Add(this.TeamB);
            this.Controls.Add(this.TeamA);
            this.Controls.Add(this.txtBscore);
            this.Controls.Add(this.txtAscore);
            this.Controls.Add(this.btnBstr);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnbfoul);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnSdown);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnBcut);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnMdown);
            this.Controls.Add(this.btnMup);
            this.Controls.Add(this.btnQuarter);
            this.Controls.Add(this.btnAstr);
            this.Controls.Add(this.btnScoreReset);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btn14);
            this.Controls.Add(this.btnAfoul);
            this.Controls.Add(this.btn24down);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnsettingsave);
            this.Controls.Add(this.btnAcut);
            this.Controls.Add(this.btn24reset);
            this.Controls.Add(this.btnA1);
            this.Controls.Add(this.btn24up);
            this.Controls.Add(this.btnBuzzer);
            this.Controls.Add(this.btn24start);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BasketBallScoreBoard";
            this.Text = "BasketBallScoreBoard";
            this.TeamA.ResumeLayout(false);
            this.TeamA.PerformLayout();
            this.TeamB.ResumeLayout(false);
            this.TeamB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btn24start;
        private System.Windows.Forms.Button btn24up;
        private System.Windows.Forms.Button btnsettingsave;
        private System.Windows.Forms.Button btnMup;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBuzzer;
        private System.Windows.Forms.Button btn24reset;
        private System.Windows.Forms.Button btn24down;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btnMdown;
        private System.Windows.Forms.Button btnSdown;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnScoreReset;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnAcut;
        private System.Windows.Forms.Button btnAfoul;
        private System.Windows.Forms.Button btnAstr;
        private System.Windows.Forms.Button btnQuarter;
        private System.Windows.Forms.Button btnBcut;
        private System.Windows.Forms.Button btnbfoul;
        private System.Windows.Forms.Button btnBstr;
        private System.Windows.Forms.TextBox txtAscore;
        private System.Windows.Forms.TextBox txtBscore;
        private System.Windows.Forms.Panel TeamA;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton rbtnA3time;
        private System.Windows.Forms.RadioButton rbtnA2time;
        private System.Windows.Forms.RadioButton rbtnA1time;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox TeamB;
        private System.Windows.Forms.RadioButton rbtnB3time;
        private System.Windows.Forms.RadioButton rbtnB2time;
        private System.Windows.Forms.RadioButton rbtnB1time;
        private System.Windows.Forms.Timer SYNC;
        private System.Windows.Forms.Label GameTime;
        private System.Windows.Forms.TextBox time24;
        private System.Windows.Forms.RadioButton rbtnQ1;
        private System.Windows.Forms.RadioButton rbtnQ2;
        private System.Windows.Forms.RadioButton rbtnQ3;
        private System.Windows.Forms.RadioButton rbtnQ4;
        private System.Windows.Forms.RadioButton rbtnQ5;
        private System.Windows.Forms.Timer SYNC24;
    }
}

