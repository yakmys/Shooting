///////////////////////////
//製作者　名越大樹
//制作日　9月14日
//エネミーの動きに関する動き
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction2 : MonoBehaviour
{

    [SerializeField]
    EnemyStatus enemyStatusScript;
    [SerializeField]
    int bulletCount;//一度にどれだけ出すか
    [SerializeField]
    int bulletInstanceCount; //何回繰り返すか
    [SerializeField]
    float instanceBulletInterval;
    float copyInstanceBulletInterval;
    bool isBulletInstance = false;
    float movePosYValue;
    [SerializeField]
    GameObject bulletObj;

    // Use this for initialization
    void Start()
    {
        Ini();
    }

    void Ini()
    {
        enemyStatusScript.SearchManagerObj();
        copyInstanceBulletInterval = instanceBulletInterval;
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        Shot();
        Timer();
    }

    void Move()
    {
        Vector3 pos = Vector3.zero;
        float worldspeed = enemyStatusScript.GetWorldSpeed();
        pos.y = Mathf.Cos(movePosYValue) * worldspeed;
        pos.x = Time.deltaTime * -worldspeed * enemyStatusScript.GetWorldSpeed() * 2;
        transform.Translate(pos);
        movePosYValue += 0.15f * worldspeed;

    }

    void Shot()
    {
        if (isBulletInstance)
        {
            if (bulletInstanceCount >= 0)
            {
                float z = 0.0f;
                float angle = 1.0f;
                z = Mathf.Sin(angle);
                Quaternion instancerotation = Quaternion.identity;
                instancerotation.z = z;
                GameObject obj = Instantiate(bulletObj, transform.position, instancerotation);
                GameObject player = enemyStatusScript.GetPlayerObj();
                Vector3 vec = (player.transform.position - transform.position).normalized;
                obj.GetComponent<EnemyBulletLineMove>().Ini(vec);
                obj.GetComponent<BulletStatus>().SetManagerObj(enemyStatusScript.GetTimeManager());
                bulletInstanceCount--;
                isBulletInstance = false;
                instanceBulletInterval = copyInstanceBulletInterval;
            }
        }
    }

    void Timer()
    {
        instanceBulletInterval -= Time.deltaTime;
        if (instanceBulletInterval <= 0)
        {
            isBulletInstance = true;
        }
    }
}
