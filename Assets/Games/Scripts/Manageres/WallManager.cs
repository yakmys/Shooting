///////////////////////////
//製作者　名越大樹
//制作日　9月12日
//壁の当たり判定を管理するクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    ///////////////
    //変数宣言開始
    ///////////////
    bool isWallLeft = false;
    bool isWallRight = false;
    bool isWallTop = false;
    bool isWallButtom = false;
    ///////////////
    //変数宣言終了
    ///////////////

    /// <summary>
    /// プレイヤーが壁に当たった時の処理
    /// </summary>
    /// <param name="wallobjname"></param>
    public void EnterWall(string wallobjname)
    {
        if(wallobjname == "Left")
        {
            SetWallLeft(true);
        }

        else if(wallobjname == "Right")
        {
            SetWallRight(true);
        }

        if (wallobjname == "Top")
        {
            SetWallTop(true);
        }

        else if (wallobjname == "Buttom")
        {
            SetWallButtom(true);
        }
    }

    /// <summary>
    /// プレイヤーが壁から離れた時の処理
    /// </summary>
    /// <param name="wallobjname"></param>
    public void ExitWall(string wallobjname)
    {
        if (wallobjname == "Left")
        {
            SetWallLeft(false);
        }

        else if (wallobjname == "Right")
        {
            SetWallRight(false);
        }

        if (wallobjname == "Top")
        {
            SetWallTop(false);
        }

        else if (wallobjname == "Buttom")
        {
            Debug.Log("hoge");
            SetWallButtom(false);
        }
    }

    //////////////
    //以下各壁の当たり判定をセットを開始
    //////////////
    public void SetWallLeft(bool set)
    {
        isWallLeft = set;
    }

    public void SetWallRight(bool set)
    {
        isWallRight = set;
    }

    public void SetWallTop(bool set)
    {
        isWallTop = set;
    }

    public void SetWallButtom(bool set)
    {
        isWallButtom = set;
    }
    //////////////
    //以上各壁の当たり判定をセット終了
    //////////////

    //////////////
    //以下各壁の当たり判定の取得を開始
    //////////////
    public bool GetWallLeft()
    {
        return isWallLeft;
    }

    public bool GetWallRight()
    {
        return isWallRight;
    }

    public bool GetWallTop()
    {
        return isWallTop;
    }

    public bool GetWallButtom()
    {
        return isWallButtom;
    }
    //////////////
    //以上各壁の当たり判定の取得を終了
    //////////////
}
