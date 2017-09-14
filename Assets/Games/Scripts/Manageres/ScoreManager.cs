using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static string score;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}
    public void SetScore(string data)
    {
        score = data;
    }

    public string GetScore()
    {
        return score;
    }
}
