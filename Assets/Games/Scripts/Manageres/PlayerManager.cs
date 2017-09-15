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
    [SerializeField]
    GameObject playerObj;
    [SerializeField]
    PlayerBomSkill playerBomSkill;
    [SerializeField]
    GameObject BomObj;
    [SerializeField]
    SeManager seManagerScript;
    [SerializeField]
    GameObject timeObj;

    public bool GetIsGame()
    {
        return gameMasterScript.GetIsGame();
    }

    public int GetHp()
    {
        return playerStatusScript.GetHp();
    }

    public GameObject GetPlayerObj()
    {
        return playerObj;
    }

    public void SetBomSkillScript(bool set)
    {
        seManagerScript.SeStart(3);
        BomObj.GetComponent<PlayerBomSkill>().enabled = true;
    }

    public void SetTimeObjEnabled(bool set)
    {
        timeObj.SetActive(set);
    }
}
