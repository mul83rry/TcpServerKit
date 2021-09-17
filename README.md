
# Getting Started

First of all, create a Console Application project.


## [Install package from nuget](https://www.nuget.org/packages/TcpServerKit/)

Create a new Class and inherit from Server (*my class name is **`MyServer`***)

Add following namespaces

```csharp
using System.Net.Sockets;
using System.Threading.Tasks;
using TcpServerKit.Core;
```

Then declare the constructor

```csharp
public MyServer(string ip, int port) : base(ip, port) { }
```

And implement two abstract tasks

```csharp
public override async Task ClientExited(TcpClient client)
{
     Console.WriteLine("client exited");
}

override async Task NewClientJoined(TcpClient client)
{
    Console.WriteLine("new client");
}
```

The result must be something like this

```csharp
using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using TcpServerKit.Core;

namespace TCPSERVERKIT_Sample
{
    class MyServer : Server
    {
        public MyServer(string ip, int port) : base(ip, port) { }

        public override async Task ClientExited(TcpClient client)
        {
            Console.WriteLine("Client exited.");
        }

        public override async Task NewClientJoined(TcpClient client)
        {
            Console.WriteLine("New client.");
        }
    }
}
```

Then create a new object from **`MyServer`** and set server IP and port.

```csharp
var ip = "127.0.0.1";
var port = 3000;
var newServer = new MyServer(ip, port);
```

Now our server is ready to start, but before that let's add some listeners.

Create a new class and name it **`MyListener` and inherit from `ListenersManager`**

Create one Tasks and set the `Listener` attribute to it.

```csharp
[Listener(name:"Login")]
public async Task LoginAsync(string data, TcpClient client)
{
}
```

Tip: If we set the `name` of the attribute, the name of the event name witch server listens to changes. If not, the event name will be set with the task name. in there will be `"LoginAsync"`

In this example we add one listener with name `Login`. After the client sends a message with the same event name, the `Login` task will be run.

`data` is a string data which client sends to the server and `client` is a TCPClient object of who sends it.

The result must be something like this.

```csharp
using System.Net.Sockets;
using System.Threading.Tasks;
using TcpServerKit.Attributes;
using TcpServerKit.Manager;

namespace TCPSERVERKIT_Sample
{
    public class MyListener : ListenersManager
    {
        [Listener(name:"Login")]
        public async Task LoginAsync(string data, TcpClient client)
				{
				}
    }
}
```

Then create a new object from `MyListener`.

```csharp
var myListener = new MyListener();
```

Very well. After adding all of the listeners we can start the server.

```csharp
newServer.Start();
```

```csharp
using System;

namespace TCPSERVERKIT_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
						var ip = "127.0.0.1";
						var port = 3000;
						var newServer = new MyServer(ip, port);

            var myListener = new MyListener();

            newServer.Start();
            Console.ReadKey();
        }
    }
}
```

There is it. All you need is to run your server.

And don’t forget to put a `Console.ReadKey();` to prevent the console from closing.
