using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hoge : MonoBehaviour {

    [SerializeField]
    Text hogete;
    [SerializeField]
    Text ho;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(OnTouchDown())
        {
            hogete.text = "おされました";
        }
	}
    bool OnTouchDown()
    {
        if(0 < Input.touchCount )
        {
            ho.text = Input.touchCount.ToString();
            return true;
        }
        return false;
    }
}
