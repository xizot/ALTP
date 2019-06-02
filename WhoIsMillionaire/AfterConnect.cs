using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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

        void TachDuLieu(string str, ref Question question)
        {
            string[] arr = str.Split('@');
            question.CauHoi = arr[0];
            question.CauA = arr[1];
            question.CauB = arr[2];
            question.CauC = arr[3];
            question.CauD = arr[4];
        }

        int lblCount = 1;
        void ChangeColorMoney(int count)
        {
            if(lblCount==1)
            {
                Muc1.BackColor = Color.Yellow;
            }
            else if(lblCount == 2)
            {
                Muc1.BackColor = Color.Transparent;
                Muc2.BackColor = Color.Yellow;
            }
            else if (lblCount == 3)
            {
                Muc2.BackColor = Color.Transparent;
                Muc3.BackColor = Color.Yellow;
            }
            else if (lblCount == 4)
            {
                Muc3.BackColor = Color.Transparent;
                Muc4.BackColor = Color.Yellow;
            }
            else if (lblCount == 5)
            {
                Muc4.BackColor = Color.Transparent;
                Muc5.BackColor = Color.Yellow;
            }
            else if (lblCount == 6)
            {
                Muc5.BackColor = Color.Transparent;
                Muc6.BackColor = Color.Yellow;
            }
            else if (lblCount == 7)
            {
                Muc6.BackColor = Color.Transparent;
                Muc7.BackColor = Color.Yellow;
            }
            else if (lblCount == 8)
            {
                Muc7.BackColor = Color.Transparent;
                Muc8.BackColor = Color.Yellow;
            }
            else if (lblCount == 9)
            {
                Muc8.BackColor = Color.Transparent;
                Muc9.BackColor = Color.Yellow;
            }
            else if (lblCount == 10)
            {
                Muc9.BackColor = Color.Transparent;
                Muc10.BackColor = Color.Yellow;
            }
            else if (lblCount == 11)
            {
                Muc10.BackColor = Color.Transparent;
                Muc11.BackColor = Color.Yellow;
            }
            else if (lblCount == 12)
            {
                Muc11.BackColor = Color.Transparent;
                Muc12.BackColor = Color.Yellow;
            }
            else if (lblCount == 13)
            {
                Muc12.BackColor = Color.Transparent;
                Muc13.BackColor = Color.Yellow;
            }
            else if (lblCount == 14)
            {
                Muc13.BackColor = Color.Transparent;
                Muc14.BackColor = Color.Yellow;
            }
            else if (lblCount == 15)
            {
                Muc14.BackColor = Color.Transparent;
                Muc15.BackColor = Color.Yellow;
            }
           

        }
        private void NhanCauHoi()
        {
            while (true)
            {

                string data = "";
                Receive(Player, ref data);

                if (data[0] == 'T')
                {
                    MessageBox.Show("Ban da chien thang");
                    lblCount++;
                    ChangeColorMoney(lblCount);
                    
                }
                else if (data[0] == 'F')
                {
                    MessageBox.Show("Ban da that bai");
                }
                else
                {
                    TachDuLieu(data, ref question);
                    AddFrom(question);
                }

            }

        }

        //private void button2_MouseHover(object sender, EventArgs e)
        //{
        //    btnInfor.BackColor = Color.FromArgb(28, 26, 26);
        //}

        //private void button1_MouseHover(object sender, EventArgs e)
        //{
        //    btnHelp.BackColor = Color.FromArgb(28, 26, 26);
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnInfor_MouseLeave(object sender, EventArgs e)
        //{
        //    btnInfor.BackColor = Color.FromArgb(51, 46, 47);
        //}

        //private void btnHelp_MouseLeave(object sender, EventArgs e)
        //{
        //    btnHelp.BackColor = Color.FromArgb(51, 46, 47);
        //}

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

        private void FirstCustomControl1_Load(object sender, EventArgs e)
        {

        }
        Socket Player = null;
        int PORT = 12345;
        Question question = new Question();

        private void BtnStart_Click(object sender, EventArgs e)
        {

        }


        private void LoopConnect()
        {
            while (!Player.Connected)
            {
                try
                {
                    if (txtIP.Text != null)
                    {
                        IPAddress IP = IPAddress.Parse(txtIP.Text);
                        Player.Connect(IP, PORT);
                    }

                }
                catch (SocketException)
                {


                }

                Thread NhanCH = new Thread(NhanCauHoi);
                NhanCH.IsBackground = true;
                NhanCH.Start();

            }
        }


        void AddFrom(Question q)
        {
            lblQuestion.Text = q.CauHoi;
            btnA.Text = q.CauA;
            btnB.Text = q.CauB;
            btnC.Text = q.CauC;
            btnD.Text = q.CauD;
        }
        void Receive(Socket player, ref string data)
        {
            byte[] receivedBUFFER = new byte[1024*5000];
            //nhan du lieu
            int received = player.Receive(receivedBUFFER);
            if (received != 0)
            {
                //chuyen byte -> string
                byte[] DuLieu = new byte[received];
                Array.Copy(receivedBUFFER, DuLieu, received);
                data = Encoding.ASCII.GetString(DuLieu);
            }
        }

        private void Send(Socket client)
        {
            byte[] data = Encoding.ASCII.GetBytes(txtName.Text);
            client.Send(data);
        }

        private void BtnStart_Click_1(object sender, EventArgs e)
        {
            Player = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            gbMoney.Visible = true;
            lblQuestion.Visible = true;

            gb2.Visible = false;


            LoopConnect();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes("*4");
            Player.Send(data);
        }

        private void Gb2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes("*6");
            Player.Send(data);
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes("*7");
            Player.Send(data);
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes("*8");
            Player.Send(data);
        }
    }
}
