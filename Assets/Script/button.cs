using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : ball {
    Vector3 pos;
	// Use this for initialization
	void Start () {
	  
	}

    // Update is called once per frame
    void Update()
    {


    }
    public void  changePosition()
    {
        rb.position = new Vector3(1, -9);
        rb.AddForce(new Vector2(ballForce, ballForce));
        
    }
 
}
