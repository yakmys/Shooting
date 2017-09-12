using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStatus1 : MonoBehaviour {

    [SerializeField]
    int hp;
    [SerializeField]
    float moveSpeed;

    public void SetHp(int set)
        {
        hp = set;
        }

    public int GetHp()
    {
        return hp;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

}
