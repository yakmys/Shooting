///////////////////////////
//製作者　名越大樹
//制作日　9月11日
//プレイヤーのステータスに関するクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStatus : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float hp;

    public float GetHp()
    {
        return hp;
    }

    public bool SetHp(int set)
    {
        hp -= set;
        bool result = CheckHp();
        return result;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public void SetMoveSpeed(float set)
    {
        moveSpeed = set;
    }

    public bool CheckHp()
    {
        if(hp <= 0)
        {
            return true;
        }
        return false;
    }
}
