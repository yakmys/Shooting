///////////////////////////
//製作者　名越大樹
//制作日　9月12日
//背景を管理するクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundManager : MonoBehaviour {

    [SerializeField]
    GameMaster gameMasterScript;
    [SerializeField]
    List<GameObject> backGroundImgList;
    [SerializeField]
    float iniWidthPos;
    float iniPosY;
    void Start()
    {
        for(int count = 0; count < backGroundImgList.Count; ++count )
        {
            if(count !=0)
            {
                Vector3 pos = backGroundImgList[0].transform.position;
                pos.x += iniWidthPos * count;
                backGroundImgList[count].transform.position = pos;
            }
        }
        iniPosY = backGroundImgList[0].transform.position.y;
    }

    public bool GetIsPlay()
    {
        return gameMasterScript.GetIsGame();
    }

    /// <summary>
    /// 一番後ろにいる画像のポジションを索敵
    /// </summary>
    /// <returns></returns>
    public float LastPos()
    {
        float lastpos = 0.0f;
        for(int count = 0;count < backGroundImgList.Count;++count)
        {
            float x = backGroundImgList[count].transform.position.x;
            if (x >= lastpos)
                lastpos = x;
        }
        lastpos += iniWidthPos;
        return lastpos;
    }

}
