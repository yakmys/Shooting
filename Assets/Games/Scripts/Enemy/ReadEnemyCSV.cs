///////////////////////////////////
//製作者　名越大樹
//制作日　9月12日
//csvからエネミー生成のデータを読み込む
///////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System;
public class ReadEnemyCSV : MonoBehaviour
{
    [SerializeField]
    bool isReadCsv;
    [SerializeField]
    List<InstanceClass> instanceClassListDebugVer = new List<InstanceClass>();
    [SerializeField]
    string fileName;
    List<InstanceClass> instanceClassList = new List<InstanceClass>();
    public void ReadStart()
    {
        if (isReadCsv)
        {
            StreamReader sr = new StreamReader(Application.dataPath + fileName, Encoding.GetEncoding("Shift_JIS"));
            Debug.Log(sr);
            int count = 0;
            while (sr.Peek() > -1)
            {
                string col = sr.ReadLine();
                string[] cols = col.Split(',');
                if (count != 0)
                {
                    int castcount = int.Parse(cols[0].ToString());
                    int castenemynumber = int.Parse(cols[4].ToString());
                    Vector3 pos = Vector3.zero;
                    pos = ParsePos(pos, cols);
                    InstanceClass instanceclass = new InstanceClass();
                    instanceclass.SetInstanceClass(castcount, pos, castenemynumber);
                    instanceClassList.Add(instanceclass);
                }
                count++;
            }
            Debug.Log(sr + "End");
            sr.ReadToEnd();
        }
        
    }

    /// <summary>
    /// 生成場所のポジションを返還する
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="cols"></param>
    /// <returns></returns>
    Vector3 ParsePos(Vector3 pos, string[] cols)
    {
        for (int count = 1; count <= 3; ++count)
        {
            float castvalue = float.Parse(cols[count]);
            switch (count)
            {
                case 1:
                    pos.x = castvalue;
                    break;

                case 2:
                    pos.y = castvalue;
                    break;

                case 3:
                    pos.z = castvalue;
                    break;
            }
        }
        return pos;
    }

    public List<InstanceClass> GetDataList()
    {
        return instanceClassList;
    }

    public List<InstanceClass> GetDataDebugList()
    {
        return instanceClassListDebugVer;
    }

    public bool GetIsReadCSV()
    {
        return isReadCsv;
    }
}
