using System;
using System.Data.SqlTypes;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        HttpServer httpServer = new HttpServer();
    }
}

class HttpServer
{
    int port = 8080;
    int backlog = 10;
    public HttpServer()
    {
        Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
        IPAddress hostIP = (IPAddress.Any);
        IPEndPoint ep = new IPEndPoint(hostIP, port);
        listenSocket.Bind(ep);
        
        listenSocket.Listen(backlog);
        Console.WriteLine("Server wartet auf Verbindung...");

        Socket clientSocket = listenSocket.Accept();
        Console.WriteLine("Client verbunden!");

        byte[] bytes = new byte[256];
        int byteCount = clientSocket.Receive(bytes, SocketFlags.None);
        Console.WriteLine("Received {0} bytes.", byteCount);

        if (byteCount > 0)
        {
            string fullText = Encoding.UTF8.GetString(bytes, 0, byteCount);
            string[] lines = fullText.Split(new[] { "\r\n", "\n"}, StringSplitOptions.None);

            string firstLine = lines[0];
            string[] parts = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string method = parts[0];
            string requestTarget = parts[1];
            string version = parts[2];

            string search = "Host:";

            foreach (string host in lines)
            {
                if (host.StartsWith(search, StringComparison.OrdinalIgnoreCase))
                {
                    string[] onlyHost = host.Split(new char[] { ' ' }, StringSplitOptions.None);
                    string hostValue = onlyHost[1];

                    Console.WriteLine(hostValue);
                }
            }

            Console.WriteLine(method);
            Console.WriteLine(requestTarget);
            Console.WriteLine(version);
        }
    }
}