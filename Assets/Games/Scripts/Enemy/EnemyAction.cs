/////////////////////////
//製作者　名越大樹
//制作日　9月12日
//敵の動きのクラス
/////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour {

    [SerializeField]
    EnemyStatus enemyStatusScript;

    void Update()
    {
        Move();  
    }

    void Move()
    {
        float speed = -enemyStatusScript.GetMoveSpeed();
        Vector3 pos = Vector3.zero;
        pos.x = speed;
        transform.Translate(pos * Time.deltaTime);
    }
}
