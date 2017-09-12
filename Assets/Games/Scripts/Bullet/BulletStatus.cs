using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStatus : MonoBehaviour {

    [SerializeField]
    private float moveSpeed;

    public void SetSpeed(float set)
    {
        moveSpeed = set;
    }

    public float GetSpeed()
    {
        return moveSpeed;
    }

    public void SetDestroyTime(float set)
    {
        Destroy(gameObject,set);
    }
}
