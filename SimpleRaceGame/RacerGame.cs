using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleRaceGame
{
    public partial class RacerGame : Form
    {
        private int speedRoad = 10;
        private int speedPlayerCar = 10;
        private int speedEnemyCar = 12;
        private Timer timerGame;
        
        public RacerGame() 
        {
            InitializeComponent();

            this.KeyPress += StartGame_KeyPress;            
        }

        private void StartGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                StartGameLabel_Click(sender, e);
                this.KeyPress -= StartGame_KeyPress;
            }
        }
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RacerGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (timerGame != null)
                {
                    timerGame.Stop();
                    MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                    DialogResult dialog = MessageBox.Show("Are you sure want to exit?", "Exit", messageBoxButtons);
                    if (dialog == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        timerGame.Start();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void RacerGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (PlayerCar.Left > 150) { PlayerCar.Left -= speedPlayerCar; }
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (PlayerCar.Right < 690) { PlayerCar.Left += speedPlayerCar; }
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (PlayerCar.Top > 20) { PlayerCar.Top -= speedPlayerCar; }
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (PlayerCar.Bottom < 610) { PlayerCar.Top += speedPlayerCar; }
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            RoadPictureMain.Top += speedRoad;
            RoadPictureBack.Top += speedRoad;

            EnemyCar1.Top += speedEnemyCar;
            EnemyCar2.Top += speedEnemyCar;

            if (RoadPictureMain.Top == this.Height)
            {
                RoadPictureMain.Top = 0;
                RoadPictureBack.Top = -this.Height;
            }
            if (EnemyCar1.Top >= (int)this.Height * 1.1) 
            { 
                EnemyCar1.Top = -150;
                EnemyCar1.Left = new Random().Next(150, 650);
            }
            if (EnemyCar2.Top >= (int)this.Height * 1.1) 
            { 
                EnemyCar2.Top = -300;
                EnemyCar2.Left = new Random().Next(150, 650);
            }

            if (PlayerCar.Bounds.IntersectsWith(EnemyCar1.Bounds))
            {
                timerGame.Stop();
                this.KeyDown -= RacerGame_KeyDown;
                CrashEvent(EnemyCar1.Bounds);
            }
            if (PlayerCar.Bounds.IntersectsWith(EnemyCar2.Bounds))
            {
                timerGame.Stop();
                this.KeyDown -= RacerGame_KeyDown;
                CrashEvent(EnemyCar2.Bounds);
            }
        }

        private void StartGameLabel_Click(object sender, EventArgs e)
        {
            WelcomeLabel.Enabled = false;
            WelcomeLabel.Visible = false;

            StartGameLabel.Enabled = false;
            StartGameLabel.Visible = false;

            ExitLabel.Enabled = false;
            ExitLabel.Visible = false;

            timerGame = new Timer();
            timerGame.Enabled = true;
            timerGame.Interval = 20;
            timerGame.Tick += timer_Tick;

            this.KeyPress -= StartGame_KeyPress;
        }

        public void CrashEvent(Rectangle rec)
        {
            Rectangle recCar = PlayerCar.Bounds;
            recCar.Intersect(rec);

            Point point = new Point(recCar.X - CrashPicture.Width/2, recCar.Y - CrashPicture.Height / 2);
            CrashPicture.Location = point;
        }
    }
}
