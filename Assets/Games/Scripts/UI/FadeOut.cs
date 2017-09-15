////////////////////////
//製作者　名越大樹
//制作日　9月14日
//フェードアウトするクラス
////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeOut : MonoBehaviour
{

    [SerializeField]
    Image fadeOutImg;
    bool isFadeOut = false;
    [SerializeField]
    float colorValue;
    [SerializeField]
    UIManager uiManagerScript;
    [SerializeField]
    TimeManager timeManagerScript;
    // Update is called once per frame
    void Update()
    {
        Fade();
    }

    void Fade()
    {
        Color color = fadeOutImg.color;
        color.a = colorValue;
        fadeOutImg.color = color;
        colorValue += Time.deltaTime * timeManagerScript.GetSpeed() * 3;
        if (colorValue >= 1.0f)
        {
            uiManagerScript.SceneMove();
        }
    }
}
