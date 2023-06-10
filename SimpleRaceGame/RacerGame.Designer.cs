namespace SimpleRaceGame
{
    partial class RacerGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacerGame));
            this.PlayerCar = new System.Windows.Forms.PictureBox();
            this.RoadPictureBack = new System.Windows.Forms.PictureBox();
            this.RoadPictureMain = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.StartGameLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.EnemyCar1 = new System.Windows.Forms.PictureBox();
            this.EnemyCar2 = new System.Windows.Forms.PictureBox();
            this.CrashPicture = new System.Windows.Forms.PictureBox();
            this.CoinPicture = new System.Windows.Forms.PictureBox();
            this.CoinsValueLabel = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.RestartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadPictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadPictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrashPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerCar
            // 
            this.PlayerCar.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCar.Image = ((System.Drawing.Image)(resources.GetObject("PlayerCar.Image")));
            this.PlayerCar.Location = new System.Drawing.Point(448, 497);
            this.PlayerCar.Name = "PlayerCar";
            this.PlayerCar.Size = new System.Drawing.Size(80, 128);
            this.PlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCar.TabIndex = 1;
            this.PlayerCar.TabStop = false;
            // 
            // RoadPictureBack
            // 
            this.RoadPictureBack.Image = ((System.Drawing.Image)(resources.GetObject("RoadPictureBack.Image")));
            this.RoadPictureBack.Location = new System.Drawing.Point(0, -650);
            this.RoadPictureBack.Name = "RoadPictureBack";
            this.RoadPictureBack.Size = new System.Drawing.Size(840, 650);
            this.RoadPictureBack.TabIndex = 2;
            this.RoadPictureBack.TabStop = false;
            // 
            // RoadPictureMain
            // 
            this.RoadPictureMain.Image = ((System.Drawing.Image)(resources.GetObject("RoadPictureMain.Image")));
            this.RoadPictureMain.Location = new System.Drawing.Point(0, 0);
            this.RoadPictureMain.Name = "RoadPictureMain";
            this.RoadPictureMain.Size = new System.Drawing.Size(840, 650);
            this.RoadPictureMain.TabIndex = 0;
            this.RoadPictureMain.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomeLabel.Location = new System.Drawing.Point(264, 167);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(324, 78);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome to \n SimpleRaceGame";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartGameLabel
            // 
            this.StartGameLabel.AutoSize = true;
            this.StartGameLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.StartGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartGameLabel.Location = new System.Drawing.Point(323, 301);
            this.StartGameLabel.Name = "StartGameLabel";
            this.StartGameLabel.Size = new System.Drawing.Size(205, 31);
            this.StartGameLabel.TabIndex = 4;
            this.StartGameLabel.Text = "Start the game";
            this.StartGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartGameLabel.Click += new System.EventHandler(this.StartGameLabel_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitLabel.Location = new System.Drawing.Point(387, 359);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(63, 31);
            this.ExitLabel.TabIndex = 5;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // EnemyCar1
            // 
            this.EnemyCar1.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCar1.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar1.Image")));
            this.EnemyCar1.Location = new System.Drawing.Point(184, -150);
            this.EnemyCar1.Name = "EnemyCar1";
            this.EnemyCar1.Size = new System.Drawing.Size(80, 128);
            this.EnemyCar1.TabIndex = 6;
            this.EnemyCar1.TabStop = false;
            // 
            // EnemyCar2
            // 
            this.EnemyCar2.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCar2.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar2.Image")));
            this.EnemyCar2.Location = new System.Drawing.Point(567, -300);
            this.EnemyCar2.Name = "EnemyCar2";
            this.EnemyCar2.Size = new System.Drawing.Size(80, 128);
            this.EnemyCar2.TabIndex = 7;
            this.EnemyCar2.TabStop = false;
            // 
            // CrashPicture
            // 
            this.CrashPicture.BackColor = System.Drawing.Color.Transparent;
            this.CrashPicture.Image = ((System.Drawing.Image)(resources.GetObject("CrashPicture.Image")));
            this.CrashPicture.Location = new System.Drawing.Point(523, -420);
            this.CrashPicture.Name = "CrashPicture";
            this.CrashPicture.Size = new System.Drawing.Size(90, 80);
            this.CrashPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CrashPicture.TabIndex = 8;
            this.CrashPicture.TabStop = false;
            // 
            // CoinPicture
            // 
            this.CoinPicture.BackColor = System.Drawing.Color.Transparent;
            this.CoinPicture.Image = ((System.Drawing.Image)(resources.GetObject("CoinPicture.Image")));
            this.CoinPicture.Location = new System.Drawing.Point(460, -650);
            this.CoinPicture.Name = "CoinPicture";
            this.CoinPicture.Size = new System.Drawing.Size(50, 50);
            this.CoinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoinPicture.TabIndex = 9;
            this.CoinPicture.TabStop = false;
            // 
            // CoinsValueLabel
            // 
            this.CoinsValueLabel.AutoSize = true;
            this.CoinsValueLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.CoinsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoinsValueLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CoinsValueLabel.Location = new System.Drawing.Point(12, 9);
            this.CoinsValueLabel.Name = "CoinsValueLabel";
            this.CoinsValueLabel.Size = new System.Drawing.Size(0, 37);
            this.CoinsValueLabel.TabIndex = 10;
            this.CoinsValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CoinsValueLabel.Visible = false;
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.GameOverLabel.Enabled = false;
            this.GameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameOverLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GameOverLabel.Location = new System.Drawing.Point(322, 187);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(206, 39);
            this.GameOverLabel.TabIndex = 11;
            this.GameOverLabel.Text = "Game Over";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOverLabel.Visible = false;
            // 
            // RestartLabel
            // 
            this.RestartLabel.AutoSize = true;
            this.RestartLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.RestartLabel.Enabled = false;
            this.RestartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RestartLabel.Location = new System.Drawing.Point(368, 301);
            this.RestartLabel.Name = "RestartLabel";
            this.RestartLabel.Size = new System.Drawing.Size(110, 31);
            this.RestartLabel.TabIndex = 12;
            this.RestartLabel.Text = "Restart";
            this.RestartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RestartLabel.Visible = false;
            this.RestartLabel.Click += new System.EventHandler(this.RestartLabel_Click);
            // 
            // RacerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.RestartLabel);
            this.Controls.Add(this.CoinsValueLabel);
            this.Controls.Add(this.CoinPicture);
            this.Controls.Add(this.CrashPicture);
            this.Controls.Add(this.EnemyCar2);
            this.Controls.Add(this.EnemyCar1);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.StartGameLabel);
            this.Controls.Add(this.PlayerCar);
            this.Controls.Add(this.RoadPictureBack);
            this.Controls.Add(this.RoadPictureMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RacerGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleRacerGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RacerGame_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RacerGame_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadPictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadPictureMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrashPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PlayerCar;
        private System.Windows.Forms.PictureBox RoadPictureBack;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox RoadPictureMain;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label StartGameLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.PictureBox EnemyCar1;
        private System.Windows.Forms.PictureBox EnemyCar2;
        private System.Windows.Forms.PictureBox CrashPicture;
        private System.Windows.Forms.PictureBox CoinPicture;
        private System.Windows.Forms.Label CoinsValueLabel;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label RestartLabel;
    }
}

