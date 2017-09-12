///////////////////////////
//製作者　名越大樹
//制作日   9月11日
//クラス名  シーン移動をするクラス
///////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMaster : MonoBehaviour
{

    public enum SceneStage
    {
        Title,
        Main,
        GameOver,
        Result
    }

    /// <summary>
    /// 任意のステージに遷移させる
    /// </summary>
    /// <param name="select"></param>
    public void SelectStage(SceneStage select)
    {
        switch (select)
        {
            case SceneStage.Title:
                SceneManager.LoadScene("Title");
                break;

            case SceneStage.Main:
                SceneManager.LoadScene("Main");
                break;

            case SceneStage.Result:
                SceneManager.LoadScene("Result");
                break;

            case SceneStage.GameOver:
                SceneManager.LoadScene("GameOver");
                break;
        }
    }
}
