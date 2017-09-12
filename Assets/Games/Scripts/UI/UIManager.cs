/////////////////////////
//製作者　名越大樹
//製作日 9月12日
//UIを管理するクラス
/////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    [SerializeField]
    GameMaster gameMasterScript;
    bool isStartUI = false;
    void Start()
    {
        if(!gameMasterScript.GetIsGame())
        {
            isStartUI = true;
        }
    }

    public bool GetIsStartUI()
    {
        return isStartUI;
    }

    public void SetIsStartUI(bool set)
    {
        isStartUI = set;
    }

    public void SetGamePlay(bool set)
    {
        gameMasterScript.SetIsGame(set);
    }
}
