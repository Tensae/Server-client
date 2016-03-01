using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DoctorServer
{
    class Server
    {
        DatabaseConnections db = new DatabaseConnections();

        static UnicodeEncoding encoding = new UnicodeEncoding();
        static Socket listeningSocket = null;
        static Socket socket = null;
        const Int32 BUFFERLENGTH = 80;
        //public class Arduino
        //{
        //    SerialPort port = new SerialPort();
        //    public Arduino()
        //    {
        //        port.PortName = "COM4";
        //        port.BaudRate = 9600;
        //    }

        //    public void SendAnswer(string answer)
        //    {
        //        port.Open();
        //        if (port.IsOpen)
        //        {
        //            port.Write(answer);
        //        }
        //        port.Close();
        //    }
        //}
        public void SocketServer(string ip, int port)
        {
            //Arduino ar = new Arduino();
            IPAddress ipAddress = IPAddress.Parse(ip);
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, port);
            //while(true)
            //{

                try
                {
                    listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    listeningSocket.Bind(localEndPoint);
                    listeningSocket.Listen(1);

                    //Found a connection
                    socket = listeningSocket.Accept();

                    Byte[] buffer = new Byte[BUFFERLENGTH];
                    socket.Receive(buffer);
                    String message = encoding.GetString(buffer);

                    bool login = db.IsUserLoggedIn(message);
                    string result;

                    if (login)
                    {
                        result = "1";
                        //ar.SendAnswer(result);
                    }
                    else
                    {
                        result = "0";
                    }


                    //bool test = db.IsUserRegistered(message);
                    //string result;
                    //if (test)
                    //{
                    //    result = "1";
                    //}
                    //else
                    //{
                    //    result = "0";
                    //}

                    Console.WriteLine("Received message: " + message);

                    byte[] resp = encoding.GetBytes(result);
                    socket.Send(resp);

                }
                catch (Exception exception)
                {
                    Console.WriteLine("ERROR: " + exception.Message + "\n" + exception.StackTrace);
                    Console.ReadLine();
                }
                finally
                {

                    if (listeningSocket != null)
                        listeningSocket.Close();
                    if (socket != null)
                        socket.Close();
                }
            }
           
        }
    }
//}
