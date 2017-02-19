/*
 * TCPEchoClient
 *
 * Author Michael Claudius, ZIBAT Computer Scienc
 * Version 1.0. 2014.02.10
 * Copyright 2014 by Michael Claudius
 * Revised 2014.09.01
 * All rights reserved
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPEchoClient
{
    class TCPEchoClient
    {
        static void Main(string[] args)
        {
            //Console.ReadLine();
            TcpClient clientSocket = new TcpClient("192.168.3.102", 6789);

            Stream ns = clientSocket.GetStream();  //provides a Stream
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            Console.WriteLine(sr.ReadLine());
            string message = "";

            while (message != "quit")
            {
                message = Console.ReadLine();
                sw.WriteLine(message);
                string serverAnswer = sr.ReadLine();
                Console.WriteLine("Server: " + serverAnswer);
            }

            ns.Close();

            clientSocket.Close();
            Console.ReadKey();

        }

    }




}
