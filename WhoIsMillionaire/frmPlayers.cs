using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WhoIsMillionaire
{
    public partial class frmPlayers : Form
    {
       

        public frmPlayers()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void FrmPlayers_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cpbTime.Text = seconds.ToString();
            cpbTime.Value = seconds;

            // rolling intro
            //player.SoundLocation = ;
           

        }

        int seconds = 60;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(seconds <= 0)
            {
                timer1.Enabled = false;
            }
            cpbTime.Value = seconds;
            cpbTime.Text = seconds.ToString();
            seconds--;
        }
    }
}
