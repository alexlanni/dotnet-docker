using System.IO;
using System.Net;
using System.Net.Sockets;


bool quit = false;

// Listen on 0.0.0.0 (Any address available)
// and open port 5000
TcpListener myListner = new
TcpListener(new IPAddress(0x00000000), 5010);
myListner.Start();

while(!quit)
{
    Socket mySocket = myListner.AcceptSocket();
    Stream myStream = new NetworkStream(mySocket);
    StreamReader reader = new StreamReader(myStream);
    StreamWriter writer = new StreamWriter(myStream)
        {AutoFlush = true};

    writer.WriteLine("Starting");

    string text = reader.ReadLine();
    if(text != null && text.ToLower() == "quit")
    {
        quit = true;
    }
    writer.WriteLine("Hello I'm a TCP server");
    myStream.Close();
    mySocket.Close();
}
