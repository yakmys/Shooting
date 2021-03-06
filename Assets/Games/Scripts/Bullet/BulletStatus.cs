﻿///////////////////////
//製作者　名越大樹
//製作日　9月13日
//弾のパラメータに関するクラス
///////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStatus : MonoBehaviour {

    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float destoryTime;
    GameObject managerObj;
    [SerializeField]
    TimeManager timeManagerScript;

    public void SetSpeed(float set)
    {
        moveSpeed = set;
    }

    public float GetSpeed()
    {
        return moveSpeed;
    }

    public void SetDestroyTime(float set)
    {
        destoryTime = set;
    }

    public float GetDestroyTime()
    {
        return destoryTime;
    }

    public float GetWorldTimeSpeed()
    {
        return timeManagerScript.GetSpeed();
    }

    public void SetManagerObj(TimeManager manager)
    {
        timeManagerScript = manager;
    }

    public TimeManager GetManager()
    {
        return timeManagerScript;
    }
    public void DestroyTimeSubtraction()
    {
        destoryTime -= Time.deltaTime * GetWorldTimeSpeed();
        if (destoryTime <= 0)
        {
            Destroy(gameObject);
        }
    }

}
