using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
public class SocketClass : MonoBehaviour
{

    public void Bind(ref Socket sock, IPEndPoint ep)
    {
        sock.Bind(ep);
        sock.Listen(10);
        Debug.Log("バインド完了");
    }

    public Socket Accept(ref Socket sock)
    {
        sock.Accept();
        Socket listen = sock.Accept();
        Debug.Log("アクセプト完了");
        return listen;

    }

    public void Send(Socket sock, string message)
    {
        byte[] sendmessage = Encoding.GetEncoding("shift_jis").GetBytes(message);
        sock.Send(sendmessage);
        Debug.Log("送信完了");
    }

    public string Recieve(Socket sock)
    {
        byte[] receivebyte = new byte[100];
        sock.Receive(receivebyte);
        string message = Encoding.GetEncoding("UTF-8").GetString(receivebyte);
        Debug.Log("受信完了");
        return message;
    }

    public void Connect(ref Socket sock,IPAddress ip,int port)
    {
        while (sock.Connected) {
            sock.Connect(ip, port);
        }
        Debug.Log("サーバーに接続完了");
    }
}
