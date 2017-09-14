////////////////////////
//製作者　名越大樹
//製作日　9月14日
//CSVが読み込めなかった時用の処理
////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{

    [SerializeField]
    ScoreManager scoreManagerScript;
    [SerializeField]
    Text scoreText;
    GameObject scoreObj;
    [SerializeField]
    Client clientScript;
    // Use this for initialization
    void Start()
    {
        scoreObj = GameObject.Find("ScoreManager");
        string score = scoreObj.GetComponent<ScoreManager>().GetScore();
        scoreText.text = "<b>今回</b>敵を倒した数は = <i><b><color='red'>" + score + "</color></b></i>";
        GameObject ClientObj = GameObject.Find("Client");
        ClientObj.GetComponent<Client>().ThreadIni(score);
    }

}
