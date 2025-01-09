namespace SpaceShoot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MoveBgTimer = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            LeftMoveTimer = new System.Windows.Forms.Timer(components);
            RightMoveTimer = new System.Windows.Forms.Timer(components);
            UpMoveTimer = new System.Windows.Forms.Timer(components);
            DownMoveTimer = new System.Windows.Forms.Timer(components);
            MoveMunitionTimer = new System.Windows.Forms.Timer(components);
            MoveEnemiesTimer = new System.Windows.Forms.Timer(components);
            EnemiesMunitionTimer = new System.Windows.Forms.Timer(components);
            ReplayBtn = new Button();
            ExitBtn = new Button();
            label = new Label();
            label1 = new Label();
            scoreLbl = new Label();
            label3 = new Label();
            levelLbl = new Label();
            pictureBoxButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButton).BeginInit();
            SuspendLayout();
            // 
            // MoveBgTimer
            // 
            MoveBgTimer.Enabled = true;
            MoveBgTimer.Interval = 10;
            MoveBgTimer.Tick += MoveBgTimer_Tick;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(458, 698);
            player.Name = "player";
            player.Size = new Size(108, 90);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // LeftMoveTimer
            // 
            LeftMoveTimer.Interval = 5;
            LeftMoveTimer.Tick += LeftMoveTimer_Tick;
            // 
            // RightMoveTimer
            // 
            RightMoveTimer.Interval = 5;
            RightMoveTimer.Tick += RightMoveTimer_Tick;
            // 
            // UpMoveTimer
            // 
            UpMoveTimer.Interval = 5;
            UpMoveTimer.Tick += UpMoveTimer_Tick;
            // 
            // DownMoveTimer
            // 
            DownMoveTimer.Interval = 5;
            DownMoveTimer.Tick += DownMoveTimer_Tick;
            // 
            // MoveMunitionTimer
            // 
            MoveMunitionTimer.Enabled = true;
            MoveMunitionTimer.Interval = 20;
            MoveMunitionTimer.Tick += MoveMunitionTimer_Tick;
            // 
            // MoveEnemiesTimer
            // 
            MoveEnemiesTimer.Enabled = true;
            MoveEnemiesTimer.Tick += MoveEnemiesTimer_Tick;
            // 
            // EnemiesMunitionTimer
            // 
            EnemiesMunitionTimer.Enabled = true;
            EnemiesMunitionTimer.Interval = 20;
            EnemiesMunitionTimer.Tick += EnemiesMunitionTimer_Tick;
            // 
            // ReplayBtn
            // 
            ReplayBtn.Location = new Point(291, 436);
            ReplayBtn.Name = "ReplayBtn";
            ReplayBtn.Size = new Size(460, 84);
            ReplayBtn.TabIndex = 1;
            ReplayBtn.Text = "Replay";
            ReplayBtn.UseVisualStyleBackColor = true;
            ReplayBtn.Visible = false;
            ReplayBtn.Click += ReplayBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(291, 570);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(460, 83);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Visible = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.Red;
            label.Location = new Point(304, 270);
            label.Name = "label";
            label.Size = new Size(436, 94);
            label.TabIndex = 3;
            label.Text = "GAME OVER";
            label.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(120, 33);
            label1.TabIndex = 4;
            label1.Text = "SCORE: ";
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.BackColor = Color.Transparent;
            scoreLbl.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLbl.ForeColor = Color.Yellow;
            scoreLbl.Location = new Point(117, 27);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(45, 33);
            scoreLbl.TabIndex = 5;
            scoreLbl.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(895, 29);
            label3.Name = "label3";
            label3.Size = new Size(120, 33);
            label3.TabIndex = 6;
            label3.Text = "LEVEL: ";
            // 
            // levelLbl
            // 
            levelLbl.AutoSize = true;
            levelLbl.BackColor = Color.Transparent;
            levelLbl.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            levelLbl.ForeColor = Color.Yellow;
            levelLbl.Location = new Point(998, 29);
            levelLbl.Name = "levelLbl";
            levelLbl.Size = new Size(45, 33);
            levelLbl.TabIndex = 7;
            levelLbl.Text = "01";
            // 
            // pictureBoxButton
            // 
            pictureBoxButton.BackColor = Color.LightGray;
            pictureBoxButton.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxButton.Cursor = Cursors.Hand;
            pictureBoxButton.Image = (Image)resources.GetObject("pictureBoxButton.Image");
            pictureBoxButton.Location = new Point(402, 292);
            pictureBoxButton.Name = "pictureBoxButton";
            pictureBoxButton.Size = new Size(314, 240);
            pictureBoxButton.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxButton.TabIndex = 8;
            pictureBoxButton.TabStop = false;
            pictureBoxButton.Visible = false;
            pictureBoxButton.Click += pictureBoxButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1096, 853);
            Controls.Add(pictureBoxButton);
            Controls.Add(levelLbl);
            Controls.Add(label3);
            Controls.Add(scoreLbl);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(ExitBtn);
            Controls.Add(ReplayBtn);
            Controls.Add(player);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1100, 900);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Space Shooter";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private PictureBox player;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer MoveMunitionTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
        private Button ReplayBtn;
        private Button ExitBtn;
        private Label label;
        private Label label1;
        private Label scoreLbl;
        private Label label3;
        private Label levelLbl;
        private PictureBox pictureBoxButton;
    }
}
