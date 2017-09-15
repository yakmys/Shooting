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
    [SerializeField]
    UIManager uiManagaerScript;
    int hp;

    void Start()
    {
        int hp = uiManagaerScript.GetPlayerHp();
        Vector3 pos = Setpos.transform.position;
        for (int count = 0; count < hp; count++)
        {
            GameObject obj = Instantiate(playerUIObj, pos, Quaternion.identity);
            playerLifeList.Add(obj);
            pos.x++;
        }
    }

    public void SetLife(int set)
    {
        Vector3 pos = Setpos.transform.position;
        hp--;
        if (playerLifeList.Count > 0)
        {
            for (int count = 0; count < hp; count++)
            {
                GameObject obj = Instantiate(playerUIObj, pos, Quaternion.identity);
                playerLifeList.Add(obj);
                pos.x++;
            }
        }
    }

    public void UISubtraction()
    {
        if (playerLifeList.Count > 0)
        {
            int index = playerLifeList.Count - 1;
            Destroy(playerLifeList[index]);
            playerLifeList.RemoveAt(index);
        }
    }
}
