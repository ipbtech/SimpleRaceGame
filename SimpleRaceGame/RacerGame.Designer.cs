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
            this.RoadPictureMain = new System.Windows.Forms.PictureBox();
            this.PlayerCar = new System.Windows.Forms.PictureBox();
            this.RoadPictureBack = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RoadPictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadPictureBack)).BeginInit();
            this.SuspendLayout();
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
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RacerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 650);
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
            ((System.ComponentModel.ISupportInitialize)(this.RoadPictureMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadPictureBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RoadPictureMain;
        private System.Windows.Forms.PictureBox PlayerCar;
        private System.Windows.Forms.PictureBox RoadPictureBack;
        private System.Windows.Forms.Timer timer;
    }
}

