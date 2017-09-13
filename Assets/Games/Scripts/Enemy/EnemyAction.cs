/////////////////////////
//製作者　名越大樹
//制作日　9月12日
//敵の動きのクラス
/////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour
{

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
    float destoryTimeCount;
    void Start()
    {
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
        transform.Translate(-pos * Time.deltaTime * speed * worldSpeed);
    }

    void Shot()
    {
        if (isShotAction)
        {
            if (shotActionTime <= 0 && intervalShotTime <= 0)
            {
                Quaternion instancerotation = Quaternion.identity;
                if (instanceBulletCount == instanceBulletCount % 2)
                {
                    instancerotation = Quaternion.EulerAngles(0, 0, 90);
                }
                else
                {
                    instancerotation = Quaternion.EulerAngles(0, 0, -90);
                }
               GameObject obj = Instantiate(enemyBulletObj, transform.position, instancerotation);
                obj.GetComponent<BulletStatus>().SetManagerObj(enemyStatusScript.GetTimeManager());
                instanceBulletCount--;
            }
        }
        if (instanceBulletCount <= 0)
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

    void DestoryCountTime()
    {
        float time = enemyStatusScript.GetDestroyTime();
        destoryTimeCount += Time.deltaTime * worldSpeed;
        if (time <= destoryTimeCount)
        {
            Debug.Log("時間が来ました");
            enemyStatusScript.SetDestroy();
        }
    }
}
