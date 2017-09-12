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
    void Start()
    {
      playerObj = GameObject.Find("player");
    }

    void Update()
    {
        Move();    
    }

    void Move()
    {
        if(noTrackingTime >= 0)
        {
            float speed = bulletStatusScript.GetSpeed();
            Vector3 pos = Vector3.zero;
            pos.x = 1;
            transform.Translate(pos * speed * Time.deltaTime);
            noTrackingTime -= Time.deltaTime;
        }

        else if(noTrackingTime <= 0 && trackingTime >= 0)
        {
            float speed = bulletStatusScript.GetSpeed();
            Vector3 pos = (playerObj.transform.position - transform.position).normalized;
            transform.position += pos * speed * Time.deltaTime;
            trackingTime -= Time.deltaTime;
        }

        else
        {
            float speed = bulletStatusScript.GetSpeed();
            Vector3 pos = transform.position;
            pos.x--;
            pos.y--;
            Vector3 diff = (pos - transform.position).normalized;
            transform.position += diff * Time.deltaTime * speed;
        }
    }

}
