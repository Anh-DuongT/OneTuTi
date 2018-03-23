using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Net.NetworkInformation;

namespace Client
{
    public partial class Form1 : Form
    {
        Socket server, client;
        EndPoint remote;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPEndPoint ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            remote=(EndPoint)ipServer;
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            txtLuaChon.Text = "Bua";
            byte[] sendData = Encoding.ASCII.GetBytes("1");
            server.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];
            server.ReceiveFrom(receiveData, ref remote);
            txtKetQua.Text = Encoding.ASCII.GetString(receiveData);
            Random r = new Random();
            r.Next(0, 3);
        }

        private void btnKeo_Click(object sender, EventArgs e)
        {
            txtLuaChon.Text = "Keo";
            byte[] sendData = Encoding.ASCII.GetBytes("2");
            server.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];
            server.ReceiveFrom(receiveData, ref remote);
            txtKetQua.Text = Encoding.ASCII.GetString(receiveData);
            Random r = new Random();
            r.Next(0, 3);
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            txtLuaChon.Text = "Bao";
            byte[] sendData = Encoding.ASCII.GetBytes("0");
            server.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];
            server.ReceiveFrom(receiveData, ref remote);
            txtKetQua.Text = Encoding.ASCII.GetString(receiveData);
            Random r = new Random();
            r.Next(0, 3);
        }
    }
}
