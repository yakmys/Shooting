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

    public float GetBackGroundEndPos()
    {
        return backGoundEndPos.transform.position.x;
    }
    
    public float GetLastPos()
    {
       return backGroundManagerScript.LastPos();
    }
}
