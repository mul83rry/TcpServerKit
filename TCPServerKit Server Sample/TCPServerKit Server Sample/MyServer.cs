using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using TcpServerKit.Core;

namespace TCPServerKit_Server_Sample
{
    internal class MyServer : Server
    {
        public MyServer(string ip, int port) : base(ip, port)
        {
        }

        public override async Task ClientExited(TcpClient client)
        {
            Console.WriteLine("client exited");
        }

        public override async Task NewClientJoined(TcpClient client)
        {
            Console.WriteLine("new client");
        }
    }
}