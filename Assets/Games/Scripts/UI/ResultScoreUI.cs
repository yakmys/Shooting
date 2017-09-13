/////////////////////
//製作者　名越大樹
//制作日　9月13日
//リザルトシーンでスコアに関するクラス
/////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScoreUI : MonoBehaviour {

    [SerializeField]
    Score scoreScript;
    [SerializeField]
    Text ScoreText;
    [SerializeField]
    Client clientScript;
    void Start()
    {
        string data = scoreScript.ReadData();
        clientScript.ThreadSendMessage(data);
        ScoreText.text = "今回倒した敵の数は = " + data;
    }
}
