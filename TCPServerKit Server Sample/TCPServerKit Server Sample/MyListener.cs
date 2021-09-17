using System.Net.Sockets;
using System.Threading.Tasks;
using TcpServerKit.Attributes;
using TcpServerKit.Manager;

namespace TCPServerKit_Server_Sample
{
    public class MyListener : ListenersManager
    {
        [Listener(name: "Login")]
        public async Task LoginAsync(string data, TcpClient client) => System.Console.WriteLine(data);

        [Listener()]
        public async Task Task1(string data, TcpClient client) => System.Console.WriteLine(data);
    }
}
