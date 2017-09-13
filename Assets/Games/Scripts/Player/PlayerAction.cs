//////////////////////////////
//製作者　名越大樹
//制作日　9月11日
//プレイヤーの操作に関するクラス
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour {

    [SerializeField]
    WallManager wallManagerScript;
    [SerializeField]
    PlayerManager playerManagerScript;
    [SerializeField]
    PlayerStatus playerStatusScript;
    [SerializeField]
    BulletManager bulletManagerScript;
    bool IsMove;
    [SerializeField]
    GameObject centerPos;
    [SerializeField]
    float centerPosWidth;
    [SerializeField]
    float centerPosHeith;
    float checkvalue;

    // Update is called once per frame
    void Update ()
    {
        if (playerManagerScript.GetIsGame())
        {
            MouseAction();
            BulletAction();
        }
    }

    void MouseAction()
    {
       if(Input.GetMouseButtonDown(0))
        {
            IsMove = true;
        }

       else if(Input.GetMouseButtonUp(0))
        {
            IsMove = false;
        }

        ActiionCheck();
    }

    void ActiionCheck()
    {
        if (IsMove)
        {
            Move();
        }
    }

    void Move()
    {
        Vector3 inputmousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        inputmousepos.z = 0;
        Vector3 movepos = MousePosionCheck(inputmousepos);
        movepos = WallCollisionCheck(movepos);
        transform.position += movepos * playerStatusScript.GetMoveSpeed() * Time.deltaTime;
    }
    
    /// <summary>
    /// マウスの位置によって動く方向を指定
    /// </summary>
    /// <param name="mousepos"></param>
    /// <returns></returns>
    Vector3 MousePosionCheck(Vector3 mousepos)
    {
        Vector3 centerpos = centerPos.transform.position;
        if(mousepos.x >= centerpos.x + centerPosWidth)
        {
            mousepos.x = 1;
        }

        else if(mousepos.x <= centerpos.x - centerPosWidth)
        {
            mousepos.x = -1;
        }

        else
        {
            mousepos.x = 0;
        }

        if(mousepos.y >= centerPos.transform.position.y + centerPosHeith)
        {
            mousepos.y = 1;
        }

        else if(mousepos.y <= centerPos.transform.position.y - centerPosHeith)
        {
            mousepos.y = -1;
        }

        else
        {
            mousepos.y = 0;
        }

        return mousepos;
    }

    /// <summary>
    /// 「BulletManager」に弾を生成してもらう
    /// </summary>
    void BulletAction()
    {
        bulletManagerScript.InstanceBullet(transform.position);
    }

    /// <summary>
    /// 壁に当たっているかをチェックする
    /// </summary>
    /// <param name="pos"></param>
    /// <returns></returns>
    Vector3 WallCollisionCheck(Vector3 pos)
    {
        if(pos.x == -1)//左側の壁の当たり判定
        {
            if(wallManagerScript.GetWallLeft())
            {
                pos.x = 0;
            }
        }
        else if(pos.x == 1)//右側の壁の当たり判定
        {
            if (wallManagerScript.GetWallRight())
            {
                pos.x = 0;
            }
        }

        if (pos.y == 1)//上側の壁の当たり判定
        {
            if (wallManagerScript.GetWallTop())
            {
                pos.y = 0;
            }
        }
        else if (pos.x == -1)//下側の壁の当たり判定
        {
            if (wallManagerScript.GetWallButtom())
            {
                pos.y = 0;
            }
        }

        return pos;
    }
}
