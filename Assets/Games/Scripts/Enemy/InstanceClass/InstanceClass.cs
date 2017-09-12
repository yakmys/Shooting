///////////////////////////
//製作者　名越大樹
//制作日　9月12日
//敵の生成に関するクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InstanceClass {

    [SerializeField]
    Vector3 instancePos;
    [SerializeField]
    int count;

    public void SetInstanceClass(int setcount,Vector3 setpos)
    {
        count = setcount;
        instancePos = setpos;
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
}
