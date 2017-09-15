//////////////////////
//製作者　名越大樹
//製作日　9月15日
//一定範囲に来ると強制的にスキルを発動させるクラス
//////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimeSkill : MonoBehaviour {

    [SerializeField]
    CollisionManager collisionManagerScript;
    [SerializeField]
    PlayerSkillAction playerSkillActionScript;
    bool isSkillActive = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
       bool result =  collisionManagerScript.HitTimerSkillArea(collision.gameObject);
        if(!isSkillActive && result)
        {
            isSkillActive = true;
            playerSkillActionScript.SetSkillStatus(PlayerSkillAction.SkillStatus.Use);
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        bool result = collisionManagerScript.HitTimerSkillArea(collision.gameObject);
        if (isSkillActive && result)
        {
            isSkillActive = false;
            playerSkillActionScript.SetSkillStatus(PlayerSkillAction.SkillStatus.NoUse);
        }
    }
}
