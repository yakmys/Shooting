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

    public void SetHp(int set)
    {
        hp -= set;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public void SetMoveSpeed(float set)
    {
        moveSpeed = set;
    }
}
