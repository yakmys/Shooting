///////////////////////////
//製作者　名越大樹
//制作日　9月12日
//背景のパラメータを持つクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundStatus : MonoBehaviour {

    [SerializeField]
    float moveSpeed;
    [SerializeField]
    GameObject backGoundEndPos;
    [SerializeField]
    BackGroundManager backGroundManagerScript;
    public void SetMoveSpeed(float set)
    {
        moveSpeed = set;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    /// <summary>
    /// 一定の距離に進んだら
    /// </summary>
    /// <returns></returns>
    public float GetBackGroundEndPos()
    {
        return backGoundEndPos.transform.position.x;
    }
    
    /// <summary>
    /// 現在の一番後ろの画像のポジションを取得
    /// </summary>
    /// <returns></returns>
    public float GetLastPos()
    {
       return backGroundManagerScript.LastPos();
    }

    public float GetWorldTimeSpeed()
    {
        return backGroundManagerScript.GetWorldTimeSpeed();
    }
}
