﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//击打气球效果
public class hitBall : MonoBehaviour {
    public GameObject boomEffect;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                //点击气球成功后给予提示
                //Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                //Debug.Log("Target Name: " + hit.collider.gameObject.transform.name);

                if (hit.collider.gameObject.transform.name == "redBall(Clone)")
                {
                    if (gameConfig.hp > 0)
                        gameConfig.scores += 1;
                    Instantiate(boomEffect, hit.collider.gameObject.transform.position, transform.rotation);
                    Destroy(hit.collider.gameObject);
                }
                if (hit.collider.gameObject.transform.name == "blackBall(Clone)")
                {
                    Instantiate(boomEffect, hit.collider.gameObject.transform.position, transform.rotation);
                    gameConfig.hp -= 1;
                    Destroy(hit.collider.gameObject);
                }
            }
        }

    }
}
