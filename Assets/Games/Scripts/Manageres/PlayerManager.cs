//////////////////////////
//製作者　名越大樹
//制作日　9月11日
//プレイヤーを管理するクラス
//////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    [SerializeField]
    GameMaster gameMasterScript;
    bool iniInstancePlayer;
    [SerializeField]
    PlayerStatus playerStatusScript;
    public bool GetIsGame()
    {
        return gameMasterScript.GetIsGame();
    }

    public int GetHp()
    {
        return playerStatusScript.GetHp();
    }

}
