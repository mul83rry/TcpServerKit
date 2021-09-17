using System;

namespace TCPServerKit_Server_Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var newServer = new MyServer("127.0.0.1", 3001);
            newServer.Start();
            _ = new MyListener();

            Console.ReadKey();
        }
    }
}