using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletLineMove : MonoBehaviour
{

    [SerializeField]
    BulletStatus BulletStatusScript;
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.right *  Time.deltaTime);
    }
}
