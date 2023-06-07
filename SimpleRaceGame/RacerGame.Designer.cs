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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacerGame));
            this.PlayerCar = new System.Windows.Forms.PictureBox();
            this.RoadPictureBack = new System.Windows.Forms.PictureBox();
            this.RoadPictureMain = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.StartGameLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadPictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadPictureMain)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerCar
            // 
            this.PlayerCar.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCar.Image = ((System.Drawing.Image)(resources.GetObject("PlayerCar.Image")));
            this.PlayerCar.Location = new System.Drawing.Point(426, 470);
            this.PlayerCar.Name = "PlayerCar";
            this.PlayerCar.Size = new System.Drawing.Size(120, 128);
            this.PlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCar.TabIndex = 1;
            this.PlayerCar.TabStop = false;
            // 
            // RoadPictureBack
            // 
            this.RoadPictureBack.Image = ((System.Drawing.Image)(resources.GetObject("RoadPictureBack.Image")));
            this.RoadPictureBack.Location = new System.Drawing.Point(0, -630);
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
            this.WelcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomeLabel.Location = new System.Drawing.Point(266, 167);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(324, 78);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome to \n SimpleRaceGame";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartGameLabel
            // 
            this.StartGameLabel.AutoSize = true;
            this.StartGameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.ExitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            // RacerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.StartGameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.PlayerCar);
            this.Controls.Add(this.RoadPictureMain);
            this.Controls.Add(this.RoadPictureBack);
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
    }
}

