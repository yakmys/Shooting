////////////////////////
//製作者　名越大樹
//制作日　9月14日
//任意のBGMを開始させるクラス
////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMStatus : MonoBehaviour {

    [SerializeField]
    BgmManager bgmManagerScript;
    [SerializeField]
    int bgmNumber;
	// Use this for initialization
	void Start () {
        bgmManagerScript.StartBgm(bgmNumber);
	}
	
}
