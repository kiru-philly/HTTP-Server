using System;
using System.Data.SqlTypes;
using System.Net;
using System.Net.Sockets;
using System.Text;
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

        string response = "HTTP/1.1 200 OK\r\n";
        string header = "Content-Type: text/plain\r\n\r\n";
        string testText = "Hello";

        string text = response + header + testText;
        byte[] getBytes = Encoding.UTF8.GetBytes(text);

        int send = clientSocket.Send(getBytes);
        Console.WriteLine(send);

        if (byteCount > 0)
        {
            string fullText = Encoding.UTF8.GetString(bytes, 0, byteCount);
            
            HttpRequest httpRequest = new HttpRequest(fullText);
            Console.WriteLine(httpRequest.Method);
            Console.WriteLine(httpRequest.RequestTarget);
            Console.WriteLine(httpRequest.Version);
            Console.WriteLine(httpRequest.Host);
        }
    }
}