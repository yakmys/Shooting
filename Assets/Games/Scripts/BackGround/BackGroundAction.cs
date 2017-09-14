///////////////////////////
//製作者　名越大樹
//制作日　9月12日
//背景の動きに関するクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundAction : MonoBehaviour {

    [SerializeField]
    BackGroundStatus backGroundStatusScript;
	// Update is called once per frame
	void Update ()
    {
        Move();
        PositionCheck();
	}

    void Move()
    {
        float speed = backGroundStatusScript.GetMoveSpeed();
        float worldspeed = backGroundStatusScript.GetWorldTimeSpeed();
        Vector3 pos = Vector3.zero;
        pos.x = -speed * Time.deltaTime * worldspeed;
        transform.Translate(pos);
    }

    /// <summary>
    ///一定の距離に進んだ場合元の場所に戻る 
    /// </summary>
    void PositionCheck()
    {
      float checkposx =  backGroundStatusScript.GetBackGroundEndPos();
        if(checkposx >= transform.position.x)
        {
            Vector3 pos = Vector3.zero;
            pos.x = backGroundStatusScript.GetLastPos();
            transform.position = pos;
        }
    }
}
