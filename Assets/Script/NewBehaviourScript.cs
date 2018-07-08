using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed;
    public float maxX;


	
	void Start () {
		
	}
	
	
	void Update () {
        float x;

       x= Input.GetAxis("Horizontal");
        if (x == 0) { stop(); }
        else if (x < 0)
        {
            moveLeft();
        }
        else if (x > 0)
        {
            moveRight();
        }
        Vector3 pos = transform.position;

       pos.x= Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;

    

	}
    void moveRight()
    {
        rb.velocity = new Vector2(speed, 0);
    }
    void moveLeft()
    {

        rb.velocity = new Vector2(-speed,0);
    }
    void stop()
    {
        rb.velocity = Vector2.zero;
    }
}
