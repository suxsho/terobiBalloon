using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomEffectSpt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(load());
    }

    IEnumerator load()
    {
        yield return new WaitForSeconds(1); //等待一秒
        Destroy(gameObject);        //删除组件
    }
}
