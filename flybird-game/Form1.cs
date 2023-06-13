using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class FormBig : Form
    {
        // Variables
        private bool is_running = false;
        private int speed = 10;
        const int gravity = 10;
        private bool display_out = false;
        private int score = 0;

        // Game load
        public FormBig()
        {
            InitializeComponent();
            is_running = true;
            display_out = false;
            ExitPanel.Hide();
            Player.Location = new Point(200, 200);
            TimerTick.Interval = 20;
            score = 0;
            label2.Location = new Point(37, 24);
            ScorePosition.Location = new Point(123, 24);
        }

        // Close the game
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Keep the game moving
        private void TimerTick_Tick(object sender, EventArgs e)
        {
            // Check if the game is running
            if (is_running == false)
                TimerTick.Enabled = false;

            // Create movement
            moveBushes();
            playerGravity();
            if (display_out == true) display_end();
            movePillars();
            ScorePosition.Text = (score / 2).ToString();

            // Increase dificulty every 10 points
            if ((score / 2) % 3 == 0 && score != 0)
                speed += 1;
        }

        // Move the bushes to the left and reset them if they leave the game space
        private void moveBushes()
        {
            int bush_speed = 20;

            // Move object 1
            if (object_bush_1.Location.X < 0)
            {
                object_bush_1.Location = new Point(1200, object_bush_1.Location.Y);
            }
            object_bush_1.Location = new Point(object_bush_1.Location.X - bush_speed, object_bush_1.Location.Y);

            // Move object 2
            if (object_bush_2.Location.X < 0)
            {
                object_bush_2.Location = new Point(1200, object_bush_2.Location.Y);
            }
            object_bush_2.Location = new Point(object_bush_2.Location.X - bush_speed, object_bush_2.Location.Y);

            // Move object 3
            if (object_bush_3.Location.X < 0)
            {
                object_bush_3.Location = new Point(1200, object_bush_3.Location.Y);
            }
            object_bush_3.Location = new Point(object_bush_3.Location.X - bush_speed, object_bush_3.Location.Y);
        }

        // Move the player down
        private void playerGravity()
        {
            Player.Top += gravity;

            if ((int)Player.Location.Y > Ground.Bottom + 20 || Player.Location.Y > 700)
            {
                is_running = false;
                display_out = true;
            }
        }

        // Display game over
        private void display_end()
        {
            if (display_out == true)
            {
                ExitPanel.Location = new Point(225, 42);
                hidePillars();
                ExitPanel.Show();
                ExitPanel.Focus();
                FinalScore.Text = (score / 2).ToString();
            }
        }

        // Hide all pillars
        void hidePillars(bool hide = true)
        {
            if (hide)
            {
                Pillar1A.Hide();
                Pillar1B.Hide();
                PILLAR2A.Hide();
                PILLAR2B.Hide();
                PILLAR3A.Hide();
                PILLAR3B.Hide();
                PILLAR4A.Hide();
                PILLAR4B.Hide();
                PILLAR5A.Hide();
                PILLAR5B.Hide();
                PILLAR6A.Hide();
                PILLAR6B.Hide();
            }
            else
            {
                Pillar1A.Show();
                Pillar1B.Show();
                PILLAR2A.Show();
                PILLAR2B.Show();
                PILLAR3A.Show();
                PILLAR3B.Show();
                PILLAR4A.Show();
                PILLAR4B.Show();
                PILLAR5A.Show();
                PILLAR5B.Show();
                PILLAR6A.Show();
                PILLAR6B.Show();
            }
        }

        // Move pillars
        void movePillars()
        {
            moveSinglePillar(Pillar1A, Pillar1B, true);
            moveSinglePillar(PILLAR2A, PILLAR2B, true);
            moveSinglePillar(PILLAR3A, PILLAR3B);
            moveSinglePillar(PILLAR4A, PILLAR4B);
            moveSinglePillar(PILLAR5A, PILLAR5B, true);
            moveSinglePillar(PILLAR6A, PILLAR6B);
        }

        // Move individual pillar
        void moveSinglePillar(PictureBox body, PictureBox top, bool up = false)
        {
            Random randnumber = new Random();
            body.Left -= speed;
            top.Left -= speed;

            if (body.Left < 0)
            {
                body.Left = 1000;
                top.Location = body.Location;
                top.Left -= 20;

                body.Height = randnumber.Next(0, 220);

                if (up)
                    top.Location = new Point(top.Location.X, body.Height - 10);

                if (!up)
                {
                    // Move down
                    body.Location = new Point(body.Location.X, 650 - body.Height);
                    top.Location = new Point(top.Location.X, 650 - top.Height - body.Height);
                }

                score++;
            }

            if (checkPlayerCollision(body, top) == true)
            {
                is_running = false;
                display_out = true;
            }
        }

        // User jump
        private void FormBig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Space)
            {
                Player.Top -= 60;
            }
        }

        // Check if the player collides with an enemy
        bool checkPlayerCollision(PictureBox body, PictureBox top)
        {
            if (Player.Bounds.IntersectsWith(body.Bounds) || Player.Bounds.IntersectsWith(top.Bounds))
                return true;
            else
                return false;
        }

        // Restart the game
        private void Restart_Click(object sender, EventArgs e)
        {
            FinalScore.Text = 0.ToString();
            is_running = true;
            display_out = false;
            ExitPanel.Hide();
            score = 0;
            Player.Location = new Point(200, 200);
            hidePillars(false);
            TimerTick.Enabled = true;
            pillarsResetPositions();
            speed = 10;
        }

        // Reset the positions of the pillars
        private void pillarsResetPositions()
        {
            Pillar1A.Location = new Point(Pillar1A.Location.X + 300, Pillar1A.Location.Y);
            Pillar1B.Location = new Point(Pillar1B.Location.X + 300, Pillar1B.Location.Y);
            PILLAR2A.Location = new Point(PILLAR2A.Location.X + 300, PILLAR2A.Location.Y);
            PILLAR2B.Location = new Point(PILLAR2B.Location.X + 300, PILLAR2B.Location.Y);
            PILLAR3A.Location = new Point(PILLAR3A.Location.X + 450, PILLAR3A.Location.Y);
            PILLAR3B.Location = new Point(PILLAR3B.Location.X + 450, PILLAR3B.Location.Y);
            PILLAR4A.Location = new Point(PILLAR4A.Location.X + 450, PILLAR4A.Location.Y);
            PILLAR4B.Location = new Point(PILLAR4B.Location.X + 450, PILLAR4B.Location.Y);
            PILLAR5A.Location = new Point(PILLAR5A.Location.X + 600, PILLAR5A.Location.Y);
            PILLAR5B.Location = new Point(PILLAR5B.Location.X + 600, PILLAR5B.Location.Y);
            PILLAR6A.Location = new Point(PILLAR6A.Location.X + 600, PILLAR6A.Location.Y);
            PILLAR6B.Location = new Point(PILLAR6B.Location.X + 600, PILLAR6B.Location.Y);
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string url = "https://fatihonder.org.tr"; // Açmak istediğiniz web sitesinin URL'sini buraya yazın
            System.Diagnostics.Process.Start(url);
        }
    }
}
