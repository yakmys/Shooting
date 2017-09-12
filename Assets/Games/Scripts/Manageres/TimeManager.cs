///////////////////////////
//製作者　名越大樹
//制作日　9月11日
//ステージの時間を管理するクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    [SerializeField]
    float worldSpeed;

    public void SetSpeed(float set)
    {
        worldSpeed = set;
    }

    public float GetSpeed()
    {
        return worldSpeed;
    }
}
