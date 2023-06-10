using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleRaceGame
{
    public partial class RacerGame : Form
    {
        private int speedRoad = 12;
        private int speedPlayerCar = 10;
        private int speedEnemyCar = 12;
        private int speedCoinMoves = 12;
        private int coinsAmount = 0;
        private Timer timerGame;
        
        public RacerGame() 
        {
            InitializeComponent();

            timerGame = new Timer();
            timerGame.Enabled = true;
            timerGame.Interval = 20;

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
        private void RestartGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RestartLabel_Click(sender, e);
                this.KeyPress -= RestartGame_KeyPress;
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
            //else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            //{
            //    if (PlayerCar.Top > 20) { PlayerCar.Top -= speedPlayerCar; }
            //}
            //else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            //{
            //    if (PlayerCar.Bottom < 610) { PlayerCar.Top += speedPlayerCar; }
            //}
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            #region Add dynamic to pictures
            RoadPictureMain.Top += speedRoad;
            RoadPictureBack.Top += speedRoad;

            EnemyCar1.Top += speedEnemyCar;
            EnemyCar2.Top += speedEnemyCar;

            CoinPicture.Top += speedCoinMoves;
            #endregion

            #region Background moving
            if (RoadPictureMain.Top >= this.Height)
            {
                RoadPictureMain.Top = 0;
                RoadPictureBack.Top = -this.Height;
            }
            #endregion

            #region EnemyCars moving
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
            #endregion

            #region Coins moving and intersects
            if (CoinPicture.Top >= this.Height + CoinPicture.Height)
            {
                CoinPicture.Top = -350;
                CoinPicture.Left = new Random().Next(150, 650);
            }
            if (PlayerCar.Bounds.IntersectsWith(CoinPicture.Bounds))
            {
                CoinPicture.Top = -350;
                CoinPicture.Left = new Random().Next(150, 650);

                coinsAmount += 1;
                CoinsValueLabel.Text = $"Coins: {coinsAmount}";
            }
            #endregion

            #region Crash cars events
            if (PlayerCar.Bounds.IntersectsWith(EnemyCar1.Bounds))
            {
                timerGame.Stop();
                this.KeyDown -= RacerGame_KeyDown;
                CrashEvent(EnemyCar1.Bounds);
                GameOverAction();
            }
            if (PlayerCar.Bounds.IntersectsWith(EnemyCar2.Bounds))
            {
                timerGame.Stop();
                this.KeyDown -= RacerGame_KeyDown;
                CrashEvent(EnemyCar2.Bounds);
                GameOverAction();
            }
            #endregion
        }
        private void StartGameLabel_Click(object sender, EventArgs e)
        {
            WelcomeLabel.Enabled = false;
            WelcomeLabel.Visible = false;

            StartGameLabel.Enabled = false;
            StartGameLabel.Visible = false;

            ExitLabel.Enabled = false;
            ExitLabel.Visible = false;

            timerGame.Tick += timer_Tick;
            this.KeyPress -= StartGame_KeyPress;
            this.CoinsValueLabel.Text = $"Coins: {coinsAmount}";
            this.CoinsValueLabel.Visible = true;
        }
        private void CrashEvent(Rectangle rec)
        {
            Rectangle recCar = PlayerCar.Bounds;
            recCar.Intersect(rec);

            Point point = new Point(recCar.X - CrashPicture.Width/2, recCar.Y - CrashPicture.Height / 2);
            CrashPicture.Location = point;
        }
        private void GameOverAction()
        {
            GameOverLabel.Enabled = true;
            GameOverLabel.Visible = true;

            timerGame.Tick -= timer_Tick;
            this.KeyPress += RestartGame_KeyPress;

            RestartLabel.Enabled = true;
            RestartLabel.Visible = true;

            ExitLabel.Enabled = true;
            ExitLabel.Visible = true;
        }

        private void RestartLabel_Click(object sender, EventArgs e)
        {
            coinsAmount = 0;
            CoinsValueLabel.Text = $"Coins: {coinsAmount}";

            #region Return source position of Pictures
            RoadPictureMain.Top = 0;
            RoadPictureBack.Top = -this.Height;

            EnemyCar1.Top = -150;
            EnemyCar2.Top = -300;
            CoinPicture.Top = -350;
            CrashPicture.Top = -650;
            #endregion

            timerGame.Tick += timer_Tick;
            timerGame.Start();

            this.KeyDown += RacerGame_KeyDown;

            GameOverLabel.Enabled = false;
            GameOverLabel.Visible = false;
            
            RestartLabel.Enabled = false;
            RestartLabel.Visible = false;

            ExitLabel.Enabled = false;
            ExitLabel.Visible = false;
        }
    }
}
