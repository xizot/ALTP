using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoIsMillionaire
{
    public partial class WelcomePL : Form
    {
        public WelcomePL()
        {
            InitializeComponent();
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            pbPlay.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PbPlay_Click(object sender, EventArgs e)
        {

            player.Stop();
            pbPlay.BorderStyle = BorderStyle.Fixed3D;

            OpenfrmPlayer();
           

        }

        private void OpenfrmPlayer()
        {
            frmPlayers player = new frmPlayers();
            player.Show();
        }

        private void PbPlay_MouseLeave(object sender, EventArgs e)
        {
            pbPlay.BorderStyle = BorderStyle.None;
        }
        SoundPlayer player = new SoundPlayer(@Application.StartupPath + @"\Audio\intro.wav");

      
        private void WelcomePL_Load(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
