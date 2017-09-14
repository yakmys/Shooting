//////////////////////////
//製作者　名越大樹
//制作日　9月14日
//BGMを管理するクラス
//////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManager : MonoBehaviour
{

    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip[] bgmArray;

    public void StartBgm(int number)
    {
        audioSource.clip = bgmArray[number];
        audioSource.Play();
    }

    public void StopBgm()
    {
        audioSource.Stop();
    }
}
