using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflex_Rehab {
    public partial class levelEasy : Form {
        private Random random = new Random();
        private int score = 0;
        private int timeLeft = 10;
        private Timer gameTimer = new Timer();
        private Button targetButton = new Button();
        private Panel gamePanel = new Panel {
            Location = new Point(0, 100),
            Size = new System.Drawing.Size(1264, 885),
            //BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))))
        };
        private Panel scoreTimePanel = new Panel {
            Location = new Point(0, 0),
            Size = new System.Drawing.Size(1264, 100),
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))))
        };
        public levelEasy() {
            InitializeComponent();
            setupGame();
        }

        private void setupGame() {
            this.Text = "Reflex Rehab";
            this.Size = new Size(1280, 1024);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Ustawienia przycisku celu
            targetButton.Size = new Size(50, 50);
            targetButton.BackColor = Color.Red;
            targetButton.Click += targetButton_Click;

            // Ustawienia timera gry
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            gameTimer.Start();
            this.Controls.Add(scoreTimePanel);
            this.Controls.Add(gamePanel);

            // Etykieta wyniku
            Label scoreLabel = new Label {
                Text = $"Wynik: {score}",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold),
                ForeColor = SystemColors.Control
            };
            scoreLabel.Name = "scoreLabel";
            scoreTimePanel.Controls.Add(scoreLabel);
            // Etykieta czasu
            Label timeLabel = new Label {
                Text = $"Czas: {timeLeft}",
                Location = new Point(10, 40),
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold),
                ForeColor = SystemColors.Control
            };
            timeLabel.Name = "timeLabel";
            scoreTimePanel.Controls.Add(timeLabel);
            spawnTarget();
        }

        private void spawnTarget() {
            int x = random.Next(this.ClientSize.Width - targetButton.Width);
            int y = random.Next(this.ClientSize.Height - targetButton.Height);
            targetButton.Location = new Point(x, y);
            gamePanel.Controls.Add(targetButton);
        }

        private void targetButton_Click(object sender, EventArgs e) {
            score++;
            updateScore();
            this.Controls.Remove(targetButton); // Usuń poprzedni cel
            spawnTarget(); // Generuj nowy cel
        }

        private void updateScore() {
            var scoreLabel = scoreTimePanel.Controls["scoreLabel"] as Label;
            if (scoreLabel != null) {
                scoreLabel.Text = $"Wynik: {score}";
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e) {
            timeLeft--;
            var timeLabel = scoreTimePanel.Controls["timeLabel"] as Label;
            if (timeLabel != null) {
                timeLabel.Text = $"Czas: {timeLeft}";
            }

            if (timeLeft <= 0) {
                gameTimer.Stop();
                MessageBox.Show($"Koniec Gry! Twój wynik: {score}", "Koniec Gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void levelEasy_Load(object sender, EventArgs e){ }

        private void levelEasy_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
