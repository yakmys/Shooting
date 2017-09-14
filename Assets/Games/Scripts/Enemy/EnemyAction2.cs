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
    float instanceBulletInterval;
    float copyInstanceBulletInterval;
    bool isBulletInstance = false;
    float movePosXValue;
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
        pos.y = Mathf.Cos(movePosYValue);
        pos.x = Time.deltaTime * enemyStatusScript.GetWorldSpeed() * enemyStatusScript.GetWorldSpeed();
        transform.Translate(pos);
        movePosYValue += 0.1f;
    }

    void Shot()
    {
        if (isBulletInstance)
        {
            if (bulletInstanceCount >= 0)
            {
                float z = 0.0f;
                float angle = 1.0f;
                for (int count = 0; count <= bulletCount; ++count)
                {
                    z = Mathf.Sin(angle);
                    Quaternion instancerotation = Quaternion.identity;
                    instancerotation.z = z;
                    Instantiate(bulletObj, transform.position, instancerotation);
                }
                bulletInstanceCount--;
                isBulletInstance = false;
                instanceBulletInterval = copyInstanceBulletInterval;
            }
        }
    }

    void Timer()
    {
        instanceBulletInterval -= Time.deltaTime;
    }
}
