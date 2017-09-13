///////////////////
//製作者　名越大樹
//制作日　9月13日
//プレイヤーの残気を表示と制御をするクラス
///////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeUI : MonoBehaviour
{

    [SerializeField]
    List<GameObject> playerLifeList;
    [SerializeField]
    GameObject playerUIObj;
    [SerializeField]
    GameObject Setpos;

    public void SetLife(int set)
    {
        Vector3 pos = Setpos.transform.position;
        for (int count = 0; count < set; count++)
        {
            GameObject obj = Instantiate(playerUIObj, pos, Quaternion.identity);
            playerLifeList.Add(obj);
            pos.x++;
        }
    }

    public void UISubtraction()
    {
        int index = playerLifeList.Count - 1;
        Destroy(playerLifeList[index]);
        playerLifeList.RemoveAt(index);
    }
}
