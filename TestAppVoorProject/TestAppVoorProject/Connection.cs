using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace TestAppVoorProject
{
    public class Connection
    {
        private static bool connected = false;
        private static Socket client;
        private static IPEndPoint remoteEP;
        private static IPAddress ipAddress;

        public static bool IsConnected()
        {
            return connected;
        }

        /// <summary>
        /// Send a command on which an <OK> response is expected
        /// </summary>
        /// <param name="command">The command to be sent</param>
        /// <returns>true if <OK> is received</returns>
        private static string SendCommand(string command)
        {
            if (connected)
            {
                client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    //opening
                    client.Connect(remoteEP);

                    //sending
                    byte[] message = Encoding.ASCII.GetBytes(command);
                    int bytesSent = client.Send(message);

                    //receiving
                    byte[] bytes = new byte[1024];
                    int bytesRec = client.Receive(bytes);
                    string receivedMessage = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    //closing
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();

                    return receivedMessage;
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);
                    return "error";
                }
            }
            else
                return "no connection";
        }


        public static bool LedToggle()
        {
            string received = SendCommand("<PIN7TOGGLE>");

            if (received == "<LEDON>\r\n")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static string ReadSensor()
        {
            return SendCommand("<READSENSORPINA0>");
        }

        public static string TestConnection(string ip, int port)
        {
            connected = false;
            client = null;
            string IPregex = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            Regex regex = new Regex(IPregex);
            if (regex.IsMatch(ip))
            {
                if (port >= 0 && port < 65536)
                {
                    ipAddress = IPAddress.Parse(ip);
                    remoteEP = new IPEndPoint(ipAddress, port);
                    client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        //opening
                        client.Connect(remoteEP);

                        //sending
                        byte[] message = Encoding.ASCII.GetBytes("<ECHO>");
                        int bytesSent = client.Send(message);

                        //receiving
                        byte[] bytes = new byte[1024];
                        int bytesRec = client.Receive(bytes);
                        string receivedMessage = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                        //closing
                        client.Shutdown(SocketShutdown.Both);
                        client.Close();

                        //evaluating respons
                        if (receivedMessage == "<ECHO>\r\n")
                        {
                            connected = true;
                            return "Connection established, ECHO received";
                        }
                        else
                        {
                            return "Connection failed, no ECHO received";
                        }

                    }
                    catch (Exception exception)
                    {
                        Debug.WriteLine(exception.Message);
                        client = null;
                        connected = false;
                        return "Connection failed, " + exception.Message;
                    }
                }
                else
                {
                    return "Port out of range (0-65535)";
                }
            }
            else
            {
                return "IP not valid";
            }
        }
    }
}
