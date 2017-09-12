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
    PlayerManager playerManagerScript;
    [SerializeField]
    PlayerStatus playerStatusScript;
    [SerializeField]
    BulletManager bulletManagerScript;
    bool IsMove;
    [SerializeField]
    private GameObject centerPos;
    [SerializeField]
    private float centerPosWidth;
    [SerializeField]
    private float centerPosHeith;

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
        Vector3 diff = MousePosionCheck(inputmousepos);
        transform.position += diff * playerStatusScript.GetMoveSpeed() * Time.deltaTime;
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
}
