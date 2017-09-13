//////////////////////
//製作者　名越大樹
//製作日 9月13日
//ほかのオブジェクトと当たっときのクラス
//////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollsion : MonoBehaviour {
    [SerializeField]
    EnemyStatus enemyStatusScript;
    void OnTriggerEnter2D(Collider2D collision)
    {
        enemyStatusScript.SearchManagerObj();
        GameObject obj = enemyStatusScript.GetManagerObj();
        obj.GetComponent<CollisionManager>().HitEnemyEnter(collision.gameObject,gameObject);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        enemyStatusScript.SearchManagerObj();
        GameObject obj = enemyStatusScript.GetManagerObj();
        obj.GetComponent<CollisionManager>().HitEnemyExit(collision.gameObject, gameObject);
    }
}
