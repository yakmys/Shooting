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
    bool isInstance = false;
    [SerializeField]
    int onStageEnemyCount;
    bool isNextInstance;
    [SerializeField]
    int sumEnemyCount = 0;

    void Start()
    {
        Ini();
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

    /// <summary>
    /// 現在のリストのインデックスを返す
    /// </summary>
    /// <returns></returns>
    public InstanceClass GetInstanceEnemyList()
    {
        return instanceClassList[instanceClassListIndex];
    }

    public bool GetIsPlay()
    {
        return gameMasterScript.GetIsGame();
    }

    public void SetCountAdd()
    {
        onStageEnemyCount++;
    }

    public void SetCount(int set)
    {
        onStageEnemyCount += set;
    }

    /// <summary>
    ///　エネミーを倒した時の処理 
    /// </summary>
    public void SetCountSubtraction()
    {
        onStageEnemyCount--;
        sumEnemyCount--;
        if (onStageEnemyCount == 0 && !isInstance && sumEnemyCount != 0)
        {
            if(instanceClassListIndex != instanceClassList.Count)
            isInstance = true;
        }
        else if(sumEnemyCount == 0)
        {
            gameMasterScript.GameResult(GameMaster.GameStatus.Clear);
        }
    }

    public bool GetIsInstance()
    {
        return isInstance;
    }

    public void IniSumEnemyCount()
    {
        for(int count =0;count < instanceClassList.Count;count++)
        {
            sumEnemyCount += instanceClassList[count].GetCount();
        }
    }

    public int GetSumEnemyCount()
    {
        return sumEnemyCount;
    }

    void Ini()
    {
        readEnemyCSVScript.ReadStart();
        instanceClassList = readEnemyCSVScript.GetDataList();
        IniSumEnemyCount();
    }
}
