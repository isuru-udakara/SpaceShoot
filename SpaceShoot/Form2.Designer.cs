namespace SpaceShoot
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            buttonPlay = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonPlay
            // 
            buttonPlay.FlatStyle = FlatStyle.System;
            buttonPlay.Font = new Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPlay.Location = new Point(296, 152);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(353, 78);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "Play Game";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(296, 282);
            button2.Name = "button2";
            button2.Size = new Size(353, 76);
            button2.TabIndex = 1;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(267, 52);
            label1.Name = "label1";
            label1.Size = new Size(406, 54);
            label1.TabIndex = 2;
            label1.Text = "Shoot and Destroy";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(709, 222);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(236, 160);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // buttonExit
            // 
            buttonExit.FlatStyle = FlatStyle.System;
            buttonExit.Font = new Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(296, 410);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(353, 76);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit Game";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(957, 540);
            ControlBox = false;
            Controls.Add(buttonExit);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(buttonPlay);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Space Shooter";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPlay;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonExit;
    }
}