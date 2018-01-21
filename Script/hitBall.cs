using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//击打气球效果
public class hitBall : MonoBehaviour {

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
                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                Debug.Log("Target Name: " + hit.collider.gameObject.transform.name);

                if(hit.collider.gameObject.transform.name == "redBall(Clone)")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }

    }
}
