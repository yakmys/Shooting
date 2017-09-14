///////////////////////
//製作者　名越大樹
//制作日　9月14日
//SEを管理するクラス
///////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeManager : MonoBehaviour {

    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip[] audioClip;

    public void SeStart(int number)
    {
        audioSource.clip = audioClip[number];
        audioSource.Play();
    }
}
