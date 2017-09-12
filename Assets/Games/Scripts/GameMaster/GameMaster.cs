////////////////////
//製作者　名越大樹
//制作日　9月11日
//ゲームの進行を管理するクラス
////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    ////////////////////
    //変数宣言開始
    ////////////////////
    [SerializeField]
    bool isGamePlay;
    ////////////////////
    //変数宣言終了
    ////////////////////

    //以下処理コード

    public void SetIsGame(bool set)
    {
        isGamePlay = set;
    }
    public bool GetIsGame()
    {
        return isGamePlay;
    }
}
