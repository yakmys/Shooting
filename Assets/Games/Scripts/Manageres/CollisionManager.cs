////////////////////
//製作者　名越大樹
//制作日　9月13日
//当たったオブジェクトの処理を管理するクラス
////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour {

    [SerializeField]
    string[] tagNames;
    [SerializeField]
    GameMaster gameMasterScript;

    public void HitEnemy(GameObject collishonobj,GameObject enemyobj)
    {
        //エネミーの弾だっただった場合
        if(collishonobj.tag == tagNames[3])
        {
            bool result = enemyobj.GetComponent<EnemyStatus>().DamageHp(1);
            if(result)
            {
                DestoryObj(enemyobj);
            }
        }
    }

    public void HitPlayer(GameObject obj,GameObject playerobj)
    {
        //エネミーの弾だった場合
        if (obj.tag == tagNames[2])
        {
            bool result = playerobj.GetComponent<PlayerStatus>().SetHp(1);
            if(result)
            {
                gameMasterScript.GameResult(GameMaster.GameStatus.GameOver);
            }
        }
    }

    void DestoryObj(GameObject obj)
    {
        Destroy(obj);
    }
}
