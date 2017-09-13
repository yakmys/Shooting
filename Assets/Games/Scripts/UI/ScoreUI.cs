///////////////////////
//製作者　名越大樹
//制作日　9月13日
//スコアを表示するUI
///////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    int scoreValue = 0;
    [SerializeField]
    Text scoreText;

    void Start()
    {
        UpdateScore();
    }

    public void SetScore()
    {
        scoreValue++;
        UpdateScore();
    }

    public int GetScore()
    {
        return scoreValue;
    }

    void UpdateScore()
    {
        scoreText.text = "倒した敵の数   =" + scoreValue.ToString();
    }
}
