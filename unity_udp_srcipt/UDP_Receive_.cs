using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

public class UDP_Receive_ : MonoBehaviour
{
    public Socket server;
    public string receive_data;

    public int port = 5556;
    public string IP_a = "192.168.1.213";

    public GameObject ball;
    public Color ball_C;

    void Start()
    {

        server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        server.Bind(new IPEndPoint(IPAddress.Parse(IP_a), port));
        Thread t = new Thread(ReciveMsg);
        t.Start();
    }

    void Update()
    {

    }

    public void ReciveMsg()
    {
        while (true)
        {
            EndPoint point = new IPEndPoint(IPAddress.Any, 0);
            byte[] buffer = new byte[1024];
            int length = server.ReceiveFrom(buffer, ref point);
            string message = Encoding.UTF8.GetString(buffer, 0, length);
            receive_data = message;
            //print(receive_data);


        }

    }
}
