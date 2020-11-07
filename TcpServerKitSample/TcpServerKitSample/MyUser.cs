using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using TcpServerKit.Core;

namespace TcpServerKitSample
{
    class MyUser : User
    {
        public MyUser()
        {
        }

        public MyUser(TcpClient tcpClient) : base(tcpClient)
        {
        }
    }
}
