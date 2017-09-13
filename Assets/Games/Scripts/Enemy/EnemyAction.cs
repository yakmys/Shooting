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
    [SerializeField]
    float shotActionTime;
    bool isShotAction = true;
    [SerializeField]
    GameObject enemyBulletObj;
    [SerializeField]
    int instanceBulletCount;
    [SerializeField]
    float intervalShotTime;
    float worldSpeed;
    void Start()
    {
        enemyStatusScript.DestroyStart();
        enemyStatusScript.SearchManagerObj();
    }

    void Update()
    {
        Move();
        Shot();
        ShotTimer();
    }

    void Move()
    {
        worldSpeed = enemyStatusScript.GetWorldSpeed();
        float speed = -enemyStatusScript.GetMoveSpeed();
        Vector3 pos = Vector3.zero;
        pos.x = -1;
        transform.Translate(pos * Time.deltaTime * speed * worldSpeed);
    }

    void Shot()
    {
        if (isShotAction)
        {
            if(shotActionTime <= 0 && intervalShotTime <= 0)
            {
                    Quaternion instancerotation = Quaternion.identity;
                    if(instanceBulletCount == instanceBulletCount % 2)
                    {
                        instancerotation = Quaternion.EulerAngles(0, 0, 90);
                    }
                    else
                    {
                        instancerotation = Quaternion.EulerAngles(0, 0, -90);
                    }
                    Instantiate(enemyBulletObj,transform.position,instancerotation);
                instanceBulletCount--;
            }
        }
        if(instanceBulletCount <= 0)
        {
            isShotAction = false;
        }
    }
    void ShotTimer()
    {
        if (isShotAction)
        {
            shotActionTime -= Time.deltaTime * worldSpeed;
            intervalShotTime -= Time.deltaTime * worldSpeed;
        }
    }
}
