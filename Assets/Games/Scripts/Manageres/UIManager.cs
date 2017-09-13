/////////////////////////
//製作者　名越大樹
//製作日 9月12日
//UIを管理するクラス
/////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    GameMaster gameMasterScript;
    [SerializeField]
    EnemyManager enemyManagerScript;
    [SerializeField]
    PlayerLifeUI playerLifeUIScript;
    [SerializeField]
    PlayerManager playerManagerScript;
    bool isStartUI = false;
    void Start()
    {
        if (!gameMasterScript.GetIsGame())
        {
            isStartUI = true;
        }
        int hp = playerManagerScript.GetHp();
        playerLifeUIScript.SetLife(hp);
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
        gameMasterScript.SetIsGame(set);
        enemyManagerScript.SetIsInstance(true);
    }

    public int GetSumCount()
    {
        return enemyManagerScript.GetSumEnemyCount();
    }

    public void PlayerUISubtraction()
    {
        playerLifeUIScript.UISubtraction();
    }
}
