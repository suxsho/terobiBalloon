using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//创造气球
public class creatBall : MonoBehaviour {
    public GameObject ball;
    float i = 0;
    float j = 0;
    // Use this for initialization
    void Start () {
        j = Random.Range(-0.3f, 1.3f);

    }
	
	// Update is called once per frame
	void Update () {

        if (i >= j)
        {
            Instantiate(ball, new Vector2(Random.Range(-2.3f, 2.4f), -6), transform.rotation);
            j = Random.Range(0.1f, 1.0f);
            i = 0;
        }
        i += Time.deltaTime;

    }
}
