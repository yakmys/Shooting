///////////////////////////
//製作者　名越大樹
//制作日　9月12日
//敵の生成に関するクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InstanceClass
{

    [SerializeField]
    Vector3 instancePos;
    [SerializeField]
    int count;
    [SerializeField]
    int enemyNumber;
    public void SetInstanceClass(int setcount, Vector3 setpos,int enemynumber)
    {
        count = setcount;
        instancePos = setpos;
        enemyNumber = enemynumber;
        Debug.Log(enemynumber);
    }

    public int GetCount()
    {
        return count;
    }

    public void SetCount(int value)
    {
        count = value;
    }

    public Vector3 GetPos()
    {
        return instancePos;
    }

    public int GetEnemyNumber()
    {
        return enemyNumber;
    }

    public void SetEnemyNumber(int set)
    {
        enemyNumber = set;
    }
}
