////////////////////////
//製作者　名越大樹
//制作日　9月12日
//壁の左側の当たり判定を検知するクラス
////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLeft : MonoBehaviour {

    [SerializeField]
    WallManager wallManagerScript;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            wallManagerScript.SetWallLeft(false);
        }
    }
}
