////////////////////
//製作者　名越大樹
//制作日　9月13日
//スコアのデータに関するクラス
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
        StreamReader sr = new StreamReader(Application.dataPath + fileName,Encoding.GetEncoding("shift_jis"));
        string col = sr.ReadLine();
        sr.Close();
        return col;
    }

    public void WriteData(string data)
    {
        StreamWriter sr = new StreamWriter(Application.dataPath + fileName);
        sr.Write(data);
        sr.Close();
    }
}
