/////////////////////////////
//製作者　名越大樹
//制作日　9月12日
//敵のステータスのクラス
/////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    [SerializeField]
    int hp;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float destoryTime;
    float countDestroyTime;
    GameObject ManagerObj;
    TimeManager timeManagerScript;
    EnemyManager enemyManagerScript;   
    public void SetHp(int set)
    {
        hp = set;
    }

    public int GetHp()
    {
        return hp;
    }

    public bool DamageHp(int damage)
    {
        hp -= damage;
       bool result = CheckHp();
        return result;
    }

    public bool CheckHp()
    {
        if (hp <= 0)
        {
            return true;
       }
        return false;
    }

    public void SetMoveSpeed(float set)
    {
        moveSpeed = set;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public void DestroyStart()
    {
        Destroy(gameObject,destoryTime);
    }

    public void SearchManagerObj()
    {
        ManagerObj = GameObject.Find("Manageres");
        timeManagerScript = ManagerObj.GetComponent<TimeManager>();
        enemyManagerScript = ManagerObj.GetComponent<EnemyManager>();
    }
    public GameObject GetManagerObj()
    {
        return ManagerObj;
    }

    public float GetWorldSpeed()
    {
        return timeManagerScript.GetSpeed();
    }

    public float GetDestroyTime()
    {
        return destoryTime;
    }

    public void SetDestroy()
    {
        enemyManagerScript.SetCountSubtraction();
        Destroy(gameObject);
    }
    
    public TimeManager GetTimeManager()
    {
        return timeManagerScript;
    }

    public GameObject GetPlayerObj()
    {
        return enemyManagerScript.GetPlayerObj();
    }
}
