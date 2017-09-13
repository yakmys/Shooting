///////////////////////////////////
//製作者　名越大樹
//制作日　9月11日
//弾を管理するクラス
///////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    ///////////////////////////////////
    //変数宣言開始
    ///////////////////////////////////
    [SerializeField]
    GameObject bulletObj;
    [SerializeField]
    float intervalBullet;
    float copyIntervalBullet;
    [SerializeField]
    GameMaster gameMasterScript;
    [SerializeField]
    TimeManager timeManagerScript;
    ///////////////////////////////////
    //変数宣言終了
    ///////////////////////////////////

    //以下処理コード
    void Start()
    {
        copyIntervalBullet = intervalBullet;
    }
    public void InstanceBullet(Vector3 pos)
    {
        if (gameMasterScript.GetIsGame())
        {
            if (intervalBullet <= 0)
            {
               GameObject obj = Instantiate(bulletObj, pos, Quaternion.identity);
                obj.GetComponent<BulletStatus>().SetManagerObj(timeManagerScript);
                intervalBullet = copyIntervalBullet;
            }
        }
    }

    void Update()
    {
        Interval();
    }

    void Interval()
    {
        intervalBullet -= Time.deltaTime * timeManagerScript.GetSpeed();
    }
}
