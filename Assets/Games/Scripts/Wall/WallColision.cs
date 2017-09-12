///////////////////////////
//製作者　名越大樹
//制作日　9月12日
//壁に当たった時に呼び出されるクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColision : MonoBehaviour {

    [SerializeField]
    WallManager wallManagerScript;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            wallManagerScript.EnterWall(gameObject.name);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            wallManagerScript.ExitWall(gameObject.name);
        }
    }
}
