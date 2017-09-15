//////////////////////
//製作者　名越大樹
//制作日　9月14日
//玉を生成するクラス
//////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInstance1 : MonoBehaviour {

    [SerializeField]
    GameObject bulletObj;

    public void Instance(int number,int instancecount)
    {
        switch(number)
        {
            case 1://拡散型
                Diffusion(instancecount);
                break;
            case 2://追尾団
                break;
        }
    }

    void Diffusion(int instancecount)
    {
        float z = 0.0f;
        float angle = 0.0f;
        for(int count = 0;count < instancecount;++count)
        {
            z = Mathf.Sin(360 * angle)*45;
            Quaternion instancerotation = Quaternion.identity;
            instancerotation.z = z;
            GameObject obj = Instantiate(bulletObj,transform.position,Quaternion.identity);
            angle += 0.1f;

        }
    }
}
