
namespace ColorSwitchGameWindowsFormApp
{
    partial class ColorSwitchGameForm
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
            this.components = new System.ComponentModel.Container();
            this.pcBxBackground = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.txBxScores = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pcBxPlayer = new System.Windows.Forms.PictureBox();
            this.pcBxBar1 = new System.Windows.Forms.PictureBox();
            this.pcBxBar2 = new System.Windows.Forms.PictureBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCyan = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBxBackground
            // 
            this.pcBxBackground.BackColor = System.Drawing.Color.Black;
            this.pcBxBackground.Location = new System.Drawing.Point(0, 0);
            this.pcBxBackground.Name = "pcBxBackground";
            this.pcBxBackground.Size = new System.Drawing.Size(230, 370);
            this.pcBxBackground.TabIndex = 0;
            this.pcBxBackground.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(235, 263);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 37);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start / Restart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(236, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(72, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Your Score: 0";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(235, 49);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(80, 13);
            this.lblTop.TabIndex = 3;
            this.lblTop.Text = "Top 10 Scores:";
            // 
            // txBxScores
            // 
            this.txBxScores.Location = new System.Drawing.Point(236, 66);
            this.txBxScores.Multiline = true;
            this.txBxScores.Name = "txBxScores";
            this.txBxScores.ReadOnly = true;
            this.txBxScores.Size = new System.Drawing.Size(100, 191);
            this.txBxScores.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(235, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pcBxPlayer
            // 
            this.pcBxPlayer.BackColor = System.Drawing.Color.White;
            this.pcBxPlayer.Location = new System.Drawing.Point(50, 290);
            this.pcBxPlayer.Name = "pcBxPlayer";
            this.pcBxPlayer.Size = new System.Drawing.Size(130, 25);
            this.pcBxPlayer.TabIndex = 6;
            this.pcBxPlayer.TabStop = false;
            // 
            // pcBxBar1
            // 
            this.pcBxBar1.BackColor = System.Drawing.Color.Cyan;
            this.pcBxBar1.Location = new System.Drawing.Point(0, 50);
            this.pcBxBar1.Name = "pcBxBar1";
            this.pcBxBar1.Size = new System.Drawing.Size(230, 25);
            this.pcBxBar1.TabIndex = 7;
            this.pcBxBar1.TabStop = false;
            this.pcBxBar1.Tag = "Obstacle";
            // 
            // pcBxBar2
            // 
            this.pcBxBar2.BackColor = System.Drawing.Color.Yellow;
            this.pcBxBar2.Location = new System.Drawing.Point(0, 150);
            this.pcBxBar2.Name = "pcBxBar2";
            this.pcBxBar2.Size = new System.Drawing.Size(230, 25);
            this.pcBxBar2.TabIndex = 8;
            this.pcBxBar2.TabStop = false;
            this.pcBxBar2.Tag = "Obstacle";
            // 
            // tmr
            // 
            this.tmr.Interval = 10;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(30, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 73);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // btnCyan
            // 
            this.btnCyan.BackColor = System.Drawing.Color.Aqua;
            this.btnCyan.Location = new System.Drawing.Point(342, 153);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(85, 23);
            this.btnCyan.TabIndex = 10;
            this.btnCyan.UseVisualStyleBackColor = false;
            this.btnCyan.Click += new System.EventHandler(this.btnCyan_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(342, 95);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(85, 23);
            this.btnYellow.TabIndex = 11;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnPink
            // 
            this.btnPink.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPink.Location = new System.Drawing.Point(342, 124);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(85, 23);
            this.btnPink.TabIndex = 12;
            this.btnPink.UseVisualStyleBackColor = false;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(343, 240);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(85, 23);
            this.btnRed.TabIndex = 13;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(342, 211);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(85, 23);
            this.btnBlue.TabIndex = 14;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Lime;
            this.btnGreen.Location = new System.Drawing.Point(343, 182);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(85, 23);
            this.btnGreen.TabIndex = 15;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(342, 66);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(85, 23);
            this.btnWhite.TabIndex = 16;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // ColorSwitchGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 366);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnPink);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnCyan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcBxPlayer);
            this.Controls.Add(this.pcBxBar2);
            this.Controls.Add(this.pcBxBar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txBxScores);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pcBxBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ColorSwitchGameForm";
            this.Text = "Color Switch Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorSwitchGameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcBxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBxBackground;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.TextBox txBxScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pcBxPlayer;
        private System.Windows.Forms.PictureBox pcBxBar1;
        private System.Windows.Forms.PictureBox pcBxBar2;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCyan;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnPink;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnWhite;
    }
}

