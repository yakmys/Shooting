////////////////
//製作者　名越大樹
//制作日　9月13日
//タイトルシーンからリザルトシーンへ行くクラス
////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : MonoBehaviour {

    [SerializeField]
    SceneMaster sceneMasterScript;
    // Update is called once per frame
    void Update()
    {
        if (OnTouch())
        {
            sceneMasterScript.SelectStage(SceneMaster.SceneStage.Main);
        }
    }

    bool OnTouch()
    {
        if (Input.touchCount == 1)
        {
            return true;
        }
        return false;
    }
}
