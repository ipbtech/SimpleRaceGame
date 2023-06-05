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
        }

        private void RacerGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти?", "Выход", messageBoxButtons);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
