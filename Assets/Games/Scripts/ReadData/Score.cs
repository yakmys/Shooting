////////////////////
//製作者　名越大樹
//制作日　9月13日
//スコアに関するクラス
////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Score : MonoBehaviour {

    [SerializeField]
    string fileName;
    public string ReadData()
    {
        StreamReader sr = new StreamReader(Application.dataPath + fileName);
        string col = sr.ReadLine();
        return col;
    }

    public void WriteData()
    {
        StreamWriter sr = new StreamWriter(Application.dataPath + fileName);
    }
}
