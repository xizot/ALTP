using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoIsMillionaire
{
    public partial class AfterConnect : Form
    {
        public AfterConnect()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AfterConnect_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
           btnInfor.BackColor = Color.FromArgb(28, 26, 26);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.FromArgb(28, 26, 26);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInfor_MouseLeave(object sender, EventArgs e)
        {
            btnInfor.BackColor = Color.FromArgb(51, 46, 47);
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.FromArgb(51, 46, 47);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnInfor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
