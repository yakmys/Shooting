////////////////////////
//製作者　名越大樹
//製作日　9月13日
//プレイヤーのスキルに関するクラス
////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillAction : MonoBehaviour {

    [SerializeField]
    TimeManager timeManagerScript;
    [SerializeField]
    float lateTime;
	
    // Update is called once per frame
	void Update () {
        Skill();
	}

    void Skill()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            timeManagerScript.SetSpeed(lateTime);
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            timeManagerScript.SetDefaultSpeed();
        }
    }
}
