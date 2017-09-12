////////////////////////
//製作者　名越大樹
//製作日　9月12日
//メインステージでのスタートのカウントダウンをするクラス
////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUI : MonoBehaviour
{
    [SerializeField]
    Text countDownText;
    [SerializeField]
    UIManager uiManagerScript;
    bool isStartUI;
    [SerializeField]
    float Timer;
    void Update()
    {
        MoveAnimation();
    }

    void MoveAnimation()
    {
        if(uiManagerScript.GetIsStartUI())
        {
            CountDown();
        }
    }

    void CountDown()
    {
        Timer -= Time.deltaTime;
        countDownText.text = Timer.ToString("F00");
        if(Timer <= 1 && Timer >= 0)
        {
            countDownText.text = "START";
        }
        else if(Timer <= 0)
        {
            uiManagerScript.SetGamePlay(true);
            countDownText.enabled = false;
        }
    }
}
