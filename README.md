# TcpServerKit
## _best choice for creating online multiplayer game Ever_

***A free package for creating online multiplayer games, using tcp protocol. includes clientside code and some other utilities to help online game developing faster.***

## Easy implementation

First of all, create a **console project** in [dotnet core](https://dotnet.microsoft.com/download) .

**download it from https://www.nuget.org/packages/TcpServerKit/**

Add following namespaces

```javascript
using TcpServerKit.Core;
using TcpServerKit.Core.Socket;
using System.Net.Sockets;

Then initialize server ip and port

javascript
Server.InitServer("127.0.0.1", 3000);

Define two properties for client’s event
javascript
Server.NewClientJoined += (TcpClient client) =>
{
    Console.WriteLine("new client join");
};
Server.ClientExited += (TcpClient client) =>
{
    Console.WriteLine("client exit");
};

Now your server is ready to start, but before that we need to add listeners
javascript
Server.AddListener("LoginAsync", Login);
In this example we add one listener with eventName “Login”.
After the client sends a message with the same “eventName”, the Login function is invoked.

javascript
Task LoginAsync(string data, TcpClient client)
{
 
}

data is a string data which client sends to the server and client is a TcpClient object of who sends it.


Very well. After adding all of the listeners we can start the server.

javascript
Server.StartServer();

There is it. All you need to run your server.

And don’t forget to put a Console.ReadKey(); To prevent the console from closing.


***See the result.***

![mul83rry](https://github.com/mul83rry/TcpServerKit/blob/main/result.PNG)

For more information check website : [TcpServerKit](https://tcpserverkit.com/)


```
