////////////////////////
//製作者　名越大樹
//制作日　9月12日
//敵を管理するクラス
////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    GameMaster gameMasterScript;
    [SerializeField]
    EnemyInstance enemyInstanceScript;
    [SerializeField]
    ReadEnemyCSV readEnemyCSVScript;
    [SerializeField]
    List<InstanceClass> instanceClassList;
    [SerializeField]
    InstanceClass instanceClassScript;
    int instanceClassListIndex;
    bool isInstance = true;

    void Start()
    {
        readEnemyCSVScript.ReadStart();
        instanceClassList = readEnemyCSVScript.GetDataList();
    }

    // Update is called once per frame
    void Update()
    {
        InstanceCall();
    }

    /// <summary>
    /// EnemyInstanceスクリプトから生成を呼び出す
    /// </summary>
    void InstanceCall()
    {
        if (isInstance)
        {
            enemyInstanceScript.InstanceEnemy();
        }
    }

    public void SetIsInstance(bool set)
    {
        isInstance = set;
    }

    public void InsranceClassIndexAdd()
    {
        instanceClassListIndex++;
    }

    public InstanceClass GetInstanceEnemyList()
    {
        return instanceClassList[instanceClassListIndex];
    }

    public bool GetIsPlay()
    {
        return gameMasterScript.GetIsGame();
    }
}
