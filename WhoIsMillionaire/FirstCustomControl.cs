using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WhoIsMillionaire
{
    public partial class FirstCustomControl : UserControl
    {
        public FirstCustomControl()
        {
            InitializeComponent();
        }

        Socket Player = null;
        int PORT = 12345;

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Player = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            pn1.Visible = false;
            LoopConnect(Player);
        }

        private void LoopConnect(Socket pl)
        {
            while (!pl.Connected)
            {
                try
                {
                    if (txtIP.Text != null)
                    {
                        IPAddress IP = IPAddress.Parse(txtIP.Text);
                        pl.Connect(IP, PORT);
                    }
                  
                }
                catch (SocketException)
                {

                   
                }
                MessageBox.Show("Ket noi thanh cong");
                Send(pl);
            }
        }

        private void Send(Socket client)
        {
            byte[] data = Encoding.ASCII.GetBytes(txtName.Text);
            client.Send(data);
        }
    }
}
