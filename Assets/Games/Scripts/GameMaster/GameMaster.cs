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
    public enum GameStatus
    {
        None,
        Clear,
        GameOver,
        Result2
    }
    [SerializeField]
    SceneMaster scenMasterScript;
    [SerializeField]
    ReadEnemyCSV readEnemyCsvScript;//CSVが読み込まれなかったよう
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

    public void GameResult(GameStatus status)
    {
        switch (status)
        {
            case GameStatus.Clear:
                scenMasterScript.SelectStage(SceneMaster.SceneStage.Result);
                break;
            case GameStatus.Result2:
                scenMasterScript.SelectStage(SceneMaster.SceneStage.Result2);
                break;

            case GameStatus.GameOver:
                scenMasterScript.SelectStage(SceneMaster.SceneStage.GameOver);
                break;
        }
    }
}
