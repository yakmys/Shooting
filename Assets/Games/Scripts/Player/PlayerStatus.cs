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
    private int hp;
    [SerializeField]
    PlayerLifeUI playerLifeUIScript;
    [SerializeField]
    float collisionTime;
    float copycollisonTime;
    bool isCollision = true;

    void Start()
    {
        copycollisonTime = collisionTime;
    }

    public int GetHp()
    {
        return hp;
    }

    public bool SetHp(int set)
    {
        hp -= set;
        playerLifeUIScript.UISubtraction();
        bool result = CheckHp();
        collisionTime = copycollisonTime;
        SetColliderEnabled(false);
        return result;
    }

    public float GetCollisitonTime()
    {
        return collisionTime;
    }

    public void SetCollisionTime(float set)
    {
        collisionTime = set;
        if(collisionTime <= 0)
        {            
            SetColliderEnabled(true);
        }
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
        if (hp <= 0)
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// 当たり判定を一定の間消す
    /// </summary>
    /// <param name="set"></param>
    void SetColliderEnabled(bool set)
    {
        isCollision = set;
        GetComponent<BoxCollider2D>().enabled = set;
    }

    /// <summary>
    /// 当たり判定があるかどうかとってくる
    /// </summary>
    /// <returns></returns>
    public bool GetIsCollision()
    {
        return isCollision;
    }
}
