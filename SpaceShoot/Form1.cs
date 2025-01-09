using global::System;
using global::System.Collections.Generic;
using global::System.Drawing;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;
using global::System.Windows.Forms;
using global::WMPLib;
using Microsoft.Data.SqlClient;

namespace SpaceShoot
{
    public partial class Form1 : Form
    {
        PictureBox[] stars;
        int backgroundSpeed;
        int playerSpeed = 0;
        Random rnd;

        PictureBox[] munitions;
        int munitionSpeed;

        PictureBox[] enemies;
        int enemySpeed;

        PictureBox[] enemiesMunition;
        int enemiesMunitionSpeed;

        int score;
        int level;
        int difficulty;
        bool pause = false;
        bool gameIsOver;

        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
        WindowsMediaPlayer pexplotion;
        WindowsMediaPlayer enexplotion;

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\Works\\CSharp\\SpaceShoot\\SpaceShoot\\SpaceShoot\\DataDB.mdf;Integrated Security=True";
        private int sessionId;

        public Form1()
        {
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            this.Load += new EventHandler(Form1_Load);
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundSpeed = 4;
            playerSpeed = 4;
            stars = new PictureBox[20];
            rnd = new Random();

            //pause = false;
            gameIsOver = false;
            score = 0;
            level = 1;
            difficulty = 9;

            StartTimers();

            StartGameSession();

            munitionSpeed = 25;
            munitions = new PictureBox[3];

            enemySpeed = 4;
            enemies = new PictureBox[10];

            enemiesMunitionSpeed = 4;
            enemiesMunition = new PictureBox[10];


            Image enemy1 = Image.FromFile(@"C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\images\e1.png");
            Image enemy2 = Image.FromFile(@"C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\images\e2.png");
            Image enemy3 = Image.FromFile(@"C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\images\e3.png");
            Image boss1 = Image.FromFile(@"C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\images\b1.png");
            Image boss2 = Image.FromFile(@"C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\images\b2.png");

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(80, 80);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 100, -50);
            }

            enemies[0].Image = boss1;
            enemies[1].Image = enemy2;
            enemies[2].Image = enemy3;
            enemies[3].Image = enemy3;
            enemies[4].Image = enemy1;
            enemies[5].Image = enemy3;
            enemies[6].Image = enemy2;
            enemies[7].Image = enemy1;
            enemies[8].Image = enemy2;
            enemies[9].Image = boss2;

            // player munition edition here
            Image munition = Image.FromFile(@"C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\images\munition.png");

            for (int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(15, 15);
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }

            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            pexplotion = new WindowsMediaPlayer();
            enexplotion = new WindowsMediaPlayer();

