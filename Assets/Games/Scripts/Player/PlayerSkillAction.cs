////////////////////////
//製作者　名越大樹
//製作日　9月13日
//プレイヤーのスキルに関するクラス
////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerSkillAction : MonoBehaviour
{

    [SerializeField]
    TimeManager timeManagerScript;
    [SerializeField]
    float lateTime;
    [SerializeField]
    Slider timeGage;
    [SerializeField]
    float addValue;
    [SerializeField]
    GameMaster gameMasterScript;
    [SerializeField]
    float subtractionValue;
    [SerializeField]
    bool isSkill = true;
    bool isTimeArea = false;
    public enum SkillStatus
    {
        None,
        Use,
        NoUse
    }
    SkillStatus status = SkillStatus.NoUse;

    // Update is called once per frame
    void Update()
    {
        if (gameMasterScript.GetIsGame())
        {
            Skill();
            ValueUpdate();
        }
    }

    void Skill()
    {
        if (Input.touchCount == 2 && isSkill)
        {
            timeManagerScript.SetSpeed(lateTime);
            isTimeArea = false;
            status = SkillStatus.Use;
        }

        else if (Input.touchCount < 2 && !isTimeArea)
        {
            timeManagerScript.SetDefaultSpeed();
            status = SkillStatus.NoUse;
        }
    }

    void ValueUpdate()
    {
        switch (status)
        {
            case SkillStatus.Use:
                timeGage.value -= Time.deltaTime * subtractionValue;
                ValueCheck();
                break;
            case SkillStatus.NoUse:
                timeGage.value += Time.deltaTime * addValue;
                ValueCheck();
                break;
        }
    }

    void ValueCheck()
    {
        if (timeGage.value <= 0)
        {
            status = SkillStatus.NoUse;
            timeManagerScript.SetDefaultSpeed();
            isSkill = false;
        }
        else if (timeGage.value >= 0.5f)
        {
            isSkill = true;
        }
    }

    public void SetSkillStatus(SkillStatus set)
    {
        status = set;
        switch (set)
        {
            case SkillStatus.Use:
                status = set;
                isTimeArea = true;
                timeManagerScript.SetSpeed(0.1f);
                break;
            case SkillStatus.NoUse:
                status = set;
                isTimeArea = false;
                timeManagerScript.SetDefaultSpeed();
                break;
        }
    }
}
