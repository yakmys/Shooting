using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletLineMove : MonoBehaviour
{

    [SerializeField]
    BulletStatus bulletStatusScript;
    // Update is called once per frame
    public void Ini(Vector3 vec)
    {
        transform.rotation = Quaternion.FromToRotation(Vector3.up,vec);
    }
    void Update()
    {
        Move();
        Timer();
    }

    void Move()
    {
        transform.Translate(Vector3.up *  Time.deltaTime * bulletStatusScript.GetSpeed() * bulletStatusScript.GetWorldTimeSpeed());
    }

    void Timer()
    {
        bulletStatusScript.DestroyTimeSubtraction();
    }
}