            gameMedia.URL = @"C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\audios\background.mp3";
            shootgMedia.URL = @"C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\audios\shooting.mp3";
            pexplotion.URL = @"C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\audios\player-explotion.mp3";
            enexplotion.URL = @"C:\Users\User\Desktop\Works\CSharp\SpaceShoot\SpaceShoot\SpaceShoot\audios\enemy-explotion.mp3";

            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 7;
            shootgMedia.settings.volume = 8;
            pexplotion.settings.volume = 9;
            enexplotion.settings.volume = 11;

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                // set x, y for star
                stars[i].Location = new Point(rnd.Next(20, 900), rnd.Next(-10, 750));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }

            for (int i = 0; i < enemiesMunition.Length; i++)
            {
                enemiesMunition[i] = new PictureBox();
                enemiesMunition[i].Size = new Size(8, 10);
                enemiesMunition[i].Visible = false;
                enemiesMunition[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                enemiesMunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesMunition[i]);
            }

            gameMedia.controls.play();

        }

        private void MoveBgTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundSpeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundSpeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Right < 1060)
            {
                player.Left += playerSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Top > 10)
            {
                player.Top -= playerSpeed;
            }
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if (player.Top < 840)
            {
                player.Top += playerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    RightMoveTimer.Start();
                }

                if (e.KeyCode == Keys.Left)
                {
                    LeftMoveTimer.Start();
                }

                if (e.KeyCode == Keys.Down)
                {
                    DownMoveTimer.Start();
                }

                if (e.KeyCode == Keys.Up)
                {
                    UpMoveTimer.Start();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {
                        StartTimers();
                        label.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                        ResumeGame();
                    }
                    else
                    {
                        label.Location = new Point(this.Width / 2 - 120, 150);
                        label.Text = "PAUSED";
                        label.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        PauseGame();
                        pause = true;
                    }
                }
            }
        }

        private void PauseGame()
        {
            // Stop all game timers or game loops
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();
            gameMedia.controls.pause();

            // Show the paused label and stop PictureBox button
            label.Location = new Point(this.Width / 2 - 120, 150);
            label.Text = "PAUSED";
            label.Visible = true;
            pictureBoxButton.Visible = true; // Show the PictureBox button when pausing

            pause = true;
        }

        private void ResumeGame()
        {
            // Start all game timers or game loops
            RightMoveTimer.Start();
            LeftMoveTimer.Start();
            DownMoveTimer.Start();
            UpMoveTimer.Start();
            gameMedia.controls.play();

            // Hide the paused label and stop PictureBox button
            label.Visible = false;
            pictureBoxButton.Visible = false; // Hide the PictureBox button when resuming

            pause = false;
        }


        private void MoveMunitionTimer_Tick(object sender, EventArgs e)
        {
            shootgMedia.controls.play();
            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= munitionSpeed;
                    Collision();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(player.Location.X + 50, player.Location.Y - i * 30);
                }
            }
        }

        private void Collision()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds)
                    || munitions[1].Bounds.IntersectsWith(enemies[i].Bounds)
                    || munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    enexplotion.controls.play();

                    score += 1;
                    scoreLbl.Text = (score < 10) ? "0" + score.ToString() : score.ToString();

                    if (score % 30 == 0)
                    {
                        level += 1;
                        levelLbl.Text = (level < 10) ? "0" + level.ToString() : level.ToString();

                        if (enemySpeed <= 10 && enemiesMunitionSpeed <= 10 && difficulty >= 0)
                        {
                            difficulty--;
                            enemySpeed++;
                            enemiesMunitionSpeed++;
                        }
                        if (level == 10)
                        {
                            GameOver("NICE DONE");
                        }
                    }

                    enemies[i].Location = new Point((i + 1) * 90, -100);

                }
                if (player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    pexplotion.controls.play();
                    player.Visible = false;
                    GameOver("GAME OVER");
                }
            }
        }

        private void GameOver(string str)
        {
            label.Text = str;
            label.Location = new Point(293, 270);
            label.Visible = true;
            label.BackColor = Color.Transparent;
            ReplayBtn.Visible = true;
            ExitBtn.Visible = true;

            gameMedia.controls.stop();
            StopTimers();
            EndGameSession(score, level);
        }

        private void StopTimers()
        {
            MoveBgTimer.Stop();
            MoveEnemiesTimer.Stop();
            MoveMunitionTimer.Stop();
            EnemiesMunitionTimer.Stop();
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();
        }

        private void StartTimers()
        {
            MoveBgTimer.Start();
            MoveEnemiesTimer.Start();
            MoveMunitionTimer.Start();
            EnemiesMunitionTimer.Start();
            RightMoveTimer.Start();
            LeftMoveTimer.Start();
            DownMoveTimer.Start();
            UpMoveTimer.Start();
        }

        private void MoveEnemiesTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemySpeed);
        }

        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;
                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 90, -200);
                }
            }
        }

        private void EnemiesMunitionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < (enemiesMunition.Length - difficulty); i++)
            {
                if (enemiesMunition[i].Top < this.Height)
                {
                    enemiesMunition[i].Visible = true;
                    enemiesMunition[i].Top += enemiesMunitionSpeed;
                    CollisionWithEnemiesMunition();
                }
                else
                {
                    enemiesMunition[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemiesMunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }

        // Player is desctroyed by enemy munitions
        // Game is over. 
        private void CollisionWithEnemiesMunition()
        {
            for (int i = 0; i < enemiesMunition.Length; i++)
            {
                if (enemiesMunition[i].Bounds.IntersectsWith(player.Bounds))
                {
                    enemiesMunition[i].Visible = false;
                    pexplotion.controls.play();
                    player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        private void ReplayBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show();
            this.Hide();
        }

        private void ResetGame()
        {
            // Reset game state variables
            pause = false;
            gameIsOver = false;
            label.Visible = false;

            // Start the timers if needed
            StartTimers();
        }

        private void pictureBoxButton_Click(object sender, EventArgs e)
        {
            if (gameIsOver || pause) 
            { 
                EndGameSession(score, level); 
                Station st = new Station();
                st.Show(); 
                this.Close(); 
            }
        }


        private void StartGameSession()
        {
            DateTime startTime = DateTime.Now;
            DateTime date = DateTime.Now.Date;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [Table] (start_time, date) OUTPUT INSERTED.session VALUES (@StartTime, @Date)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartTime", startTime);
                command.Parameters.AddWithValue("@Date", date);

                connection.Open();
                sessionId = (int)command.ExecuteScalar();
            }
        }

        private void EndGameSession(int score, int level)
        {
            DateTime endTime = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE [Table] SET end_time = @EndTime, score = @Score, level = @Level WHERE session = @SessionID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EndTime", endTime);
                command.Parameters.AddWithValue("@Score", score);
                command.Parameters.AddWithValue("@Level", level);
                command.Parameters.AddWithValue("@SessionID", sessionId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


    }
}
