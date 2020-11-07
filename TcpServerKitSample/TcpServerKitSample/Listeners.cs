using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using TcpServerKit.Manager;

namespace TcpServerKitSample
{
    public static class Listeners
    {
        internal static void Join(string data, TcpClient client)
        {
            var user = UserManager.FindUser(client);
        }
    }
}
