using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflex_Rehab
{
    public partial class levelEasy : Form
    {
        private Random random = new Random();
        private int score = 0;
        private int timeLeft = 30;
        private Timer gameTimer = new Timer();
        private Button targetButton = new Button();
        public levelEasy()
        {
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

            // Etykieta wyniku
            Label scoreLabel = new Label {
                Text = $"Wynik: {score}",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            scoreLabel.Name = "scoreLabel";
            this.Controls.Add(scoreLabel);

            // Etykieta czasu
            Label timeLabel = new Label {
                Text = $"Czas: {timeLeft}",
                Location = new Point(10, 40),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            timeLabel.Name = "timeLabel";
            this.Controls.Add(timeLabel);

            spawnTarget();
        }

        private void spawnTarget() {
            int x = random.Next(this.ClientSize.Width - targetButton.Width);
            int y = random.Next(this.ClientSize.Height - targetButton.Height);
            targetButton.Location = new Point(x, y);
            this.Controls.Add(targetButton);
        }

        private void targetButton_Click(object sender, EventArgs e) {
            score++;
            updateScore();
            this.Controls.Remove(targetButton); // Usuń poprzedni cel
            spawnTarget(); // Generuj nowy cel
        }

        private void updateScore() {
            var scoreLabel = this.Controls["scoreLabel"] as Label;
            if (scoreLabel != null) {
                scoreLabel.Text = $"Wynik: {score}";
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e) {
            timeLeft--;
            var timeLabel = this.Controls["timeLabel"] as Label;
            if (timeLabel != null) {
                timeLabel.Text = $"Czas: {timeLeft}";
            }

            if (timeLeft <= 0) {
                gameTimer.Stop();
                MessageBox.Show($"Game Over! Your score: {score}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void levelEasy_Load(object sender, EventArgs e)
        {

        }

        private void levelEasy_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
