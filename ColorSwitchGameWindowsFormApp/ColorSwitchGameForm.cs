using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ColorSwitchGameWindowsFormApp
{
    public partial class ColorSwitchGameForm : Form
    {
        private const int OBSTACLE_SPEED = 2;
        bool running = false;
        int playerColorIndex = 0;
        int currentScore = -1;
        Random rng = new Random();
        Color[] colors = { Color.White, Color.Red, Color.Blue, Color.Green, Color.Cyan, Color.Magenta, Color.Yellow };
        string filePath;

        public ColorSwitchGameForm()
        {
            InitializeComponent();
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            appDataPath = System.IO.Path.Combine(appDataPath, "ColorSwitchGame");
            System.IO.Directory.CreateDirectory(appDataPath);
            filePath = System.IO.Path.Combine(appDataPath, "HighScores.txt");
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.File.Create(filePath).Dispose();
            }
            MessageBox.Show("Instructions: use the arrow keys to match the color of the incoming bars");
            updateScores();
        }

        private void updateScores()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                txBxScores.Text = "";
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] parts = line.Split(',');
                    txBxScores.AppendText($"{parts[0]} {parts[1],6}\r\n");
                    line = reader.ReadLine();
                }
            }
        }

        public static string GetInitials(string title, string text)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 140,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 10, Top = 10, Text = text, Width = 250 };
            TextBox textBox = new TextBox() { Left = 10, Top = 30, Width = 250 };
            Button okButton = new Button()
            {
                Text = "OK",
                Left = 10,
                Width = 50,
                Top = 60,
                DialogResult = DialogResult.OK
            };
            okButton.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(okButton);
            prompt.Controls.Add(textLabel);
            prompt.MaximizeBox = false;
            prompt.MinimizeBox = false;
            prompt.AcceptButton = okButton;
            prompt.ShowDialog();

            return textBox.Text.Trim();
        }

        private void resetGame()
        {
            currentScore = 0;
            lblScore.Text = "Your score: " + currentScore.ToString();
            playerColorIndex = 0;
            pcBxPlayer.BackColor = colors[0];
            pcBxBar1.Top = -10;
            pcBxBar1.BackColor = colors[6];
            pcBxBar2.Top = -110;
            pcBxBar2.BackColor = colors[4];
            pcBxPlayer.Focus();
            tmr.Start();
        }

        private void ColorSwitchGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Right) && (running))
            {
                if (playerColorIndex < colors.Length - 1)
                {
                    playerColorIndex++;
                }
                else
                {
                    playerColorIndex = 0;
                }
                pcBxPlayer.BackColor = colors[playerColorIndex];
            }
            if ((e.KeyCode == Keys.Left) && (running))
            {
                if (playerColorIndex > 0)
                {
                    playerColorIndex--;
                }
                else
                {
                    playerColorIndex = colors.Length - 1;
                }
                pcBxPlayer.BackColor = colors[playerColorIndex];
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            resetGame();
            running = true;
            SendKeys.SendWait("{Left}");
            SendKeys.SendWait("{Left}");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                foreach (Control c in this.Controls)
                {
                    if (c.Tag != null)
                    {
                        c.Top += OBSTACLE_SPEED;
                        // check if obstacles are off screen
                        if (c.Top > ActiveForm.Size.Height)
                        {
                            c.Top = rng.Next(-110, -9);
                            c.BackColor = colors[rng.Next(0, colors.Length)];
                            currentScore++;
                            lblScore.Text = "Your score: " + currentScore.ToString();
                        }
                        if (((c.Top + c.Height) > pcBxPlayer.Top) && (c.Top + c.Height < (pcBxPlayer.Top + pcBxPlayer.Height)) && (pcBxPlayer.BackColor != c.BackColor))
                        {
                            tmr.Stop();
                            running = false;
                            checkScore();
                        }
                    }
                }
            }
        }

        private void checkScore()
        {
            try
            {
                string[] scores = new string[10];
                int lineNum = 0;
                bool scoreUpdated = false;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        string currentInitials = GetInitials("New High Score!", "Enter your initials:");
                        scores[0] = currentInitials + "," + currentScore;
                    }
                    else
                    {
                        while ((lineNum < 10) && (line != null))
                        {
                            string[] parts = line.Split(',');
                            int fileScore = int.Parse(parts[1]);

                            if ((currentScore > fileScore) && (!scoreUpdated))
                            {
                                string currentInitials = GetInitials("New High Score!", "Enter your initials:");
                                scores[lineNum] = currentInitials + "," + currentScore;
                                lineNum++;
                                scoreUpdated = true;
                            }
                            if (lineNum == 10)
                            {
                                break;
                            }
                            scores[lineNum] = line;
                            line = reader.ReadLine();
                            lineNum++;
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string score in scores)
                    {
                        if (score != null)
                        {
                            writer.WriteLine(score);
                        }
                    }
                }
                updateScores();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found, here's a bunch of stuff: " + e.Message);
            }
            catch (IOException e)
            {
                Console.Out.WriteLine("Exception: " + e.Message);
            }
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            if (running)
            {
                pcBxPlayer.BackColor = colors[0];
            }
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            if (running)
            {
                pcBxPlayer.BackColor = colors[6];
            }
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            if (running)
            {
                pcBxPlayer.BackColor = colors[5];
            }
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            if (running)
            {
                pcBxPlayer.BackColor = colors[4];
            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (running)
            {
                pcBxPlayer.BackColor = colors[3];
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (running)
            {
                pcBxPlayer.BackColor = colors[2];
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (running)
            {
                pcBxPlayer.BackColor = colors[1];
            }
        }
    }
}
