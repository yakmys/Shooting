///////////////////
//製作者　名越大樹
//製作日　9月11日
//プレイヤーの弾の動きに関するクラス
///////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAction : MonoBehaviour
{

    [SerializeField]
    BulletStatus bulletStatusScript;
    [SerializeField]
    TimeManager timeManagerScript;

    void Start()
    {
        bulletStatusScript.SetDestroyTime();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float worldspeed = bulletStatusScript.GetWorldTimeSpeed();
        float bulletspeed = bulletStatusScript.GetSpeed();
        Vector3 pos = Vector3.right;
        transform.Translate(pos * Time.deltaTime * bulletspeed * worldspeed);
    }
}
