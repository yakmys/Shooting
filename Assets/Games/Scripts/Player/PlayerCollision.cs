/////////////////////
//製作者　名越大樹
//制作日　9月13日
//プレイヤーが当たった時に呼び出すクラス
/////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    [SerializeField]
    CollisionManager collisihonManagerScript;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collisihonManagerScript.HitPlayerEnter(collision.gameObject,gameObject);
    }
}
