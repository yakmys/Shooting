using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimeManager : MonoBehaviour {

    [SerializeField]
    float bulletDestroyTime;
    public float GetBulletDestroyTime()
    {
        return bulletDestroyTime;
    }

}
