using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAction : MonoBehaviour {

    [SerializeField]
    BulletStatus bulletStatusScript;
    [SerializeField]
    float destroyTime;
    void Start()
    {
        bulletStatusScript.SetDestroyTime(destroyTime);    
    }
    // Update is called once per frame
    void Update ()
    {
        Move();
	}

    void Move()
    {
        Vector3 pos = Vector3.right;
     transform.Translate(pos * Time.deltaTime * bulletStatusScript.GetSpeed());
    }
}
