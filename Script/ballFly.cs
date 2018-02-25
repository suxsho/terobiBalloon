using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballFly : MonoBehaviour {
    public static float speedY = 1;
    float i;

    public enum ballID { red, black };      //start是在UI里显示的 END是在关卡过关的地方执行的
    public ballID mode;
    // Use this for initialization
    void Start () {
        speedY = Random.Range(speedY, speedY + 0.05f);
    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.up * speedY * Time.deltaTime);

      //失败个数
            if (transform.position.y >= 7)
            {
                if (mode == ballID.red)
                {
                    if (gameConfig.hp > 0)
                        gameConfig.hp -= 1;
                    Destroy(gameObject);

                    print(gameConfig.hp);
                }
                if (mode == ballID.black)
                {
                        
                }
            }


    }
}
