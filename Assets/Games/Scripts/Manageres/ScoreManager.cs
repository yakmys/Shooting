using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    [SerializeField]
    public static string score;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);

	}
    public void SetScore(string data)
    {
        Debug.Log("a");
        score = data;
    }

    public string GetScore()
    {
        return score;
    }
}
