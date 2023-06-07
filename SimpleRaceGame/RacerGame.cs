﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRaceGame
{
    public partial class RacerGame : Form
    {
        private int speedRoad = 10;
        private int speedPlayerCar = 10;
        
        public RacerGame()
        {
            InitializeComponent();
        }

        private void RacerGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                timer.Stop();
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                DialogResult dialog = MessageBox.Show("Are you sure want to exit?", "Exit", messageBoxButtons);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    timer.Start();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RoadPictureMain.Top += speedRoad;
            RoadPictureBack.Top += speedRoad;

            if (RoadPictureMain.Top == this.Height)
            {
                RoadPictureMain.Top = 0;
                RoadPictureBack.Top = -this.Height;
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
                if (PlayerCar.Right < 700) { PlayerCar.Left += speedPlayerCar; }
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
    }
}
