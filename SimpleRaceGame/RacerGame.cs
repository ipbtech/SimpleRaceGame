using System;
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
        public RacerGame()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Tick += timer_Tick;

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

            int speed = 10;
            RoadPictureMain.Top += speed;
            RoadPictureBack.Top += speed;
            //RoadPictureBack.Top += (int)(speed * 1.1);

            if (RoadPictureMain.Top == this.Height)
            {
                RoadPictureMain.Top = 0;
                RoadPictureBack.Top = -this.Height;
                //RoadPictureBack.Top = (int)(-this.Height * 0.95);
            }
        }
    }
}
