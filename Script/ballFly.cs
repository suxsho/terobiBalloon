using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballFly : MonoBehaviour {
    float speedY = 1;
    // Use this for initialization
    void Start () {
        speedY = Random.Range(1.0f, 6.0f);
    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.up * speedY * Time.deltaTime);
    }
}
