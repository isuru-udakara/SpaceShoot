using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShoot
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
            labelDateTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 59);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Total Score: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 112);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Level Reached: ";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(171, 59);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(17, 20);
            labelScore.TabIndex = 2;
            labelScore.Text = "0";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(202, 112);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(17, 20);
            labelLevel.TabIndex = 3;
            labelLevel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 169);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Time Spent: ";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(185, 169);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(17, 20);
            labelTime.TabIndex = 5;
            labelTime.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(64, 314);
            button1.Name = "button1";
            button1.Size = new Size(108, 51);
            button1.TabIndex = 6;
            button1.Text = "Main";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(230, 314);
            button2.Name = "button2";
            button2.Size = new Size(113, 51);
            button2.TabIndex = 7;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Bell MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(398, 315);
            button3.Name = "button3";
            button3.Size = new Size(99, 50);
            button3.TabIndex = 8;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 225);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 9;
            label4.Text = "Played Count: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 225);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 10;
            label5.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(474, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Location = new Point(510, 188);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(0, 20);
            labelDateTime.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form3
            // 
            ClientSize = new Size(653, 422);
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
        private Label labelDateTime;
        private System.Windows.Forms.Timer timer1;
        private IContainer components;
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
    }
}
