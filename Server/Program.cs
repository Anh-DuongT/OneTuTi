﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Net.NetworkInformation;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 1234);
            sock.Bind(ipe);
            EndPoint ep = ipe;

            byte[] receiveData = new byte[10];
            sock.ReceiveFrom(receiveData, ref ep);
            int clientResult = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));
            Random r = new Random();
            int serverResult = r.Next(0, 3);
            if (((serverResult == 0) && (clientResult == 0)) || ((serverResult == 1) && (clientResult == 1)) || ((serverResult == 2) && (clientResult == 2)))
            {
                byte[] sendData = Encoding.ASCII.GetBytes("hoa");
                sock.SendTo(sendData, ep);
            }
            else
            {
                if (((serverResult == 0) && (clientResult == 1)) || ((serverResult == 1) && (clientResult == 2)) || ((serverResult == 2) && (clientResult == 0)))
                {
                    byte[] sendData = Encoding.ASCII.GetBytes("server thang");
                    sock.SendTo(sendData, ep);
                }
                else {
                    byte[] sendData = Encoding.ASCII.GetBytes("ban thang");
                    sock.SendTo(sendData, ep);
                }
            }
            sock.Close();
        }
    }
}
