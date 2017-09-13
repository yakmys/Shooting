////////////////////
//製作者　名越大樹
//制作日　9月13日
//任意の時間で消すクラス
////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTime : MonoBehaviour {

    [SerializeField]
    float destroyTime;
	// Use this for initialization
	void Start () {
        Destroy(gameObject,destroyTime);
	}
	
}
