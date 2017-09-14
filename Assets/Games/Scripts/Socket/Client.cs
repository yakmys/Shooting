using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
public class Client : MonoBehaviour {

    [SerializeField]
    SocketClass sockClassScript;
    [SerializeField]
    string serverIp;
    [SerializeField]
    int portNumber;
    IPAddress ipAddress;
    IPEndPoint ipEndPoint;
    Socket sock;
    string message;	

    public void ThreadIni(string score)
    {
        message = score;
        Thread ini = new Thread(Ini);
        ini.Start();
    }

    public void ThreadSendMessage(string score)
    {
        message = score;
        Thread sendmessage = new Thread(SendMessage);
        sendmessage.Start();
    }
    void Ini()
    {
        ipAddress = IPAddress.Parse(serverIp);
        ipEndPoint = new IPEndPoint(ipAddress,portNumber);
        sock = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        Debug.Log("初期化完了");
        SendMessage();
    }

    public void SendMessage()
    {
        ConnectMessage();
    }

    void ConnectMessage()
    {
        sockClassScript.Connect(ref sock,ipAddress,portNumber);
        sockClassScript.Send(sock,message);
    }


}
