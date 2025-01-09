using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SpaceShoot
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            labelScore = new Label();
            labelLevel = new Label();
            label3 = new Label();
            labelTime = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labelDateTime = new Label();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bruce Forever", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(77, 143);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 0;
            label1.Text = "Total Score: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bruce Forever", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(77, 196);
            label2.Name = "label2";
            label2.Size = new Size(233, 25);
            label2.TabIndex = 1;
            label2.Text = "Level Reached: ";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Bruce Forever", 12F);
            labelScore.ForeColor = Color.Black;
            labelScore.Location = new Point(358, 143);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(33, 25);
            labelScore.TabIndex = 2;
            labelScore.Text = "0";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.BackColor = Color.Transparent;
            labelLevel.Font = new Font("Bruce Forever", 12F);
            labelLevel.ForeColor = Color.Black;
            labelLevel.Location = new Point(358, 196);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(33, 25);
            labelLevel.TabIndex = 3;
            labelLevel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bruce Forever", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(77, 249);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 4;
            label3.Text = "Time Spent: ";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.Transparent;
            labelTime.Font = new Font("Bruce Forever", 12F);
            labelTime.ForeColor = Color.Black;
            labelTime.Location = new Point(358, 249);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(33, 25);
            labelTime.TabIndex = 5;
            labelTime.Text = "0";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Bruce Forever", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(77, 410);
            button1.Name = "button1";
            button1.Size = new Size(108, 51);
            button1.TabIndex = 6;
            button1.Text = "Main";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Bruce Forever", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 0, 192);
            button2.Location = new Point(243, 410);
            button2.Name = "button2";
            button2.Size = new Size(113, 51);
            button2.TabIndex = 7;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Bruce Forever", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(411, 410);
            button3.Name = "button3";
            button3.Size = new Size(127, 51);
            button3.TabIndex = 8;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bruce Forever", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(77, 305);
            label4.Name = "label4";
            label4.Size = new Size(226, 25);
            label4.TabIndex = 9;
            label4.Text = "Played Count: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bruce Forever", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(358, 305);
            label5.Name = "label5";
            label5.Size = new Size(33, 25);
            label5.TabIndex = 10;
            label5.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(589, 338);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.BackColor = Color.Transparent;
            labelDateTime.Font = new Font("Bruce Forever", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDateTime.Location = new Point(629, 54);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(59, 25);
            labelDateTime.TabIndex = 12;
            labelDateTime.Text = "0:0";
            // 
            // Form3
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1002, 535);
            ControlBox = false;
            Controls.Add(labelDateTime);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelTime);
            Controls.Add(label3);
            Controls.Add(labelLevel);
            Controls.Add(labelScore);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Dashboard";
            Load += Form3_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label labelScore;
        private Label labelLevel;
        private Label label3;
        private Label labelTime;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private IContainer components;
        private Label labelDateTime;
        private Button button3;

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            labelDateTime.Text = today.ToLongTimeString();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataFromDatabase()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\Works\\CSharp\\SpaceShoot\\SpaceShoot\\SpaceShoot\\DataDB.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(score) as TotalScore, MAX(level) as MaxLevel, SUM(DATEDIFF(SECOND, start_time, end_time)) as TotalTimeSpent, COUNT(*) as PlayedCount FROM [Table]";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    labelScore.Text = reader["TotalScore"] != DBNull.Value ? reader["TotalScore"].ToString() : "0";
                    labelLevel.Text = reader["MaxLevel"] != DBNull.Value ? reader["MaxLevel"].ToString() : "0";
                    labelTime.Text = reader["TotalTimeSpent"] != DBNull.Value
                        ? (Convert.ToInt32(reader["TotalTimeSpent"]) / 60).ToString() + " mins"
                        : "0 mins";
                    label5.Text = reader["PlayedCount"] != DBNull.Value ? reader["PlayedCount"].ToString() : "0";
                }
                reader.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\Works\\CSharp\\SpaceShoot\\SpaceShoot\\SpaceShoot\\DataDB.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM [Table]";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                labelScore.Text = "0";
                labelLevel.Text = "0";
                labelTime.Text = "0 mins";
                label5.Text = "0";

                MessageBox.Show("Your data has been cleared!", "Reset Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Station st = new Station();
            st.Show();
            this.Hide();
        }
    }
}
