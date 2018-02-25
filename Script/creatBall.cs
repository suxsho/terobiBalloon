using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//创造气球
public class creatBall : MonoBehaviour {
    public GameObject ball;
    public GameObject blackBall;
    float i = 0;
    float j;

    int ballID; //气球ID，随机数
    // Use this for initialization
    void Start () {
        j = 1;


    }
	
	// Update is called once per frame
	void Update () {

        if (i >= j && gameConfig.hp > 0)
        {
            ballID = Random.Range(0, 11);
            if(ballID > 3)
            Instantiate(ball, new Vector2(Random.Range(-2.3f, 2.4f), -6), transform.rotation);
            else
                Instantiate(blackBall, new Vector2(Random.Range(-2.3f, 2.4f), -6), transform.rotation);
            j = Random.Range(1.2f - gameConfig.scores * 0.005f - 0.2f, 1.2f - gameConfig.scores * 0.005f + 0.2f);
            if (j <= 0.1f)
                j = Random.Range(0.2f, 0.6f);
            i = 0;
            print(j);
        }
        i += Time.deltaTime;


    }
}
