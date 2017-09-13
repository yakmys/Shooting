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
    [SerializeField]
    EnemyManager enemyManagerScript;
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

    /// <summary>
    ///　メインステージ上でのゲーム開始
    /// </summary>
    /// <param name="set"></param>
    public void SetGamePlay(bool set)
    {
        Debug.Log("a");
        gameMasterScript.SetIsGame(set);
        enemyManagerScript.SetIsInstance(true);
    }

}
