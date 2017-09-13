////////////////
//製作者　名越大樹
//制作日　9月13日
//リザルトシーンからタイトルシーンへ行くクラス
////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScene : MonoBehaviour {

    [SerializeField]
    SceneMaster sceneMasterScript;

    [SerializeField]
    Client clientScript;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (OnTouch())
        {
            sceneMasterScript.SelectStage(SceneMaster.SceneStage.Title);
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
