/////////////////////////////
//製作者　名越大樹
//制作日　9月12日
//敵のステータスのクラス
/////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    [SerializeField]
    int hp;
    [SerializeField]
    float moveSpeed;

    public void SetHp(int set)
    {
        hp = set;
    }

    public int GetHp()
    {
        return hp;
    }

    public void SetMoveSpeed(float set)
    {
        moveSpeed = set;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }
}
