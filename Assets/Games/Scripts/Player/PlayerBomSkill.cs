﻿//////////////////////
//製作者　名越大樹
//制作日　9月15日
//プレイヤーが当たった時に使う処理
//////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBomSkill : MonoBehaviour {

    [SerializeField]
    CollisionManager collisionManagerScript;
    [SerializeField]
    GameObject bomBerEffectObj;
    [SerializeField]
    float timer;
    float copytimer;
    bool isIni = true;
    [SerializeField]
    float instancePos;

    void Update()
    {
        if(isIni)
        {
            Ini();
        }
        Timer();
    }

    void Ini()
    {
        Vector3 pos = transform.position;
        pos.z = instancePos;
        GameObject obj = Instantiate(bomBerEffectObj,pos,Quaternion.identity);
        obj.transform.parent = transform;
        GetComponent<BoxCollider2D>().enabled = true;
        copytimer = timer;
        isIni = false;
    }

    void Timer()
    {
        copytimer -= Time.deltaTime;
        if (copytimer <= 0)
        {
            isIni = true;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<PlayerBomSkill>().enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        collisionManagerScript.HitBomberEnter(collision.gameObject);
    }
}
