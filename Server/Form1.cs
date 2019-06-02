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
using System.IO;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] BUFFER = new byte[1024];
        Socket server = null;
        Socket NguoiChoi = null;
        int PORT = 12345;
        IPEndPoint address = null;
        List<Socket> SocketList;
        List<string> NickName;
        List<ListQuestion> listQuestions = new List<ListQuestion>();

        List<PlayerInformation> ListPlayerInformation = new List<PlayerInformation> { };//Thông tin người chơi

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            CheckForIllegalCrossThreadCalls = false;

            SettingUp();

        }

      
        //cap nhat  danh sach


        public void ReadFile()
        {
            string filePath = @"./CAUHOI/cauhoi.txt";
            string[] lines;


            //kiem tra file ton tai?
            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    ListQuestion question = new ListQuestion();
                    TachDuLieu(lines[i], ref question);
                    listQuestions.Add(question);
                }
            }
        }

        public void TachDuLieu(string str, ref ListQuestion question)
        {

            string[] ArrayStr = str.Split('@');
            question.Question = ArrayStr[0];
            question.A = ArrayStr[1];
            question.B = ArrayStr[2];
            question.C = ArrayStr[3];
            question.D = ArrayStr[4];
            question.DapAn = "*" + ArrayStr[5];
        }

        public void SettingUp()
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            address = new IPEndPoint(IPAddress.Any, 12345);
            server.Bind(address);

            // lang nghe ket noi
            Thread Listen = new Thread(Listener);
            Listen.IsBackground = true;
            Listen.Start();

            // Nhan du lieu
            Thread t= new Thread(Nhan1);
            t.IsBackground = true;
            t.Start();
        }

        private void Listener()
        {

            try
            {
                while (true)
                {
                    server.Listen(5);
                    NguoiChoi = server.Accept();

                    Nhan();

                }
            }
            catch
            {
                // thử kết nối lại

                address = new IPEndPoint(IPAddress.Any, PORT);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            }
        }

        private void Nhan1()
        {
            while(true)
            {
                if (NguoiChoi != null)
                {
                    // Lay nick 
                    string data = "";

                    ReceiveData(NguoiChoi, ref data);
                    MessageBox.Show(data);
                    if (data[0] == '*') // neu nhan duoc '*' o dau laf cau tra loi
                    {
                        if (data == "*4")
                        {
                            Send(NguoiChoi, "T");
                        }
                        else
                        {
                            Send(NguoiChoi, "F");
                        }

                    }
                    else
                    {
                        PlayerInformation player = new PlayerInformation();
                        AddInfor(ref player, data, 0, 0, 3);
                        AddListView(player);
                    }
                }
            }
           

        }

        private void Nhan()
        {
            // Lay nick 
            string data = "";

            ReceiveData(NguoiChoi, ref data);
            MessageBox.Show(data);
            PlayerInformation player = new PlayerInformation();
            AddInfor(ref player, data, 0, 0, 3);
            AddListView(player);

        }

        //add to infor
        void AddInfor(ref PlayerInformation player, string NickName, int socaudung, int sotien, int quyentrogiup)
        {
            player.Name = NickName;
            player.SoCauDung = socaudung;
            player.SoTienNhanDuoc = sotien;
            player.CacQuyenTroGiup = quyentrogiup;
        }

        //add to list view
        void AddListView(PlayerInformation player)
        {
            ListViewItem name = new ListViewItem(player.Name);
            name.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = player.SoCauDung.ToString() });
            name.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = player.SoTienNhanDuoc.ToString() });
            name.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = player.CacQuyenTroGiup.ToString() });


            listView1.Items.Add(name);
        }

        private void ReceiveData(Socket client, ref string data)
        {
            byte[] receivedBUFFER = new byte[1024];
            //nhan du lieu
            int received = client.Receive(receivedBUFFER);
            if (received != 0)
            {
                //chuyen byte -> string
                byte[] DuLieu = new byte[received];
                Array.Copy(receivedBUFFER, DuLieu, received);
                data = Encoding.ASCII.GetString(DuLieu);
            }
        }

        void Send(Socket client, string data)
        {
            byte[] DuLieu = Encoding.ASCII.GetBytes(data);
            client.Send(DuLieu);
        }

        int k = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (k < 10)
            {
                Thread t = new Thread(SendCauHoi);
                t.IsBackground = true;
                t.Start(k);

                k++;


                //string CauHoi = listQuestions[k].Question + "@" + listQuestions[k].A + "@" + listQuestions[k].B + "@" + listQuestions[k].C + "@" + listQuestions[k].D;
                //Send(NguoiChoi, CauHoi);
            }


        }

        int ToINT(string str)
        {
            return int.Parse(str);
        }
        private void SendCauHoi(object index)
        {
            int count = ToINT(index.ToString());
            string CauHoi = listQuestions[count].Question + "@" + listQuestions[count].A + "@" + listQuestions[count].B + "@" + listQuestions[count].C + "@" + listQuestions[count].D;
            Send(NguoiChoi, CauHoi);
        }
    }
}
