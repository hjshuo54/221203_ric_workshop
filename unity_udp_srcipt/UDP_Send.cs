using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;

public class UDP_Send : MonoBehaviour
{
    private float time = 1.5f;
    private int iter = 0;
    private IPEndPoint ipEndPoint;
    private UdpClient udpClient;
    private byte[] sendByte;

    public int port = 5555;
    public string IPlocation = "192.168.1.107";

    
    void Start()
    {

    }

    void Update()
    {
        
        

    }

    public void SendUDPData(string Data)
    {
        ipEndPoint = new IPEndPoint(IPAddress.Parse(IPlocation), port);
        udpClient = new UdpClient();
        sendByte = System.Text.Encoding.UTF8.GetBytes(Data);
        udpClient.Send(sendByte, sendByte.Length, ipEndPoint);
    }
}
