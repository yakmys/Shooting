///////////////////////////
//製作者　名越大樹
//制作日　9月12日
//敵を生成するクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstance : MonoBehaviour
{

    [SerializeField]
    EnemyManager enemyManagerScript;
    [SerializeField]
    InstanceClass instanceClass;
    [SerializeField]
    GameObject enemyObj;
    [SerializeField]
    float instanceInterval;
    float copyInstanceInterval;

    void Start()
    {
        copyInstanceInterval = instanceInterval;
    }

    /// <summary>
    /// エネミーを生成
    /// </summary>
    public void InstanceEnemy()
    {
        if (instanceInterval <= 0)
        {
            InstanceClass instanceclass = enemyManagerScript.GetInstanceEnemyList();
            Vector3 instancepos = instanceclass.GetPos();
            Instantiate(enemyObj, instancepos, Quaternion.identity);
            instanceInterval = copyInstanceInterval;
            int getvalue = instanceclass.GetCount();
            getvalue--;
            instanceclass.SetCount(getvalue);
            if (getvalue == 0)
            {
                enemyManagerScript.SetIsInstance(false);
                enemyManagerScript.InsranceClassIndexAdd();
            }
        }
        instanceInterval -= Time.deltaTime;
    }
}
