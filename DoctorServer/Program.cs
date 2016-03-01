using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoctorServer
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnections db = new DatabaseConnections();
            Server server = new Server();
            while (true) {
                server.SocketServer("127.0.0.1", 8145);
            } 
        }
        
    }
}

