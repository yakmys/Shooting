//////////////////////
//製作者　名越大樹
//制作日　9月13日
//サーバー関係のクラス
//////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine.UI;
public class Server : MonoBehaviour
{

    [SerializeField]
    SocketClass socketClassScript;
    [SerializeField]
    int portNumber;
    [SerializeField]
    string serverIPAdress;
    IPAddress ipAddress;
    IPEndPoint endPoint;
    Socket sock;
    int maxScore = 0;
    int recvMessage;
    bool isUpdate;
    [SerializeField]
    Text scoreText;

    // Use this for initialization
    void Start()
    {
        ipAddress = IPAddress.Parse(serverIPAdress);
        sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        endPoint = new IPEndPoint(ipAddress,portNumber);
        Thread ini = new Thread(Ini);
        ini.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if(isUpdate)
        {
            ScoreUpdate();
        }
    }

    void Ini()
    {
        Wait();
    }

    void Wait()
    {
        Debug.Log("aaa");
        socketClassScript.Bind(ref sock, endPoint);
        Socket listen = socketClassScript.Accept(ref sock);
        Thread next = new Thread(Wait);
        string message = socketClassScript.Recieve(sock);        
        recvMessage = int.Parse(message);
        isUpdate = true;
    }

    void ScoreUpdate()
    {
       if(maxScore <= recvMessage)
        {
            scoreText.text = recvMessage.ToString();
        }
        isUpdate = false;
    }
}
