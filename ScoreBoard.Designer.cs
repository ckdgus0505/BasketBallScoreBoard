namespace BasketBallScoreBoard
{
    partial class ScoreBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreBoard));
            this.txtAscore = new System.Windows.Forms.TextBox();
            this.txtBscore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAscore
            // 
            this.txtAscore.BackColor = System.Drawing.Color.Black;
            this.txtAscore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAscore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAscore.ForeColor = System.Drawing.Color.Red;
            this.txtAscore.Location = new System.Drawing.Point(42, 247);
            this.txtAscore.MaxLength = 3;
            this.txtAscore.Name = "txtAscore";
            this.txtAscore.ReadOnly = true;
            this.txtAscore.Size = new System.Drawing.Size(245, 167);
            this.txtAscore.TabIndex = 0;
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
            this.txtBscore.Location = new System.Drawing.Point(515, 247);
            this.txtBscore.MaxLength = 3;
            this.txtBscore.Name = "txtBscore";
            this.txtBscore.ReadOnly = true;
            this.txtBscore.Size = new System.Drawing.Size(245, 167);
            this.txtBscore.TabIndex = 0;
            this.txtBscore.Text = "0";
            this.txtBscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasketBallScoreBoard.Properties.Resources._interface;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBscore);
            this.Controls.Add(this.txtAscore);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScoreBoard";
            this.ShowIcon = false;
            this.Text = "scoreBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAscore;
        private System.Windows.Forms.TextBox txtBscore;
    }
}