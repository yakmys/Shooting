////////////////////////
//製作者　名越大樹
//制作日　9月13日
//エフェクトの生成を管理するクラス
////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{

    [SerializeField]
    GameObject[] gameEffects;

    public void InstanceEffect(int number, Vector3 pos)
    {
        pos.z = -2;
        Instantiate(gameEffects[number], pos, Quaternion.identity);
    }
}
