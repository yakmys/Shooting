//////////////////////
//製作者　名越大樹
//制作日　9月12日
//追尾機能のある弾のクラス
//////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  TrackingBulletAction : MonoBehaviour{

    [SerializeField]
    float trackingTime;
    [SerializeField]
    float noTrackingTime;
    GameObject playerObj;
    [SerializeField]
    BulletStatus bulletStatusScript;
    [SerializeField]
    GameObject childObj;
    void Start()
    {
      playerObj = GameObject.Find("player");
    }

    void Update()
    {
        Move();
        Timer();
    }

    void Move()
    {
        float worldspeed = bulletStatusScript.GetWorldTimeSpeed();
        if(noTrackingTime >= 0)
        {
            float speed = bulletStatusScript.GetSpeed();
            Vector3 pos = Vector3.zero;
            pos.x = 1;
            transform.Translate(pos * speed * Time.deltaTime * worldspeed);
            noTrackingTime -= Time.deltaTime;
        }

        //追尾のアクション
        else if(noTrackingTime <= 0 && trackingTime >= 0)
        {
            float speed = bulletStatusScript.GetSpeed();
            Vector3 pos = (playerObj.transform.position - transform.position).normalized;
            transform.rotation = Quaternion.FromToRotation(Vector3.up,pos);
            transform.position += pos * speed * Time.deltaTime * worldspeed;
            trackingTime -= Time.deltaTime;
        }

        //追尾の終了アクション
        else
        {
            float speed = bulletStatusScript.GetSpeed();
            Vector3 pos = (childObj.transform.position - transform.position).normalized;
            transform.position += pos * speed * Time.deltaTime * worldspeed;
        }
    }

    void Timer()
    {
        bulletStatusScript.DestroyTimeSubtraction();
    }
}
