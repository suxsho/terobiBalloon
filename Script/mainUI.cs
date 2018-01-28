using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
//主界面UI
public class mainUI : MonoBehaviour {
    public GameObject socres;           //把UI中的scores拖进来
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        socres.GetComponent<Text>().text = gameConfig.scores.ToString();
    }
}
